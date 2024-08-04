namespace QLBanHang
{
    partial class fTONKHO
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtSld = new System.Windows.Forms.TextBox();
            this.txtSlc = new System.Windows.Forms.TextBox();
            this.txtTongSLN = new System.Windows.Forms.TextBox();
            this.txtTongSLX = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbMaVTu = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnThemMoi);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Location = new System.Drawing.Point(20, 190);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 57);
            this.panel2.TabIndex = 3;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(315, 15);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(88, 27);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(220, 15);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(88, 27);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(31, 15);
            this.btnThemMoi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(88, 27);
            this.btnThemMoi.TabIndex = 0;
            this.btnThemMoi.Text = "Thêm";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(126, 15);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(88, 27);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu ";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbMaVTu);
            this.panel1.Controls.Add(this.txtTongSLX);
            this.panel1.Controls.Add(this.txtTongSLN);
            this.panel1.Controls.Add(this.txtSlc);
            this.panel1.Controls.Add(this.txtSld);
            this.panel1.Controls.Add(this.txtDate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(20, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 169);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(20, 251);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(834, 268);
            this.panel3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã vật tư:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Năm tháng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng đầu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng cuối:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(581, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tổng SLN:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(581, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tổng SLX:";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(80, 89);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(179, 21);
            this.txtDate.TabIndex = 7;
            // 
            // txtSld
            // 
            this.txtSld.Location = new System.Drawing.Point(384, 21);
            this.txtSld.Name = "txtSld";
            this.txtSld.Size = new System.Drawing.Size(179, 21);
            this.txtSld.TabIndex = 8;
            // 
            // txtSlc
            // 
            this.txtSlc.Location = new System.Drawing.Point(384, 89);
            this.txtSlc.Name = "txtSlc";
            this.txtSlc.Size = new System.Drawing.Size(179, 21);
            this.txtSlc.TabIndex = 9;
            // 
            // txtTongSLN
            // 
            this.txtTongSLN.Location = new System.Drawing.Point(651, 19);
            this.txtTongSLN.Name = "txtTongSLN";
            this.txtTongSLN.Size = new System.Drawing.Size(179, 21);
            this.txtTongSLN.TabIndex = 10;
            // 
            // txtTongSLX
            // 
            this.txtTongSLX.Location = new System.Drawing.Point(651, 89);
            this.txtTongSLX.Name = "txtTongSLX";
            this.txtTongSLX.Size = new System.Drawing.Size(179, 21);
            this.txtTongSLX.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(834, 268);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cbMaVTu
            // 
            this.cbMaVTu.FormattingEnabled = true;
            this.cbMaVTu.Location = new System.Drawing.Point(81, 24);
            this.cbMaVTu.Name = "cbMaVTu";
            this.cbMaVTu.Size = new System.Drawing.Size(177, 23);
            this.cbMaVTu.TabIndex = 12;
            // 
            // fTONKHO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 519);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "fTONKHO";
            this.Text = "fTONKHO";
            this.Load += new System.EventHandler(this.fTONKHO_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbMaVTu;
        private System.Windows.Forms.TextBox txtTongSLX;
        private System.Windows.Forms.TextBox txtTongSLN;
        private System.Windows.Forms.TextBox txtSlc;
        private System.Windows.Forms.TextBox txtSld;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}