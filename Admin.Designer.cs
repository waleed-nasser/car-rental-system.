namespace car_rental_system
{
    partial class Admin
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            lg_pic = new PictureBox();
            label5 = new Label();
            exit = new Label();
            LGlabel1 = new Label();
            label1 = new Label();
            Aid = new TextBox();
            label2 = new Label();
            Aname = new TextBox();
            panel5 = new Panel();
            panel3 = new Panel();
            Apass = new TextBox();
            add = new Button();
            back = new Button();
            delete = new Button();
            edit = new Button();
            label4 = new Label();
            panel2 = new Panel();
            label7 = new Label();
            AdminDVG = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lg_pic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AdminDVG).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 219, 88);
            panel1.Controls.Add(lg_pic);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(exit);
            panel1.Controls.Add(LGlabel1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1270, 80);
            panel1.TabIndex = 17;
            // 
            // lg_pic
            // 
            lg_pic.BackgroundImage = Properties.Resources.car_1;
            lg_pic.BackgroundImageLayout = ImageLayout.Zoom;
            lg_pic.Location = new Point(6, -1);
            lg_pic.Name = "lg_pic";
            lg_pic.Size = new Size(88, 69);
            lg_pic.TabIndex = 20;
            lg_pic.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Bernard MT Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(570, 47);
            label5.Name = "label5";
            label5.Size = new Size(141, 28);
            label5.TabIndex = 4;
            label5.Text = "Manage Admin";
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Font = new Font("Algerian", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exit.Location = new Point(1230, 0);
            exit.Name = "exit";
            exit.Size = new Size(42, 38);
            exit.TabIndex = 20;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // LGlabel1
            // 
            LGlabel1.AutoSize = true;
            LGlabel1.BackColor = Color.Transparent;
            LGlabel1.Font = new Font("Bernard MT Condensed", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LGlabel1.ForeColor = SystemColors.ControlText;
            LGlabel1.Location = new Point(510, 7);
            LGlabel1.Name = "LGlabel1";
            LGlabel1.Size = new Size(267, 40);
            LGlabel1.TabIndex = 3;
            LGlabel1.Text = "CAR RENTAL SYSTEM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bernard MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(12, 158);
            label1.Name = "label1";
            label1.Size = new Size(38, 33);
            label1.TabIndex = 18;
            label1.Text = "ID";
            // 
            // Aid
            // 
            Aid.BackColor = SystemColors.ControlLightLight;
            Aid.BorderStyle = BorderStyle.None;
            Aid.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Aid.ForeColor = SystemColors.InfoText;
            Aid.Location = new Point(136, 164);
            Aid.Name = "Aid";
            Aid.Size = new Size(443, 25);
            Aid.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Bernard MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(2, 232);
            label2.Name = "label2";
            label2.Size = new Size(74, 33);
            label2.TabIndex = 20;
            label2.Text = "Name";
            // 
            // Aname
            // 
            Aname.BackColor = SystemColors.ControlLightLight;
            Aname.BorderStyle = BorderStyle.None;
            Aname.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Aname.ForeColor = SystemColors.InfoText;
            Aname.Location = new Point(136, 238);
            Aname.Name = "Aname";
            Aname.Size = new Size(440, 25);
            Aname.TabIndex = 21;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 219, 88);
            panel5.ForeColor = SystemColors.ActiveCaptionText;
            panel5.Location = new Point(136, 261);
            panel5.Name = "panel5";
            panel5.Size = new Size(440, 4);
            panel5.TabIndex = 22;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 219, 88);
            panel3.ForeColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(139, 345);
            panel3.Name = "panel3";
            panel3.Size = new Size(440, 4);
            panel3.TabIndex = 24;
            // 
            // Apass
            // 
            Apass.BackColor = SystemColors.ControlLightLight;
            Apass.BorderStyle = BorderStyle.None;
            Apass.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Apass.ForeColor = SystemColors.InfoText;
            Apass.Location = new Point(139, 316);
            Apass.Name = "Apass";
            Apass.Size = new Size(437, 25);
            Apass.TabIndex = 25;
            // 
            // add
            // 
            add.BackColor = Color.FromArgb(255, 219, 88);
            add.FlatAppearance.BorderSize = 0;
            add.FlatStyle = FlatStyle.Flat;
            add.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            add.ForeColor = Color.White;
            add.Location = new Point(90, 411);
            add.Name = "add";
            add.Size = new Size(126, 32);
            add.TabIndex = 28;
            add.Text = "Add";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(255, 219, 88);
            back.FlatAppearance.BorderSize = 0;
            back.FlatStyle = FlatStyle.Flat;
            back.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            back.ForeColor = Color.White;
            back.Location = new Point(251, 471);
            back.Name = "back";
            back.Size = new Size(126, 32);
            back.TabIndex = 29;
            back.Text = "Back";
            back.UseVisualStyleBackColor = false;
            back.Click += button1_Click;
            // 
            // delete
            // 
            delete.BackColor = Color.FromArgb(255, 219, 88);
            delete.FlatAppearance.BorderSize = 0;
            delete.FlatStyle = FlatStyle.Flat;
            delete.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            delete.ForeColor = Color.White;
            delete.Location = new Point(414, 411);
            delete.Name = "delete";
            delete.Size = new Size(126, 32);
            delete.TabIndex = 30;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = false;
            delete.Click += button2_Click;
            // 
            // edit
            // 
            edit.BackColor = Color.FromArgb(255, 219, 88);
            edit.FlatAppearance.BorderSize = 0;
            edit.FlatStyle = FlatStyle.Flat;
            edit.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            edit.ForeColor = Color.White;
            edit.Location = new Point(251, 411);
            edit.Name = "edit";
            edit.Size = new Size(126, 32);
            edit.TabIndex = 31;
            edit.Text = "Edit";
            edit.UseVisualStyleBackColor = false;
            edit.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bernard MT Condensed", 16.2F);
            label4.Location = new Point(896, 99);
            label4.Name = "label4";
            label4.Size = new Size(127, 33);
            label4.TabIndex = 32;
            label4.Text = "Admin List";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 219, 88);
            panel2.ForeColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(136, 187);
            panel2.Name = "panel2";
            panel2.Size = new Size(440, 4);
            panel2.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Bernard MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(2, 316);
            label7.Name = "label7";
            label7.Size = new Size(116, 33);
            label7.TabIndex = 35;
            label7.Text = "Password";
            // 
            // AdminDVG
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 219, 88);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            AdminDVG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            AdminDVG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AdminDVG.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            AdminDVG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            AdminDVG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AdminDVG.Cursor = Cursors.Hand;
            AdminDVG.GridColor = SystemColors.InactiveBorder;
            AdminDVG.Location = new Point(663, 143);
            AdminDVG.Name = "AdminDVG";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            AdminDVG.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            AdminDVG.RowHeadersWidth = 72;
            dataGridViewCellStyle4.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText;
            AdminDVG.RowsDefaultCellStyle = dataGridViewCellStyle4;
            AdminDVG.Size = new Size(576, 512);
            AdminDVG.TabIndex = 36;
            AdminDVG.CellContentClick += AdminDVG_CellContentClick_1;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1269, 688);
            Controls.Add(AdminDVG);
            Controls.Add(label7);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(edit);
            Controls.Add(delete);
            Controls.Add(back);
            Controls.Add(add);
            Controls.Add(Apass);
            Controls.Add(panel3);
            Controls.Add(panel5);
            Controls.Add(Aname);
            Controls.Add(label2);
            Controls.Add(Aid);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += Admin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lg_pic).EndInit();
            ((System.ComponentModel.ISupportInitialize)AdminDVG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox lg_pic;
        private Label label5;
        private Label exit;
        private Label LGlabel1;
        private Label label1;
        private TextBox Aid;
        private Label label2;
        private TextBox Aname;
        private Panel panel5;
        private Panel panel3;
        private TextBox Apass;
        private Button add;
        private Button back;
        private Button delete;
        private Button edit;
        private Label label4;
        private Panel panel2;
        private Label label7;
        private DataGridView AdminDVG;
    }
}