namespace winfrom_vs_sql_sever
{
    partial class Form5
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
            this.lsbNCC = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsvDonDH = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bài Tập";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsbNCC);
            this.groupBox1.Location = new System.Drawing.Point(57, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 271);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách nhà cung cấp";
            // 
            // lsbNCC
            // 
            this.lsbNCC.FormattingEnabled = true;
            this.lsbNCC.Location = new System.Drawing.Point(0, 19);
            this.lsbNCC.Name = "lsbNCC";
            this.lsbNCC.Size = new System.Drawing.Size(330, 251);
            this.lsbNCC.TabIndex = 0;
            this.lsbNCC.Tag = "";
            this.lsbNCC.SelectedIndexChanged += new System.EventHandler(this.lsbNCC_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsvDonDH);
            this.groupBox2.Location = new System.Drawing.Point(393, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 267);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách đơn đặt hàng theo nhà cung cấp ";
            // 
            // lsvDonDH
            // 
            this.lsvDonDH.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lsvDonDH.FullRowSelect = true;
            this.lsvDonDH.GridLines = true;
            this.lsvDonDH.HideSelection = false;
            this.lsvDonDH.Location = new System.Drawing.Point(0, 19);
            this.lsvDonDH.Name = "lsvDonDH";
            this.lsvDonDH.Size = new System.Drawing.Size(441, 248);
            this.lsvDonDH.TabIndex = 0;
            this.lsvDonDH.UseCompatibleStateImageBehavior = false;
            this.lsvDonDH.View = System.Windows.Forms.View.Details;
            this.lsvDonDH.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Số đơn hàng ";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ngày đặt hàng ";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mã Nhà cung cấp ";
            this.columnHeader3.Width = 150;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lsbNCC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lsvDonDH;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}