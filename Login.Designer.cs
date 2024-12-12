namespace car_rental_system
{
    partial class Login
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
            LGLabel2 = new Label();
            lg_pic = new PictureBox();
            LGLabel1 = new Label();
            PasswordLabel = new Label();
            adminLabel = new Label();
            Aname = new TextBox();
            Apass = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            loginButton = new Button();
            exitLabel = new Label();
            clearLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lg_pic).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 219, 88);
            panel1.Controls.Add(LGLabel2);
            panel1.Controls.Add(lg_pic);
            panel1.Location = new Point(0, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(290, 453);
            panel1.TabIndex = 0;
            // 
            // LGLabel2
            // 
            LGLabel2.AutoSize = true;
            LGLabel2.BackColor = Color.Transparent;
            LGLabel2.Font = new Font("Bernard MT Condensed", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LGLabel2.ForeColor = SystemColors.ControlText;
            LGLabel2.Location = new Point(12, 54);
            LGLabel2.Name = "LGLabel2";
            LGLabel2.Size = new Size(267, 40);
            LGLabel2.TabIndex = 2;
            LGLabel2.Text = "CAR RENTAL SYSTEM";
            // 
            // lg_pic
            // 
            lg_pic.BackgroundImage = Properties.Resources.car_1;
            lg_pic.BackgroundImageLayout = ImageLayout.Zoom;
            lg_pic.Location = new Point(12, 138);
            lg_pic.Name = "lg_pic";
            lg_pic.Size = new Size(256, 167);
            lg_pic.TabIndex = 0;
            lg_pic.TabStop = false;
            // 
            // LGLabel1
            // 
            LGLabel1.AutoSize = true;
            LGLabel1.BackColor = Color.Transparent;
            LGLabel1.Font = new Font("Bernard MT Condensed", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LGLabel1.ForeColor = SystemColors.ControlText;
            LGLabel1.Location = new Point(500, 9);
            LGLabel1.Name = "LGLabel1";
            LGLabel1.Size = new Size(93, 40);
            LGLabel1.TabIndex = 3;
            LGLabel1.Text = "LOGIN";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.BackColor = Color.Transparent;
            PasswordLabel.Font = new Font("Bernard MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordLabel.ForeColor = SystemColors.ControlText;
            PasswordLabel.Location = new Point(296, 264);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(116, 33);
            PasswordLabel.TabIndex = 4;
            PasswordLabel.Text = "Password";
            // 
            // adminLabel
            // 
            adminLabel.AutoSize = true;
            adminLabel.BackColor = Color.Transparent;
            adminLabel.Font = new Font("Bernard MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminLabel.ForeColor = SystemColors.ControlText;
            adminLabel.Location = new Point(296, 141);
            adminLabel.Name = "adminLabel";
            adminLabel.Size = new Size(69, 33);
            adminLabel.TabIndex = 5;
            adminLabel.Text = "NAME";
            // 
            // Aname
            // 
            Aname.BackColor = SystemColors.ControlLightLight;
            Aname.BorderStyle = BorderStyle.None;
            Aname.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Aname.ForeColor = SystemColors.InfoText;
            Aname.Location = new Point(412, 150);
            Aname.Name = "Aname";
            Aname.Size = new Size(345, 24);
            Aname.TabIndex = 6;
            // 
            // Apass
            // 
            Apass.BackColor = SystemColors.ControlLightLight;
            Apass.BorderStyle = BorderStyle.None;
            Apass.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Apass.ForeColor = SystemColors.ControlText;
            Apass.Location = new Point(412, 275);
            Apass.Name = "Apass";
            Apass.Size = new Size(345, 24);
            Apass.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 219, 88);
            panel2.ForeColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(303, 173);
            panel2.Name = "panel2";
            panel2.Size = new Size(461, 4);
            panel2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 219, 88);
            panel3.ForeColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(303, 298);
            panel3.Name = "panel3";
            panel3.Size = new Size(454, 4);
            panel3.TabIndex = 9;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(255, 219, 88);
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginButton.ForeColor = Color.Transparent;
            loginButton.Location = new Point(442, 330);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(216, 37);
            loginButton.TabIndex = 10;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += button1_Click;
            // 
            // exitLabel
            // 
            exitLabel.AutoSize = true;
            exitLabel.BackColor = Color.Transparent;
            exitLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitLabel.ForeColor = Color.FromArgb(255, 219, 88);
            exitLabel.Location = new Point(525, 386);
            exitLabel.Name = "exitLabel";
            exitLabel.Size = new Size(44, 25);
            exitLabel.TabIndex = 11;
            exitLabel.Text = "Exit";
            exitLabel.Click += label3_Click;
            // 
            // clearLabel
            // 
            clearLabel.AutoSize = true;
            clearLabel.BackColor = Color.Transparent;
            clearLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearLabel.ForeColor = Color.FromArgb(255, 219, 88);
            clearLabel.Location = new Point(674, 330);
            clearLabel.Name = "clearLabel";
            clearLabel.Size = new Size(53, 25);
            clearLabel.TabIndex = 12;
            clearLabel.Text = "clear";
            clearLabel.Click += label1_Click_1;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(clearLabel);
            Controls.Add(exitLabel);
            Controls.Add(loginButton);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(Apass);
            Controls.Add(Aname);
            Controls.Add(adminLabel);
            Controls.Add(PasswordLabel);
            Controls.Add(LGLabel1);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lg_pic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox lg_pic;
        private Label LGLabel2;
        private Label LGLabel1;
        private Label PasswordLabel;
        private Label adminLabel;
        private TextBox Aname;
        private TextBox Apass;
        private Panel panel2;
        private Panel panel3;
        private Button loginButton;
        private Label exitLabel;
        private Label clearLabel;
    }
}