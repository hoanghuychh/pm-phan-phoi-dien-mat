namespace ProjectBNG
{
    partial class frmNoiGui_1_cs
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.noiGuisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridviewNoiGui = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMa1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tbMaNguoiGui = new System.Windows.Forms.TextBox();
            this.tbTenNguoiGui = new System.Windows.Forms.TextBox();
            this.btnThemNguoiGui = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiGuisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewNoiGui)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.noiGuisBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(8, 12);
            this.gridControl1.MainView = this.gridviewNoiGui;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(643, 570);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridviewNoiGui});
            this.gridControl1.Load += new System.EventHandler(this.gridControl1_Load);
            // 
            // noiGuisBindingSource
            // 
            this.noiGuisBindingSource.DataSource = typeof(ProjectBNG.Models.NoiGui);
            // 
            // gridviewNoiGui
            // 
            this.gridviewNoiGui.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa1,
            this.colTen1,
            this.colMa,
            this.colTen});
            this.gridviewNoiGui.GridControl = this.gridControl1;
            this.gridviewNoiGui.Name = "gridviewNoiGui";
            this.gridviewNoiGui.OptionsBehavior.Editable = false;
            this.gridviewNoiGui.OptionsCustomization.CustomizationFormSearchBoxVisible = true;
            this.gridviewNoiGui.OptionsFind.FindNullPrompt = "Tìm kiếm thông tin nơi gửi";
            this.gridviewNoiGui.OptionsFind.ShowSearchNavButtons = false;
            this.gridviewNoiGui.OptionsView.ShowAutoFilterRow = true;
            this.gridviewNoiGui.OptionsView.ShowGroupPanel = false;
            this.gridviewNoiGui.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridviewNoiGui_CustomDrawRowIndicator);
            // 
            // colMa1
            // 
            this.colMa1.Caption = "Mã";
            this.colMa1.FieldName = "Ma";
            this.colMa1.MinWidth = 25;
            this.colMa1.Name = "colMa1";
            this.colMa1.Width = 138;
            // 
            // colTen1
            // 
            this.colTen1.AppearanceCell.BorderColor = System.Drawing.Color.Black;
            this.colTen1.AppearanceCell.Options.UseBorderColor = true;
            this.colTen1.Caption = "Tên";
            this.colTen1.FieldName = "Ten";
            this.colTen1.MinWidth = 25;
            this.colTen1.Name = "colTen1";
            this.colTen1.Width = 657;
            // 
            // colMa
            // 
            this.colMa.Caption = "Mã";
            this.colMa.FieldName = "Ma";
            this.colMa.MinWidth = 25;
            this.colMa.Name = "colMa";
            this.colMa.Visible = true;
            this.colMa.VisibleIndex = 0;
            this.colMa.Width = 138;
            // 
            // colTen
            // 
            this.colTen.Caption = "Tên nơi gửi";
            this.colTen.FieldName = "Ten";
            this.colTen.MinWidth = 25;
            this.colTen.Name = "colTen";
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 1;
            this.colTen.Width = 475;
            // 
            // tbMaNguoiGui
            // 
            this.tbMaNguoiGui.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbMaNguoiGui.Location = new System.Drawing.Point(12, 588);
            this.tbMaNguoiGui.Multiline = true;
            this.tbMaNguoiGui.Name = "tbMaNguoiGui";
            this.tbMaNguoiGui.Size = new System.Drawing.Size(155, 28);
            this.tbMaNguoiGui.TabIndex = 3;
            // 
            // tbTenNguoiGui
            // 
            this.tbTenNguoiGui.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbTenNguoiGui.Location = new System.Drawing.Point(173, 588);
            this.tbTenNguoiGui.Multiline = true;
            this.tbTenNguoiGui.Name = "tbTenNguoiGui";
            this.tbTenNguoiGui.Size = new System.Drawing.Size(371, 28);
            this.tbTenNguoiGui.TabIndex = 4;
            // 
            // btnThemNguoiGui
            // 
            this.btnThemNguoiGui.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThemNguoiGui.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemNguoiGui.Location = new System.Drawing.Point(550, 588);
            this.btnThemNguoiGui.Name = "btnThemNguoiGui";
            this.btnThemNguoiGui.Size = new System.Drawing.Size(101, 28);
            this.btnThemNguoiGui.TabIndex = 5;
            this.btnThemNguoiGui.Text = "Thêm";
            this.btnThemNguoiGui.UseVisualStyleBackColor = true;
            this.btnThemNguoiGui.Click += new System.EventHandler(this.btnThemNguoiGui_Click);
            // 
            // btXoa
            // 
            this.btXoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btXoa.Location = new System.Drawing.Point(208, 622);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(94, 32);
            this.btXoa.TabIndex = 6;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(337, 622);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 32);
            this.button4.TabIndex = 7;
            this.button4.Text = "Đóng";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmNoiGui_1_cs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(663, 662);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btnThemNguoiGui);
            this.Controls.Add(this.tbTenNguoiGui);
            this.Controls.Add(this.tbMaNguoiGui);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmNoiGui_1_cs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nơi gửi";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiGuisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewNoiGui)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridviewNoiGui;
        private System.Windows.Forms.BindingSource noiGuisBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMa1;
        private DevExpress.XtraGrid.Columns.GridColumn colTen1;
        private System.Windows.Forms.TextBox tbMaNguoiGui;
        private System.Windows.Forms.TextBox tbTenNguoiGui;
        private System.Windows.Forms.Button btnThemNguoiGui;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button button4;
        private DevExpress.XtraGrid.Columns.GridColumn colMa;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
    }
}