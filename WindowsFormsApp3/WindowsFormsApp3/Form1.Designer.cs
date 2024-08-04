namespace WindowsFormsApp3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXuatExecl = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhap = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbPhanloai = new System.Windows.Forms.ComboBox();
            this.cbSoghe = new System.Windows.Forms.ComboBox();
            this.cbHangsanxuat = new System.Windows.Forms.ComboBox();
            this.txtkichthuoc = new System.Windows.Forms.TextBox();
            this.txtTenmaybay = new System.Windows.Forms.TextBox();
            this.txtMamaybay = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsvDanhsach = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lí máy bay ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnXuatExecl);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnCapNhap);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.cbPhanloai);
            this.groupBox1.Controls.Add(this.cbSoghe);
            this.groupBox1.Controls.Add(this.cbHangsanxuat);
            this.groupBox1.Controls.Add(this.txtkichthuoc);
            this.groupBox1.Controls.Add(this.txtTenmaybay);
            this.groupBox1.Controls.Add(this.txtMamaybay);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(74, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 316);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // btnXuatExecl
            // 
            this.btnXuatExecl.Location = new System.Drawing.Point(564, 214);
            this.btnXuatExecl.Name = "btnXuatExecl";
            this.btnXuatExecl.Size = new System.Drawing.Size(77, 24);
            this.btnXuatExecl.TabIndex = 21;
            this.btnXuatExecl.Text = "Xuất Execl";
            this.btnXuatExecl.UseVisualStyleBackColor = true;
            this.btnXuatExecl.Click += new System.EventHandler(this.btnXuatExecl_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(564, 171);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(77, 20);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhap
            // 
            this.btnCapNhap.Location = new System.Drawing.Point(564, 126);
            this.btnCapNhap.Name = "btnCapNhap";
            this.btnCapNhap.Size = new System.Drawing.Size(77, 23);
            this.btnCapNhap.TabIndex = 19;
            this.btnCapNhap.Text = "Cập nhập";
            this.btnCapNhap.UseVisualStyleBackColor = true;
            this.btnCapNhap.Click += new System.EventHandler(this.btnCapNhap_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(564, 86);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(77, 23);
            this.btnLuu.TabIndex = 18;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(564, 42);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(77, 21);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbPhanloai
            // 
            this.cbPhanloai.FormattingEnabled = true;
            this.cbPhanloai.Items.AddRange(new object[] {
            "Thương gia",
            "Phổ thông "});
            this.cbPhanloai.Location = new System.Drawing.Point(202, 242);
            this.cbPhanloai.Name = "cbPhanloai";
            this.cbPhanloai.Size = new System.Drawing.Size(318, 21);
            this.cbPhanloai.TabIndex = 16;
            // 
            // cbSoghe
            // 
            this.cbSoghe.FormattingEnabled = true;
            this.cbSoghe.Items.AddRange(new object[] {
            "100",
            "200",
            "300"});
            this.cbSoghe.Location = new System.Drawing.Point(202, 206);
            this.cbSoghe.Name = "cbSoghe";
            this.cbSoghe.Size = new System.Drawing.Size(318, 21);
            this.cbSoghe.TabIndex = 15;
            // 
            // cbHangsanxuat
            // 
            this.cbHangsanxuat.FormattingEnabled = true;
            this.cbHangsanxuat.Items.AddRange(new object[] {
            "Vietnam Arilines",
            "Vietjet Air",
            "Jetstar Pacific Airlines",
            "Bamboo Airways"});
            this.cbHangsanxuat.Location = new System.Drawing.Point(202, 123);
            this.cbHangsanxuat.Name = "cbHangsanxuat";
            this.cbHangsanxuat.Size = new System.Drawing.Size(318, 21);
            this.cbHangsanxuat.TabIndex = 14;
            // 
            // txtkichthuoc
            // 
            this.txtkichthuoc.Location = new System.Drawing.Point(202, 168);
            this.txtkichthuoc.Name = "txtkichthuoc";
            this.txtkichthuoc.Size = new System.Drawing.Size(318, 20);
            this.txtkichthuoc.TabIndex = 13;
            // 
            // txtTenmaybay
            // 
            this.txtTenmaybay.Location = new System.Drawing.Point(202, 86);
            this.txtTenmaybay.Name = "txtTenmaybay";
            this.txtTenmaybay.Size = new System.Drawing.Size(318, 20);
            this.txtTenmaybay.TabIndex = 12;
            // 
            // txtMamaybay
            // 
            this.txtMamaybay.Location = new System.Drawing.Point(202, 42);
            this.txtMamaybay.Name = "txtMamaybay";
            this.txtMamaybay.Size = new System.Drawing.Size(318, 20);
            this.txtMamaybay.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Phân loại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Số ghế:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Kích thước:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hãng sản xuất:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên máy bay:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã máy bay:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsvDanhsach);
            this.groupBox2.Location = new System.Drawing.Point(4, 370);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(863, 200);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiển thị danh sách";
            // 
            // lsvDanhsach
            // 
            this.lsvDanhsach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lsvDanhsach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvDanhsach.FullRowSelect = true;
            this.lsvDanhsach.GridLines = true;
            this.lsvDanhsach.HideSelection = false;
            this.lsvDanhsach.Location = new System.Drawing.Point(3, 16);
            this.lsvDanhsach.Name = "lsvDanhsach";
            this.lsvDanhsach.Size = new System.Drawing.Size(857, 181);
            this.lsvDanhsach.TabIndex = 0;
            this.lsvDanhsach.UseCompatibleStateImageBehavior = false;
            this.lsvDanhsach.View = System.Windows.Forms.View.Details;
            this.lsvDanhsach.SelectedIndexChanged += new System.EventHandler(this.lsvDanhsach_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã MBay";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên MBay";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Hãng SX";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kích thước";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Số Ghế ";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Phân loại";
            this.columnHeader6.Width = 80;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(445, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "NHẬP DỮ LIỆU TỪ FILE ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 660);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "From1";
            this.Load += new System.EventHandler(this.From1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbPhanloai;
        private System.Windows.Forms.ComboBox cbSoghe;
        private System.Windows.Forms.ComboBox cbHangsanxuat;
        private System.Windows.Forms.TextBox txtkichthuoc;
        private System.Windows.Forms.TextBox txtTenmaybay;
        private System.Windows.Forms.TextBox txtMamaybay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCapNhap;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXuatExecl;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lsvDanhsach;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button button1;
    }
}

