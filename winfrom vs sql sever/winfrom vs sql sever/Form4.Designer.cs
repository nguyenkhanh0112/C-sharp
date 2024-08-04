namespace winfrom_vs_sql_sever
{
    partial class Form4
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
            this.btnXemtt = new System.Windows.Forms.Button();
            this.lsVTT = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Truy vấn trả về nhiều dòng dữ liệu";
            // 
            // btnXemtt
            // 
            this.btnXemtt.Location = new System.Drawing.Point(225, 78);
            this.btnXemtt.Name = "btnXemtt";
            this.btnXemtt.Size = new System.Drawing.Size(331, 53);
            this.btnXemtt.TabIndex = 1;
            this.btnXemtt.Text = "xem thông tin";
            this.btnXemtt.UseVisualStyleBackColor = true;
            this.btnXemtt.Click += new System.EventHandler(this.btnXemtt_Click);
            // 
            // lsVTT
            // 
            this.lsVTT.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsVTT.FullRowSelect = true;
            this.lsVTT.GridLines = true;
            this.lsVTT.HideSelection = false;
            this.lsVTT.Location = new System.Drawing.Point(180, 207);
            this.lsVTT.Name = "lsVTT";
            this.lsVTT.Size = new System.Drawing.Size(480, 214);
            this.lsVTT.TabIndex = 2;
            this.lsVTT.UseCompatibleStateImageBehavior = false;
            this.lsVTT.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Vật Tư ";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Vật Tư ";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn Vị Tính";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Phần Trăm ";
            this.columnHeader4.Width = 80;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsVTT);
            this.Controls.Add(this.btnXemtt);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXemtt;
        private System.Windows.Forms.ListView lsVTT;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}