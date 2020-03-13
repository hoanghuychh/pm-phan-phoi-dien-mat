namespace ProjectBNG
{
    partial class frmKiemChungDien
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
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTuNgay = new System.Windows.Forms.DateTimePicker();
            this.btnTim = new System.Windows.Forms.Button();
            this.gridControlKiemChungDien = new DevExpress.XtraGrid.GridControl();
            this.kiemChungDiensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewKiemChungDien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenNoiNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDanhSachDien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoBiThu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTongSoTrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKiemChungDien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiemChungDiensBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKiemChungDien)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Đến ngày";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Từ ngày";
            // 
            // dateTimePickerDenNgay
            // 
            this.dateTimePickerDenNgay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePickerDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDenNgay.Location = new System.Drawing.Point(358, 17);
            this.dateTimePickerDenNgay.Name = "dateTimePickerDenNgay";
            this.dateTimePickerDenNgay.Size = new System.Drawing.Size(130, 22);
            this.dateTimePickerDenNgay.TabIndex = 14;
            // 
            // dateTimePickerTuNgay
            // 
            this.dateTimePickerTuNgay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePickerTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTuNgay.Location = new System.Drawing.Point(147, 17);
            this.dateTimePickerTuNgay.Name = "dateTimePickerTuNgay";
            this.dateTimePickerTuNgay.Size = new System.Drawing.Size(130, 22);
            this.dateTimePickerTuNgay.TabIndex = 13;
            // 
            // btnTim
            // 
            this.btnTim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTim.Location = new System.Drawing.Point(537, 14);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(101, 32);
            this.btnTim.TabIndex = 17;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // gridControlKiemChungDien
            // 
            this.gridControlKiemChungDien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlKiemChungDien.DataSource = this.kiemChungDiensBindingSource;
            this.gridControlKiemChungDien.Location = new System.Drawing.Point(7, 59);
            this.gridControlKiemChungDien.MainView = this.gridViewKiemChungDien;
            this.gridControlKiemChungDien.Name = "gridControlKiemChungDien";
            this.gridControlKiemChungDien.Size = new System.Drawing.Size(1431, 703);
            this.gridControlKiemChungDien.TabIndex = 18;
            this.gridControlKiemChungDien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewKiemChungDien});
            // 
            // kiemChungDiensBindingSource
            // 
            this.kiemChungDiensBindingSource.DataSource = typeof(ProjectBNG.Models.KiemChungDien);
            // 
            // gridViewKiemChungDien
            // 
            this.gridViewKiemChungDien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenNoiNhan,
            this.colDanhSachDien,
            this.colSoBiThu,
            this.colTongSoTrang});
            this.gridViewKiemChungDien.GridControl = this.gridControlKiemChungDien;
            this.gridViewKiemChungDien.Name = "gridViewKiemChungDien";
            this.gridViewKiemChungDien.OptionsBehavior.Editable = false;
            this.gridViewKiemChungDien.OptionsView.ShowGroupPanel = false;
            this.gridViewKiemChungDien.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewKiemChungDien_CustomDrawRowIndicator);
            // 
            // colTenNoiNhan
            // 
            this.colTenNoiNhan.Caption = "Nơi nhận";
            this.colTenNoiNhan.FieldName = "TenNoiNhan";
            this.colTenNoiNhan.MinWidth = 25;
            this.colTenNoiNhan.Name = "colTenNoiNhan";
            this.colTenNoiNhan.Visible = true;
            this.colTenNoiNhan.VisibleIndex = 0;
            this.colTenNoiNhan.Width = 308;
            // 
            // colDanhSachDien
            // 
            this.colDanhSachDien.Caption = "Điện mật";
            this.colDanhSachDien.FieldName = "DanhSachDien";
            this.colDanhSachDien.MinWidth = 25;
            this.colDanhSachDien.Name = "colDanhSachDien";
            this.colDanhSachDien.Visible = true;
            this.colDanhSachDien.VisibleIndex = 1;
            this.colDanhSachDien.Width = 746;
            // 
            // colSoBiThu
            // 
            this.colSoBiThu.Caption = "Số lượng điện";
            this.colSoBiThu.FieldName = "SoBiThu";
            this.colSoBiThu.MinWidth = 25;
            this.colSoBiThu.Name = "colSoBiThu";
            this.colSoBiThu.Visible = true;
            this.colSoBiThu.VisibleIndex = 2;
            this.colSoBiThu.Width = 150;
            // 
            // colTongSoTrang
            // 
            this.colTongSoTrang.Caption = "Tổng số trang";
            this.colTongSoTrang.FieldName = "TongSoTrang";
            this.colTongSoTrang.MinWidth = 25;
            this.colTongSoTrang.Name = "colTongSoTrang";
            this.colTongSoTrang.Visible = true;
            this.colTongSoTrang.VisibleIndex = 3;
            this.colTongSoTrang.Width = 150;
            // 
            // btnDong
            // 
            this.btnDong.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDong.Location = new System.Drawing.Point(743, 779);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(101, 32);
            this.btnDong.TabIndex = 19;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnIn
            // 
            this.btnIn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIn.Location = new System.Drawing.Point(599, 779);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(101, 32);
            this.btnIn.TabIndex = 20;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            // 
            // frmKiemChungDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 823);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.gridControlKiemChungDien);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerDenNgay);
            this.Controls.Add(this.dateTimePickerTuNgay);
            this.Name = "frmKiemChungDien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiểm chứng điện";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKiemChungDien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiemChungDiensBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKiemChungDien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDenNgay;
        private System.Windows.Forms.DateTimePicker dateTimePickerTuNgay;
        private System.Windows.Forms.Button btnTim;
        private DevExpress.XtraGrid.GridControl gridControlKiemChungDien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewKiemChungDien;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.BindingSource kiemChungDiensBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNoiNhan;
        private DevExpress.XtraGrid.Columns.GridColumn colDanhSachDien;
        private DevExpress.XtraGrid.Columns.GridColumn colSoBiThu;
        private DevExpress.XtraGrid.Columns.GridColumn colTongSoTrang;
    }
}