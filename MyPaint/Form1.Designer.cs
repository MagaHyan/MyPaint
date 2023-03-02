namespace MyPaint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(830, 440);
            panel1.TabIndex = 0;
            panel1.Click += panel1_Click;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(8, 8);
            panel2.Name = "panel2";
            panel2.Size = new Size(262, 36);
            panel2.TabIndex = 1;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.DeepPink;
            pictureBox6.Location = new Point(180, 0);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(30, 36);
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            pictureBox6.Click += panel1_Click;
            pictureBox6.MouseDown += panel1_MouseDown;
            pictureBox6.MouseMove += panel1_MouseMove;
            pictureBox6.MouseUp += panel1_MouseUp;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Blue;
            pictureBox5.Location = new Point(144, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 36);
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            pictureBox5.Click += panel1_Click;
            pictureBox5.MouseDown += panel1_MouseDown;
            pictureBox5.MouseMove += panel1_MouseMove;
            pictureBox5.MouseUp += panel1_MouseUp;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Yellow;
            pictureBox4.Location = new Point(36, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 36);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            pictureBox4.Click += panel1_Click;
            pictureBox4.MouseDown += panel1_MouseDown;
            pictureBox4.MouseMove += panel1_MouseMove;
            pictureBox4.MouseUp += panel1_MouseUp;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Red;
            pictureBox3.Location = new Point(72, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 36);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += panel1_Click;
            pictureBox3.MouseDown += panel1_MouseDown;
            pictureBox3.MouseMove += panel1_MouseMove;
            pictureBox3.MouseUp += panel1_MouseUp;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Fuchsia;
            pictureBox2.Location = new Point(108, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 36);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += panel1_Click;
            pictureBox2.MouseDown += panel1_MouseDown;
            pictureBox2.MouseMove += panel1_MouseMove;
            pictureBox2.MouseUp += panel1_MouseUp;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Lime;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 36);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += panel1_Click;
            pictureBox1.MouseDown += panel1_MouseDown;
            pictureBox1.MouseMove += panel1_MouseMove;
            pictureBox1.MouseUp += panel1_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 453);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}