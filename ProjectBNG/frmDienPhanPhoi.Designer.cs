namespace ProjectBNG
{
    partial class frmDienPhanPhoi
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
            this.dateTimePickerTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.txbSoMat = new System.Windows.Forms.TextBox();
            this.tbxTrichYeu = new System.Windows.Forms.TextBox();
            this.cbxNoiGui = new System.Windows.Forms.ComboBox();
            this.cbxNoiNhan = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControlBaoCao = new DevExpress.XtraGrid.GridControl();
            this.dienMatsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewDienPhanPhoi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaDienMat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoiGui = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoMat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrichYeu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBanIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLuuFile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNguoiIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoiNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dienMatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnInLai = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBaoCao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dienMatsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDienPhanPhoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dienMatsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerTuNgay
            // 
            this.dateTimePickerTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTuNgay.Location = new System.Drawing.Point(70, 13);
            this.dateTimePickerTuNgay.Name = "dateTimePickerTuNgay";
            this.dateTimePickerTuNgay.Size = new System.Drawing.Size(130, 22);
            this.dateTimePickerTuNgay.TabIndex = 0;
            // 
            // dateTimePickerDenNgay
            // 
            this.dateTimePickerDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDenNgay.Location = new System.Drawing.Point(281, 13);
            this.dateTimePickerDenNgay.Name = "dateTimePickerDenNgay";
            this.dateTimePickerDenNgay.Size = new System.Drawing.Size(130, 22);
            this.dateTimePickerDenNgay.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Từ ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nơi gửi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(632, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nơi nhận";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(859, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số mật";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1033, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Trích yếu";
            // 
            // btnTim
            // 
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTim.Location = new System.Drawing.Point(1358, 6);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(101, 32);
            this.btnTim.TabIndex = 7;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txbSoMat
            // 
            this.txbSoMat.Location = new System.Drawing.Point(917, 11);
            this.txbSoMat.Multiline = true;
            this.txbSoMat.Name = "txbSoMat";
            this.txbSoMat.Size = new System.Drawing.Size(100, 24);
            this.txbSoMat.TabIndex = 8;
            // 
            // tbxTrichYeu
            // 
            this.tbxTrichYeu.Location = new System.Drawing.Point(1106, 11);
            this.tbxTrichYeu.Multiline = true;
            this.tbxTrichYeu.Name = "tbxTrichYeu";
            this.tbxTrichYeu.Size = new System.Drawing.Size(216, 24);
            this.tbxTrichYeu.TabIndex = 9;
            // 
            // cbxNoiGui
            // 
            this.cbxNoiGui.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNoiGui.FormattingEnabled = true;
            this.cbxNoiGui.Location = new System.Drawing.Point(484, 11);
            this.cbxNoiGui.Name = "cbxNoiGui";
            this.cbxNoiGui.Size = new System.Drawing.Size(142, 24);
            this.cbxNoiGui.TabIndex = 10;
            // 
            // cbxNoiNhan
            // 
            this.cbxNoiNhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNoiNhan.FormattingEnabled = true;
            this.cbxNoiNhan.Location = new System.Drawing.Point(701, 11);
            this.cbxNoiNhan.Name = "cbxNoiNhan";
            this.cbxNoiNhan.Size = new System.Drawing.Size(142, 24);
            this.cbxNoiNhan.TabIndex = 11; 
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Đến ngày";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbxNoiNhan);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbxNoiGui);
            this.panel1.Controls.Add(this.dateTimePickerDenNgay);
            this.panel1.Controls.Add(this.dateTimePickerTuNgay);
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.tbxTrichYeu);
            this.panel1.Controls.Add(this.txbSoMat);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1558, 55);
            this.panel1.TabIndex = 13;
            // 
            // gridControlBaoCao
            // 
            this.gridControlBaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlBaoCao.DataSource = this.dienMatsBindingSource1;
            this.gridControlBaoCao.Location = new System.Drawing.Point(12, 73);
            this.gridControlBaoCao.MainView = this.gridViewDienPhanPhoi;
            this.gridControlBaoCao.Name = "gridControlBaoCao";
            this.gridControlBaoCao.Size = new System.Drawing.Size(1558, 679);
            this.gridControlBaoCao.TabIndex = 14;
            this.gridControlBaoCao.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDienPhanPhoi});
            this.gridControlBaoCao.Load += new System.EventHandler(this.gridControlBaoCao_Load);
            // 
            // dienMatsBindingSource1
            // 
            this.dienMatsBindingSource1.DataSource = typeof(ProjectBNG.Models.DienMat);
            // 
            // gridViewDienPhanPhoi
            // 
            this.gridViewDienPhanPhoi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaDienMat,
            this.colNgay,
            this.colNoiGui,
            this.colDoMat,
            this.colTrichYeu,
            this.colBanIn,
            this.colNgayIn,
            this.colLuuFile,
            this.colNguoiIn,
            this.colNoiNhan,
            this.colTrang});
            this.gridViewDienPhanPhoi.GridControl = this.gridControlBaoCao;
            this.gridViewDienPhanPhoi.Name = "gridViewDienPhanPhoi";
            this.gridViewDienPhanPhoi.OptionsBehavior.Editable = false;
            this.gridViewDienPhanPhoi.OptionsCustomization.CustomizationFormSearchBoxVisible = true;
            this.gridViewDienPhanPhoi.OptionsFind.FindDelay = 500;
            this.gridViewDienPhanPhoi.OptionsFind.FindNullPrompt = "Tìm kiếm thông tin điện mật đã phân phối";
            this.gridViewDienPhanPhoi.OptionsSelection.MultiSelect = true;
            this.gridViewDienPhanPhoi.OptionsView.ShowGroupPanel = false;
            this.gridViewDienPhanPhoi.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewDienPhanPhoi_CustomDrawRowIndicator);
            // 
            // colMaDienMat
            // 
            this.colMaDienMat.Caption = "Số mật";
            this.colMaDienMat.FieldName = "MaDienMat";
            this.colMaDienMat.MinWidth = 25;
            this.colMaDienMat.Name = "colMaDienMat";
            this.colMaDienMat.Visible = true;
            this.colMaDienMat.VisibleIndex = 0;
            this.colMaDienMat.Width = 65;
            // 
            // colNgay
            // 
            this.colNgay.Caption = "Ngày gửi";
            this.colNgay.FieldName = "Ngay";
            this.colNgay.MinWidth = 25;
            this.colNgay.Name = "colNgay";
            this.colNgay.Visible = true;
            this.colNgay.VisibleIndex = 1;
            this.colNgay.Width = 100;
            // 
            // colNoiGui
            // 
            this.colNoiGui.Caption = "Nơi gửi";
            this.colNoiGui.FieldName = "NoiGui";
            this.colNoiGui.MinWidth = 25;
            this.colNoiGui.Name = "colNoiGui";
            this.colNoiGui.Visible = true;
            this.colNoiGui.VisibleIndex = 2;
            this.colNoiGui.Width = 100;
            // 
            // colDoMat
            // 
            this.colDoMat.Caption = "Độ mật";
            this.colDoMat.FieldName = "DoMat";
            this.colDoMat.MinWidth = 25;
            this.colDoMat.Name = "colDoMat";
            this.colDoMat.Visible = true;
            this.colDoMat.VisibleIndex = 3;
            this.colDoMat.Width = 80;
            // 
            // colTrichYeu
            // 
            this.colTrichYeu.Caption = "Trích yếu";
            this.colTrichYeu.FieldName = "TrichYeu";
            this.colTrichYeu.MinWidth = 25;
            this.colTrichYeu.Name = "colTrichYeu";
            this.colTrichYeu.Visible = true;
            this.colTrichYeu.VisibleIndex = 7;
            this.colTrichYeu.Width = 273;
            // 
            // colBanIn
            // 
            this.colBanIn.Caption = "Bản in";
            this.colBanIn.FieldName = "BanIn";
            this.colBanIn.MinWidth = 25;
            this.colBanIn.Name = "colBanIn";
            this.colBanIn.Visible = true;
            this.colBanIn.VisibleIndex = 6;
            this.colBanIn.Width = 53;
            // 
            // colNgayIn
            // 
            this.colNgayIn.Caption = "Ngày in";
            this.colNgayIn.FieldName = "NgayIn";
            this.colNgayIn.MinWidth = 25;
            this.colNgayIn.Name = "colNgayIn";
            this.colNgayIn.Visible = true;
            this.colNgayIn.VisibleIndex = 9;
            this.colNgayIn.Width = 79;
            // 
            // colLuuFile
            // 
            this.colLuuFile.Caption = "Lưu file";
            this.colLuuFile.FieldName = "LuuFile";
            this.colLuuFile.MinWidth = 25;
            this.colLuuFile.Name = "colLuuFile";
            this.colLuuFile.Visible = true;
            this.colLuuFile.VisibleIndex = 10;
            this.colLuuFile.Width = 374;
            // 
            // colNguoiIn
            // 
            this.colNguoiIn.Caption = "Người in";
            this.colNguoiIn.FieldName = "NguoiIn";
            this.colNguoiIn.MinWidth = 25;
            this.colNguoiIn.Name = "colNguoiIn";
            this.colNguoiIn.Visible = true;
            this.colNguoiIn.VisibleIndex = 8;
            this.colNguoiIn.Width = 99;
            // 
            // colNoiNhan
            // 
            this.colNoiNhan.Caption = "Nơi nhận";
            this.colNoiNhan.FieldName = "DsNoiNhan";
            this.colNoiNhan.MinWidth = 25;
            this.colNoiNhan.Name = "colNoiNhan";
            this.colNoiNhan.Visible = true;
            this.colNoiNhan.VisibleIndex = 4;
            this.colNoiNhan.Width = 255;
            // 
            // colTrang
            // 
            this.colTrang.Caption = "Trang";
            this.colTrang.FieldName = "Trang";
            this.colTrang.MinWidth = 25;
            this.colTrang.Name = "colTrang";
            this.colTrang.Visible = true;
            this.colTrang.VisibleIndex = 5;
            this.colTrang.Width = 50;
            // 
            // dienMatsBindingSource
            // 
            this.dienMatsBindingSource.DataSource = typeof(ProjectBNG.Models.DienMat);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Location = new System.Drawing.Point(18, 758);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 33);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnInLai
            // 
            this.btnInLai.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnInLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInLai.Location = new System.Drawing.Point(569, 758);
            this.btnInLai.Name = "btnInLai";
            this.btnInLai.Size = new System.Drawing.Size(100, 33);
            this.btnInLai.TabIndex = 16;
            this.btnInLai.Text = "In lại";
            this.btnInLai.UseVisualStyleBackColor = true;
            // 
            // btnIn
            // 
            this.btnIn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIn.Location = new System.Drawing.Point(683, 758);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(100, 33);
            this.btnIn.TabIndex = 17;
            this.btnIn.Text = "In báo cáo";
            this.btnIn.UseVisualStyleBackColor = true;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Location = new System.Drawing.Point(796, 758);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(100, 33);
            this.btnThongKe.TabIndex = 18;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Location = new System.Drawing.Point(907, 758);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 33);
            this.btnDong.TabIndex = 19;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmDienPhanPhoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 803);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnInLai);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.gridControlBaoCao);
            this.Controls.Add(this.panel1);
            this.Name = "frmDienPhanPhoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách điện đã phân phối";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBaoCao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dienMatsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDienPhanPhoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dienMatsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerTuNgay;
        private System.Windows.Forms.DateTimePicker dateTimePickerDenNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txbSoMat;
        private System.Windows.Forms.TextBox tbxTrichYeu;
        private System.Windows.Forms.ComboBox cbxNoiGui;
        private System.Windows.Forms.ComboBox cbxNoiNhan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControlBaoCao;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDienPhanPhoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnInLai;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.BindingSource dienMatsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDienMat;
        private DevExpress.XtraGrid.Columns.GridColumn colNoiGui;
        private DevExpress.XtraGrid.Columns.GridColumn colTrichYeu;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay;
        private DevExpress.XtraGrid.Columns.GridColumn colDoMat;
        private DevExpress.XtraGrid.Columns.GridColumn colBanIn;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayIn;
        private DevExpress.XtraGrid.Columns.GridColumn colLuuFile;
        private DevExpress.XtraGrid.Columns.GridColumn colNguoiIn;
        private DevExpress.XtraGrid.Columns.GridColumn colNoiNhan;
        private DevExpress.XtraGrid.Columns.GridColumn colTrang;
        private System.Windows.Forms.BindingSource dienMatsBindingSource1;
    }
}