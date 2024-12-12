namespace car_rental_system
{
    partial class Customer
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
            Userlabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            back = new Button();
            label4 = new Label();
            panel1 = new Panel();
            lg_pic = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            LGlabel1 = new Label();
            panel5 = new Panel();
            add = new Button();
            edit = new Button();
            delete = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            Userid = new TextBox();
            name = new TextBox();
            address = new TextBox();
            phone = new TextBox();
            customerDVG = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lg_pic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerDVG).BeginInit();
            SuspendLayout();
            // 
            // Userlabel
            // 
            Userlabel.AutoSize = true;
            Userlabel.BackColor = Color.Transparent;
            Userlabel.Font = new Font("Bernard MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Userlabel.ForeColor = SystemColors.ControlText;
            Userlabel.Location = new Point(-3, 344);
            Userlabel.Name = "Userlabel";
            Userlabel.Size = new Size(97, 33);
            Userlabel.TabIndex = 6;
            Userlabel.Text = "Address";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bernard MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(1, 169);
            label1.Name = "label1";
            label1.Size = new Size(38, 33);
            label1.TabIndex = 7;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Bernard MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(1, 261);
            label2.Name = "label2";
            label2.Size = new Size(74, 33);
            label2.TabIndex = 8;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Bernard MT Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(1, 422);
            label3.Name = "label3";
            label3.Size = new Size(84, 33);
            label3.TabIndex = 9;
            label3.Text = "Phone";
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(255, 219, 88);
            back.FlatAppearance.BorderSize = 0;
            back.FlatStyle = FlatStyle.Flat;
            back.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            back.ForeColor = Color.White;
            back.Location = new Point(229, 599);
            back.Name = "back";
            back.Size = new Size(126, 32);
            back.TabIndex = 13;
            back.Text = "Back";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bernard MT Condensed", 16.2F);
            label4.Location = new Point(873, 78);
            label4.Name = "label4";
            label4.Size = new Size(156, 33);
            label4.TabIndex = 15;
            label4.Text = "Customer List";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 219, 88);
            panel1.Controls.Add(lg_pic);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(LGlabel1);
            panel1.Location = new Point(-3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1275, 68);
            panel1.TabIndex = 16;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Algerian", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(1230, 0);
            label6.Name = "label6";
            label6.Size = new Size(42, 38);
            label6.TabIndex = 20;
            label6.Text = "X";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Bernard MT Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(544, 34);
            label5.Name = "label5";
            label5.Size = new Size(173, 28);
            label5.TabIndex = 4;
            label5.Text = "Manage Customers";
            // 
            // LGlabel1
            // 
            LGlabel1.AutoSize = true;
            LGlabel1.BackColor = Color.Transparent;
            LGlabel1.Font = new Font("Bernard MT Condensed", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LGlabel1.ForeColor = SystemColors.ControlText;
            LGlabel1.Location = new Point(502, 0);
            LGlabel1.Name = "LGlabel1";
            LGlabel1.Size = new Size(267, 40);
            LGlabel1.TabIndex = 3;
            LGlabel1.Text = "CAR RENTAL SYSTEM";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 219, 88);
            panel5.ForeColor = SystemColors.ActiveCaptionText;
            panel5.Location = new Point(85, 202);
            panel5.Name = "panel5";
            panel5.Size = new Size(440, 4);
            panel5.TabIndex = 9;
            // 
            // add
            // 
            add.BackColor = Color.FromArgb(255, 219, 88);
            add.FlatAppearance.BorderSize = 0;
            add.FlatStyle = FlatStyle.Flat;
            add.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            add.ForeColor = Color.White;
            add.Location = new Point(97, 545);
            add.Name = "add";
            add.Size = new Size(126, 32);
            add.TabIndex = 10;
            add.Text = "Add";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // edit
            // 
            edit.BackColor = Color.FromArgb(255, 219, 88);
            edit.FlatAppearance.BorderSize = 0;
            edit.FlatStyle = FlatStyle.Flat;
            edit.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            edit.ForeColor = Color.White;
            edit.Location = new Point(229, 545);
            edit.Name = "edit";
            edit.Size = new Size(126, 32);
            edit.TabIndex = 11;
            edit.Text = "Edit";
            edit.UseVisualStyleBackColor = false;
            edit.Click += edit_Click_1;
            // 
            // delete
            // 
            delete.BackColor = Color.FromArgb(255, 219, 88);
            delete.FlatAppearance.BorderSize = 0;
            delete.FlatStyle = FlatStyle.Flat;
            delete.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            delete.ForeColor = Color.White;
            delete.Location = new Point(361, 544);
            delete.Name = "delete";
            delete.Size = new Size(126, 32);
            delete.TabIndex = 12;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 219, 88);
            panel2.ForeColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(85, 380);
            panel2.Name = "panel2";
            panel2.Size = new Size(440, 4);
            panel2.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 219, 88);
            panel3.ForeColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(85, 290);
            panel3.Name = "panel3";
            panel3.Size = new Size(440, 4);
            panel3.TabIndex = 10;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 219, 88);
            panel4.ForeColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(85, 458);
            panel4.Name = "panel4";
            panel4.Size = new Size(440, 4);
            panel4.TabIndex = 10;
            // 
            // Userid
            // 
            Userid.BackColor = SystemColors.ControlLightLight;
            Userid.BorderStyle = BorderStyle.None;
            Userid.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Userid.ForeColor = SystemColors.InfoText;
            Userid.Location = new Point(97, 175);
            Userid.Name = "Userid";
            Userid.Size = new Size(402, 27);
            Userid.TabIndex = 7;
            // 
            // name
            // 
            name.BackColor = SystemColors.ControlLightLight;
            name.BorderStyle = BorderStyle.None;
            name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name.ForeColor = SystemColors.InfoText;
            name.Location = new Point(99, 260);
            name.Name = "name";
            name.Size = new Size(402, 27);
            name.TabIndex = 17;
            // 
            // address
            // 
            address.BackColor = SystemColors.ControlLightLight;
            address.BorderStyle = BorderStyle.None;
            address.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            address.ForeColor = SystemColors.InfoText;
            address.Location = new Point(99, 350);
            address.Name = "address";
            address.Size = new Size(402, 27);
            address.TabIndex = 18;
            // 
            // phone
            // 
            phone.BackColor = SystemColors.ControlLightLight;
            phone.BorderStyle = BorderStyle.None;
            phone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phone.ForeColor = SystemColors.InfoText;
            phone.Location = new Point(98, 431);
            phone.Name = "phone";
            phone.Size = new Size(402, 27);
            phone.TabIndex = 19;
            // 
            // customerDVG
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 219, 88);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            customerDVG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            customerDVG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            customerDVG.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            customerDVG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            customerDVG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customerDVG.Cursor = Cursors.Hand;
            customerDVG.GridColor = SystemColors.InactiveBorder;
            customerDVG.Location = new Point(652, 114);
            customerDVG.Name = "customerDVG";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            customerDVG.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            customerDVG.RowHeadersWidth = 72;
            dataGridViewCellStyle4.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText;
            customerDVG.RowsDefaultCellStyle = dataGridViewCellStyle4;
            customerDVG.Size = new Size(576, 512);
            customerDVG.TabIndex = 21;
            customerDVG.CellContentClick += customerDVG_CellContentClick;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1269, 655);
            Controls.Add(customerDVG);
            Controls.Add(phone);
            Controls.Add(address);
            Controls.Add(name);
            Controls.Add(Userid);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(back);
            Controls.Add(delete);
            Controls.Add(edit);
            Controls.Add(add);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Userlabel);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Customer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phone";
            Load += Customer_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lg_pic).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerDVG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Userlabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button back;
        private Label label4;
        private Panel panel1;
        private Panel panel5;
        private Button add;
        private Button edit;
        private Button delete;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label LGlabel1;
        private Label label5;
        private TextBox Userid;
        private TextBox name;
        private TextBox address;
        private TextBox phone;
        private Label label6;
        private PictureBox lg_pic;
        private DataGridView customerDVG;
    }
}