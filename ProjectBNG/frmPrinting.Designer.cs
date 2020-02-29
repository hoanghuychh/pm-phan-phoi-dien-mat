namespace ProjectBNG
{
    partial class frmPrinting
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddAttachedFile = new System.Windows.Forms.Button();
            this.btnRemoveAttachedFile = new System.Windows.Forms.Button();
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.datetime = new System.Windows.Forms.DateTimePicker();
            this.txtPrivateNumber = new System.Windows.Forms.TextBox();
            this.cbxPrivateAttachedFile = new System.Windows.Forms.ComboBox();
            this.cbxPrivateFile = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxPlaceOfSending = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtAttachedFileName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIncludingFile = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dienMatsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewNoiNhanPDF = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaNoiNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNoiNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoBaoMat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rtxtSignature = new System.Windows.Forms.RichTextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.txtIncluding = new System.Windows.Forms.TextBox();
            this.chbIncluding = new System.Windows.Forms.CheckBox();
            this.txtAllignBottomSM = new System.Windows.Forms.TextBox();
            this.txtAllignBottomSignature = new System.Windows.Forms.TextBox();
            this.txtAllignBottomIncludedSM = new System.Windows.Forms.TextBox();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.cbxSigner = new System.Windows.Forms.ComboBox();
            this.cbxCensor = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnRemovePlaceOfSending = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnAddPlaceOfSending = new System.Windows.Forms.Button();
            this.chbPrint = new System.Windows.Forms.CheckBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dienMatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pdfViewer1 = new DevExpress.XtraPdfViewer.PdfViewer();
            this.noiNhanTempsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dienMatsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNoiNhanPDF)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dienMatsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiNhanTempsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddAttachedFile);
            this.panel1.Controls.Add(this.btnRemoveAttachedFile);
            this.panel1.Controls.Add(this.btnBrowseFile);
            this.panel1.Controls.Add(this.datetime);
            this.panel1.Controls.Add(this.txtPrivateNumber);
            this.panel1.Controls.Add(this.cbxPrivateAttachedFile);
            this.panel1.Controls.Add(this.cbxPrivateFile);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbxPlaceOfSending);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.txtAttachedFileName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtIncludingFile);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtFileName);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 167);
            this.panel1.TabIndex = 21;
            // 
            // btnAddAttachedFile
            // 
            this.btnAddAttachedFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAttachedFile.Image = global::ProjectBNG.Properties.Resources.plus;
            this.btnAddAttachedFile.Location = new System.Drawing.Point(479, 52);
            this.btnAddAttachedFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAttachedFile.Name = "btnAddAttachedFile";
            this.btnAddAttachedFile.Size = new System.Drawing.Size(56, 28);
            this.btnAddAttachedFile.TabIndex = 36;
            this.btnAddAttachedFile.UseVisualStyleBackColor = true;
            this.btnAddAttachedFile.Click += new System.EventHandler(this.btnAddAttachedFile_Click);
            // 
            // btnRemoveAttachedFile
            // 
            this.btnRemoveAttachedFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAttachedFile.Image = global::ProjectBNG.Properties.Resources.minus;
            this.btnRemoveAttachedFile.Location = new System.Drawing.Point(421, 52);
            this.btnRemoveAttachedFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveAttachedFile.Name = "btnRemoveAttachedFile";
            this.btnRemoveAttachedFile.Size = new System.Drawing.Size(56, 28);
            this.btnRemoveAttachedFile.TabIndex = 35;
            this.btnRemoveAttachedFile.UseVisualStyleBackColor = true;
            this.btnRemoveAttachedFile.Click += new System.EventHandler(this.btnRemoveAttachedFile_Click);
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseFile.Location = new System.Drawing.Point(421, 11);
            this.btnBrowseFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(115, 28);
            this.btnBrowseFile.TabIndex = 34;
            this.btnBrowseFile.Text = "...";
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // datetime
            // 
            this.datetime.CustomFormat = "dd/MM/yyyy";
            this.datetime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetime.Location = new System.Drawing.Point(603, 94);
            this.datetime.Margin = new System.Windows.Forms.Padding(4);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(159, 22);
            this.datetime.TabIndex = 33;
            // 
            // txtPrivateNumber
            // 
            this.txtPrivateNumber.Location = new System.Drawing.Point(408, 94);
            this.txtPrivateNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrivateNumber.Name = "txtPrivateNumber";
            this.txtPrivateNumber.Size = new System.Drawing.Size(125, 22);
            this.txtPrivateNumber.TabIndex = 32;
            // 
            // cbxPrivateAttachedFile
            // 
            this.cbxPrivateAttachedFile.FormattingEnabled = true;
            this.cbxPrivateAttachedFile.Location = new System.Drawing.Point(603, 53);
            this.cbxPrivateAttachedFile.Margin = new System.Windows.Forms.Padding(4);
            this.cbxPrivateAttachedFile.Name = "cbxPrivateAttachedFile";
            this.cbxPrivateAttachedFile.Size = new System.Drawing.Size(159, 24);
            this.cbxPrivateAttachedFile.TabIndex = 31;
            // 
            // cbxPrivateFile
            // 
            this.cbxPrivateFile.FormattingEnabled = true;
            this.cbxPrivateFile.Location = new System.Drawing.Point(603, 12);
            this.cbxPrivateFile.Margin = new System.Windows.Forms.Padding(4);
            this.cbxPrivateFile.Name = "cbxPrivateFile";
            this.cbxPrivateFile.Size = new System.Drawing.Size(159, 24);
            this.cbxPrivateFile.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(541, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Độ mật";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(543, 98);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Ngày";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Số mật";
            // 
            // cbxPlaceOfSending
            // 
            this.cbxPlaceOfSending.FormattingEnabled = true;
            this.cbxPlaceOfSending.Location = new System.Drawing.Point(129, 94);
            this.cbxPlaceOfSending.Margin = new System.Windows.Forms.Padding(4);
            this.cbxPlaceOfSending.Name = "cbxPlaceOfSending";
            this.cbxPlaceOfSending.Size = new System.Drawing.Size(191, 24);
            this.cbxPlaceOfSending.TabIndex = 26;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(129, 134);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(632, 22);
            this.textBox3.TabIndex = 25;
            // 
            // txtAttachedFileName
            // 
            this.txtAttachedFileName.Location = new System.Drawing.Point(129, 53);
            this.txtAttachedFileName.Margin = new System.Windows.Forms.Padding(4);
            this.txtAttachedFileName.Name = "txtAttachedFileName";
            this.txtAttachedFileName.Size = new System.Drawing.Size(280, 22);
            this.txtAttachedFileName.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Trích yêu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nơi gửi";
            // 
            // txtIncludingFile
            // 
            this.txtIncludingFile.AutoSize = true;
            this.txtIncludingFile.Location = new System.Drawing.Point(9, 58);
            this.txtIncludingFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtIncludingFile.Name = "txtIncludingFile";
            this.txtIncludingFile.Size = new System.Drawing.Size(91, 17);
            this.txtIncludingFile.TabIndex = 21;
            this.txtIncludingFile.Text = "File đính kèm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Điện mật";
            // 
            // txtFileName
            // 
            this.txtFileName.Enabled = false;
            this.txtFileName.Location = new System.Drawing.Point(129, 12);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(280, 22);
            this.txtFileName.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(15, 190);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(764, 369);
            this.panel2.TabIndex = 22;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.noiNhanTempsBindingSource;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 33);
            this.gridControl1.MainView = this.gridViewNoiNhanPDF;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(761, 332);
            this.gridControl1.TabIndex = 23;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewNoiNhanPDF});
            // 
            // dienMatsBindingSource1
            // 
            this.dienMatsBindingSource1.DataSource = typeof(ProjectBNG.Models.DienMat);
            // 
            // gridViewNoiNhanPDF
            // 
            this.gridViewNoiNhanPDF.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNoiNhan,
            this.colTenNoiNhan,
            this.colLoai,
            this.colSoBaoMat});
            this.gridViewNoiNhanPDF.GridControl = this.gridControl1;
            this.gridViewNoiNhanPDF.Name = "gridViewNoiNhanPDF";
            this.gridViewNoiNhanPDF.OptionsView.ShowGroupPanel = false;
            this.gridViewNoiNhanPDF.OptionsView.ShowIndicator = false;
            // 
            // colMaNoiNhan
            // 
            this.colMaNoiNhan.Caption = "Mã nơi nhận";
            this.colMaNoiNhan.FieldName = "MaNoiNhan";
            this.colMaNoiNhan.MinWidth = 25;
            this.colMaNoiNhan.Name = "colMaNoiNhan";
            this.colMaNoiNhan.Visible = true;
            this.colMaNoiNhan.VisibleIndex = 0;
            this.colMaNoiNhan.Width = 93;
            // 
            // colTenNoiNhan
            // 
            this.colTenNoiNhan.Caption = "Tên nơi nhận";
            this.colTenNoiNhan.FieldName = "TenNoiNhan";
            this.colTenNoiNhan.MinWidth = 25;
            this.colTenNoiNhan.Name = "colTenNoiNhan";
            this.colTenNoiNhan.Visible = true;
            this.colTenNoiNhan.VisibleIndex = 1;
            this.colTenNoiNhan.Width = 93;
            // 
            // colLoai
            // 
            this.colLoai.Caption = "Loại";
            this.colLoai.FieldName = "Loai";
            this.colLoai.MinWidth = 25;
            this.colLoai.Name = "colLoai";
            this.colLoai.Visible = true;
            this.colLoai.VisibleIndex = 2;
            this.colLoai.Width = 93;
            // 
            // colSoBaoMat
            // 
            this.colSoBaoMat.Caption = "Số bảo mật";
            this.colSoBaoMat.FieldName = "SoBaoMat";
            this.colSoBaoMat.MinWidth = 25;
            this.colSoBaoMat.Name = "colSoBaoMat";
            this.colSoBaoMat.Visible = true;
            this.colSoBaoMat.VisibleIndex = 3;
            this.colSoBaoMat.Width = 93;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Nơi nhận";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rtxtSignature);
            this.panel3.Controls.Add(this.textBox12);
            this.panel3.Controls.Add(this.txtIncluding);
            this.panel3.Controls.Add(this.chbIncluding);
            this.panel3.Controls.Add(this.txtAllignBottomSM);
            this.panel3.Controls.Add(this.txtAllignBottomSignature);
            this.panel3.Controls.Add(this.txtAllignBottomIncludedSM);
            this.panel3.Controls.Add(this.txtPage);
            this.panel3.Controls.Add(this.txtTitle);
            this.panel3.Controls.Add(this.txtNote);
            this.panel3.Controls.Add(this.cbxSigner);
            this.panel3.Controls.Add(this.cbxCensor);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(16, 566);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(765, 171);
            this.panel3.TabIndex = 23;
            // 
            // rtxtSignature
            // 
            this.rtxtSignature.Location = new System.Drawing.Point(361, 92);
            this.rtxtSignature.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtSignature.Name = "rtxtSignature";
            this.rtxtSignature.ReadOnly = true;
            this.rtxtSignature.Size = new System.Drawing.Size(165, 64);
            this.rtxtSignature.TabIndex = 43;
            this.rtxtSignature.Text = "";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(365, 14);
            this.textBox12.Margin = new System.Windows.Forms.Padding(4);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(161, 22);
            this.textBox12.TabIndex = 42;
            this.textBox12.Text = "Kính gửi:";
            // 
            // txtIncluding
            // 
            this.txtIncluding.Location = new System.Drawing.Point(427, 53);
            this.txtIncluding.Margin = new System.Windows.Forms.Padding(4);
            this.txtIncluding.Name = "txtIncluding";
            this.txtIncluding.Size = new System.Drawing.Size(100, 22);
            this.txtIncluding.TabIndex = 41;
            this.txtIncluding.Text = "(Ghi)";
            this.txtIncluding.Click += new System.EventHandler(this.txt_Click);
            // 
            // chbIncluding
            // 
            this.chbIncluding.AutoSize = true;
            this.chbIncluding.Location = new System.Drawing.Point(361, 55);
            this.chbIncluding.Margin = new System.Windows.Forms.Padding(4);
            this.chbIncluding.Name = "chbIncluding";
            this.chbIncluding.Size = new System.Drawing.Size(57, 21);
            this.chbIncluding.TabIndex = 40;
            this.chbIncluding.Text = "Gộp";
            this.chbIncluding.UseVisualStyleBackColor = true;
            // 
            // txtAllignBottomSM
            // 
            this.txtAllignBottomSM.Location = new System.Drawing.Point(696, 92);
            this.txtAllignBottomSM.Margin = new System.Windows.Forms.Padding(4);
            this.txtAllignBottomSM.Name = "txtAllignBottomSM";
            this.txtAllignBottomSM.Size = new System.Drawing.Size(65, 22);
            this.txtAllignBottomSM.TabIndex = 39;
            this.txtAllignBottomSM.Text = "0";
            this.txtAllignBottomSM.Click += new System.EventHandler(this.txt_Click);
            this.txtAllignBottomSM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyPress);
            // 
            // txtAllignBottomSignature
            // 
            this.txtAllignBottomSignature.Location = new System.Drawing.Point(696, 53);
            this.txtAllignBottomSignature.Margin = new System.Windows.Forms.Padding(4);
            this.txtAllignBottomSignature.Name = "txtAllignBottomSignature";
            this.txtAllignBottomSignature.Size = new System.Drawing.Size(65, 22);
            this.txtAllignBottomSignature.TabIndex = 38;
            this.txtAllignBottomSignature.Text = "0";
            this.txtAllignBottomSignature.Click += new System.EventHandler(this.txt_Click);
            this.txtAllignBottomSignature.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyPress);
            // 
            // txtAllignBottomIncludedSM
            // 
            this.txtAllignBottomIncludedSM.Location = new System.Drawing.Point(696, 132);
            this.txtAllignBottomIncludedSM.Margin = new System.Windows.Forms.Padding(4);
            this.txtAllignBottomIncludedSM.Name = "txtAllignBottomIncludedSM";
            this.txtAllignBottomIncludedSM.Size = new System.Drawing.Size(65, 22);
            this.txtAllignBottomIncludedSM.TabIndex = 37;
            this.txtAllignBottomIncludedSM.Text = "0";
            this.txtAllignBottomIncludedSM.Click += new System.EventHandler(this.txt_Click);
            this.txtAllignBottomIncludedSM.TextChanged += new System.EventHandler(this.txtAllignBottomIncludedSM_TextChanged);
            this.txtAllignBottomIncludedSM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyPress);
            // 
            // txtPage
            // 
            this.txtPage.Location = new System.Drawing.Point(696, 14);
            this.txtPage.Margin = new System.Windows.Forms.Padding(4);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(65, 22);
            this.txtPage.TabIndex = 36;
            this.txtPage.Text = "0";
            this.txtPage.Click += new System.EventHandler(this.txt_Click);
            this.txtPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyPress);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(97, 132);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(257, 22);
            this.txtTitle.TabIndex = 35;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(144, 14);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(211, 22);
            this.txtNote.TabIndex = 34;
            // 
            // cbxSigner
            // 
            this.cbxSigner.FormattingEnabled = true;
            this.cbxSigner.Location = new System.Drawing.Point(97, 92);
            this.cbxSigner.Margin = new System.Windows.Forms.Padding(4);
            this.cbxSigner.Name = "cbxSigner";
            this.cbxSigner.Size = new System.Drawing.Size(257, 24);
            this.cbxSigner.TabIndex = 33;
            // 
            // cbxCensor
            // 
            this.cbxCensor.FormattingEnabled = true;
            this.cbxCensor.Location = new System.Drawing.Point(97, 53);
            this.cbxCensor.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCensor.Name = "cbxCensor";
            this.cbxCensor.Size = new System.Drawing.Size(257, 24);
            this.cbxCensor.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(539, 137);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 17);
            this.label13.TabIndex = 31;
            this.label13.Text = "Lề dưới SM đính kèm";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(537, 97);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(147, 17);
            this.label14.TabIndex = 30;
            this.label14.Text = "Lề dưới SM trang dưới";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(537, 58);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 17);
            this.label15.TabIndex = 29;
            this.label15.Text = "Lề dười chữ ký";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(536, 18);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 17);
            this.label16.TabIndex = 28;
            this.label16.Text = "Đặt chữ ký trang";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 137);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "Chức danh";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 97);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "Người ký";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 58);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Người duyệt";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 18);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "Chú thích bên trái";
            // 
            // btnRemovePlaceOfSending
            // 
            this.btnRemovePlaceOfSending.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovePlaceOfSending.Image = global::ProjectBNG.Properties.Resources.minus;
            this.btnRemovePlaceOfSending.Location = new System.Drawing.Point(787, 258);
            this.btnRemovePlaceOfSending.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemovePlaceOfSending.Name = "btnRemovePlaceOfSending";
            this.btnRemovePlaceOfSending.Size = new System.Drawing.Size(40, 28);
            this.btnRemovePlaceOfSending.TabIndex = 39;
            this.btnRemovePlaceOfSending.UseVisualStyleBackColor = true;
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.Image = global::ProjectBNG.Properties.Resources.page_up;
            this.btnUp.Location = new System.Drawing.Point(787, 363);
            this.btnUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(40, 28);
            this.btnUp.TabIndex = 38;
            this.btnUp.UseVisualStyleBackColor = true;
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.Image = global::ProjectBNG.Properties.Resources.page_down;
            this.btnDown.Location = new System.Drawing.Point(787, 399);
            this.btnDown.Margin = new System.Windows.Forms.Padding(4);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(40, 28);
            this.btnDown.TabIndex = 37;
            this.btnDown.UseVisualStyleBackColor = true;
            // 
            // btnAddPlaceOfSending
            // 
            this.btnAddPlaceOfSending.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPlaceOfSending.Image = global::ProjectBNG.Properties.Resources.plus;
            this.btnAddPlaceOfSending.Location = new System.Drawing.Point(787, 223);
            this.btnAddPlaceOfSending.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddPlaceOfSending.Name = "btnAddPlaceOfSending";
            this.btnAddPlaceOfSending.Size = new System.Drawing.Size(40, 28);
            this.btnAddPlaceOfSending.TabIndex = 36;
            this.btnAddPlaceOfSending.UseVisualStyleBackColor = true;
            this.btnAddPlaceOfSending.Click += new System.EventHandler(this.btnAddPlaceOfSending_Click);
            // 
            // chbPrint
            // 
            this.chbPrint.AutoSize = true;
            this.chbPrint.Location = new System.Drawing.Point(835, 698);
            this.chbPrint.Margin = new System.Windows.Forms.Padding(4);
            this.chbPrint.Name = "chbPrint";
            this.chbPrint.Size = new System.Drawing.Size(117, 21);
            this.chbPrint.TabIndex = 40;
            this.chbPrint.Text = "In SM lên trên";
            this.chbPrint.UseVisualStyleBackColor = true;
            this.chbPrint.CheckedChanged += new System.EventHandler(this.chbPrint_CheckedChanged);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(964, 694);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(4);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(100, 28);
            this.btnPreview.TabIndex = 41;
            this.btnPreview.Text = "Xem trước";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(1072, 694);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 28);
            this.btnPrint.TabIndex = 42;
            this.btnPrint.Text = "In";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1396, 694);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 28);
            this.btnClose.TabIndex = 43;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1288, 694);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 45;
            this.button1.Text = "Phóng to";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1180, 694);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 46;
            this.button2.Text = "Thu nhỏ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dienMatsBindingSource
            // 
            this.dienMatsBindingSource.DataSource = typeof(ProjectBNG.Models.DienMat);
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.Location = new System.Drawing.Point(836, 15);
            this.pdfViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.NavigationPaneInitialVisibility = DevExpress.XtraPdfViewer.PdfNavigationPaneVisibility.Hidden;
            this.pdfViewer1.Size = new System.Drawing.Size(659, 671);
            this.pdfViewer1.TabIndex = 47;
            // 
            // noiNhanTempsBindingSource
            // 
            this.noiNhanTempsBindingSource.DataSource = typeof(ProjectBNG.Models.NoiNhanTemp);
            // 
            // frmPrinting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1511, 738);
            this.Controls.Add(this.pdfViewer1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.chbPrint);
            this.Controls.Add(this.btnRemovePlaceOfSending);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnAddPlaceOfSending);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrinting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In điện mật";
            this.Load += new System.EventHandler(this.frmPrinting_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dienMatsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNoiNhanPDF)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dienMatsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiNhanTempsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddAttachedFile;
        private System.Windows.Forms.Button btnRemoveAttachedFile;
        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.DateTimePicker datetime;
        private System.Windows.Forms.TextBox txtPrivateNumber;
        private System.Windows.Forms.ComboBox cbxPrivateAttachedFile;
        private System.Windows.Forms.ComboBox cbxPrivateFile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxPlaceOfSending;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtAttachedFileName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtIncludingFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox rtxtSignature;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox txtIncluding;
        private System.Windows.Forms.CheckBox chbIncluding;
        private System.Windows.Forms.TextBox txtAllignBottomSM;
        private System.Windows.Forms.TextBox txtAllignBottomSignature;
        private System.Windows.Forms.TextBox txtAllignBottomIncludedSM;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.ComboBox cbxSigner;
        private System.Windows.Forms.ComboBox cbxCensor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAddPlaceOfSending;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnRemovePlaceOfSending;
        private System.Windows.Forms.CheckBox chbPrint;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource dienMatsBindingSource;
        private System.Windows.Forms.BindingSource dienMatsBindingSource1;
        private DevExpress.XtraPdfViewer.PdfViewer pdfViewer1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewNoiNhanPDF;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNoiNhan;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNoiNhan;
        private DevExpress.XtraGrid.Columns.GridColumn colLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colSoBaoMat;
        private System.Windows.Forms.BindingSource noiNhanTempsBindingSource;
    }
}

