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
            this.dataGridViewDiemMat_BiThu = new System.Windows.Forms.DataGridView();
            this.dienMatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sMMgDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sMMgDataSet = new ProjectBNG.SMMgDataSet();
            this.biThuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.biThuTableAdapter = new ProjectBNG.SMMgDataSetTableAdapters.BiThuTableAdapter();
            this.dienMatTableAdapter = new ProjectBNG.SMMgDataSetTableAdapters.DienMatTableAdapter();
            this.MaDienMat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LuuFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luuFileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noiGuiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trichYeuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doMatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDienMatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soBaoMatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.banInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoiDuyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoiKyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucDanhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chuKyDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.nguoiInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiemMat_BiThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dienMatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMMgDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMMgDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biThuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDiemMat_BiThu
            // 
            this.dataGridViewDiemMat_BiThu.AllowUserToAddRows = false;
            this.dataGridViewDiemMat_BiThu.AllowUserToDeleteRows = false;
            this.dataGridViewDiemMat_BiThu.AutoGenerateColumns = false;
            this.dataGridViewDiemMat_BiThu.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewDiemMat_BiThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDiemMat_BiThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDienMat,
            this.LuuFile,
            this.Ngay,
            this.luuFileDataGridViewTextBoxColumn,
            this.noiGuiDataGridViewTextBoxColumn,
            this.trichYeuDataGridViewTextBoxColumn,
            this.doMatDataGridViewTextBoxColumn,
            this.maDienMatDataGridViewTextBoxColumn,
            this.ghiChuDataGridViewTextBoxColumn,
            this.loaiDataGridViewTextBoxColumn,
            this.soBaoMatDataGridViewTextBoxColumn,
            this.banInDataGridViewTextBoxColumn,
            this.ngayInDataGridViewTextBoxColumn,
            this.nguoiDuyetDataGridViewTextBoxColumn,
            this.nguoiKyDataGridViewTextBoxColumn,
            this.chucDanhDataGridViewTextBoxColumn,
            this.chuKyDataGridViewImageColumn,
            this.nguoiInDataGridViewTextBoxColumn});
            this.dataGridViewDiemMat_BiThu.DataSource = this.dienMatBindingSource;
            this.dataGridViewDiemMat_BiThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDiemMat_BiThu.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridViewDiemMat_BiThu.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDiemMat_BiThu.Name = "dataGridViewDiemMat_BiThu";
            this.dataGridViewDiemMat_BiThu.ReadOnly = true;
            this.dataGridViewDiemMat_BiThu.RowTemplate.Height = 24;
            this.dataGridViewDiemMat_BiThu.Size = new System.Drawing.Size(846, 427);
            this.dataGridViewDiemMat_BiThu.TabIndex = 0;
            this.dataGridViewDiemMat_BiThu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // dienMatBindingSource
            // 
            this.dienMatBindingSource.DataMember = "DienMat";
            this.dienMatBindingSource.DataSource = this.sMMgDataSetBindingSource;
            // 
            // sMMgDataSetBindingSource
            // 
            this.sMMgDataSetBindingSource.DataSource = this.sMMgDataSet;
            this.sMMgDataSetBindingSource.Position = 0;
            // 
            // sMMgDataSet
            // 
            this.sMMgDataSet.DataSetName = "SMMgDataSet";
            this.sMMgDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // dienMatTableAdapter
            // 
            this.dienMatTableAdapter.ClearBeforeFill = true;
            // 
            // MaDienMat
            // 
            this.MaDienMat.DataPropertyName = "MaDienMat";
            this.MaDienMat.HeaderText = "Số điện";
            this.MaDienMat.Name = "MaDienMat";
            this.MaDienMat.ReadOnly = true;
            // 
            // LuuFile
            // 
            this.LuuFile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LuuFile.DataPropertyName = "LuuFile";
            this.LuuFile.HeaderText = "Lưu File";
            this.LuuFile.Name = "LuuFile";
            this.LuuFile.ReadOnly = true;
            // 
            // Ngay
            // 
            this.Ngay.DataPropertyName = "Ngay";
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.Name = "Ngay";
            this.Ngay.ReadOnly = true;
            // 
            // luuFileDataGridViewTextBoxColumn
            // 
            this.luuFileDataGridViewTextBoxColumn.DataPropertyName = "LuuFile";
            this.luuFileDataGridViewTextBoxColumn.HeaderText = "LuuFile";
            this.luuFileDataGridViewTextBoxColumn.Name = "luuFileDataGridViewTextBoxColumn";
            this.luuFileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noiGuiDataGridViewTextBoxColumn
            // 
            this.noiGuiDataGridViewTextBoxColumn.DataPropertyName = "NoiGui";
            this.noiGuiDataGridViewTextBoxColumn.HeaderText = "NoiGui";
            this.noiGuiDataGridViewTextBoxColumn.Name = "noiGuiDataGridViewTextBoxColumn";
            this.noiGuiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trichYeuDataGridViewTextBoxColumn
            // 
            this.trichYeuDataGridViewTextBoxColumn.DataPropertyName = "TrichYeu";
            this.trichYeuDataGridViewTextBoxColumn.HeaderText = "TrichYeu";
            this.trichYeuDataGridViewTextBoxColumn.Name = "trichYeuDataGridViewTextBoxColumn";
            this.trichYeuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doMatDataGridViewTextBoxColumn
            // 
            this.doMatDataGridViewTextBoxColumn.DataPropertyName = "DoMat";
            this.doMatDataGridViewTextBoxColumn.HeaderText = "DoMat";
            this.doMatDataGridViewTextBoxColumn.Name = "doMatDataGridViewTextBoxColumn";
            this.doMatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maDienMatDataGridViewTextBoxColumn
            // 
            this.maDienMatDataGridViewTextBoxColumn.DataPropertyName = "MaDienMat";
            this.maDienMatDataGridViewTextBoxColumn.HeaderText = "MaDienMat";
            this.maDienMatDataGridViewTextBoxColumn.Name = "maDienMatDataGridViewTextBoxColumn";
            this.maDienMatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ghiChuDataGridViewTextBoxColumn
            // 
            this.ghiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.HeaderText = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.Name = "ghiChuDataGridViewTextBoxColumn";
            this.ghiChuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loaiDataGridViewTextBoxColumn
            // 
            this.loaiDataGridViewTextBoxColumn.DataPropertyName = "Loai";
            this.loaiDataGridViewTextBoxColumn.HeaderText = "Loai";
            this.loaiDataGridViewTextBoxColumn.Name = "loaiDataGridViewTextBoxColumn";
            this.loaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soBaoMatDataGridViewTextBoxColumn
            // 
            this.soBaoMatDataGridViewTextBoxColumn.DataPropertyName = "SoBaoMat";
            this.soBaoMatDataGridViewTextBoxColumn.HeaderText = "SoBaoMat";
            this.soBaoMatDataGridViewTextBoxColumn.Name = "soBaoMatDataGridViewTextBoxColumn";
            this.soBaoMatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // banInDataGridViewTextBoxColumn
            // 
            this.banInDataGridViewTextBoxColumn.DataPropertyName = "BanIn";
            this.banInDataGridViewTextBoxColumn.HeaderText = "BanIn";
            this.banInDataGridViewTextBoxColumn.Name = "banInDataGridViewTextBoxColumn";
            this.banInDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayInDataGridViewTextBoxColumn
            // 
            this.ngayInDataGridViewTextBoxColumn.DataPropertyName = "NgayIn";
            this.ngayInDataGridViewTextBoxColumn.HeaderText = "NgayIn";
            this.ngayInDataGridViewTextBoxColumn.Name = "ngayInDataGridViewTextBoxColumn";
            this.ngayInDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nguoiDuyetDataGridViewTextBoxColumn
            // 
            this.nguoiDuyetDataGridViewTextBoxColumn.DataPropertyName = "NguoiDuyet";
            this.nguoiDuyetDataGridViewTextBoxColumn.HeaderText = "NguoiDuyet";
            this.nguoiDuyetDataGridViewTextBoxColumn.Name = "nguoiDuyetDataGridViewTextBoxColumn";
            this.nguoiDuyetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nguoiKyDataGridViewTextBoxColumn
            // 
            this.nguoiKyDataGridViewTextBoxColumn.DataPropertyName = "NguoiKy";
            this.nguoiKyDataGridViewTextBoxColumn.HeaderText = "NguoiKy";
            this.nguoiKyDataGridViewTextBoxColumn.Name = "nguoiKyDataGridViewTextBoxColumn";
            this.nguoiKyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chucDanhDataGridViewTextBoxColumn
            // 
            this.chucDanhDataGridViewTextBoxColumn.DataPropertyName = "ChucDanh";
            this.chucDanhDataGridViewTextBoxColumn.HeaderText = "ChucDanh";
            this.chucDanhDataGridViewTextBoxColumn.Name = "chucDanhDataGridViewTextBoxColumn";
            this.chucDanhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chuKyDataGridViewImageColumn
            // 
            this.chuKyDataGridViewImageColumn.DataPropertyName = "ChuKy";
            this.chuKyDataGridViewImageColumn.HeaderText = "ChuKy";
            this.chuKyDataGridViewImageColumn.Name = "chuKyDataGridViewImageColumn";
            this.chuKyDataGridViewImageColumn.ReadOnly = true;
            // 
            // nguoiInDataGridViewTextBoxColumn
            // 
            this.nguoiInDataGridViewTextBoxColumn.DataPropertyName = "NguoiIn";
            this.nguoiInDataGridViewTextBoxColumn.HeaderText = "NguoiIn";
            this.nguoiInDataGridViewTextBoxColumn.Name = "nguoiInDataGridViewTextBoxColumn";
            this.nguoiInDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmChiTietBiThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 427);
            this.Controls.Add(this.dataGridViewDiemMat_BiThu);
            this.Name = "frmChiTietBiThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Điện mật";
            this.Load += new System.EventHandler(this.frmChiTietBiThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiemMat_BiThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dienMatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMMgDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMMgDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biThuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDiemMat_BiThu;
        private System.Windows.Forms.BindingSource sMMgDataSetBindingSource;
        private SMMgDataSet sMMgDataSet;
        private System.Windows.Forms.BindingSource biThuBindingSource;
        private SMMgDataSetTableAdapters.BiThuTableAdapter biThuTableAdapter;
        private System.Windows.Forms.BindingSource dienMatBindingSource;
        private SMMgDataSetTableAdapters.DienMatTableAdapter dienMatTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDienMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuuFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn luuFileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiGuiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trichYeuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doMatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDienMatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soBaoMatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn banInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguoiDuyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguoiKyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucDanhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn chuKyDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguoiInDataGridViewTextBoxColumn;
    }
}