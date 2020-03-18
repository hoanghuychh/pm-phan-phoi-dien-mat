namespace ProjectBNG
{
    partial class frmBiThu
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
            this.biThusBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.biThusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControlBiThu0 = new DevExpress.XtraGrid.GridControl();
            this.biThusBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewBiThu0 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNgay1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoPhieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDanhSachDien1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoBiThu1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKiNhan1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoiNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.biThusBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biThusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBiThu0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biThusBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBiThu0)).BeginInit();
            this.SuspendLayout();
            // 
            // biThusBindingSource1
            // 
            this.biThusBindingSource1.DataSource = typeof(ProjectBNG.Models.BiThu);
            // 
            // biThusBindingSource
            // 
            this.biThusBindingSource.DataSource = typeof(ProjectBNG.Models.BiThu);
            // 
            // gridControlBiThu0
            // 
            this.gridControlBiThu0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlBiThu0.DataSource = this.biThusBindingSource2;
            this.gridControlBiThu0.Location = new System.Drawing.Point(9, 12);
            this.gridControlBiThu0.MainView = this.gridViewBiThu0;
            this.gridControlBiThu0.Name = "gridControlBiThu0";
            this.gridControlBiThu0.Size = new System.Drawing.Size(953, 741);
            this.gridControlBiThu0.TabIndex = 1;
            this.gridControlBiThu0.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBiThu0});
            // 
            // biThusBindingSource2
            // 
            this.biThusBindingSource2.DataSource = typeof(ProjectBNG.Models.BiThu);
            // 
            // gridViewBiThu0
            // 
            this.gridViewBiThu0.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNgay1,
            this.colSoPhieu,
            this.colDanhSachDien1,
            this.colSoBiThu1,
            this.colKiNhan1,
            this.colNoiNhan});
            this.gridViewBiThu0.GridControl = this.gridControlBiThu0;
            this.gridViewBiThu0.Name = "gridViewBiThu0";
            this.gridViewBiThu0.OptionsBehavior.Editable = false;
            this.gridViewBiThu0.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewBiThu0.OptionsFind.FindNullPrompt = "Tìm kiếm thông tin bì thư";
            this.gridViewBiThu0.OptionsView.ShowGroupPanel = false;
            this.gridViewBiThu0.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewBiThu0_RowCellClick);
            this.gridViewBiThu0.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewBiThu0_CustomDrawRowIndicator);
            // 
            // colNgay1
            // 
            this.colNgay1.Caption = "Giờ, ngày gửi";
            this.colNgay1.FieldName = "Ngay";
            this.colNgay1.MinWidth = 25;
            this.colNgay1.Name = "colNgay1";
            this.colNgay1.Visible = true;
            this.colNgay1.VisibleIndex = 0;
            this.colNgay1.Width = 110;
            // 
            // colSoPhieu
            // 
            this.colSoPhieu.Caption = "Số phiếu";
            this.colSoPhieu.FieldName = "SoPhieu";
            this.colSoPhieu.MinWidth = 25;
            this.colSoPhieu.Name = "colSoPhieu";
            this.colSoPhieu.Visible = true;
            this.colSoPhieu.VisibleIndex = 1;
            this.colSoPhieu.Width = 90;
            // 
            // colDanhSachDien1
            // 
            this.colDanhSachDien1.Caption = "Số điện";
            this.colDanhSachDien1.FieldName = "DanhSachDienMat";
            this.colDanhSachDien1.MinWidth = 25;
            this.colDanhSachDien1.Name = "colDanhSachDien1";
            this.colDanhSachDien1.Visible = true;
            this.colDanhSachDien1.VisibleIndex = 3;
            this.colDanhSachDien1.Width = 397;
            // 
            // colSoBiThu1
            // 
            this.colSoBiThu1.Caption = "Tổng số";
            this.colSoBiThu1.FieldName = "TongSo";
            this.colSoBiThu1.MinWidth = 25;
            this.colSoBiThu1.Name = "colSoBiThu1";
            this.colSoBiThu1.Visible = true;
            this.colSoBiThu1.VisibleIndex = 4;
            this.colSoBiThu1.Width = 88;
            // 
            // colKiNhan1
            // 
            this.colKiNhan1.Caption = "Kí nhận";
            this.colKiNhan1.FieldName = "KiNhan";
            this.colKiNhan1.MinWidth = 25;
            this.colKiNhan1.Name = "colKiNhan1";
            this.colKiNhan1.Visible = true;
            this.colKiNhan1.VisibleIndex = 5;
            this.colKiNhan1.Width = 120;
            // 
            // colNoiNhan
            // 
            this.colNoiNhan.Caption = "Nơi nhận";
            this.colNoiNhan.FieldName = "TenNoiNhan";
            this.colNoiNhan.MinWidth = 25;
            this.colNoiNhan.Name = "colNoiNhan";
            this.colNoiNhan.Visible = true;
            this.colNoiNhan.VisibleIndex = 2;
            this.colNoiNhan.Width = 145;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(524, 774);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 32);
            this.button1.TabIndex = 46;
            this.button1.Text = "Đóng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnXemChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXemChiTiet.Location = new System.Drawing.Point(410, 774);
            this.btnXemChiTiet.Margin = new System.Windows.Forms.Padding(4);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(94, 32);
            this.btnXemChiTiet.TabIndex = 45;
            this.btnXemChiTiet.Text = "Xem chi tiết";
            this.btnXemChiTiet.UseVisualStyleBackColor = true;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // frmBiThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 829);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnXemChiTiet);
            this.Controls.Add(this.gridControlBiThu0);
            this.Name = "frmBiThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bì thư";
            ((System.ComponentModel.ISupportInitialize)(this.biThusBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biThusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBiThu0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biThusBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBiThu0)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource biThusBindingSource;
        private System.Windows.Forms.BindingSource biThusBindingSource1;
        private DevExpress.XtraGrid.GridControl gridControlBiThu0;
        private System.Windows.Forms.BindingSource biThusBindingSource2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewBiThu0;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay1;
        private DevExpress.XtraGrid.Columns.GridColumn colSoPhieu;
        private DevExpress.XtraGrid.Columns.GridColumn colDanhSachDien1;
        private DevExpress.XtraGrid.Columns.GridColumn colSoBiThu1;
        private DevExpress.XtraGrid.Columns.GridColumn colKiNhan1;
        private DevExpress.XtraGrid.Columns.GridColumn colNoiNhan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnXemChiTiet;
    }
}