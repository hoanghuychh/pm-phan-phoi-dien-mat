namespace ProjectBNG
{
    partial class frmNoinhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNoinhan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.noiNhansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaNoiNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNoiNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoBaoMat = new DevExpress.XtraGrid.Columns.GridColumn();
            //this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThemNoiNhan = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cmbLoai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTenNoiNhanTimKiem = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiNhansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl1);
            //this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 540);
            this.panel1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.noiNhansBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(4, 42);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(970, 490);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Load += new System.EventHandler(this.gridControl1_Load);
            // 
            // noiNhansBindingSource
            //// 
            //this.noiNhansBindingSource.DataSource = typeof(ProjectBNG.Models.NoiNhan);
            // 
            // gridView1
            // 
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNoiNhan,
            this.colTenNoiNhan,
            this.colLoai,
            this.colSoBaoMat});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
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
            this.colMaNoiNhan.MinWidth = 25;
            this.colMaNoiNhan.Name = "colMaNoiNhan";
            this.colMaNoiNhan.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colMaNoiNhan.Visible = true;
            this.colMaNoiNhan.VisibleIndex = 0;
            this.colMaNoiNhan.Width = 94;
            // 
            // colTenNoiNhan
            // 
            this.colTenNoiNhan.Caption = "Tên nơi nhận";
            this.colTenNoiNhan.FieldName = "TenNoiNhan";
            this.colTenNoiNhan.MinWidth = 25;
            this.colTenNoiNhan.Name = "colTenNoiNhan";
            this.colTenNoiNhan.Visible = true;
            this.colTenNoiNhan.VisibleIndex = 1;
            this.colTenNoiNhan.Width = 94;
            // 
            // colLoai
            // 
            this.colLoai.Caption = "Loại";
            this.colLoai.FieldName = "Loai";
            this.colLoai.MinWidth = 25;
            this.colLoai.Name = "colLoai";
            this.colLoai.Visible = true;
            this.colLoai.VisibleIndex = 2;
            this.colLoai.Width = 94;
            // 
            // colSoBaoMat
            // 
            this.colSoBaoMat.Caption = "Số bảo mật";
            this.colSoBaoMat.FieldName = "SoBaoMat";
            this.colSoBaoMat.MinWidth = 25;
            this.colSoBaoMat.Name = "colSoBaoMat";
            this.colSoBaoMat.Visible = true;
            this.colSoBaoMat.VisibleIndex = 3;
            this.colSoBaoMat.Width = 94;
            // 
            // dataGridView1
            // 
            //this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //this.dataGridView1.Location = new System.Drawing.Point(4, 41);
            //this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            //this.dataGridView1.Name = "dataGridView1";
            //this.dataGridView1.Size = new System.Drawing.Size(939, 465);
            //this.dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right));
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnThemNoiNhan);
            this.panel2.Controls.Add(this.btnTimKiem);
            this.panel2.Controls.Add(this.cmbLoai);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbTenNoiNhanTimKiem);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(939, 31);
            this.panel2.TabIndex = 0;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(895, 1);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(40, 28);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThemNoiNhan
            // 
            this.btnThemNoiNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemNoiNhan.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNoiNhan.Image")));
            this.btnThemNoiNhan.Location = new System.Drawing.Point(847, 1);
            this.btnThemNoiNhan.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemNoiNhan.Name = "btnThemNoiNhan";
            this.btnThemNoiNhan.Size = new System.Drawing.Size(40, 28);
            this.btnThemNoiNhan.TabIndex = 6;
            this.btnThemNoiNhan.UseVisualStyleBackColor = true;
            this.btnThemNoiNhan.Click += new System.EventHandler(this.btnThemNoiNhan_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor= ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top )));
            this.btnTimKiem.Location = new System.Drawing.Point(601, 1);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 28);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = true;

            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cmbLoai
            // 

            this.cmbLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top)));
            this.cmbLoai.FormattingEnabled = true;
            this.cmbLoai.Location = new System.Drawing.Point(443, 2);
            this.cmbLoai.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLoai.Name = "cmbLoai";
            this.cmbLoai.Size = new System.Drawing.Size(137, 24);
            this.cmbLoai.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor= ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Loại";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên nơi nhận";
            // 
            // tbTenNoiNhanTimKiem
            // 
            this.tbTenNoiNhanTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top)));
            this.tbTenNoiNhanTimKiem.Location = new System.Drawing.Point(105, 2);
            this.tbTenNoiNhanTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.tbTenNoiNhanTimKiem.Name = "tbTenNoiNhanTimKiem";
            this.tbTenNoiNhanTimKiem.Size = new System.Drawing.Size(269, 22);
            this.tbTenNoiNhanTimKiem.TabIndex = 0;
            // 
            // frmNoinhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 550);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNoinhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nơi nhận";
            this.Activated += new System.EventHandler(this.frmNoinhan_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNoinhan_FormClosing);
            this.Load += new System.EventHandler(this.frmNoinhan_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiNhansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThemNoiNhan;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cmbLoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTenNoiNhanTimKiem;
        private System.Windows.Forms.Button btnXoa;
        //private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource noiNhansBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNoiNhan;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNoiNhan;
        private DevExpress.XtraGrid.Columns.GridColumn colLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colSoBaoMat;
    }
}