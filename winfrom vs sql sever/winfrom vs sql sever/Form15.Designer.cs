namespace winfrom_vs_sql_sever
{
    partial class Form15
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaVT = new System.Windows.Forms.TextBox();
            this.txtTenVT = new System.Windows.Forms.TextBox();
            this.txtDVtinh = new System.Windows.Forms.TextBox();
            this.txtPhantram = new System.Windows.Forms.TextBox();
            this.quanlybanhangDataSet = new winfrom_vs_sql_sever.QuanlybanhangDataSet();
            this.vATTUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vATTUTableAdapter = new winfrom_vs_sql_sever.QuanlybanhangDataSetTableAdapters.VATTUTableAdapter();
            this.maVTuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenVTuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phanTramDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlybanhangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATTUBindingSource)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.txtPhantram);
            this.splitContainer1.Panel2.Controls.Add(this.txtDVtinh);
            this.splitContainer1.Panel2.Controls.Add(this.txtTenVT);
            this.splitContainer1.Panel2.Controls.Add(this.txtMaVT);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(814, 440);
            this.splitContainer1.SplitterDistance = 422;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maVTuDataGridViewTextBoxColumn,
            this.tenVTuDataGridViewTextBoxColumn,
            this.dvTinhDataGridViewTextBoxColumn,
            this.phanTramDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vATTUBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(422, 440);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã VT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên VT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn vị tính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phần Trăm: ";
            // 
            // txtMaVT
            // 
            this.txtMaVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vATTUBindingSource, "MaVTu", true));
            this.txtMaVT.Location = new System.Drawing.Point(143, 80);
            this.txtMaVT.Name = "txtMaVT";
            this.txtMaVT.Size = new System.Drawing.Size(164, 20);
            this.txtMaVT.TabIndex = 4;
            // 
            // txtTenVT
            // 
            this.txtTenVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vATTUBindingSource, "TenVTu", true));
            this.txtTenVT.Location = new System.Drawing.Point(147, 173);
            this.txtTenVT.Name = "txtTenVT";
            this.txtTenVT.Size = new System.Drawing.Size(160, 20);
            this.txtTenVT.TabIndex = 5;
            // 
            // txtDVtinh
            // 
            this.txtDVtinh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vATTUBindingSource, "DvTinh", true));
            this.txtDVtinh.Location = new System.Drawing.Point(164, 250);
            this.txtDVtinh.Name = "txtDVtinh";
            this.txtDVtinh.Size = new System.Drawing.Size(143, 20);
            this.txtDVtinh.TabIndex = 6;
            // 
            // txtPhantram
            // 
            this.txtPhantram.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vATTUBindingSource, "PhanTram", true));
            this.txtPhantram.Location = new System.Drawing.Point(166, 323);
            this.txtPhantram.Name = "txtPhantram";
            this.txtPhantram.Size = new System.Drawing.Size(141, 20);
            this.txtPhantram.TabIndex = 7;
            // 
            // quanlybanhangDataSet
            // 
            this.quanlybanhangDataSet.DataSetName = "QuanlybanhangDataSet";
            this.quanlybanhangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vATTUBindingSource
            // 
            this.vATTUBindingSource.DataMember = "VATTU";
            this.vATTUBindingSource.DataSource = this.quanlybanhangDataSet;
            // 
            // vATTUTableAdapter
            // 
            this.vATTUTableAdapter.ClearBeforeFill = true;
            // 
            // maVTuDataGridViewTextBoxColumn
            // 
            this.maVTuDataGridViewTextBoxColumn.DataPropertyName = "MaVTu";
            this.maVTuDataGridViewTextBoxColumn.HeaderText = "MaVTu";
            this.maVTuDataGridViewTextBoxColumn.Name = "maVTuDataGridViewTextBoxColumn";
            // 
            // tenVTuDataGridViewTextBoxColumn
            // 
            this.tenVTuDataGridViewTextBoxColumn.DataPropertyName = "TenVTu";
            this.tenVTuDataGridViewTextBoxColumn.HeaderText = "TenVTu";
            this.tenVTuDataGridViewTextBoxColumn.Name = "tenVTuDataGridViewTextBoxColumn";
            // 
            // dvTinhDataGridViewTextBoxColumn
            // 
            this.dvTinhDataGridViewTextBoxColumn.DataPropertyName = "DvTinh";
            this.dvTinhDataGridViewTextBoxColumn.HeaderText = "DvTinh";
            this.dvTinhDataGridViewTextBoxColumn.Name = "dvTinhDataGridViewTextBoxColumn";
            // 
            // phanTramDataGridViewTextBoxColumn
            // 
            this.phanTramDataGridViewTextBoxColumn.DataPropertyName = "PhanTram";
            this.phanTramDataGridViewTextBoxColumn.HeaderText = "PhanTram";
            this.phanTramDataGridViewTextBoxColumn.Name = "phanTramDataGridViewTextBoxColumn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "DataBinDing";
            // 
            // Form15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 440);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form15";
            this.Text = "Form15";
            this.Load += new System.EventHandler(this.Form15_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlybanhangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATTUBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhantram;
        private System.Windows.Forms.TextBox txtDVtinh;
        private System.Windows.Forms.TextBox txtTenVT;
        private System.Windows.Forms.TextBox txtMaVT;
        private QuanlybanhangDataSet quanlybanhangDataSet;
        private System.Windows.Forms.BindingSource vATTUBindingSource;
        private QuanlybanhangDataSetTableAdapters.VATTUTableAdapter vATTUTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maVTuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenVTuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phanTramDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
    }
}