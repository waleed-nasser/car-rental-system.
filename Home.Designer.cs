namespace car_rental_system
{
    partial class Home
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
            panel1 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            exit = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 219, 88);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 655);
            panel1.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bernard MT Condensed", 14.8000011F);
            label8.Location = new Point(78, 409);
            label8.Name = "label8";
            label8.Size = new Size(96, 29);
            label8.TabIndex = 6;
            label8.Text = "returned";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bernard MT Condensed", 14.8000011F);
            label7.Location = new Point(71, 350);
            label7.Name = "label7";
            label7.Size = new Size(112, 29);
            label7.TabIndex = 5;
            label7.Text = "Rental Car";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bernard MT Condensed", 14.8000011F);
            label6.Location = new Point(74, 294);
            label6.Name = "label6";
            label6.Size = new Size(109, 29);
            label6.TabIndex = 4;
            label6.Text = "Coustomrs";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bernard MT Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(100, 247);
            label5.Name = "label5";
            label5.Size = new Size(48, 28);
            label5.TabIndex = 3;
            label5.Text = "Cars";
            label5.Click += label5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bernard MT Condensed", 14.2F);
            label3.Location = new Point(89, 197);
            label3.Name = "label3";
            label3.Size = new Size(80, 28);
            label3.TabIndex = 2;
            label3.Text = "admins";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bernard MT Condensed", 14.2F);
            label2.Location = new Point(79, 144);
            label2.Name = "label2";
            label2.Size = new Size(113, 28);
            label2.TabIndex = 1;
            label2.Text = "dashboard";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bernard MT Condensed", 19.8000011F);
            label1.Location = new Point(51, 22);
            label1.Name = "label1";
            label1.Size = new Size(158, 80);
            label1.TabIndex = 0;
            label1.Text = "Car Rental \r\n    System";
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.BackColor = Color.White;
            exit.Font = new Font("Bernard MT Condensed", 14.8000011F);
            exit.Location = new Point(1180, 597);
            exit.Name = "exit";
            exit.Size = new Size(63, 29);
            exit.TabIndex = 8;
            exit.Text = "EXIST";
            exit.Click += exit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Bernard MT Condensed", 19.8000011F);
            label4.Location = new Point(297, 22);
            label4.Name = "label4";
            label4.Size = new Size(88, 40);
            label4.TabIndex = 9;
            label4.Text = "HOME";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.car_2;
            pictureBox1.Location = new Point(282, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(989, 514);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1269, 655);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(exit);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label exit;
        private Label label4;
        private PictureBox pictureBox1;
    }
}