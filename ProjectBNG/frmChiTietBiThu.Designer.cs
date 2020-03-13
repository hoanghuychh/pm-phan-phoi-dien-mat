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
            this.btnOpenPdf = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sMMgDataSet1 = new ProjectBNG.SMMgDataSet1();
            this.dienMatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dienMatTableAdapter = new ProjectBNG.SMMgDataSet1TableAdapters.DienMatTableAdapter();
            this.gridControlChiTietBiThu = new DevExpress.XtraGrid.GridControl();
            this.dienMatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewChiTietBiThu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNoiGui = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaDienMat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNguoiDuyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNguoiKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNguoiIn = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sMMgDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dienMatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlChiTietBiThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dienMatsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewChiTietBiThu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenPdf
            // 
            this.btnOpenPdf.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOpenPdf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpenPdf.Location = new System.Drawing.Point(309, 405);
            this.btnOpenPdf.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenPdf.Name = "btnOpenPdf";
            this.btnOpenPdf.Size = new System.Drawing.Size(94, 32);
            this.btnOpenPdf.TabIndex = 43;
            this.btnOpenPdf.Text = "Xem chi tiết";
            this.btnOpenPdf.UseVisualStyleBackColor = true;
            this.btnOpenPdf.Click += new System.EventHandler(this.btnOpenPdf_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(423, 405);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 32);
            this.button1.TabIndex = 44;
            this.button1.Text = "Đóng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sMMgDataSet1
            // 
            this.sMMgDataSet1.DataSetName = "SMMgDataSet1";
            this.sMMgDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dienMatBindingSource
            // 
            this.dienMatBindingSource.DataMember = "DienMat";
            this.dienMatBindingSource.DataSource = this.sMMgDataSet1;
            // 
            // dienMatTableAdapter
            // 
            this.dienMatTableAdapter.ClearBeforeFill = true;
            // 
            // gridControlChiTietBiThu
            // 
            this.gridControlChiTietBiThu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlChiTietBiThu.DataSource = this.dienMatsBindingSource;
            this.gridControlChiTietBiThu.Location = new System.Drawing.Point(12, 12);
            this.gridControlChiTietBiThu.MainView = this.gridViewChiTietBiThu;
            this.gridControlChiTietBiThu.Name = "gridControlChiTietBiThu";
            this.gridControlChiTietBiThu.Size = new System.Drawing.Size(776, 386);
            this.gridControlChiTietBiThu.TabIndex = 45;
            this.gridControlChiTietBiThu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewChiTietBiThu});
            // 
            // dienMatsBindingSource
            // 
            this.dienMatsBindingSource.DataSource = typeof(ProjectBNG.Models.DienMat);
            // 
            // gridViewChiTietBiThu
            // 
            this.gridViewChiTietBiThu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNoiGui,
            this.colMaDienMat,
            this.colNgay,
            this.colNguoiDuyet,
            this.colNguoiKy,
            this.colTrang,
            this.colNguoiIn});
            this.gridViewChiTietBiThu.GridControl = this.gridControlChiTietBiThu;
            this.gridViewChiTietBiThu.Name = "gridViewChiTietBiThu";
            this.gridViewChiTietBiThu.OptionsBehavior.Editable = false;
            this.gridViewChiTietBiThu.OptionsView.ShowGroupPanel = false;
            this.gridViewChiTietBiThu.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewChiTietBiThu_CustomDrawRowIndicator);
            // 
            // colNoiGui
            // 
            this.colNoiGui.Caption = "Nơi gửi";
            this.colNoiGui.FieldName = "NoiGui";
            this.colNoiGui.MinWidth = 25;
            this.colNoiGui.Name = "colNoiGui";
            this.colNoiGui.Visible = true;
            this.colNoiGui.VisibleIndex = 0;
            this.colNoiGui.Width = 94;
            // 
            // colMaDienMat
            // 
            this.colMaDienMat.Caption = "Mã điện mật";
            this.colMaDienMat.FieldName = "MaDienMat";
            this.colMaDienMat.MinWidth = 25;
            this.colMaDienMat.Name = "colMaDienMat";
            this.colMaDienMat.Visible = true;
            this.colMaDienMat.VisibleIndex = 1;
            this.colMaDienMat.Width = 94;
            // 
            // colNgay
            // 
            this.colNgay.Caption = "Ngày";
            this.colNgay.FieldName = "Ngay";
            this.colNgay.MinWidth = 25;
            this.colNgay.Name = "colNgay";
            this.colNgay.Visible = true;
            this.colNgay.VisibleIndex = 2;
            this.colNgay.Width = 94;
            // 
            // colNguoiDuyet
            // 
            this.colNguoiDuyet.Caption = "Người duyệt";
            this.colNguoiDuyet.FieldName = "NguoiDuyet";
            this.colNguoiDuyet.MinWidth = 25;
            this.colNguoiDuyet.Name = "colNguoiDuyet";
            this.colNguoiDuyet.Visible = true;
            this.colNguoiDuyet.VisibleIndex = 3;
            this.colNguoiDuyet.Width = 94;
            // 
            // colNguoiKy
            // 
            this.colNguoiKy.Caption = "Người kí";
            this.colNguoiKy.FieldName = "NguoiKy";
            this.colNguoiKy.MinWidth = 25;
            this.colNguoiKy.Name = "colNguoiKy";
            this.colNguoiKy.Visible = true;
            this.colNguoiKy.VisibleIndex = 4;
            this.colNguoiKy.Width = 94;
            // 
            // colTrang
            // 
            this.colTrang.Caption = "Số trang";
            this.colTrang.FieldName = "Trang";
            this.colTrang.MinWidth = 25;
            this.colTrang.Name = "colTrang";
            this.colTrang.Visible = true;
            this.colTrang.VisibleIndex = 5;
            this.colTrang.Width = 94;
            // 
            // colNguoiIn
            // 
            this.colNguoiIn.Caption = "Người in";
            this.colNguoiIn.FieldName = "NguoiIn";
            this.colNguoiIn.MinWidth = 25;
            this.colNguoiIn.Name = "colNguoiIn";
            this.colNguoiIn.Visible = true;
            this.colNguoiIn.VisibleIndex = 6;
            this.colNguoiIn.Width = 94;
            // 
            // frmChiTietBiThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridControlChiTietBiThu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOpenPdf);
            this.Name = "frmChiTietBiThu";
            this.Text = "Chi tiết bì thư";
            this.Load += new System.EventHandler(this.frmChiTietBiThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sMMgDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dienMatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlChiTietBiThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dienMatsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewChiTietBiThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOpenPdf;
        private System.Windows.Forms.Button button1;
        private SMMgDataSet1 sMMgDataSet1;
        private System.Windows.Forms.BindingSource dienMatBindingSource;
        private SMMgDataSet1TableAdapters.DienMatTableAdapter dienMatTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControlChiTietBiThu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewChiTietBiThu;
        private DevExpress.XtraGrid.Columns.GridColumn colNoiGui;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDienMat;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay;
        private DevExpress.XtraGrid.Columns.GridColumn colNguoiDuyet;
        private DevExpress.XtraGrid.Columns.GridColumn colNguoiKy;
        private DevExpress.XtraGrid.Columns.GridColumn colTrang;
        private DevExpress.XtraGrid.Columns.GridColumn colNguoiIn;
        private System.Windows.Forms.BindingSource dienMatsBindingSource;
    }
}