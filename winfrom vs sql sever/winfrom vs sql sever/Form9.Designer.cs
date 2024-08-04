namespace winfrom_vs_sql_sever
{
    partial class Form9
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsvDanhsachPN = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoPN = new System.Windows.Forms.TextBox();
            this.txtMaVT = new System.Windows.Forms.TextBox();
            this.txtSoLN = new System.Windows.Forms.TextBox();
            this.txtDonGN = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Truy vấn dữ liệu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsvDanhsachPN);
            this.groupBox1.Location = new System.Drawing.Point(39, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 326);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách phiếu nhập";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDonGN);
            this.groupBox2.Controls.Add(this.txtSoLN);
            this.groupBox2.Controls.Add(this.txtMaVT);
            this.groupBox2.Controls.Add(this.txtSoPN);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(387, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 326);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết phiếu nhập";
            // 
            // lsvDanhsachPN
            // 
            this.lsvDanhsachPN.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lsvDanhsachPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvDanhsachPN.FullRowSelect = true;
            this.lsvDanhsachPN.GridLines = true;
            this.lsvDanhsachPN.HideSelection = false;
            this.lsvDanhsachPN.Location = new System.Drawing.Point(3, 16);
            this.lsvDanhsachPN.Name = "lsvDanhsachPN";
            this.lsvDanhsachPN.Size = new System.Drawing.Size(275, 307);
            this.lsvDanhsachPN.TabIndex = 0;
            this.lsvDanhsachPN.UseCompatibleStateImageBehavior = false;
            this.lsvDanhsachPN.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Số phiếu nhập";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ngày nhập";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số đơn hàng";
            this.columnHeader3.Width = 90;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số phiếu nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã vật tư:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số lượng nhập:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Đơn giá nhập:";
            // 
            // txtSoPN
            // 
            this.txtSoPN.Location = new System.Drawing.Point(104, 68);
            this.txtSoPN.Name = "txtSoPN";
            this.txtSoPN.Size = new System.Drawing.Size(220, 20);
            this.txtSoPN.TabIndex = 4;
            // 
            // txtMaVT
            // 
            this.txtMaVT.Location = new System.Drawing.Point(104, 127);
            this.txtMaVT.Name = "txtMaVT";
            this.txtMaVT.Size = new System.Drawing.Size(220, 20);
            this.txtMaVT.TabIndex = 5;
            // 
            // txtSoLN
            // 
            this.txtSoLN.Location = new System.Drawing.Point(104, 183);
            this.txtSoLN.Name = "txtSoLN";
            this.txtSoLN.Size = new System.Drawing.Size(220, 20);
            this.txtSoLN.TabIndex = 6;
            // 
            // txtDonGN
            // 
            this.txtDonGN.Location = new System.Drawing.Point(104, 242);
            this.txtDonGN.Name = "txtDonGN";
            this.txtDonGN.Size = new System.Drawing.Size(220, 20);
            this.txtDonGN.TabIndex = 7;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lsvDanhsachPN;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox txtDonGN;
        private System.Windows.Forms.TextBox txtSoLN;
        private System.Windows.Forms.TextBox txtMaVT;
        private System.Windows.Forms.TextBox txtSoPN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}