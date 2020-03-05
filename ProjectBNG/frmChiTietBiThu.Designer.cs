namespace ProjectBNG
{
    partial class frmChiTietBiThu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sMMgDataSet = new ProjectBNG.SMMgDataSet();
            this.sMMgDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.biThuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.biThuTableAdapter = new ProjectBNG.SMMgDataSetTableAdapters.BiThuTableAdapter();
            this.dienMatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dienMatTableAdapter = new ProjectBNG.SMMgDataSetTableAdapters.DienMatTableAdapter();
            this.MaDienMat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LuuFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMMgDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMMgDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biThuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dienMatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDienMat,
            this.LuuFile,
            this.Ngay});
            this.dataGridView1.DataSource = this.dienMatBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(790, 427);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // sMMgDataSet
            // 
            this.sMMgDataSet.DataSetName = "SMMgDataSet";
            this.sMMgDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sMMgDataSetBindingSource
            // 
            this.sMMgDataSetBindingSource.DataSource = this.sMMgDataSet;
            this.sMMgDataSetBindingSource.Position = 0;
            // 
            // biThuBindingSource
            // 
            this.biThuBindingSource.DataMember = "BiThu";
            this.biThuBindingSource.DataSource = this.sMMgDataSet;
            // 
            // biThuTableAdapter
            // 
            this.biThuTableAdapter.ClearBeforeFill = true;
            // 
            // dienMatBindingSource
            // 
            this.dienMatBindingSource.DataMember = "DienMat";
            this.dienMatBindingSource.DataSource = this.sMMgDataSetBindingSource;
            // 
            // dienMatTableAdapter
            // 
            this.dienMatTableAdapter.ClearBeforeFill = true;
            // 
            // MaDienMat
            // 
            this.MaDienMat.DataPropertyName = "MaDienMat";
            this.MaDienMat.HeaderText = "Số điện";
            this.MaDienMat.Name = "MaDienMat";
            // 
            // LuuFile
            // 
            this.LuuFile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LuuFile.DataPropertyName = "LuuFile";
            this.LuuFile.HeaderText = "Lưu File";
            this.LuuFile.Name = "LuuFile";
            // 
            // Ngay
            // 
            this.Ngay.DataPropertyName = "Ngay";
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.Name = "Ngay";
            // 
            // frmChiTietBiThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 427);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmChiTietBiThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Điện mật";
            this.Load += new System.EventHandler(this.frmChiTietBiThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMMgDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMMgDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biThuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dienMatBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sMMgDataSetBindingSource;
        private SMMgDataSet sMMgDataSet;
        private System.Windows.Forms.BindingSource biThuBindingSource;
        private SMMgDataSetTableAdapters.BiThuTableAdapter biThuTableAdapter;
        private System.Windows.Forms.BindingSource dienMatBindingSource;
        private SMMgDataSetTableAdapters.DienMatTableAdapter dienMatTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDienMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuuFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
    }
}