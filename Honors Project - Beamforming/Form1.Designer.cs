namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_MicLine = new System.Windows.Forms.Label();
            this.pic_Source = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.lbl_TimeShift = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Freq = new System.Windows.Forms.TextBox();
            this.txt_MicSeparation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MicCount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Source)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_MicLine
            // 
            this.txt_MicLine.AutoSize = true;
            this.txt_MicLine.Location = new System.Drawing.Point(273, 147);
            this.txt_MicLine.Name = "txt_MicLine";
            this.txt_MicLine.Size = new System.Drawing.Size(201, 13);
            this.txt_MicLine.TabIndex = 0;
            this.txt_MicLine.Text = "_________Microphone Plane_________";
            // 
            // pic_Source
            // 
            this.pic_Source.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_Source.BackgroundImage")));
            this.pic_Source.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Source.Location = new System.Drawing.Point(345, 289);
            this.pic_Source.Name = "pic_Source";
            this.pic_Source.Size = new System.Drawing.Size(70, 70);
            this.pic_Source.TabIndex = 1;
            this.pic_Source.TabStop = false;
            this.pic_Source.Click += new System.EventHandler(this.pic_Source_Click);
            this.pic_Source.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_Source_MouseDown);
            this.pic_Source.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_Source_MouseMove);
            this.pic_Source.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_Source_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Submit);
            this.groupBox1.Controls.Add(this.txt_MicCount);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_MicSeparation);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Freq);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(721, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 211);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_TimeShift);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(721, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 301);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "Previous";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(154, 27);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Show Plot";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(154, 50);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(90, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Show Source";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // lbl_TimeShift
            // 
            this.lbl_TimeShift.AutoSize = true;
            this.lbl_TimeShift.Location = new System.Drawing.Point(69, 27);
            this.lbl_TimeShift.Name = "lbl_TimeShift";
            this.lbl_TimeShift.Size = new System.Drawing.Size(37, 13);
            this.lbl_TimeShift.TabIndex = 3;
            this.lbl_TimeShift.Text = "Angle:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Time Shift:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Frequency:";
            // 
            // txt_Freq
            // 
            this.txt_Freq.Location = new System.Drawing.Point(150, 85);
            this.txt_Freq.Name = "txt_Freq";
            this.txt_Freq.Size = new System.Drawing.Size(75, 20);
            this.txt_Freq.TabIndex = 7;
            // 
            // txt_MicSeparation
            // 
            this.txt_MicSeparation.Location = new System.Drawing.Point(150, 111);
            this.txt_MicSeparation.Name = "txt_MicSeparation";
            this.txt_MicSeparation.Size = new System.Drawing.Size(75, 20);
            this.txt_MicSeparation.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mic Separation:";
            // 
            // txt_MicCount
            // 
            this.txt_MicCount.Location = new System.Drawing.Point(150, 137);
            this.txt_MicCount.Name = "txt_MicCount";
            this.txt_MicCount.Size = new System.Drawing.Size(75, 20);
            this.txt_MicCount.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Mic Count:";
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(171, 163);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(54, 23);
            this.btn_Submit.TabIndex = 12;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1001, 563);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pic_Source);
            this.Controls.Add(this.txt_MicLine);
            this.Name = "Form1";
            this.Text = "Beamforming Demenstration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Source)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_MicLine;
        private System.Windows.Forms.PictureBox pic_Source;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label lbl_TimeShift;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.TextBox txt_MicCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_MicSeparation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Freq;
        private System.Windows.Forms.Label label3;
    }
}

