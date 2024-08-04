namespace BAI_TAP_TREN_LOP
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
            this.aNhap = new System.Windows.Forms.Label();
            this.bNhap = new System.Windows.Forms.Label();
            this.PT = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ketqua = new System.Windows.Forms.TextBox();
            this.cNhap = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giải PT Bậc Hai Một Ẩn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // aNhap
            // 
            this.aNhap.AutoSize = true;
            this.aNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aNhap.Location = new System.Drawing.Point(80, 70);
            this.aNhap.Name = "aNhap";
            this.aNhap.Size = new System.Drawing.Size(54, 19);
            this.aNhap.TabIndex = 1;
            this.aNhap.Text = "Nhap a";
            // 
            // bNhap
            // 
            this.bNhap.AutoSize = true;
            this.bNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNhap.Location = new System.Drawing.Point(80, 114);
            this.bNhap.Name = "bNhap";
            this.bNhap.Size = new System.Drawing.Size(55, 19);
            this.bNhap.TabIndex = 2;
            this.bNhap.Text = "Nhap b";
            // 
            // PT
            // 
            this.PT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PT.Location = new System.Drawing.Point(128, 190);
            this.PT.Name = "PT";
            this.PT.Size = new System.Drawing.Size(73, 25);
            this.PT.TabIndex = 3;
            this.PT.Text = "Giải PT";
            this.PT.UseVisualStyleBackColor = true;
            this.PT.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "3";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(162, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(269, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "0";
            // 
            // ketqua
            // 
            this.ketqua.Location = new System.Drawing.Point(162, 234);
            this.ketqua.Name = "ketqua";
            this.ketqua.Size = new System.Drawing.Size(269, 20);
            this.ketqua.TabIndex = 6;
            this.ketqua.TextChanged += new System.EventHandler(this.ketqua_TextChanged);
            // 
            // cNhap
            // 
            this.cNhap.AutoSize = true;
            this.cNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cNhap.Location = new System.Drawing.Point(80, 154);
            this.cNhap.Name = "cNhap";
            this.cNhap.Size = new System.Drawing.Size(54, 19);
            this.cNhap.TabIndex = 7;
            this.cNhap.Text = "Nhap c";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(162, 154);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(269, 20);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "KQ";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::BAI_TAP_TREN_LOP.Properties.Resources._278599581_1681121008890062_9006682130719859060_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(573, 338);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.cNhap);
            this.Controls.Add(this.ketqua);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PT);
            this.Controls.Add(this.bNhap);
            this.Controls.Add(this.aNhap);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label aNhap;
        private System.Windows.Forms.Label bNhap;
        private System.Windows.Forms.Button PT;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox ketqua;
        private System.Windows.Forms.Label cNhap;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
    }
}

