namespace QLBanHang
{
    partial class fCTPXUAT
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
            this.panner = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSlxuat = new System.Windows.Forms.TextBox();
            this.txtDgxuat = new System.Windows.Forms.TextBox();
            this.cbMaVTu = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbSoPX = new System.Windows.Forms.ComboBox();
            this.panner.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panner
            // 
            this.panner.Controls.Add(this.cbSoPX);
            this.panner.Controls.Add(this.cbMaVTu);
            this.panner.Controls.Add(this.txtDgxuat);
            this.panner.Controls.Add(this.txtSlxuat);
            this.panner.Controls.Add(this.label4);
            this.panner.Controls.Add(this.label3);
            this.panner.Controls.Add(this.label2);
            this.panner.Controls.Add(this.label1);
            this.panner.Location = new System.Drawing.Point(12, 12);
            this.panner.Name = "panner";
            this.panner.Size = new System.Drawing.Size(809, 127);
            this.panner.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn giá xuất:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng xuất:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã vật tư:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số phiếu xuất:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnThemMoi);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Location = new System.Drawing.Point(12, 145);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(807, 58);
            this.panel2.TabIndex = 5;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(368, 17);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(103, 31);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(257, 17);
            this.btnSua.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(103, 31);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(36, 17);
            this.btnThemMoi.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(103, 31);
            this.btnThemMoi.TabIndex = 0;
            this.btnThemMoi.Text = "Thêm";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(147, 17);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(103, 31);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu ";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(14, 214);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(806, 297);
            this.panel3.TabIndex = 6;
            // 
            // txtSlxuat
            // 
            this.txtSlxuat.Location = new System.Drawing.Point(492, 11);
            this.txtSlxuat.Name = "txtSlxuat";
            this.txtSlxuat.Size = new System.Drawing.Size(178, 21);
            this.txtSlxuat.TabIndex = 5;
            // 
            // txtDgxuat
            // 
            this.txtDgxuat.Location = new System.Drawing.Point(492, 82);
            this.txtDgxuat.Name = "txtDgxuat";
            this.txtDgxuat.Size = new System.Drawing.Size(178, 21);
            this.txtDgxuat.TabIndex = 6;
            // 
            // cbMaVTu
            // 
            this.cbMaVTu.FormattingEnabled = true;
            this.cbMaVTu.Location = new System.Drawing.Point(126, 83);
            this.cbMaVTu.Name = "cbMaVTu";
            this.cbMaVTu.Size = new System.Drawing.Size(178, 23);
            this.cbMaVTu.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(806, 297);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // cbSoPX
            // 
            this.cbSoPX.FormattingEnabled = true;
            this.cbSoPX.Location = new System.Drawing.Point(126, 9);
            this.cbSoPX.Name = "cbSoPX";
            this.cbSoPX.Size = new System.Drawing.Size(178, 23);
            this.cbSoPX.TabIndex = 8;
            // 
            // fCTPXUAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 519);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panner);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "fCTPXUAT";
            this.Text = "fCTPXUAT";
            this.Load += new System.EventHandler(this.fCTPXUAT_Load);
            this.panner.ResumeLayout(false);
            this.panner.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMaVTu;
        private System.Windows.Forms.TextBox txtDgxuat;
        private System.Windows.Forms.TextBox txtSlxuat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbSoPX;
    }
}