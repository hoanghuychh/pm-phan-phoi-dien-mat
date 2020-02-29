namespace ProjectBNG
{
    partial class frmNguoiDuyet
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControlNguoiDuyet = new DevExpress.XtraGrid.GridControl();
            this.nguoiDuyetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewNguoiDuyet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenNguoiDuyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMacDinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChuKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.button4 = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNguoiDuyet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDuyetsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNguoiDuyet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControlNguoiDuyet);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 492);
            this.panel1.TabIndex = 0;
            // 
            // gridControlNguoiDuyet
            // 
            this.gridControlNguoiDuyet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlNguoiDuyet.DataSource = this.nguoiDuyetsBindingSource;
            this.gridControlNguoiDuyet.Location = new System.Drawing.Point(0, 0);
            this.gridControlNguoiDuyet.MainView = this.gridViewNguoiDuyet;
            this.gridControlNguoiDuyet.Name = "gridControlNguoiDuyet";
            this.gridControlNguoiDuyet.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.gridControlNguoiDuyet.Size = new System.Drawing.Size(709, 453);
            this.gridControlNguoiDuyet.TabIndex = 5;
            this.gridControlNguoiDuyet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewNguoiDuyet});
            // 
            // nguoiDuyetsBindingSource
            // 
            this.nguoiDuyetsBindingSource.DataSource = typeof(ProjectBNG.Models.NguoiDuyet);
            // 
            // gridViewNguoiDuyet
            // 
            this.gridViewNguoiDuyet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenNguoiDuyet,
            this.colMacDinh,
            this.colChuKy});
            this.gridViewNguoiDuyet.GridControl = this.gridControlNguoiDuyet;
            this.gridViewNguoiDuyet.Name = "gridViewNguoiDuyet";
            this.gridViewNguoiDuyet.OptionsBehavior.Editable = false;
            this.gridViewNguoiDuyet.OptionsView.ShowGroupPanel = false;
            this.gridViewNguoiDuyet.OptionsView.ShowIndicator = false;
            // 
            // colTenNguoiDuyet
            // 
            this.colTenNguoiDuyet.Caption = "Tên người duyệt";
            this.colTenNguoiDuyet.FieldName = "TenNguoiDuyet";
            this.colTenNguoiDuyet.MinWidth = 25;
            this.colTenNguoiDuyet.Name = "colTenNguoiDuyet";
            this.colTenNguoiDuyet.Visible = true;
            this.colTenNguoiDuyet.VisibleIndex = 0;
            this.colTenNguoiDuyet.Width = 94;
            // 
            // colMacDinh
            // 
            this.colMacDinh.Caption = "Mặc định";
            this.colMacDinh.FieldName = "MacDinh";
            this.colMacDinh.MinWidth = 25;
            this.colMacDinh.Name = "colMacDinh";
            this.colMacDinh.Visible = true;
            this.colMacDinh.VisibleIndex = 1;
            this.colMacDinh.Width = 94;
            // 
            // colChuKy
            // 
            this.colChuKy.Caption = "Chữ Ký";
            this.colChuKy.FieldName = "ChuKy";
            this.colChuKy.MinWidth = 25;
            this.colChuKy.Name = "colChuKy";
            this.colChuKy.Visible = true;
            this.colChuKy.VisibleIndex = 2;
            this.colChuKy.Width = 94;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(499, 460);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 4;
            this.button4.Text = "Đóng";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Location = new System.Drawing.Point(369, 460);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 28);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Location = new System.Drawing.Point(240, 460);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 28);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Location = new System.Drawing.Point(115, 460);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 28);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(709, 453);
            this.dataGridView1.TabIndex = 0;
            // 
            // frmNguoiDuyet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 522);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNguoiDuyet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách người duyệt";
            this.Load += new System.EventHandler(this.frmNguoiDuyet_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNguoiDuyet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDuyetsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNguoiDuyet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraGrid.GridControl gridControlNguoiDuyet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewNguoiDuyet;
        private System.Windows.Forms.BindingSource nguoiDuyetsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNguoiDuyet;
        private DevExpress.XtraGrid.Columns.GridColumn colMacDinh;
        private DevExpress.XtraGrid.Columns.GridColumn colChuKy;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
    }
}