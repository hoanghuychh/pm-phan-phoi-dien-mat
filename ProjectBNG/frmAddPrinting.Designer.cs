namespace ProjectBNG
{
    partial class frmAddPrinting
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
            this.noiNhansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.noiNhansBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.noiNhansBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaNoiNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNoiNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoBaoMat = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.noiNhansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiNhansBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiNhansBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // noiNhansBindingSource
            // 
            this.noiNhansBindingSource.DataSource = typeof(ProjectBNG.Models.NoiNhan);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // noiNhansBindingSource1
            // 
            this.noiNhansBindingSource1.DataSource = typeof(ProjectBNG.Models.NoiNhan);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.noiNhansBindingSource2;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.Location = new System.Drawing.Point(11, 11);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(496, 341);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // noiNhansBindingSource2
            // 
            this.noiNhansBindingSource2.DataSource = typeof(ProjectBNG.Models.NoiNhan);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNoiNhan,
            this.colTenNoiNhan,
            this.colLoai,
            this.colSoBaoMat});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colMaNoiNhan, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colMaNoiNhan
            // 
            this.colMaNoiNhan.Caption = "Mã nơi nhận";
            this.colMaNoiNhan.FieldName = "MaNoiNhan";
            this.colMaNoiNhan.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DisplayText;
            this.colMaNoiNhan.MinWidth = 19;
            this.colMaNoiNhan.Name = "colMaNoiNhan";
            this.colMaNoiNhan.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colMaNoiNhan.Visible = true;
            this.colMaNoiNhan.VisibleIndex = 0;
            this.colMaNoiNhan.Width = 70;
            // 
            // colTenNoiNhan
            // 
            this.colTenNoiNhan.Caption = "Tên nơi nhận";
            this.colTenNoiNhan.FieldName = "TenNoiNhan";
            this.colTenNoiNhan.MinWidth = 19;
            this.colTenNoiNhan.Name = "colTenNoiNhan";
            this.colTenNoiNhan.Visible = true;
            this.colTenNoiNhan.VisibleIndex = 1;
            this.colTenNoiNhan.Width = 70;
            // 
            // colLoai
            // 
            this.colLoai.Caption = "Loại";
            this.colLoai.FieldName = "Loai";
            this.colLoai.MinWidth = 19;
            this.colLoai.Name = "colLoai";
            this.colLoai.Visible = true;
            this.colLoai.VisibleIndex = 2;
            this.colLoai.Width = 70;
            // 
            // colSoBaoMat
            // 
            this.colSoBaoMat.Caption = "Số bảo mật";
            this.colSoBaoMat.FieldName = "SoBaoMat";
            this.colSoBaoMat.MinWidth = 19;
            this.colSoBaoMat.Name = "colSoBaoMat";
            this.colSoBaoMat.Visible = true;
            this.colSoBaoMat.VisibleIndex = 3;
            this.colSoBaoMat.Width = 70;
            // 
            // frmAddPrinting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 392);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.button1);
            this.Name = "frmAddPrinting";
            this.Text = "Thêm nơi nhận";
            this.Load += new System.EventHandler(this.frmAddPrinting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.noiNhansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiNhansBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiNhansBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource noiNhansBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource noiNhansBindingSource1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNoiNhan;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNoiNhan;
        private DevExpress.XtraGrid.Columns.GridColumn colLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colSoBaoMat;
        private System.Windows.Forms.BindingSource noiNhansBindingSource2;
    }
}