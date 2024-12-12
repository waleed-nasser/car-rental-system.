namespace car_rental_system
{
    partial class Rental
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            ReturnDate = new DateTimePicker();
            label10 = new Label();
            panel7 = new Panel();
            RentDate = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            CarRegCb = new ComboBox();
            panel6 = new Panel();
            label7 = new Label();
            RentDVG = new DataGridView();
            address = new TextBox();
            CustNameTb = new TextBox();
            IdTb = new TextBox();
            panel4 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            label4 = new Label();
            back = new Button();
            delete = new Button();
            edit = new Button();
            add = new Button();
            label2 = new Label();
            label1 = new Label();
            Userlabel = new Label();
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            lg_pic = new PictureBox();
            LGlabel1 = new Label();
            panel8 = new Panel();
            CustCb = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)RentDVG).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lg_pic).BeginInit();
            SuspendLayout();
            // 
            // ReturnDate
            // 
            ReturnDate.Location = new Point(299, 689);
            ReturnDate.Name = "ReturnDate";
            ReturnDate.Size = new Size(440, 47);
            ReturnDate.TabIndex = 75;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Bernard MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ControlText;
            label10.Location = new Point(19, 675);
            label10.Name = "label10";
            label10.Size = new Size(280, 66);
            label10.TabIndex = 74;
            label10.Text = "Return Date";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(255, 219, 88);
            panel7.ForeColor = SystemColors.ActiveCaptionText;
            panel7.Location = new Point(299, 735);
            panel7.Name = "panel7";
            panel7.Size = new Size(440, 4);
            panel7.TabIndex = 73;
            // 
            // RentDate
            // 
            RentDate.Location = new Point(299, 623);
            RentDate.Name = "RentDate";
            RentDate.Size = new Size(440, 47);
            RentDate.TabIndex = 72;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Bernard MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(19, 609);
            label9.Name = "label9";
            label9.Size = new Size(274, 66);
            label9.TabIndex = 71;
            label9.Text = "Rental Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Bernard MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(46, 522);
            label8.Name = "label8";
            label8.Size = new Size(144, 66);
            label8.TabIndex = 70;
            label8.Text = "Name";
            // 
            // CarRegCb
            // 
            CarRegCb.FormattingEnabled = true;
            CarRegCb.Location = new Point(299, 338);
            CarRegCb.Name = "CarRegCb";
            CarRegCb.Size = new Size(440, 49);
            CarRegCb.TabIndex = 69;
            CarRegCb.SelectionChangeCommitted += CarRegCb_SelectionChangeCommitted;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(255, 219, 88);
            panel6.ForeColor = SystemColors.ActiveCaptionText;
            panel6.Location = new Point(299, 386);
            panel6.Name = "panel6";
            panel6.Size = new Size(440, 4);
            panel6.TabIndex = 68;
            // 
            // label7
            // 
            label7.AccessibleRole = AccessibleRole.SplitButton;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Bernard MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(46, 341);
            label7.Name = "label7";
            label7.Size = new Size(176, 66);
            label7.TabIndex = 67;
            label7.Text = "CarReg";
            // 
            // RentDVG
            // 
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(255, 219, 88);
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            RentDVG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            RentDVG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            RentDVG.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            RentDVG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            RentDVG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RentDVG.Cursor = Cursors.Hand;
            RentDVG.GridColor = SystemColors.InactiveBorder;
            RentDVG.Location = new Point(853, 236);
            RentDVG.Name = "RentDVG";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            RentDVG.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            RentDVG.RowHeadersWidth = 72;
            dataGridViewCellStyle8.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.ControlText;
            RentDVG.RowsDefaultCellStyle = dataGridViewCellStyle8;
            RentDVG.Size = new Size(756, 653);
            RentDVG.TabIndex = 66;
            // 
            // address
            // 
            address.BackColor = SystemColors.ControlLightLight;
            address.BorderStyle = BorderStyle.None;
            address.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            address.ForeColor = SystemColors.InfoText;
            address.Location = new Point(299, 783);
            address.Name = "address";
            address.Size = new Size(440, 54);
            address.TabIndex = 65;
            // 
            // CustNameTb
            // 
            CustNameTb.BackColor = SystemColors.ControlLightLight;
            CustNameTb.BorderStyle = BorderStyle.None;
            CustNameTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CustNameTb.ForeColor = SystemColors.InfoText;
            CustNameTb.Location = new Point(299, 531);
            CustNameTb.Name = "CustNameTb";
            CustNameTb.Size = new Size(440, 54);
            CustNameTb.TabIndex = 64;
            // 
            // IdTb
            // 
            IdTb.BackColor = SystemColors.ControlLightLight;
            IdTb.BorderStyle = BorderStyle.None;
            IdTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IdTb.ForeColor = SystemColors.InfoText;
            IdTb.Location = new Point(299, 245);
            IdTb.Name = "IdTb";
            IdTb.Size = new Size(440, 54);
            IdTb.TabIndex = 51;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 219, 88);
            panel4.ForeColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(299, 669);
            panel4.Name = "panel4";
            panel4.Size = new Size(440, 4);
            panel4.TabIndex = 58;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 219, 88);
            panel2.ForeColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(299, 584);
            panel2.Name = "panel2";
            panel2.Size = new Size(440, 4);
            panel2.TabIndex = 55;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 219, 88);
            panel3.ForeColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(299, 493);
            panel3.Name = "panel3";
            panel3.Size = new Size(440, 4);
            panel3.TabIndex = 56;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 219, 88);
            panel5.ForeColor = SystemColors.ActiveCaptionText;
            panel5.Location = new Point(299, 298);
            panel5.Name = "panel5";
            panel5.Size = new Size(440, 4);
            panel5.TabIndex = 54;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bernard MT Condensed", 16.2F);
            label4.Location = new Point(1052, 144);
            label4.Name = "label4";
            label4.Size = new Size(289, 66);
            label4.TabIndex = 62;
            label4.Text = "Cars on Rent";
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(255, 219, 88);
            back.FlatAppearance.BorderSize = 0;
            back.FlatStyle = FlatStyle.Flat;
            back.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            back.ForeColor = Color.White;
            back.Location = new Point(339, 1043);
            back.Name = "back";
            back.Size = new Size(178, 58);
            back.TabIndex = 61;
            back.Text = "Back";
            back.UseVisualStyleBackColor = false;
            // 
            // delete
            // 
            delete.BackColor = Color.FromArgb(255, 219, 88);
            delete.FlatAppearance.BorderSize = 0;
            delete.FlatStyle = FlatStyle.Flat;
            delete.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            delete.ForeColor = Color.White;
            delete.Location = new Point(523, 976);
            delete.Name = "delete";
            delete.Size = new Size(178, 58);
            delete.TabIndex = 60;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = false;
            // 
            // edit
            // 
            edit.BackColor = Color.FromArgb(255, 219, 88);
            edit.FlatAppearance.BorderSize = 0;
            edit.FlatStyle = FlatStyle.Flat;
            edit.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            edit.ForeColor = Color.White;
            edit.Location = new Point(339, 976);
            edit.Name = "edit";
            edit.Size = new Size(178, 58);
            edit.TabIndex = 59;
            edit.Text = "Edit";
            edit.UseVisualStyleBackColor = false;
            // 
            // add
            // 
            add.BackColor = Color.FromArgb(255, 219, 88);
            add.FlatAppearance.BorderSize = 0;
            add.FlatStyle = FlatStyle.Flat;
            add.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            add.ForeColor = Color.White;
            add.Location = new Point(155, 976);
            add.Name = "add";
            add.Size = new Size(178, 58);
            add.TabIndex = 57;
            add.Text = "Add";
            add.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Bernard MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(46, 437);
            label2.Name = "label2";
            label2.Size = new Size(151, 66);
            label2.TabIndex = 52;
            label2.Text = "Custld";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bernard MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(46, 236);
            label1.Name = "label1";
            label1.Size = new Size(74, 66);
            label1.TabIndex = 50;
            label1.Text = "ID";
            // 
            // Userlabel
            // 
            Userlabel.AutoSize = true;
            Userlabel.BackColor = Color.Transparent;
            Userlabel.Font = new Font("Bernard MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Userlabel.ForeColor = SystemColors.ControlText;
            Userlabel.Location = new Point(34, 783);
            Userlabel.Name = "Userlabel";
            Userlabel.Size = new Size(118, 66);
            Userlabel.TabIndex = 49;
            Userlabel.Text = "Fees";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 219, 88);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lg_pic);
            panel1.Controls.Add(LGlabel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1636, 131);
            panel1.TabIndex = 76;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Algerian", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(1547, 0);
            label6.Name = "label6";
            label6.Size = new Size(80, 75);
            label6.TabIndex = 20;
            label6.Text = "X";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Bernard MT Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(697, 67);
            label5.Name = "label5";
            label5.Size = new Size(138, 54);
            label5.TabIndex = 4;
            label5.Text = "Rental";
            // 
            // lg_pic
            // 
            lg_pic.BackgroundImageLayout = ImageLayout.Zoom;
            lg_pic.Image = Properties.Resources.car_1;
            lg_pic.Location = new Point(0, 0);
            lg_pic.Name = "lg_pic";
            lg_pic.Size = new Size(145, 121);
            lg_pic.SizeMode = PictureBoxSizeMode.Zoom;
            lg_pic.TabIndex = 20;
            lg_pic.TabStop = false;
            // 
            // LGlabel1
            // 
            LGlabel1.AutoSize = true;
            LGlabel1.BackColor = Color.Transparent;
            LGlabel1.Font = new Font("Bernard MT Condensed", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LGlabel1.ForeColor = SystemColors.ControlText;
            LGlabel1.Location = new Point(502, 0);
            LGlabel1.Name = "LGlabel1";
            LGlabel1.Size = new Size(527, 81);
            LGlabel1.TabIndex = 3;
            LGlabel1.Text = "CAR RENTAL SYSTEM";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(255, 219, 88);
            panel8.ForeColor = SystemColors.ActiveCaptionText;
            panel8.Location = new Point(299, 843);
            panel8.Name = "panel8";
            panel8.Size = new Size(440, 4);
            panel8.TabIndex = 77;
            // 
            // CustCb
            // 
            CustCb.FormattingEnabled = true;
            CustCb.Location = new Point(299, 445);
            CustCb.Name = "CustCb";
            CustCb.Size = new Size(440, 49);
            CustCb.TabIndex = 78;
            // 
            // Rental
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1636, 1114);
            Controls.Add(CustCb);
            Controls.Add(panel8);
            Controls.Add(panel1);
            Controls.Add(ReturnDate);
            Controls.Add(label10);
            Controls.Add(panel7);
            Controls.Add(RentDate);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(CarRegCb);
            Controls.Add(panel6);
            Controls.Add(label7);
            Controls.Add(RentDVG);
            Controls.Add(address);
            Controls.Add(CustNameTb);
            Controls.Add(IdTb);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel5);
            Controls.Add(label4);
            Controls.Add(back);
            Controls.Add(delete);
            Controls.Add(edit);
            Controls.Add(add);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Userlabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Rental";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rental";
            Load += Rental_Load;
            ((System.ComponentModel.ISupportInitialize)RentDVG).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lg_pic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker ReturnDate;
        private Label label10;
        private Panel panel7;
        private DateTimePicker RentDate;
        private Label label9;
        private Label label8;
        private ComboBox CarRegCb;
        private Panel panel6;
        private Label label7;
        private DataGridView RentDVG;
        private TextBox address;
        private TextBox CustNameTb;
        private TextBox IdTb;
        private Panel panel4;
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private Label label4;
        private Button back;
        private Button delete;
        private Button edit;
        private Button add;
        private Label label2;
        private Label label1;
        private Label Userlabel;
        private Panel panel1;
        private Label label6;
        private Label label5;
        private PictureBox lg_pic;
        private Label LGlabel1;
        private Panel panel8;
        private ComboBox CustCb;
    }
}