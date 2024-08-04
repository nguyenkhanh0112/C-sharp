namespace winfrom_vs_sql_sever
{
    partial class From7
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btncodungparameter = new System.Windows.Forms.Button();
            this.btnkodungparameter = new System.Windows.Forms.Button();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.txtDonvitinh = new System.Windows.Forms.TextBox();
            this.txtTenmonan = new System.Windows.Forms.TextBox();
            this.txtIDnhommonan = new System.Windows.Forms.TextBox();
            this.txtIDmonan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "sửa dữ liệu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(31, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 318);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin món ăn";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 16);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(375, 299);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID MA";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID nhóm MA";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên MA";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ĐV tính";
            this.columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Đơn Giá";
            this.columnHeader5.Width = 80;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btncodungparameter);
            this.groupBox2.Controls.Add(this.btnkodungparameter);
            this.groupBox2.Controls.Add(this.txtDongia);
            this.groupBox2.Controls.Add(this.txtDonvitinh);
            this.groupBox2.Controls.Add(this.txtTenmonan);
            this.groupBox2.Controls.Add(this.txtIDnhommonan);
            this.groupBox2.Controls.Add(this.txtIDmonan);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(428, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 373);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chính sửa thông tin món ăn ";
            // 
            // btncodungparameter
            // 
            this.btncodungparameter.Location = new System.Drawing.Point(235, 310);
            this.btncodungparameter.Name = "btncodungparameter";
            this.btncodungparameter.Size = new System.Drawing.Size(140, 44);
            this.btncodungparameter.TabIndex = 11;
            this.btncodungparameter.Text = "dùng parmeter";
            this.btncodungparameter.UseVisualStyleBackColor = true;
            this.btncodungparameter.Click += new System.EventHandler(this.btncodungparameter_Click);
            // 
            // btnkodungparameter
            // 
            this.btnkodungparameter.Location = new System.Drawing.Point(73, 310);
            this.btnkodungparameter.Name = "btnkodungparameter";
            this.btnkodungparameter.Size = new System.Drawing.Size(128, 44);
            this.btnkodungparameter.TabIndex = 10;
            this.btnkodungparameter.Text = "không dùng parameter";
            this.btnkodungparameter.UseVisualStyleBackColor = true;
            this.btnkodungparameter.Click += new System.EventHandler(this.btnkodungparameter_Click);
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(156, 251);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(219, 20);
            this.txtDongia.TabIndex = 9;
            // 
            // txtDonvitinh
            // 
            this.txtDonvitinh.Location = new System.Drawing.Point(156, 207);
            this.txtDonvitinh.Name = "txtDonvitinh";
            this.txtDonvitinh.Size = new System.Drawing.Size(219, 20);
            this.txtDonvitinh.TabIndex = 8;
            // 
            // txtTenmonan
            // 
            this.txtTenmonan.Location = new System.Drawing.Point(156, 152);
            this.txtTenmonan.Name = "txtTenmonan";
            this.txtTenmonan.Size = new System.Drawing.Size(219, 20);
            this.txtTenmonan.TabIndex = 7;
            // 
            // txtIDnhommonan
            // 
            this.txtIDnhommonan.Location = new System.Drawing.Point(156, 96);
            this.txtIDnhommonan.Name = "txtIDnhommonan";
            this.txtIDnhommonan.Size = new System.Drawing.Size(219, 20);
            this.txtIDnhommonan.TabIndex = 6;
            // 
            // txtIDmonan
            // 
            this.txtIDmonan.Location = new System.Drawing.Point(156, 40);
            this.txtIDmonan.Name = "txtIDmonan";
            this.txtIDmonan.Size = new System.Drawing.Size(219, 20);
            this.txtIDmonan.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Đơn giá:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Đơn vị tính:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tên món ăn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "ID nhóm món ăn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID món ăn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chọn món ăn:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(187, 93);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(255, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // From7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 547);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "From7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.From7_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btncodungparameter;
        private System.Windows.Forms.Button btnkodungparameter;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.TextBox txtDonvitinh;
        private System.Windows.Forms.TextBox txtTenmonan;
        private System.Windows.Forms.TextBox txtIDnhommonan;
        private System.Windows.Forms.TextBox txtIDmonan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}