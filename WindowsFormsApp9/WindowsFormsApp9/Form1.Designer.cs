namespace WindowsFormsApp9
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtmasinhvien = new System.Windows.Forms.TextBox();
            this.txthovaten = new System.Windows.Forms.TextBox();
            this.datengaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtcccdcmt = new System.Windows.Forms.TextBox();
            this.txtquequan = new System.Windows.Forms.TextBox();
            this.cbgioitinh = new System.Windows.Forms.ComboBox();
            this.luu = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.timkiem = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSodienthoai = new System.Windows.Forms.TextBox();
            this.dgvThongtinsv = new System.Windows.Forms.DataGridView();
            this.cblop = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongtinsv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cập nhập thông tin sinh viên ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sinh viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lớp ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 321);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quê quán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(441, 83);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Họ và tên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(441, 145);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày sinh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(441, 210);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "CCCD,CMT";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtmasinhvien
            // 
            this.txtmasinhvien.Location = new System.Drawing.Point(173, 76);
            this.txtmasinhvien.Name = "txtmasinhvien";
            this.txtmasinhvien.Size = new System.Drawing.Size(238, 26);
            this.txtmasinhvien.TabIndex = 8;
            this.txtmasinhvien.TextChanged += new System.EventHandler(this.masinhvien_TextChanged);
            // 
            // txthovaten
            // 
            this.txthovaten.Location = new System.Drawing.Point(537, 76);
            this.txthovaten.Name = "txthovaten";
            this.txthovaten.Size = new System.Drawing.Size(257, 26);
            this.txthovaten.TabIndex = 9;
            // 
            // datengaysinh
            // 
            this.datengaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datengaysinh.Location = new System.Drawing.Point(537, 137);
            this.datengaysinh.Name = "datengaysinh";
            this.datengaysinh.Size = new System.Drawing.Size(257, 26);
            this.datengaysinh.TabIndex = 10;
            this.datengaysinh.Value = new System.DateTime(2023, 4, 25, 9, 42, 20, 0);
            // 
            // txtcccdcmt
            // 
            this.txtcccdcmt.Location = new System.Drawing.Point(539, 203);
            this.txtcccdcmt.Name = "txtcccdcmt";
            this.txtcccdcmt.Size = new System.Drawing.Size(255, 26);
            this.txtcccdcmt.TabIndex = 11;
            // 
            // txtquequan
            // 
            this.txtquequan.Location = new System.Drawing.Point(173, 314);
            this.txtquequan.Name = "txtquequan";
            this.txtquequan.Size = new System.Drawing.Size(562, 26);
            this.txtquequan.TabIndex = 12;
            this.txtquequan.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // cbgioitinh
            // 
            this.cbgioitinh.FormattingEnabled = true;
            this.cbgioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbgioitinh.Location = new System.Drawing.Point(173, 137);
            this.cbgioitinh.Name = "cbgioitinh";
            this.cbgioitinh.Size = new System.Drawing.Size(238, 27);
            this.cbgioitinh.TabIndex = 14;
            this.cbgioitinh.Text = "Chọn giới tính";
            // 
            // luu
            // 
            this.luu.Location = new System.Drawing.Point(173, 359);
            this.luu.Name = "luu";
            this.luu.Size = new System.Drawing.Size(75, 23);
            this.luu.TabIndex = 15;
            this.luu.Text = "Lưu ";
            this.luu.UseVisualStyleBackColor = true;
            this.luu.Click += new System.EventHandler(this.luu_Click_1);
            // 
            // sua
            // 
            this.sua.Location = new System.Drawing.Point(282, 359);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(75, 23);
            this.sua.TabIndex = 16;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = true;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(388, 359);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(75, 23);
            this.xoa.TabIndex = 17;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // timkiem
            // 
            this.timkiem.Location = new System.Drawing.Point(505, 359);
            this.timkiem.Name = "timkiem";
            this.timkiem.Size = new System.Drawing.Size(75, 23);
            this.timkiem.TabIndex = 18;
            this.timkiem.Text = "Tìm kiếm";
            this.timkiem.UseVisualStyleBackColor = true;
            this.timkiem.Click += new System.EventHandler(this.timkiem_Click);
            // 
            // thoat
            // 
            this.thoat.Location = new System.Drawing.Point(610, 359);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(75, 23);
            this.thoat.TabIndex = 19;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(75, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "Số điện thoại";
            // 
            // txtSodienthoai
            // 
            this.txtSodienthoai.Location = new System.Drawing.Point(173, 266);
            this.txtSodienthoai.Name = "txtSodienthoai";
            this.txtSodienthoai.Size = new System.Drawing.Size(238, 26);
            this.txtSodienthoai.TabIndex = 21;
            // 
            // dgvThongtinsv
            // 
            this.dgvThongtinsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongtinsv.Location = new System.Drawing.Point(79, 405);
            this.dgvThongtinsv.Name = "dgvThongtinsv";
            this.dgvThongtinsv.Size = new System.Drawing.Size(715, 241);
            this.dgvThongtinsv.TabIndex = 22;
            this.dgvThongtinsv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongtinsv_CellClick);
            this.dgvThongtinsv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cblop
            // 
            this.cblop.FormattingEnabled = true;
            this.cblop.Location = new System.Drawing.Point(173, 199);
            this.cblop.Name = "cblop";
            this.cblop.Size = new System.Drawing.Size(238, 27);
            this.cblop.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.cblop);
            this.Controls.Add(this.dgvThongtinsv);
            this.Controls.Add(this.txtSodienthoai);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.timkiem);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.sua);
            this.Controls.Add(this.luu);
            this.Controls.Add(this.cbgioitinh);
            this.Controls.Add(this.txtquequan);
            this.Controls.Add(this.txtcccdcmt);
            this.Controls.Add(this.datengaysinh);
            this.Controls.Add(this.txthovaten);
            this.Controls.Add(this.txtmasinhvien);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.textBox4_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongtinsv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtmasinhvien;
        private System.Windows.Forms.TextBox txthovaten;
        private System.Windows.Forms.DateTimePicker datengaysinh;
        private System.Windows.Forms.TextBox txtcccdcmt;
        private System.Windows.Forms.TextBox txtquequan;
        private System.Windows.Forms.ComboBox cbgioitinh;
        private System.Windows.Forms.Button luu;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button timkiem;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSodienthoai;
        private System.Windows.Forms.DataGridView dgvThongtinsv;
        private System.Windows.Forms.ComboBox cblop;
    }
}

