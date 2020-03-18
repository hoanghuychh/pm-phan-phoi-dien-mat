namespace ProjectBNG
{
    partial class frmThemFileDinhKem
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
            this.gridControlDinhKem = new DevExpress.XtraGrid.GridControl();
            this.gridViewDinhKem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.fileDinhKemDienMatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colFileDinhKem = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDinhKem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDinhKem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileDinhKemDienMatsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlDinhKem
            // 
            this.gridControlDinhKem.DataSource = this.fileDinhKemDienMatsBindingSource;
            this.gridControlDinhKem.Location = new System.Drawing.Point(12, 12);
            this.gridControlDinhKem.MainView = this.gridViewDinhKem;
            this.gridControlDinhKem.Name = "gridControlDinhKem";
            this.gridControlDinhKem.Size = new System.Drawing.Size(776, 383);
            this.gridControlDinhKem.TabIndex = 0;
            this.gridControlDinhKem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDinhKem});
            // 
            // gridViewDinhKem
            // 
            this.gridViewDinhKem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFileDinhKem});
            this.gridViewDinhKem.GridControl = this.gridControlDinhKem;
            this.gridViewDinhKem.Name = "gridViewDinhKem";
            this.gridViewDinhKem.OptionsView.ShowGroupPanel = false;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Location = new System.Drawing.Point(205, 402);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 32);
            this.btnThem.TabIndex = 42;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Location = new System.Drawing.Point(307, 402);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 32);
            this.btnXoa.TabIndex = 42;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.Location = new System.Drawing.Point(409, 402);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(94, 32);
            this.btnLuu.TabIndex = 42;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnDong
            // 
            this.btnDong.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDong.Location = new System.Drawing.Point(511, 402);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(94, 32);
            this.btnDong.TabIndex = 42;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // fileDinhKemDienMatsBindingSource
            // 
            this.fileDinhKemDienMatsBindingSource.DataSource = typeof(ProjectBNG.Models.FileDinhKemDienMat);
            // 
            // colFileDinhKem
            // 
            this.colFileDinhKem.Caption = "Đường dẫn file đính kèm";
            this.colFileDinhKem.FieldName = "FileDinhKem";
            this.colFileDinhKem.MinWidth = 25;
            this.colFileDinhKem.Name = "colFileDinhKem";
            this.colFileDinhKem.Visible = true;
            this.colFileDinhKem.VisibleIndex = 0;
            this.colFileDinhKem.Width = 94;
            // 
            // frmThemFileDinhKem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gridControlDinhKem);
            this.Name = "frmThemFileDinhKem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đính kèm";
            this.Load += new System.EventHandler(this.frmThemFileDinhKem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDinhKem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDinhKem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileDinhKemDienMatsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlDinhKem;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDinhKem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.BindingSource fileDinhKemDienMatsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colFileDinhKem;
    }
}