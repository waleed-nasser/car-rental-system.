using car_rental_system.Properties;
using System.Net.NetworkInformation;
using System.Security.AccessControl;

namespace car_rental_system
{
    partial class Splash
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            timer1 = new System.Windows.Forms.Timer(components);
            splash_label1 = new Label();
            splash_label2 = new Label();
            splash_prbar = new ProgressBar();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // splash_label1
            // 
            splash_label1.AutoSize = true;
            splash_label1.BackColor = Color.Transparent;
            splash_label1.Font = new Font("Bernard MT Condensed", 24F);
            splash_label1.ImeMode = ImeMode.NoControl;
            splash_label1.Location = new Point(174, 29);
            splash_label1.Name = "splash_label1";
            splash_label1.Size = new Size(316, 47);
            splash_label1.TabIndex = 1;
            splash_label1.Text = "CAR RENTAL SYSTEM";
            // 
            // splash_label2
            // 
            splash_label2.AutoSize = true;
            splash_label2.BackColor = Color.Transparent;
            splash_label2.Font = new Font("Bernard MT Condensed", 10.8F);
            splash_label2.ForeColor = Color.Black;
            splash_label2.ImeMode = ImeMode.NoControl;
            splash_label2.Location = new Point(174, 277);
            splash_label2.Name = "splash_label2";
            splash_label2.Size = new Size(82, 21);
            splash_label2.TabIndex = 2;
            splash_label2.Text = "Loading...";
            // 
            // splash_prbar
            // 
            splash_prbar.BackColor = Color.White;
            splash_prbar.Cursor = Cursors.AppStarting;
            splash_prbar.ForeColor = Color.Gold;
            splash_prbar.ImeMode = ImeMode.NoControl;
            splash_prbar.Location = new Point(176, 303);
            splash_prbar.Name = "splash_prbar";
            splash_prbar.Size = new Size(285, 8);
            splash_prbar.Style = ProgressBarStyle.Continuous;
            splash_prbar.TabIndex = 3;
            splash_prbar.UseWaitCursor = true;
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(638, 365);
            Controls.Add(splash_prbar);
            Controls.Add(splash_label2);
            Controls.Add(splash_label1);
            Cursor = Cursors.AppStarting;
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CAR RENTAL";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Label splash_label1;
        private Label splash_label2;
        private ProgressBar splash_prbar;
    }
}
