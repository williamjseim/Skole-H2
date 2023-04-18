namespace Dining_Philosophers
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
            this.fork4 = new System.Windows.Forms.PictureBox();
            this.fork5 = new System.Windows.Forms.PictureBox();
            this.fork3 = new System.Windows.Forms.PictureBox();
            this.fork2 = new System.Windows.Forms.PictureBox();
            this.fork1 = new System.Windows.Forms.PictureBox();
            this.plate5 = new System.Windows.Forms.PictureBox();
            this.plate4 = new System.Windows.Forms.PictureBox();
            this.plate3 = new System.Windows.Forms.PictureBox();
            this.plate2 = new System.Windows.Forms.PictureBox();
            this.plate1 = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hungryBox = new System.Windows.Forms.GroupBox();
            this.PHlabel5 = new System.Windows.Forms.Label();
            this.PHlabel4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PHlabel2 = new System.Windows.Forms.Label();
            this.PH1label = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.fork4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fork5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fork3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fork2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plate5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plate4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plate3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plate2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plate1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.hungryBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fork4
            // 
            this.fork4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fork4.Image = global::Dining_Philosophers.Properties.Resources.Fork_left_up;
            this.fork4.Location = new System.Drawing.Point(190, 289);
            this.fork4.Name = "fork4";
            this.fork4.Size = new System.Drawing.Size(51, 31);
            this.fork4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fork4.TabIndex = 9;
            this.fork4.TabStop = false;
            // 
            // fork5
            // 
            this.fork5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fork5.Image = global::Dining_Philosophers.Properties.Resources.Fork_left_down;
            this.fork5.Location = new System.Drawing.Point(198, 139);
            this.fork5.Name = "fork5";
            this.fork5.Size = new System.Drawing.Size(43, 38);
            this.fork5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fork5.TabIndex = 8;
            this.fork5.TabStop = false;
            // 
            // fork3
            // 
            this.fork3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fork3.Image = global::Dining_Philosophers.Properties.Resources.Fork_Up;
            this.fork3.Location = new System.Drawing.Point(312, 341);
            this.fork3.Name = "fork3";
            this.fork3.Size = new System.Drawing.Size(29, 57);
            this.fork3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fork3.TabIndex = 7;
            this.fork3.TabStop = false;
            // 
            // fork2
            // 
            this.fork2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fork2.Image = global::Dining_Philosophers.Properties.Resources.Fork_right_up;
            this.fork2.Location = new System.Drawing.Point(448, 289);
            this.fork2.Name = "fork2";
            this.fork2.Size = new System.Drawing.Size(47, 33);
            this.fork2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fork2.TabIndex = 6;
            this.fork2.TabStop = false;
            // 
            // fork1
            // 
            this.fork1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fork1.Image = global::Dining_Philosophers.Properties.Resources.Fork_right_down;
            this.fork1.Location = new System.Drawing.Point(403, 136);
            this.fork1.Name = "fork1";
            this.fork1.Size = new System.Drawing.Size(37, 41);
            this.fork1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fork1.TabIndex = 5;
            this.fork1.TabStop = false;
            // 
            // plate5
            // 
            this.plate5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.plate5.Image = global::Dining_Philosophers.Properties.Resources.platepng;
            this.plate5.Location = new System.Drawing.Point(110, 192);
            this.plate5.Name = "plate5";
            this.plate5.Size = new System.Drawing.Size(110, 91);
            this.plate5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.plate5.TabIndex = 4;
            this.plate5.TabStop = false;
            // 
            // plate4
            // 
            this.plate4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.plate4.Image = global::Dining_Philosophers.Properties.Resources.platepng;
            this.plate4.Location = new System.Drawing.Point(174, 341);
            this.plate4.Name = "plate4";
            this.plate4.Size = new System.Drawing.Size(110, 91);
            this.plate4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.plate4.TabIndex = 3;
            this.plate4.TabStop = false;
            // 
            // plate3
            // 
            this.plate3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.plate3.Image = global::Dining_Philosophers.Properties.Resources.platepng;
            this.plate3.Location = new System.Drawing.Point(363, 341);
            this.plate3.Name = "plate3";
            this.plate3.Size = new System.Drawing.Size(110, 91);
            this.plate3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.plate3.TabIndex = 2;
            this.plate3.TabStop = false;
            // 
            // plate2
            // 
            this.plate2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.plate2.Image = global::Dining_Philosophers.Properties.Resources.platepng;
            this.plate2.Location = new System.Drawing.Point(448, 179);
            this.plate2.Name = "plate2";
            this.plate2.Size = new System.Drawing.Size(110, 91);
            this.plate2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.plate2.TabIndex = 1;
            this.plate2.TabStop = false;
            // 
            // plate1
            // 
            this.plate1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.plate1.Image = global::Dining_Philosophers.Properties.Resources.platepng;
            this.plate1.Location = new System.Drawing.Point(266, 54);
            this.plate1.Name = "plate1";
            this.plate1.Size = new System.Drawing.Size(110, 91);
            this.plate1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.plate1.TabIndex = 0;
            this.plate1.TabStop = false;
            this.plate1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(34, 36);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 10;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(34, 79);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 11;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(99, 32);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 12;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(99, 75);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(100, 23);
            this.progressBar2.TabIndex = 13;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(99, 118);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(100, 23);
            this.progressBar3.TabIndex = 14;
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(99, 160);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(100, 23);
            this.progressBar4.TabIndex = 15;
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(99, 199);
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(100, 23);
            this.progressBar5.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.plate2);
            this.groupBox1.Controls.Add(this.plate1);
            this.groupBox1.Controls.Add(this.plate3);
            this.groupBox1.Controls.Add(this.plate4);
            this.groupBox1.Controls.Add(this.plate5);
            this.groupBox1.Controls.Add(this.fork1);
            this.groupBox1.Controls.Add(this.fork2);
            this.groupBox1.Controls.Add(this.fork3);
            this.groupBox1.Controls.Add(this.fork4);
            this.groupBox1.Controls.Add(this.fork5);
            this.groupBox1.Location = new System.Drawing.Point(91, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 542);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PresentationBox";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Philosopher #5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Philosopher #4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Philosopher #3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(564, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Philosopher #2";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Philosopher #1";
            // 
            // hungryBox
            // 
            this.hungryBox.Controls.Add(this.PHlabel5);
            this.hungryBox.Controls.Add(this.progressBar1);
            this.hungryBox.Controls.Add(this.PHlabel4);
            this.hungryBox.Controls.Add(this.progressBar2);
            this.hungryBox.Controls.Add(this.label3);
            this.hungryBox.Controls.Add(this.progressBar5);
            this.hungryBox.Controls.Add(this.PHlabel2);
            this.hungryBox.Controls.Add(this.progressBar3);
            this.hungryBox.Controls.Add(this.PH1label);
            this.hungryBox.Controls.Add(this.progressBar4);
            this.hungryBox.Location = new System.Drawing.Point(833, 250);
            this.hungryBox.Name = "hungryBox";
            this.hungryBox.Size = new System.Drawing.Size(226, 253);
            this.hungryBox.TabIndex = 18;
            this.hungryBox.TabStop = false;
            this.hungryBox.Text = "nextHungry";
            // 
            // PHlabel5
            // 
            this.PHlabel5.AutoSize = true;
            this.PHlabel5.Location = new System.Drawing.Point(15, 209);
            this.PHlabel5.Name = "PHlabel5";
            this.PHlabel5.Size = new System.Drawing.Size(78, 13);
            this.PHlabel5.TabIndex = 23;
            this.PHlabel5.Text = "Philosopher #5";
            // 
            // PHlabel4
            // 
            this.PHlabel4.AutoSize = true;
            this.PHlabel4.Location = new System.Drawing.Point(15, 170);
            this.PHlabel4.Name = "PHlabel4";
            this.PHlabel4.Size = new System.Drawing.Size(78, 13);
            this.PHlabel4.TabIndex = 22;
            this.PHlabel4.Text = "Philosopher #4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Philosopher #3";
            // 
            // PHlabel2
            // 
            this.PHlabel2.AutoSize = true;
            this.PHlabel2.Location = new System.Drawing.Point(15, 85);
            this.PHlabel2.Name = "PHlabel2";
            this.PHlabel2.Size = new System.Drawing.Size(78, 13);
            this.PHlabel2.TabIndex = 20;
            this.PHlabel2.Text = "Philosopher #2";
            this.PHlabel2.Click += new System.EventHandler(this.label2_Click);
            // 
            // PH1label
            // 
            this.PH1label.AutoSize = true;
            this.PH1label.Location = new System.Drawing.Point(15, 42);
            this.PH1label.Name = "PH1label";
            this.PH1label.Size = new System.Drawing.Size(78, 13);
            this.PH1label.TabIndex = 19;
            this.PH1label.Text = "Philosopher #1";
            this.PH1label.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.startButton);
            this.groupBox2.Controls.Add(this.resetButton);
            this.groupBox2.Location = new System.Drawing.Point(833, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 132);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ActionBox";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 698);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.hungryBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fork4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fork5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fork3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fork2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plate5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plate4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plate3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plate2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plate1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.hungryBox.ResumeLayout(false);
            this.hungryBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox plate1;
        private System.Windows.Forms.PictureBox plate2;
        private System.Windows.Forms.PictureBox plate3;
        private System.Windows.Forms.PictureBox plate4;
        private System.Windows.Forms.PictureBox plate5;
        private System.Windows.Forms.PictureBox fork1;
        private System.Windows.Forms.PictureBox fork2;
        private System.Windows.Forms.PictureBox fork3;
        private System.Windows.Forms.PictureBox fork5;
        private System.Windows.Forms.PictureBox fork4;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox hungryBox;
        private System.Windows.Forms.Label PH1label;
        private System.Windows.Forms.Label PHlabel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PHlabel4;
        private System.Windows.Forms.Label PHlabel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

