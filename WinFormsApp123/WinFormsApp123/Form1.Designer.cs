namespace WinFormsApp123
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnclick = new Button();
            panel1 = new Panel();
            dgv1 = new DataGridView();
            txtTen = new TextBox();
            txtMSV = new TextBox();
            txtDiaChi = new TextBox();
            txtSDT = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            SuspendLayout();
            // 
            // btnclick
            // 
            btnclick.Location = new Point(698, 107);
            btnclick.Name = "btnclick";
            btnclick.Size = new Size(106, 33);
            btnclick.TabIndex = 0;
            btnclick.Text = "btnClick";
            btnclick.UseVisualStyleBackColor = true;
            btnclick.Click += btnclick_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgv1);
            panel1.Location = new Point(5, 146);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 301);
            panel1.TabIndex = 1;
            // 
            // dgv1
            // 
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Location = new Point(0, 3);
            dgv1.Name = "dgv1";
            dgv1.RowTemplate.Height = 25;
            dgv1.Size = new Size(793, 298);
            dgv1.TabIndex = 0;
            dgv1.CellContentClick += dgv1_CellContentClick;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(276, 18);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(410, 23);
            txtTen.TabIndex = 2;
            // 
            // txtMSV
            // 
            txtMSV.Location = new Point(276, 56);
            txtMSV.Name = "txtMSV";
            txtMSV.Size = new Size(410, 23);
            txtMSV.TabIndex = 3;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(276, 85);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(410, 23);
            txtDiaChi.TabIndex = 4;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(276, 120);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(410, 23);
            txtSDT.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 20);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 6;
            label1.Text = "Tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 56);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 7;
            label2.Text = "Mã Sinh Viên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(129, 88);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 8;
            label3.Text = "Địa Chỉ";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(129, 123);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 9;
            label4.Text = "SDT:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 465);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSDT);
            Controls.Add(txtDiaChi);
            Controls.Add(txtMSV);
            Controls.Add(txtTen);
            Controls.Add(panel1);
            Controls.Add(btnclick);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnclick;
        private Panel panel1;
        private DataGridView dgv1;
        private TextBox txtTen;
        private TextBox txtMSV;
        private TextBox txtDiaChi;
        private TextBox txtSDT;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}