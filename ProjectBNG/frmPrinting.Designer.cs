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
            this.dgvPlacesOfReceiving = new System.Windows.Forms.DataGridView();
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
            this.rtxtPdfView = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlacesOfReceiving)).BeginInit();
            this.panel3.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 136);
            this.panel1.TabIndex = 21;
            // 
            // btnAddAttachedFile
            // 
            this.btnAddAttachedFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAttachedFile.Image = global::ProjectBNG.Properties.Resources.plus;
            this.btnAddAttachedFile.Location = new System.Drawing.Point(359, 42);
            this.btnAddAttachedFile.Name = "btnAddAttachedFile";
            this.btnAddAttachedFile.Size = new System.Drawing.Size(42, 23);
            this.btnAddAttachedFile.TabIndex = 36;
            this.btnAddAttachedFile.UseVisualStyleBackColor = true;
            this.btnAddAttachedFile.Click += new System.EventHandler(this.btnAddAttachedFile_Click);
            // 
            // btnRemoveAttachedFile
            // 
            this.btnRemoveAttachedFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAttachedFile.Image = global::ProjectBNG.Properties.Resources.minus;
            this.btnRemoveAttachedFile.Location = new System.Drawing.Point(316, 42);
            this.btnRemoveAttachedFile.Name = "btnRemoveAttachedFile";
            this.btnRemoveAttachedFile.Size = new System.Drawing.Size(42, 23);
            this.btnRemoveAttachedFile.TabIndex = 35;
            this.btnRemoveAttachedFile.UseVisualStyleBackColor = true;
            this.btnRemoveAttachedFile.Click += new System.EventHandler(this.btnRemoveAttachedFile_Click);
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseFile.Location = new System.Drawing.Point(316, 9);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(86, 23);
            this.btnBrowseFile.TabIndex = 34;
            this.btnBrowseFile.Text = "...";
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // datetime
            // 
            this.datetime.CustomFormat = "dd/MM/yyyy";
            this.datetime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetime.Location = new System.Drawing.Point(452, 76);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(120, 20);
            this.datetime.TabIndex = 33;
            // 
            // txtPrivateNumber
            // 
            this.txtPrivateNumber.Location = new System.Drawing.Point(306, 76);
            this.txtPrivateNumber.Name = "txtPrivateNumber";
            this.txtPrivateNumber.Size = new System.Drawing.Size(95, 20);
            this.txtPrivateNumber.TabIndex = 32;
            // 
            // cbxPrivateAttachedFile
            // 
            this.cbxPrivateAttachedFile.FormattingEnabled = true;
            this.cbxPrivateAttachedFile.Location = new System.Drawing.Point(452, 43);
            this.cbxPrivateAttachedFile.Name = "cbxPrivateAttachedFile";
            this.cbxPrivateAttachedFile.Size = new System.Drawing.Size(120, 21);
            this.cbxPrivateAttachedFile.TabIndex = 31;
            // 
            // cbxPrivateFile
            // 
            this.cbxPrivateFile.FormattingEnabled = true;
            this.cbxPrivateFile.Location = new System.Drawing.Point(452, 10);
            this.cbxPrivateFile.Name = "cbxPrivateFile";
            this.cbxPrivateFile.Size = new System.Drawing.Size(120, 21);
            this.cbxPrivateFile.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Độ mật";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(407, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Ngày";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Số mật";
            // 
            // cbxPlaceOfSending
            // 
            this.cbxPlaceOfSending.FormattingEnabled = true;
            this.cbxPlaceOfSending.Location = new System.Drawing.Point(97, 76);
            this.cbxPlaceOfSending.Name = "cbxPlaceOfSending";
            this.cbxPlaceOfSending.Size = new System.Drawing.Size(144, 21);
            this.cbxPlaceOfSending.TabIndex = 26;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(97, 109);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(475, 20);
            this.textBox3.TabIndex = 25;
            // 
            // txtAttachedFileName
            // 
            this.txtAttachedFileName.Location = new System.Drawing.Point(97, 43);
            this.txtAttachedFileName.Name = "txtAttachedFileName";
            this.txtAttachedFileName.Size = new System.Drawing.Size(211, 20);
            this.txtAttachedFileName.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Trích yêu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nơi gửi";
            // 
            // txtIncludingFile
            // 
            this.txtIncludingFile.AutoSize = true;
            this.txtIncludingFile.Location = new System.Drawing.Point(7, 47);
            this.txtIncludingFile.Name = "txtIncludingFile";
            this.txtIncludingFile.Size = new System.Drawing.Size(72, 13);
            this.txtIncludingFile.TabIndex = 21;
            this.txtIncludingFile.Text = "File đính kèm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Điện mật";
            // 
            // txtFileName
            // 
            this.txtFileName.Enabled = false;
            this.txtFileName.Location = new System.Drawing.Point(97, 10);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(211, 20);
            this.txtFileName.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvPlacesOfReceiving);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(11, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(574, 300);
            this.panel2.TabIndex = 22;
            // 
            // dgvPlacesOfReceiving
            // 
            this.dgvPlacesOfReceiving.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlacesOfReceiving.Location = new System.Drawing.Point(0, 27);
            this.dgvPlacesOfReceiving.Name = "dgvPlacesOfReceiving";
            this.dgvPlacesOfReceiving.Size = new System.Drawing.Size(573, 270);
            this.dgvPlacesOfReceiving.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
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
            this.panel3.Location = new System.Drawing.Point(12, 460);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(574, 139);
            this.panel3.TabIndex = 23;
            // 
            // rtxtSignature
            // 
            this.rtxtSignature.Location = new System.Drawing.Point(271, 75);
            this.rtxtSignature.Name = "rtxtSignature";
            this.rtxtSignature.ReadOnly = true;
            this.rtxtSignature.Size = new System.Drawing.Size(125, 53);
            this.rtxtSignature.TabIndex = 43;
            this.rtxtSignature.Text = "";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(274, 11);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(122, 20);
            this.textBox12.TabIndex = 42;
            this.textBox12.Text = "Kính gửi:";
            // 
            // txtIncluding
            // 
            this.txtIncluding.Location = new System.Drawing.Point(320, 43);
            this.txtIncluding.Name = "txtIncluding";
            this.txtIncluding.Size = new System.Drawing.Size(76, 20);
            this.txtIncluding.TabIndex = 41;
            this.txtIncluding.Text = "(Ghi)";
            this.txtIncluding.Click += new System.EventHandler(this.txt_Click);
            // 
            // chbIncluding
            // 
            this.chbIncluding.AutoSize = true;
            this.chbIncluding.Location = new System.Drawing.Point(271, 45);
            this.chbIncluding.Name = "chbIncluding";
            this.chbIncluding.Size = new System.Drawing.Size(46, 17);
            this.chbIncluding.TabIndex = 40;
            this.chbIncluding.Text = "Gộp";
            this.chbIncluding.UseVisualStyleBackColor = true;
            // 
            // txtAllignBottomSM
            // 
            this.txtAllignBottomSM.Location = new System.Drawing.Point(522, 75);
            this.txtAllignBottomSM.Name = "txtAllignBottomSM";
            this.txtAllignBottomSM.Size = new System.Drawing.Size(50, 20);
            this.txtAllignBottomSM.TabIndex = 39;
            this.txtAllignBottomSM.Text = "0";
            this.txtAllignBottomSM.Click += new System.EventHandler(this.txt_Click);
            this.txtAllignBottomSM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyPress);
            // 
            // txtAllignBottomSignature
            // 
            this.txtAllignBottomSignature.Location = new System.Drawing.Point(522, 43);
            this.txtAllignBottomSignature.Name = "txtAllignBottomSignature";
            this.txtAllignBottomSignature.Size = new System.Drawing.Size(50, 20);
            this.txtAllignBottomSignature.TabIndex = 38;
            this.txtAllignBottomSignature.Text = "0";
            this.txtAllignBottomSignature.Click += new System.EventHandler(this.txt_Click);
            this.txtAllignBottomSignature.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyPress);
            // 
            // txtAllignBottomIncludedSM
            // 
            this.txtAllignBottomIncludedSM.Location = new System.Drawing.Point(522, 107);
            this.txtAllignBottomIncludedSM.Name = "txtAllignBottomIncludedSM";
            this.txtAllignBottomIncludedSM.Size = new System.Drawing.Size(50, 20);
            this.txtAllignBottomIncludedSM.TabIndex = 37;
            this.txtAllignBottomIncludedSM.Text = "0";
            this.txtAllignBottomIncludedSM.Click += new System.EventHandler(this.txt_Click);
            this.txtAllignBottomIncludedSM.TextChanged += new System.EventHandler(this.txtAllignBottomIncludedSM_TextChanged);
            this.txtAllignBottomIncludedSM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyPress);
            // 
            // txtPage
            // 
            this.txtPage.Location = new System.Drawing.Point(522, 11);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(50, 20);
            this.txtPage.TabIndex = 36;
            this.txtPage.Text = "0";
            this.txtPage.Click += new System.EventHandler(this.txt_Click);
            this.txtPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyPress);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(73, 107);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(194, 20);
            this.txtTitle.TabIndex = 35;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(108, 11);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(159, 20);
            this.txtNote.TabIndex = 34;
            // 
            // cbxSigner
            // 
            this.cbxSigner.FormattingEnabled = true;
            this.cbxSigner.Location = new System.Drawing.Point(73, 75);
            this.cbxSigner.Name = "cbxSigner";
            this.cbxSigner.Size = new System.Drawing.Size(194, 21);
            this.cbxSigner.TabIndex = 33;
            // 
            // cbxCensor
            // 
            this.cbxCensor.FormattingEnabled = true;
            this.cbxCensor.Location = new System.Drawing.Point(73, 43);
            this.cbxCensor.Name = "cbxCensor";
            this.cbxCensor.Size = new System.Drawing.Size(194, 21);
            this.cbxCensor.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(404, 111);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Lề dưới SM đính kèm";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(403, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Lề dưới SM trang dưới";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(403, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Lề dười chữ ký";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(402, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "Đặt chữ ký trang";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Chức danh";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Người ký";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Người duyệt";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Chú thích bên trái";
            // 
            // btnRemovePlaceOfSending
            // 
            this.btnRemovePlaceOfSending.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovePlaceOfSending.Image = global::ProjectBNG.Properties.Resources.minus;
            this.btnRemovePlaceOfSending.Location = new System.Drawing.Point(590, 210);
            this.btnRemovePlaceOfSending.Name = "btnRemovePlaceOfSending";
            this.btnRemovePlaceOfSending.Size = new System.Drawing.Size(30, 23);
            this.btnRemovePlaceOfSending.TabIndex = 39;
            this.btnRemovePlaceOfSending.UseVisualStyleBackColor = true;
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.Image = global::ProjectBNG.Properties.Resources.page_up;
            this.btnUp.Location = new System.Drawing.Point(590, 295);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(30, 23);
            this.btnUp.TabIndex = 38;
            this.btnUp.UseVisualStyleBackColor = true;
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.Image = global::ProjectBNG.Properties.Resources.page_down;
            this.btnDown.Location = new System.Drawing.Point(590, 324);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(30, 23);
            this.btnDown.TabIndex = 37;
            this.btnDown.UseVisualStyleBackColor = true;
            // 
            // btnAddPlaceOfSending
            // 
            this.btnAddPlaceOfSending.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPlaceOfSending.Image = global::ProjectBNG.Properties.Resources.plus;
            this.btnAddPlaceOfSending.Location = new System.Drawing.Point(590, 181);
            this.btnAddPlaceOfSending.Name = "btnAddPlaceOfSending";
            this.btnAddPlaceOfSending.Size = new System.Drawing.Size(30, 23);
            this.btnAddPlaceOfSending.TabIndex = 36;
            this.btnAddPlaceOfSending.UseVisualStyleBackColor = true;
            // 
            // chbPrint
            // 
            this.chbPrint.AutoSize = true;
            this.chbPrint.Location = new System.Drawing.Point(626, 567);
            this.chbPrint.Name = "chbPrint";
            this.chbPrint.Size = new System.Drawing.Size(92, 17);
            this.chbPrint.TabIndex = 40;
            this.chbPrint.Text = "In SM lên trên";
            this.chbPrint.UseVisualStyleBackColor = true;
            this.chbPrint.CheckedChanged += new System.EventHandler(this.chbPrint_CheckedChanged);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(723, 564);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 41;
            this.btnPreview.Text = "Xem trước";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(804, 564);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 42;
            this.btnPrint.Text = "In";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1047, 564);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 43;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // rtxtPdfView
            // 
            this.rtxtPdfView.Location = new System.Drawing.Point(627, 12);
            this.rtxtPdfView.Name = "rtxtPdfView";
            this.rtxtPdfView.ReadOnly = true;
            this.rtxtPdfView.Size = new System.Drawing.Size(495, 545);
            this.rtxtPdfView.TabIndex = 44;
            this.rtxtPdfView.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(966, 564);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 45;
            this.button1.Text = "Phóng to";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(885, 564);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 46;
            this.button2.Text = "Thu nhỏ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmPrinting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 600);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtxtPdfView);
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
            this.Name = "frmPrinting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In điện mật";
            this.Load += new System.EventHandler(this.frmPrinting_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlacesOfReceiving)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgvPlacesOfReceiving;
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
        private System.Windows.Forms.RichTextBox rtxtPdfView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

