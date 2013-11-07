using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
//using Adjust_System_Volume;

namespace WindowsFormsApplication1
{
        public struct PolarPoint
        {
            double angle;
            double ampl;
            public PolarPoint(double angle_in, double ampl_in)
            {
                this.angle = angle_in;
                this.ampl = ampl_in;
            }
        }

    public partial class Form1 : Form
    {
        private const string soundPath = "C:/Users/Will/Desktop/";
        private List<Point> dots;
        private bool mouseDownOnPic = false;  
        double timeShift = 0;
        double speed = 343.0;   // The speed of sound in meters per second
        double freq = 900;        // The incoming signal frequency
        double separation = 0.2;        // Separation of the microphones
        int numMics = 10;         // Number of microphones

        MediaPlayer.MediaPlayer wm = new MediaPlayer.MediaPlayer();
        public Form1()
        {
            InitializeComponent();
            dots = new List<Point>();
            ChangeVolume(-5000);
            playSound();
            checkBox1.Checked = false;
            txt_Freq.Text = freq.ToString();
            txt_MicCount.Text = numMics.ToString();
            txt_MicSeparation.Text = separation.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double t1 = GetAngleBetweenPoints(new Point(50,0), new Point(0,0));
            double t2 = GetAngleBetweenPoints(new Point(0,0), new Point(0,50));
            double t3 = GetAngleBetweenPoints(new Point(0,0), new Point(45,45));
            double t4 = GetAngleBetweenPoints(new Point(0,0), new Point(-45,-45));

            //System.Diagnostics.Trace.WriteLine(t1 + " - " + t2 + " - " + t3 + " - " + t4);
        }
        private double GetAngleFromMics()
        {
            return GetAngleBetweenPoints(GetMicCenter(), GetSourceCenter());
        }
        private double GetAngleBetweenPoints(Point origin, Point two)
        {
            double angle = 0;
            double opposite = -1*(two.Y - origin.Y) ;
            double adjacent = (two.X - origin.X);
            //System.Diagnostics.Trace.WriteLine(opposite + " - " + adjacent);
            if (adjacent == 0)
            {
                if (opposite > 0)
                {
                    angle = Math.PI;
                }
                else
                {
                    angle = -Math.PI;
                }
            }
            else if (adjacent > 0)
            {
                angle = Math.Atan(opposite / adjacent);
            }
            else
            {
                angle = Math.Atan(opposite / adjacent) + Math.PI;
            }

            //  Subtract PI/2 from the angle to adjust for the fact that 0 degrees is actually down in our case
             angle += (Math.PI / 2);
            return angle;
  
            
        }
        private Point GetSourceCenter()
        {
            int center_x = pic_Source.Location.X + pic_Source.Width / 2;
            int center_y = pic_Source.Location.Y + pic_Source.Height / 2;
            return new Point(center_x, center_y);
        }
        private Point GetMicCenter()
        {
            int center_x = txt_MicLine.Location.X + txt_MicLine.Width / 2;
            int center_y = txt_MicLine.Location.Y + txt_MicLine.Height / 2;
            return new Point(center_x, center_y);
        }

        private void DrawFullAmplitudePlot()
        {
            this.dots = new List<Point>();
            int pointCount = 6000;

            for (int j = 0; j < pointCount; j++)
            {
                //  Determine the real angle
                double realAngle = (2 * Math.PI / pointCount) * j;
                double realTotal = 0;
                double imagTotal = 0;


                // Iterate through array elements
                for (int i = 0; i < numMics; i++)
                {
                    // Calculate element position and wavefront delay
                    double position = i * separation;
                    double delay = (position * Math.Sin(realAngle) / speed) - timeShift* i;

                    // Add Wave
                    realTotal += Math.Cos(2.0 * Math.PI * freq * delay);
                    imagTotal += Math.Sin(2.0 * Math.PI * freq * delay);
                }
                double ampl = Math.Sqrt(realTotal * realTotal + imagTotal * imagTotal) / numMics;
                DrawDotPolar(realAngle, ampl*600);
            }

            //  Actually render all the dots
            this.Invalidate();
            
        }

        private double getAmplitudeAtAngle(double angle)
        {

            double realTotal = 0;
            double imagTotal = 0;

            // Iterate through array elements
            for (int i = 0; i < numMics; i++)
            {
                // Calculate element position and wavefront delay
                double position = i * separation;
                double delay = (position * Math.Sin(angle) / speed) - timeShift*i;

                // Add Wave
                realTotal += Math.Cos(2.0 * Math.PI * freq * delay);
                imagTotal += Math.Sin(2.0 * Math.PI * freq * delay);
            }

            return Math.Sqrt(realTotal * realTotal + imagTotal * imagTotal) / numMics;
        }
        private void pic_Source_Click(object sender, EventArgs e)
        {

        }

        private void pic_Source_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownOnPic = true;
        }

        private void pic_Source_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDownOnPic = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void pic_Source_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDownOnPic)
            {

                Point locPoint = new Point();
                locPoint.X = this.PointToClient(Cursor.Position).X - (int)((0.5)*(double)pic_Source.Size.Width);
                locPoint.Y = this.PointToClient(Cursor.Position).Y - (int)((0.5)*(double)pic_Source.Size.Height);
                pic_Source.Location = locPoint;
                UpdateMicVolume();
            }
        }
        private void UpdateMicVolume()
        {
            double angle = GetAngleFromMics();

            //  The ampl will be between 0 and 1
            double ampl = getAmplitudeAtAngle(angle);

            //  Multiply by 5000 for the volume (Guess in check showed me that 5000 was pretty quiet)
            ChangeVolume(ampl * 5000);
        }
        private void DrawDotPolar(double angle, double ampl)
        {
            Point p = new Point(GetMicCenter().X + (int)(ampl * Math.Sin(angle)), GetMicCenter().Y + (int)(ampl * Math.Cos(angle)));
            dots.Add(p);
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(Color.FromArgb(0, 200, 50));
            foreach (Point p in dots)
            {
 
                e.Graphics.FillRectangle(brush, p.X, p.Y, 5, 5);
            }
            
        }
        private void playSound()
        {
            wm.Open(soundPath + "sound.wma");
            wm.Play();
        }

        private void ChangeVolume(double vol)
        {
            //  Input a value between 0(mute), and 1(max volume)
            wm.Volume = -5000 + (int)vol;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timeShift += Math.PI / 100000;
            lbl_TimeShift.Text = timeShift.ToString();
            UpdateMicVolume();
            if (checkBox1.Checked)
            {
                DrawFullAmplitudePlot();

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                DrawFullAmplitudePlot();
            }
            else
            {
                dots = new List<Point>();
                this.Invalidate();
            }
        }
        private int CalcAngleFromTimeShift()
        {
            return 0;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timeShift -= Math.PI / 100000;
            lbl_TimeShift.Text = timeShift.ToString();
            UpdateMicVolume();
            if (checkBox1.Checked)
            {
                DrawFullAmplitudePlot();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                pic_Source.Visible = true;
            }
            else
            {
                pic_Source.Visible = false;
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            freq = Int16.Parse(txt_Freq.Text);
            numMics = Int16.Parse(txt_MicCount.Text);
            separation = Double.Parse(txt_MicSeparation.Text);
            if (checkBox1.Checked)
            {
                DrawFullAmplitudePlot();
            }
        }
    }
}