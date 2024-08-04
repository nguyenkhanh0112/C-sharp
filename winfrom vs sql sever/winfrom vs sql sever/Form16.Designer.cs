namespace winfrom_vs_sql_sever
{
    partial class Form16
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listNCC = new System.Windows.Forms.ListBox();
            this.dgvDonHang = new System.Windows.Forms.DataGridView();
            this.quanlybanhangDataSet = new winfrom_vs_sql_sever.QuanlybanhangDataSet();
            this.quanlybanhangDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlybanhangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlybanhangDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listNCC);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvDonHang);
            this.splitContainer1.Size = new System.Drawing.Size(839, 490);
            this.splitContainer1.SplitterDistance = 365;
            this.splitContainer1.TabIndex = 0;
            // 
            // listNCC
            // 
            this.listNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listNCC.FormattingEnabled = true;
            this.listNCC.Location = new System.Drawing.Point(0, 0);
            this.listNCC.Name = "listNCC";
            this.listNCC.Size = new System.Drawing.Size(365, 490);
            this.listNCC.TabIndex = 0;
            this.listNCC.SelectedIndexChanged += new System.EventHandler(this.listNCC_SelectedIndexChanged);
            // 
            // dgvDonHang
            // 
            this.dgvDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDonHang.Location = new System.Drawing.Point(0, 0);
            this.dgvDonHang.Name = "dgvDonHang";
            this.dgvDonHang.Size = new System.Drawing.Size(470, 490);
            this.dgvDonHang.TabIndex = 0;
            // 
            // quanlybanhangDataSet
            // 
            this.quanlybanhangDataSet.DataSetName = "QuanlybanhangDataSet";
            this.quanlybanhangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quanlybanhangDataSetBindingSource
            // 
            this.quanlybanhangDataSetBindingSource.DataSource = this.quanlybanhangDataSet;
            this.quanlybanhangDataSetBindingSource.Position = 0;
            // 
            // Form16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 490);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form16";
            this.Text = "Form16";
            this.Load += new System.EventHandler(this.Form16_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlybanhangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlybanhangDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listNCC;
        private System.Windows.Forms.DataGridView dgvDonHang;
        private QuanlybanhangDataSet quanlybanhangDataSet;
        private System.Windows.Forms.BindingSource quanlybanhangDataSetBindingSource;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}