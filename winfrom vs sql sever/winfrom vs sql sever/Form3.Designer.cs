namespace winfrom_vs_sql_sever
{
    partial class Form3
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
            this.txtMVT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bntkhongdun = new System.Windows.Forms.Button();
            this.btncodung = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenVT = new System.Windows.Forms.TextBox();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.txtPhanTram = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Truy vấn trả về một dòng dữ liệu";
            // 
            // txtMVT
            // 
            this.txtMVT.Location = new System.Drawing.Point(254, 72);
            this.txtMVT.Name = "txtMVT";
            this.txtMVT.Size = new System.Drawing.Size(288, 20);
            this.txtMVT.TabIndex = 1;
            this.txtMVT.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập MVT:";
            // 
            // bntkhongdun
            // 
            this.bntkhongdun.Location = new System.Drawing.Point(238, 150);
            this.bntkhongdun.Name = "bntkhongdun";
            this.bntkhongdun.Size = new System.Drawing.Size(112, 43);
            this.bntkhongdun.TabIndex = 3;
            this.bntkhongdun.Text = "không dùng parameter";
            this.bntkhongdun.UseVisualStyleBackColor = true;
            this.bntkhongdun.Click += new System.EventHandler(this.bntkhongdun_Click);
            // 
            // btncodung
            // 
            this.btncodung.Location = new System.Drawing.Point(430, 151);
            this.btncodung.Name = "btncodung";
            this.btncodung.Size = new System.Drawing.Size(112, 42);
            this.btncodung.TabIndex = 4;
            this.btncodung.Text = "dùng parameter";
            this.btncodung.UseVisualStyleBackColor = true;
            this.btncodung.Click += new System.EventHandler(this.btncodung_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên VT:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Đơn Vị Tính:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Phần Trăm:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtTenVT
            // 
            this.txtTenVT.Location = new System.Drawing.Point(254, 263);
            this.txtTenVT.Name = "txtTenVT";
            this.txtTenVT.Size = new System.Drawing.Size(288, 20);
            this.txtTenVT.TabIndex = 8;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Location = new System.Drawing.Point(254, 334);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(288, 20);
            this.txtDonViTinh.TabIndex = 9;
            // 
            // txtPhanTram
            // 
            this.txtPhanTram.Location = new System.Drawing.Point(254, 390);
            this.txtPhanTram.Name = "txtPhanTram";
            this.txtPhanTram.Size = new System.Drawing.Size(288, 20);
            this.txtPhanTram.TabIndex = 10;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPhanTram);
            this.Controls.Add(this.txtDonViTinh);
            this.Controls.Add(this.txtTenVT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btncodung);
            this.Controls.Add(this.bntkhongdun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMVT);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMVT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bntkhongdun;
        private System.Windows.Forms.Button btncodung;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenVT;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.TextBox txtPhanTram;
    }
}