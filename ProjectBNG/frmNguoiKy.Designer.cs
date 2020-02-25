namespace ProjectBNG
{
    partial class frmNguoiKy
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
            this.gridControlNguoiKy = new DevExpress.XtraGrid.GridControl();
            this.nguoiKiesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewNguoiKy = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenNguoiKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChucDanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMacDinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChuKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnXoaNgKy = new System.Windows.Forms.Button();
            this.btnSuaNgKy = new System.Windows.Forms.Button();
            this.btnThemNgKy = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nguoiKiesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.nguoiKiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNguoiKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiKiesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNguoiKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiKiesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiKiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControlNguoiKy);
            this.panel1.Controls.Add(this.btnDong);
            this.panel1.Controls.Add(this.btnXoaNgKy);
            this.panel1.Controls.Add(this.btnSuaNgKy);
            this.panel1.Controls.Add(this.btnThemNgKy);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 458);
            this.panel1.TabIndex = 0;
            // 
            // gridControlNguoiKy
            // 
            this.gridControlNguoiKy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlNguoiKy.DataSource = this.nguoiKiesBindingSource1;
            this.gridControlNguoiKy.Location = new System.Drawing.Point(3, 4);
            this.gridControlNguoiKy.MainView = this.gridViewNguoiKy;
            this.gridControlNguoiKy.Name = "gridControlNguoiKy";
            this.gridControlNguoiKy.Size = new System.Drawing.Size(968, 415);
            this.gridControlNguoiKy.TabIndex = 5;
            this.gridControlNguoiKy.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewNguoiKy});
            // 
            // nguoiKiesBindingSource1
            // 
            this.nguoiKiesBindingSource1.DataSource = typeof(ProjectBNG.Models.NguoiKy);
            // 
            // gridViewNguoiKy
            // 
            this.gridViewNguoiKy.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenNguoiKy,
            this.colChucDanh,
            this.colMacDinh,
            this.colChuKy});
            this.gridViewNguoiKy.GridControl = this.gridControlNguoiKy;
            this.gridViewNguoiKy.Name = "gridViewNguoiKy";
            this.gridViewNguoiKy.OptionsView.ShowGroupPanel = false;
            this.gridViewNguoiKy.OptionsView.ShowIndicator = false;
            // 
            // colTenNguoiKy
            // 
            this.colTenNguoiKy.Caption = "Tên người ký";
            this.colTenNguoiKy.FieldName = "TenNguoiKy";
            this.colTenNguoiKy.MinWidth = 25;
            this.colTenNguoiKy.Name = "colTenNguoiKy";
            this.colTenNguoiKy.Visible = true;
            this.colTenNguoiKy.VisibleIndex = 0;
            this.colTenNguoiKy.Width = 94;
            // 
            // colChucDanh
            // 
            this.colChucDanh.Caption = "Chức danh";
            this.colChucDanh.FieldName = "ChucDanh";
            this.colChucDanh.MinWidth = 25;
            this.colChucDanh.Name = "colChucDanh";
            this.colChucDanh.Visible = true;
            this.colChucDanh.VisibleIndex = 1;
            this.colChucDanh.Width = 94;
            // 
            // colMacDinh
            // 
            this.colMacDinh.Caption = "Mặc định";
            this.colMacDinh.FieldName = "MacDinh";
            this.colMacDinh.MinWidth = 25;
            this.colMacDinh.Name = "colMacDinh";
            this.colMacDinh.Visible = true;
            this.colMacDinh.VisibleIndex = 2;
            this.colMacDinh.Width = 94;
            // 
            // colChuKy
            // 
            this.colChuKy.Caption = "Chữ ký";
            this.colChuKy.FieldName = "ChuKy";
            this.colChuKy.MinWidth = 25;
            this.colChuKy.Name = "colChuKy";
            this.colChuKy.Visible = true;
            this.colChuKy.VisibleIndex = 3;
            this.colChuKy.Width = 94;
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Location = new System.Drawing.Point(597, 426);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 28);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnXoaNgKy
            // 
            this.btnXoaNgKy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaNgKy.Location = new System.Drawing.Point(489, 426);
            this.btnXoaNgKy.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaNgKy.Name = "btnXoaNgKy";
            this.btnXoaNgKy.Size = new System.Drawing.Size(100, 28);
            this.btnXoaNgKy.TabIndex = 3;
            this.btnXoaNgKy.Text = "Xóa";
            this.btnXoaNgKy.UseVisualStyleBackColor = true;
            this.btnXoaNgKy.Click += new System.EventHandler(this.btnXoaNgKy_Click);
            // 
            // btnSuaNgKy
            // 
            this.btnSuaNgKy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaNgKy.Location = new System.Drawing.Point(381, 426);
            this.btnSuaNgKy.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaNgKy.Name = "btnSuaNgKy";
            this.btnSuaNgKy.Size = new System.Drawing.Size(100, 28);
            this.btnSuaNgKy.TabIndex = 2;
            this.btnSuaNgKy.Text = "Sửa";
            this.btnSuaNgKy.UseVisualStyleBackColor = true;
            this.btnSuaNgKy.Click += new System.EventHandler(this.btnSuaNgKy_Click);
            // 
            // btnThemNgKy
            // 
            this.btnThemNgKy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemNgKy.Location = new System.Drawing.Point(273, 426);
            this.btnThemNgKy.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemNgKy.Name = "btnThemNgKy";
            this.btnThemNgKy.Size = new System.Drawing.Size(100, 28);
            this.btnThemNgKy.TabIndex = 1;
            this.btnThemNgKy.Text = "Thêm mới";
            this.btnThemNgKy.UseVisualStyleBackColor = true;
            this.btnThemNgKy.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(968, 415);
            this.dataGridView1.TabIndex = 0;
            // 
            // nguoiKiesBindingSource2
            // 
            this.nguoiKiesBindingSource2.DataSource = typeof(ProjectBNG.Models.NguoiKy);
            // 
            // nguoiKiesBindingSource
            // 
            this.nguoiKiesBindingSource.DataSource = typeof(ProjectBNG.Models.NguoiKy);
            // 
            // frmNguoiKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 487);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNguoiKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Người Ký";
            this.Load += new System.EventHandler(this.frmNguoiKy_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNguoiKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiKiesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNguoiKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiKiesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiKiesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnXoaNgKy;
        private System.Windows.Forms.Button btnSuaNgKy;
        private System.Windows.Forms.Button btnThemNgKy;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraGrid.GridControl gridControlNguoiKy;
        private System.Windows.Forms.BindingSource nguoiKiesBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewNguoiKy;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNguoiKy;
        private DevExpress.XtraGrid.Columns.GridColumn colChucDanh;
        private DevExpress.XtraGrid.Columns.GridColumn colMacDinh;
        private DevExpress.XtraGrid.Columns.GridColumn colChuKy;
        private System.Windows.Forms.BindingSource nguoiKiesBindingSource1;
        private System.Windows.Forms.BindingSource nguoiKiesBindingSource2;
    }
}