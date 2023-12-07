namespace QLSV
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
            this.SinhVien_dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MSSV_txt = new System.Windows.Forms.TextBox();
            this.HoTen_txt = new System.Windows.Forms.TextBox();
            this.GioiTinh_txt = new System.Windows.Forms.TextBox();
            this.DiaChi_txt = new System.Windows.Forms.TextBox();
            this.SDT_txt = new System.Windows.Forms.TextBox();
            this.Email_txt = new System.Windows.Forms.TextBox();
            this.NgaySinh_dtp = new System.Windows.Forms.DateTimePicker();
            this.Them_btn = new System.Windows.Forms.Button();
            this.Sua_btn = new System.Windows.Forms.Button();
            this.Xoa_btn = new System.Windows.Forms.Button();
            this.Clear_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SinhVien_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // SinhVien_dgv
            // 
            this.SinhVien_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SinhVien_dgv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.SinhVien_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SinhVien_dgv.Location = new System.Drawing.Point(269, 8);
            this.SinhVien_dgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SinhVien_dgv.Name = "SinhVien_dgv";
            this.SinhVien_dgv.RowHeadersWidth = 62;
            this.SinhVien_dgv.RowTemplate.Height = 28;
            this.SinhVien_dgv.Size = new System.Drawing.Size(703, 363);
            this.SinhVien_dgv.TabIndex = 0;
            this.SinhVien_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SinhVien_dgv_CellClick);
            this.SinhVien_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SinhVien_dgv_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "MSSV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ và tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày Sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 196);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số điện thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 226);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Email";
            // 
            // MSSV_txt
            // 
            this.MSSV_txt.Location = new System.Drawing.Point(95, 38);
            this.MSSV_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MSSV_txt.Name = "MSSV_txt";
            this.MSSV_txt.Size = new System.Drawing.Size(153, 20);
            this.MSSV_txt.TabIndex = 1;
            // 
            // HoTen_txt
            // 
            this.HoTen_txt.Location = new System.Drawing.Point(95, 70);
            this.HoTen_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HoTen_txt.Name = "HoTen_txt";
            this.HoTen_txt.Size = new System.Drawing.Size(153, 20);
            this.HoTen_txt.TabIndex = 2;
            // 
            // GioiTinh_txt
            // 
            this.GioiTinh_txt.Location = new System.Drawing.Point(95, 99);
            this.GioiTinh_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GioiTinh_txt.Name = "GioiTinh_txt";
            this.GioiTinh_txt.Size = new System.Drawing.Size(153, 20);
            this.GioiTinh_txt.TabIndex = 3;
            // 
            // DiaChi_txt
            // 
            this.DiaChi_txt.Location = new System.Drawing.Point(95, 164);
            this.DiaChi_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DiaChi_txt.Name = "DiaChi_txt";
            this.DiaChi_txt.Size = new System.Drawing.Size(153, 20);
            this.DiaChi_txt.TabIndex = 5;
            // 
            // SDT_txt
            // 
            this.SDT_txt.Location = new System.Drawing.Point(95, 196);
            this.SDT_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SDT_txt.Name = "SDT_txt";
            this.SDT_txt.Size = new System.Drawing.Size(153, 20);
            this.SDT_txt.TabIndex = 6;
            // 
            // Email_txt
            // 
            this.Email_txt.Location = new System.Drawing.Point(95, 226);
            this.Email_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Email_txt.Name = "Email_txt";
            this.Email_txt.Size = new System.Drawing.Size(153, 20);
            this.Email_txt.TabIndex = 7;
            // 
            // NgaySinh_dtp
            // 
            this.NgaySinh_dtp.Location = new System.Drawing.Point(95, 135);
            this.NgaySinh_dtp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NgaySinh_dtp.Name = "NgaySinh_dtp";
            this.NgaySinh_dtp.Size = new System.Drawing.Size(153, 20);
            this.NgaySinh_dtp.TabIndex = 4;
            // 
            // Them_btn
            // 
            this.Them_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Them_btn.FlatAppearance.BorderSize = 0;
            this.Them_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Them_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Them_btn.ForeColor = System.Drawing.Color.Black;
            this.Them_btn.Location = new System.Drawing.Point(27, 262);
            this.Them_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Them_btn.Name = "Them_btn";
            this.Them_btn.Size = new System.Drawing.Size(96, 38);
            this.Them_btn.TabIndex = 8;
            this.Them_btn.Text = "Thêm mới";
            this.Them_btn.UseVisualStyleBackColor = false;
            this.Them_btn.Click += new System.EventHandler(this.Them_btn_Click);
            // 
            // Sua_btn
            // 
            this.Sua_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Sua_btn.Enabled = false;
            this.Sua_btn.FlatAppearance.BorderSize = 0;
            this.Sua_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sua_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sua_btn.ForeColor = System.Drawing.Color.Black;
            this.Sua_btn.Location = new System.Drawing.Point(156, 262);
            this.Sua_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Sua_btn.Name = "Sua_btn";
            this.Sua_btn.Size = new System.Drawing.Size(96, 38);
            this.Sua_btn.TabIndex = 9;
            this.Sua_btn.Text = "Sửa";
            this.Sua_btn.UseVisualStyleBackColor = false;
            this.Sua_btn.Click += new System.EventHandler(this.Sua_btn_Click);
            // 
            // Xoa_btn
            // 
            this.Xoa_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Xoa_btn.FlatAppearance.BorderSize = 0;
            this.Xoa_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Xoa_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xoa_btn.ForeColor = System.Drawing.Color.Black;
            this.Xoa_btn.Location = new System.Drawing.Point(27, 324);
            this.Xoa_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Xoa_btn.Name = "Xoa_btn";
            this.Xoa_btn.Size = new System.Drawing.Size(96, 38);
            this.Xoa_btn.TabIndex = 10;
            this.Xoa_btn.Text = "Xóa";
            this.Xoa_btn.UseVisualStyleBackColor = false;
            this.Xoa_btn.Click += new System.EventHandler(this.Xoa_btn_Click);
            // 
            // Clear_btn
            // 
            this.Clear_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Clear_btn.FlatAppearance.BorderSize = 0;
            this.Clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_btn.ForeColor = System.Drawing.Color.Black;
            this.Clear_btn.Location = new System.Drawing.Point(156, 324);
            this.Clear_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(96, 38);
            this.Clear_btn.TabIndex = 11;
            this.Clear_btn.Text = "Clear";
            this.Clear_btn.UseVisualStyleBackColor = false;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(913, 378);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.Xoa_btn);
            this.Controls.Add(this.HoTen_txt);
            this.Controls.Add(this.Sua_btn);
            this.Controls.Add(this.Them_btn);
            this.Controls.Add(this.NgaySinh_dtp);
            this.Controls.Add(this.Email_txt);
            this.Controls.Add(this.SDT_txt);
            this.Controls.Add(this.DiaChi_txt);
            this.Controls.Add(this.GioiTinh_txt);
            this.Controls.Add(this.MSSV_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SinhVien_dgv);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SinhVien_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SinhVien_dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MSSV_txt;
        private System.Windows.Forms.TextBox HoTen_txt;
        private System.Windows.Forms.TextBox GioiTinh_txt;
        private System.Windows.Forms.TextBox DiaChi_txt;
        private System.Windows.Forms.TextBox SDT_txt;
        private System.Windows.Forms.TextBox Email_txt;
        private System.Windows.Forms.DateTimePicker NgaySinh_dtp;
        private System.Windows.Forms.Button Them_btn;
        private System.Windows.Forms.Button Sua_btn;
        private System.Windows.Forms.Button Xoa_btn;
        private System.Windows.Forms.Button Clear_btn;
    }
}

