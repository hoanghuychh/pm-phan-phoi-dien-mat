using ProjectBNG.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Entity;
using DevExpress.Pdf;
using ProjectBNG.Models;
using System.Diagnostics;
using ProjectBNG.Class;
using ProjectBNG.Exten;
using DevExpress.XtraPdfViewer;
using DevExpress.XtraRichEdit;

namespace ProjectBNG
{
    public partial class frmPrinting : Form
    {
        static public List<NoiNhan> noiNhans { get; set; }
        static public List<NoiNhanTemp> noiNhanTemps { get; set; }
        static public List<NoiNhanTemp> noiNhanNoiBo { get; set; }
        static public List<NoiNhanTemp> noiNhanNgoaiBo { get; set; }
        public List<NoiNhanTemp> listDrawNoiNhanTemp = new List<NoiNhanTemp>();//list dc in ra tren pdf

        public List<NoiNhanTemp> listDrewNoiNhanTemp = new List<NoiNhanTemp>();

        List<PdfDocumentProcessor> listPdf = new List<PdfDocumentProcessor>();
        static public bool checkOpenpdf = false;
        static public float dpiDefault = 0;
        static public string FileNameOpen;
        static public MemoryStream FileStreamOpen = new MemoryStream();
        float x = 0;
        float y = 250;
        //public void DrawingNoiNhanTemp(List<NoiNhanTemp> n)
        //{

        //    MemoryStream pdfStream = new MemoryStream();

        //    MemoryStream ms2 = new MemoryStream();
        //    MemoryStream ms3 = new MemoryStream();

        //    noiNhanTemps = n;
        //    noiNhanNoiBo = new List<NoiNhanTemp>();

        //    noiNhanNgoaiBo = new List<NoiNhanTemp>();
        //    foreach (var a in noiNhanTemps)
        //    {
        //        if(a.Loai== "Nội bộ")
        //        {
        //            noiNhanNoiBo.Add(a);
        //        }
        //    }
        //    foreach(var b in noiNhanTemps)
        //    {
        //        if (b.Loai == "Bên ngoài")
        //        {
        //            noiNhanNgoaiBo.Add(b);
        //        }
        //    }
        //    try
        //    {
        //        PdfDocumentProcessor processor = new PdfDocumentProcessor();
        //        if (y == 250)
        //        {
        //            processor.LoadDocument(FileNameOpen);//lay pdf de xu li
        //            foreach (var a in noiNhanNoiBo)
        //            {

        //                using (SolidBrush textBrush = new SolidBrush(Color.FromArgb(0, 0, 0)))
        //                {

        //                    AddGraphics(processor, "- " + a.TenNoiNhan, textBrush, x, y);
        //                    //DrawGraphics();
        //                    listDrewNoiNhanTemp.Add(a);
        //                }
        //                y += 20;
        //            }
        //            //preview chu ky

        //            using (PdfGraphics graphics = processor.CreateGraphics())
        //            {
        //                DrawImage(graphics, 100, 700);
        //                graphics.AddToPageForeground(processor.Document.Pages[0], 72, 72);
        //            }
        //            //fix exception throw :devexpress...

        //            //preview chu ky
        //            processor.SaveDocument(ms2);
        //            //ms2.WriteTo(pdfStream);

        //            pdfViewer1.LoadDocument(ms2);
        //        }
        //        else
        //        {
        //            processor.LoadDocument(ms2);
        //            foreach (var a in noiNhanNoiBo)
        //            {

        //                using (SolidBrush textBrush = new SolidBrush(Color.FromArgb(0, 0, 0)))
        //                {

        //                    AddGraphics(processor, "- " + a.TenNoiNhan, textBrush, x, y);
        //                    //DrawGraphics();
        //                    listDrewNoiNhanTemp.Add(a);
        //                }
        //                y += 20;
        //            }
        //            processor.SaveDocument(pdfStream);
        //            pdfViewer1.LoadDocument(pdfStream);

        //        }

        //    }
        //    catch { }
        //}

        public void DrawingNoiNhanTemp(List<NoiNhanTemp> n)
        {
            listPdf.Clear();
            MemoryStream pdfStream = new MemoryStream();
            MemoryStream ms2 = new MemoryStream();
            MemoryStream ms3 = new MemoryStream();
            noiNhanTemps = n;
            noiNhanNoiBo = new List<NoiNhanTemp>();
            noiNhanNgoaiBo = new List<NoiNhanTemp>();
            TuyChinh tuyChinh = new TuyChinh();
            foreach (var a in noiNhanTemps)
            {
                if (a.Loai == "Nội bộ")
                {
                    noiNhanNoiBo.Add(a);
                }
            }
            foreach (var b in noiNhanTemps)
            {
                if (b.Loai == "Bên ngoài")
                {
                    noiNhanNgoaiBo.Add(b);
                }
            }
            try
            {
                foreach (var noiBo in noiNhanNoiBo)
                {
                    PdfDocumentProcessor processor = new PdfDocumentProcessor();
                    y = 250;
                    
                    try
                    {
                        processor.LoadDocument(FileNameOpen);//lay pdf de xu li
                    }
                    catch
                    {
                        processor.LoadDocument(FileStreamOpen);
                    }
                    { //In Ten noi nhan noi bo len pdf
                        foreach (var a in noiNhanNoiBo)
                        {
                            using (SolidBrush textBrush = new SolidBrush(Color.FromArgb(0, 0, 0)))
                            {
                                AddGraphics(processor, "- " + a.TenNoiNhan, textBrush, x, y);
                            }
                            y += 20;
                        }
                    }
                    { //in vung chu ky

                        using (PdfGraphics graphics = processor.CreateGraphics())
                        {

                            NguoiKy nguoiKy = db.NguoiKies.Single(x => x.TenNguoiKy == cbxNguoiKiMD.Text);
                            MemoryStream anhChuKy = new MemoryStream(nguoiKy.ChuKy);
                            //CommonFunction.InVungChuKy(processor, graphics, new Bitmap(anhChuKy), nguoiKy);
                            //graphics.AddToPageForeground(processor.Document.Pages[0], 72, 72);
                            if (tbDatChuKyTrang.Text == "0")
                            {

                            }
                            else if (pdfViewer1.PageCount >= int.Parse(tbDatChuKyTrang.Text))
                            {
                                CommonFunction.InVungChuKy(processor, graphics, new Bitmap(anhChuKy), nguoiKy, int.Parse(tbDatChuKyTrang.Text) - 1);
                                graphics.AddToPageForeground(processor.Document.Pages[int.Parse(tbDatChuKyTrang.Text) - 1], 72, 72);
                            }
                            else
                            {
                                MessageBox.Show(string.Format("Trang tối đa hiện có thể là {0}", (pdfViewer1.PageCount).ToString(), "Thông báo"));
                                return;
                            }
                        }

                    }
                    { //in watermark

                        CommonFunction.AddWatermark(noiBo.SoBaoMat.ToString(), processor);
                    }
                    listPdf.Add(processor);
                }
                listPdf[0].SaveDocument(ms2);
                pdfViewer1.LoadDocument(ms2);
                //processor.SaveDocument(ms2);
                ////ms2.WriteTo(pdfStream);
                //pdfViewer1.LoadDocument(ms2);

                //using (PdfGraphics graphics = processor.CreateGraphics())
                //{
                //    DrawImage(graphics, 100, 700);
                //    if (pdfViewer1.PageCount >= int.Parse(tbDatChuKyTrang.Text) - 1)
                //    {

                //        graphics.AddToPageForeground(processor.Document.Pages[int.Parse(tbDatChuKyTrang.Text) - 1], 72, 72);
                //    }
                //    else
                //    {
                //        MessageBox.Show("Trang tối đa hiện có thể là {0}", pdfViewer1.PageCount.ToString());
                //    }
                //}

                //PdfDocumentProcessor processor = new PdfDocumentProcessor();
                //foreach (var a in noiNhanNoiBo)
                //{
                //    {
                //        using (PdfGraphics graphics1 = processor.CreateGraphics())
                //        {
                //            CommonFunction.AddWatermark(a.SoBaoMat.ToString(), processor);

                //            NguoiKy nguoiKy = new NguoiKy();
                //            nguoiKy = db.NguoiKies.Single(x => x.TenNguoiKy == cbxNguoiKiMD.Text);
                //            MemoryStream stream = new MemoryStream(nguoiKy.ChuKy);
                //            CommonFunction.InVungChuKy(processor, graphics1, 10, 10, new Bitmap(stream),nguoiKy);
                //        }
                //        //processor.SaveDocument(ms3); 
                //        //processor.SaveDocument(tuyChinh.LuuFile + tbMaDienMat.ToString().Trim() + "_" + a.SoBaoMat.ToString() + ".pdf");
                //        //processor.SaveDocument("D:\\BACKUP\\Desktop\\Release\\" + tbMaDienMat.ToString().Trim() + "_" + a.SoBaoMat.ToString() + ".pdf");
                //    }
                //}
                ////watermark id noi gui
                //var NoiGuiSelection = db.NoiGuis.Single(x => x.Ten == cbxNoiGuiMD.Text);
                //CommonFunction.AddWatermark(NoiGuiSelection.id.ToString(),processor);

                //fix exception throw :devexpress...
                //processor.SaveDocument(ms2);
                //ms2.WriteTo(pdfStream);
                //pdfViewer1.LoadDocument(ms2);

            }
            catch { }

        }

        public frmPrinting()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            ProjectBNG.Models.SMMgEntities dbContext = new ProjectBNG.Models.SMMgEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.DienMats.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                dienMatsBindingSource1.DataSource = dbContext.DienMats.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.NoiNhanTemps.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                noiNhanTempsBindingSource.DataSource = dbContext.NoiNhanTemps.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());

        }

        private void frmPrinting_Load(object sender, EventArgs e)
        {
            //// cbxPrivateFile
            cbxPrivateFile.Items.Add("Mật");
            cbxPrivateFile.Items.Add("TM");
            cbxPrivateFile.Items.Add("Tuyệt mật");
            cbxPrivateFile.SelectedItem = cbxPrivateFile.Items[0];

            // cbxPrivateAttachedFile
            cbxPrivateAttachedFile.Items.Add("Mật");
            cbxPrivateAttachedFile.Items.Add("Fax");
            cbxPrivateAttachedFile.SelectedItem = cbxPrivateAttachedFile.Items[0];

            db.Database.ExecuteSqlCommand("delete from NoiNhanTemp", new object[] { });

            cbxNoiGuiMD.DataSource = db.NoiGuis.ToList();
            cbxNoiGuiMD.ValueMember = "id";
            cbxNoiGuiMD.DisplayMember = "Ten";
            try
            {

                NguoiDuyet defaultNguoiNhan = db.NguoiDuyets.SingleOrDefault(x => x.MacDinh == true);
                cbxNguoiDuyetMD.SelectedText = defaultNguoiNhan.TenNguoiDuyet;
                cbxNguoiDuyetMD.DataSource = db.NguoiDuyets.ToList();
                cbxNguoiDuyetMD.ValueMember = "id";
                cbxNguoiDuyetMD.DisplayMember = "TenNguoiDuyet";

                NguoiKy defaultNguoiKy = db.NguoiKies.SingleOrDefault(x => x.MacDinh == true);
                cbxNguoiKiMD.SelectedText = defaultNguoiKy.TenNguoiKy;
                cbxNguoiKiMD.DataSource = db.NguoiKies.ToList();
                cbxNguoiKiMD.ValueMember = "id";
                cbxNguoiKiMD.DisplayMember = "TenNguoiKy";

                tbChucDanhMD.Text = defaultNguoiKy.ChucDanh;

                var stream = new MemoryStream(defaultNguoiKy.ChuKy);
                pbChuKiMD.Image = Image.FromStream(stream);
                pbChuKiMD.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch
            { }
            tbDatChuKyTrang.Text = "0";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            checkOpenpdf = false;
            this.Close();
        }

        const float DrawingDpi = 72f;

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            MemoryStream PDFstream = new MemoryStream();
            using (OpenFileDialog ofd = new OpenFileDialog() { ValidateNames = true, Multiselect = false, Filter = "PDF Files(*.PDF)|*.PDF|DOC Files(*.DOC)|*.DOC|All Files(*.*)|*.*" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pdfViewer1.LoadDocument(ofd.FileName);
                    }
                    catch
                    {
                        RichEditDocumentServer server = new RichEditDocumentServer();
                        server.LoadDocument(ofd.FileName);
                        server.ExportToPdf(PDFstream);
                        pdfViewer1.LoadDocument(PDFstream);
                        FileStreamOpen = PDFstream;
                    }
                    
                    SizeF currentPageSize = pdfViewer1.GetPageSize(pdfViewer1.CurrentPageNumber);
                    float dpi = 110f;
                    float pageHeightPixel = currentPageSize.Height * dpi;
                    float topBottomOffset = 40f;
                    pdfViewer1.ZoomMode = PdfZoomMode.Custom;
                    pdfViewer1.ZoomFactor = ((float)pdfViewer1.ClientSize.Height - topBottomOffset) / pageHeightPixel * 100f;
                    dpiDefault = ((float)pdfViewer1.ClientSize.Height - topBottomOffset) / pageHeightPixel * 100f;

                    FileNameOpen = ofd.FileName;
                    tbFileNameDienMat.Text = FileNameOpen;
                    checkOpenpdf = true;

                    //using (PdfDocumentProcessor processor = new PdfDocumentProcessor())
                    //{
                    //    processor.LoadDocument(FileNameOpen);
                    //    using (PdfGraphics graphics = processor.CreateGraphics())
                    //    {
                    //        NguoiKy nguoiKy =  db.NguoiKies.Single(x => x.TenNguoiKy == cbxNguoiKiMD.Text);
                    //        MemoryStream stream = new MemoryStream(nguoiKy.ChuKy);
                    //        CommonFunction.InVungChuKy(processor, graphics, 150, 700, new Bitmap(stream), nguoiKy);
                    //        graphics.AddToPageForeground(processor.Document.Pages[0], 72, 72);
                    //        CommonFunction.AddWatermark("10", processor);
                    //    }
                    //    processor.SaveDocument(PDFstream);
                    //    pdfViewer1.LoadDocument(PDFstream);
                    //}

                    //chinh pdf vua khung 

                }

            }
            //if (listDrewNoiNhanTemp.Count > 0)
            //    listDrewNoiNhanTemp.Clear();
        }

        //static void AddGraphics(PdfDocumentProcessor processor, string text, SolidBrush textBrush, float x, float y)
        //{
        //    IList<PdfPage> pages = processor.Document.Pages;
        //    for (int i = 0; i < pages.Count; i++)
        //    {
        //        PdfPage page = pages[i];
        //        using (PdfGraphics graphics = processor.CreateGraphics())
        //        {
        //            SizeF actualPageSize = PrepareGraphics(page, graphics);
        //            using (Font font = new Font("Times New Roman", 12, FontStyle.Regular))
        //            {
        //                SizeF textSize = graphics.MeasureString(text, font, PdfStringFormat.GenericDefault);
        //                PointF topLeft = new PointF(x, y);
        //                //PointF bottomRight = new PointF(actualPageSize.Width - textSize.Width, actualPageSize.Height - textSize.Height);
        //                graphics.DrawString(text, font, textBrush, topLeft);
        //                //graphics.DrawString(text, font, textBrush, bottomRight);
        //                graphics.AddToPageForeground(page, DrawingDpi, DrawingDpi);
        //            }
        //        }
        //    }
        //}//update in khi xuong dong(prevous version)
        static void AddGraphics(PdfDocumentProcessor processor, string text, SolidBrush textBrush, float x, float y)
        {
            IList<PdfPage> pages = processor.Document.Pages;
            PdfStringFormat stringFormat = PdfStringFormat.GenericTypographic;
            stringFormat.Alignment = PdfStringAlignment.Center;
            stringFormat.LineAlignment = PdfStringAlignment.Center;
            for (int i = 0; i < pages.Count; i++)
            {
                PdfPage page = pages[i];
                using (PdfGraphics graphics = processor.CreateGraphics())
                {
                    SizeF actualPageSize = PrepareGraphics(page, graphics);
                    using (Font font = new Font("Times New Roman", 12, FontStyle.Regular))
                    {
                        SizeF textSize = graphics.MeasureString(text, font, PdfStringFormat.GenericDefault);
                        RectangleF rect = new RectangleF(x, y, 50, 20);
                        graphics.DrawString(text, font, textBrush, rect, stringFormat);
                        //graphics.DrawString(text, font, textBrush, bottomRight);
                        graphics.AddToPageForeground(page, DrawingDpi, DrawingDpi);
                    }
                }
            }
        }

        static void DrawGraphics(PdfGraphics graph)
        {
            // Draw an image on the page. 
            using (Bitmap image = new Bitmap("..\\..\\DevExpress.png"))
            {
                float width = image.Width;
                float height = image.Height;
                graph.DrawImage(image, new RectangleF(20, 40, width / 2, height / 2));
            }
        }

        static SizeF PrepareGraphics(PdfPage page, PdfGraphics graphics)
        {
            PdfRectangle cropBox = page.CropBox;
            float cropBoxWidth = (float)cropBox.Width;
            float cropBoxHeight = (float)cropBox.Height;

            switch (page.Rotate)
            {
                case 90:
                    graphics.RotateTransform(-90);
                    graphics.TranslateTransform(-cropBoxHeight, 0);
                    return new SizeF(cropBoxHeight, cropBoxWidth);
                case 180:
                    graphics.RotateTransform(-180);
                    graphics.TranslateTransform(-cropBoxWidth, -cropBoxHeight);
                    return new SizeF(cropBoxWidth, cropBoxHeight);
                case 270:
                    graphics.RotateTransform(-270);
                    graphics.TranslateTransform(0, -cropBoxWidth);
                    return new SizeF(cropBoxHeight, cropBoxWidth);
            }
            return new SizeF(cropBoxWidth, cropBoxHeight);
        }

        private void btnAddAttachedFile_Click(object sender, EventArgs e)
        {
            FileDinhKemDienMat fileDinhKemDienMat = new FileDinhKemDienMat();
            try
            {
                fileDinhKemDienMat.MaDienMat = Convert.ToInt32(tbMaDienMat.Text);
            }
            catch
            {
                MessageBox.Show("Chưa điền thông tin số mật", "Thông báo");
                return;
            }
            string[] parts = new string[10];
            if (txtAttachedFileName.Text == "")
            {
                OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "(PDF file)|*.pdf|(Docx file)|*.docx" };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    parts = openFileDialog.FileName.Trim().Split('\\');
                    txtAttachedFileName.Text += parts[parts.Length - 1] + ";";
                    fileDinhKemDienMat.FileDinhKem = openFileDialog.FileName;
                    db.FileDinhKemDienMats.Add(fileDinhKemDienMat);
                    db.SaveChanges();
                }
            }
            else
            {

                if (!CommonFunction.checkExistForm("frmThemFileDinhKem", this))
                {
                    frmThemFileDinhKem frmThemFileDinhKem = new frmThemFileDinhKem(Convert.ToInt32(tbMaDienMat.Text));
                    frmThemFileDinhKem.MdiParent = this.MdiParent;
                    frmThemFileDinhKem.Show();
                }
                else
                {
                    CommonFunction.activateForm("frmThemFileDinhKem", this);
                }
                txtAttachedFileName.Text += parts[parts.Length - 1] + ";";
            }


        }

        private void btnRemoveAttachedFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAttachedFileName.Text))
            {
                return;
            }

            string[] parts = txtAttachedFileName.Text.Trim().Split(' ');
            int count = parts.Length;
            count--;
            txtAttachedFileName.Text = "";
            for (int i = 0; i < count; i++)
            {
                txtAttachedFileName.Text += parts[i];
            }
        }

        private void txt_Click(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;

            if (textBox == null) return;
            if (textBox.Equals(txtIncluding))
            {
                txtIncluding.Text = "";
            }
            if (textBox.Equals(tbDatChuKyTrang))
            {
                tbDatChuKyTrang.Text = "";
            }
            if (textBox.Equals(tbLeDuoiChuKy))
            {
                tbLeDuoiChuKy.Text = "";
            }
            if (textBox.Equals(tbSMTrangDuoi))
            {
                tbSMTrangDuoi.Text = "";
            }
            if (textBox.Equals(tbSMDinhKem))
            {
                tbSMDinhKem.Text = "";
            }
        }

        private void txtKeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || // Alphabe char
                 char.IsSymbol(e.KeyChar) || //Special char
                 char.IsWhiteSpace(e.KeyChar) || //Space
                 char.IsPunctuation(e.KeyChar)) //dot symbol               
            {
                e.Handled = true; // Khong cho nhap so
                MessageBox.Show("Vui lòng nhập số.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pdfViewer1.ZoomMode = PdfZoomMode.Custom;
            pdfViewer1.ZoomFactor += 16f;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pdfViewer1.ZoomMode = PdfZoomMode.Custom;
            pdfViewer1.ZoomFactor -= 16f;
        }
        public List<BiThu> listBiThu = new List<BiThu>();
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (checkOpenpdf)
            {

                var isMaDiemMat = true;
                var addDienMat = new DienMat();
                try
                {

                    addDienMat.MaDienMat = Convert.ToInt32(tbMaDienMat.Text);

                }
                catch
                {
                    MessageBox.Show("Chưa điền thông tin số điện", "Thông báo");
                    isMaDiemMat = false;
                    return;
                }
                try
                {
                    SMMgEntities db = new SMMgEntities();
                    var DienMatSelected = db.DienMats.Single(x => x.MaDienMat == addDienMat.MaDienMat);
                    if (DienMatSelected != null)
                    {

                        MessageBox.Show("Mã điện mật đã được sử dụng ", "Thông báo");
                        return;
                        goto het;
                    }
                }
                catch
                {

                }

                // luu thong tin vao dien mat da phan phoi(Table Dien Mat)
                if (isMaDiemMat)
                {
                    string timeSave = DateTime.Now.ToString("ddMMyyyyHHmm");
                    TuyChinh tuyChinh = new TuyChinh();
                    tuyChinh = db.TuyChinhs.Single(x => x.id == 1);
                    int countPdfSave = 0;
                    try
                    {
                        foreach (var pdf in listPdf)
                        {
                            pdf.SaveDocument(tuyChinh.LuuFile + "\\" + addDienMat.MaDienMat.ToString().Trim() + "_" + countPdfSave.ToString() + "_" + timeSave + ".pdf");
                            countPdfSave++;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Chọn đường dẫn lưu file trong tùy chỉnh", "Thông báo");
                        return;
                    }
                    //pdfViewer1.SaveDocument(tuyChinh.LuuFile + addDienMat.MaDienMat.ToString().Trim() + "_" + timeSave + ".pdf");

                    addDienMat.LuuFile = FileNameOpen;
                    //addDienMat.FileDinhKem=
                    addDienMat.NoiGui = cbxNoiGuiMD.Text;
                    addDienMat.TrichYeu = tbTrichYeu.Text;
                    addDienMat.DoMat = cbxPrivateFile.Text;
                    //addDienMat.DoMatFile= 
                    //addDienMat.SoBiThu=
                    addDienMat.Ngay = datetimeNgayLuu.Value;
                    addDienMat.GhiChu = tbGhiChu.Text;
                    addDienMat.NguoiDuyet = cbxNguoiDuyetMD.Text;
                    addDienMat.NguoiKy = cbxNguoiKiMD.Text;
                    addDienMat.ChucDanh = tbChucDanhMD.Text;
                    try
                    {
                        addDienMat.BanIn = noiNhanTemps.Count();
                    }
                    catch
                    {
                        addDienMat.BanIn = 0;
                    }

                    //chua xong
                    //var stream = new MemoryStream();
                    //addDienMat.ChuKy = Image.FromStream(stream);
                    try
                    {

                        var arrTenNoiNhanNoiBo = noiNhanNoiBo.Select(m => m.TenNoiNhan).ToArray();
                        addDienMat.DsNoiNhan = string.Join(",", arrTenNoiNhanNoiBo);

                    }
                    catch { }
                    addDienMat.NguoiIn = frmLogin.Username;
                    addDienMat.Trang = pdfViewer1.PageCount;
                    db.DienMats.Add(addDienMat);
                    db.SaveChanges();
                    //luu xong vao dien mat da phan phoi

                    //Luu thong tin vao bi thu

                    var biThu = new BiThu();
                    biThu.Ngay = datetimeNgayLuu.Value;
                    biThu.DanhSachDienMat = addDienMat.MaDienMat.ToString().Trim();
                    biThu.KiNhan = addDienMat.NguoiKy;
                    try
                    {
                        var NoiGuiSelect = db.NoiGuis.Single(x => x.Ten == cbxNoiGuiMD.Text);
                        biThu.SoPhieu = NoiGuiSelect.id.ToString();
                    }
                    catch
                    {

                        MessageBox.Show("Nơi gửi chưa được chọn", "Thông báo");
                        return;
                    }
                    try
                    {

                        var arrTenNoiNhanNgoaiBo = noiNhanNgoaiBo.Select(m => m.TenNoiNhan).ToArray();
                        int soBiThu = arrTenNoiNhanNgoaiBo.Count();
                        string themMaDienMat = "";

                        BiThu xetBiThu = new BiThu();
                        foreach (var noiNhan in arrTenNoiNhanNgoaiBo)
                        {
                            /*"Model.Where(a => a.ReviewID == item.Key).Single().Review.PersonID"*/
                            //BiThu xetBiThu = db.BiThus.SingleOrDefault(x => x.TenNoiNhan == noiNhan);
                            try
                            {
                                xetBiThu = db.BiThus.Single(x => x.TenNoiNhan == noiNhan);
                            }
                            catch
                            {
                            }
                            if (xetBiThu.id == 0)
                            {
                                biThu.TenNoiNhan = noiNhan;
                                biThu.TongSo = 1;

                                db.BiThus.Add(biThu);
                                db.SaveChanges();
                            }
                            else
                            {
                                themMaDienMat = xetBiThu.DanhSachDienMat + ',' + addDienMat.MaDienMat.ToString().Trim();
                                db.Database.ExecuteSqlCommand(" update BiThu set DanhSachDienMat={0} where TenNoiNhan={1}", themMaDienMat, noiNhan);

                                db.Database.ExecuteSqlCommand(" update BiThu set TongSo={0} where TenNoiNhan={1}", xetBiThu.TongSo + 1, noiNhan);
                                db.SaveChanges();
                            }
                        }
                    }
                    catch { }

                    //luu thong tin bi thu xong :>

                    //luu thong tin vao kiem chung dien
                    KiemChungDien kiemChungDien = new KiemChungDien();
                    try
                    {
                        foreach (var item in noiNhanTemps)
                        {
                            try
                            {
                                kiemChungDien = db.KiemChungDiens.Single(x => x.TenNoiNhan == item.TenNoiNhan);
                            }
                            catch
                            {

                            }
                            if (kiemChungDien.id == 0)
                            {

                                kiemChungDien.TenNoiNhan = item.TenNoiNhan;
                                kiemChungDien.DanhSachDien = Convert.ToInt32(tbMaDienMat.Text).ToString().Trim();
                                kiemChungDien.TongSoTrang = pdfViewer1.PageCount;
                                kiemChungDien.SoLuongDien = 1;
                                kiemChungDien.NgayIn = datetimeNgayLuu.Value;
                                db.KiemChungDiens.Add(kiemChungDien);
                                db.SaveChanges();
                            }
                            else
                            {
                                var themDanhSachDien = kiemChungDien.DanhSachDien + ',' + Convert.ToInt32(tbMaDienMat.Text).ToString().Trim();
                                db.Database.ExecuteSqlCommand("update KiemChungDien set DanhSachDien={0} where TenNoiNhan={1}", themDanhSachDien, item.TenNoiNhan);
                                db.Database.ExecuteSqlCommand("update KiemChungDien set TongSoTrang={0} where TenNoiNhan={1}", kiemChungDien.TongSoTrang + pdfViewer1.PageCount, item.TenNoiNhan);
                                db.Database.ExecuteSqlCommand("update KiemChungDien set SoLuongDien={0} where TenNoiNhan={1}", kiemChungDien.SoLuongDien + 1, item.TenNoiNhan);
                                //if(DateTime.Compare(DateTime.Parse(kiemChungDien.NgayIn.ToString()), datetimeNgayLuu.Value) < 0)
                                //{
                                //    db.Database.ExecuteSqlCommand("update KiemChungDien set SoLuongDien={0} where TenNoiNhan={1}", kiemChungDien.SoLuongDien + 1, item.TenNoiNhan);
                                //}
                                db.SaveChanges();

                            }
                        }
                    }
                    catch { }

                }
            }
            else
            {
                MessageBox.Show("Mở tập tin điện mật", "Thông báo");
                return;
            }
            // da luu thong tin vao kiem chung dien
            MessageBox.Show("Đã lưu điện mật", "Thông báo");
        het:
            return;
        }

        //private void btnPreview_Click(object sender, EventArgs e)
        //{
        //    //try
        //    //{
        //    //    if (openNewpdf)
        //    //    {
        //    //        //db.Database.ExecuteSqlCommand("delete from NoiNhanTemp", new object[] { });

        //    //    }

        //    //}
        //    //catch { }
        //     NoiNhanTemp item = null;
        //    listDrawNoiNhanTemp.Clear();
        //    gridViewNoiNhanTemp.SelectAll();
        //    var rows = gridViewNoiNhanTemp.GetSelectedRows(); 
        //    foreach (var a in rows)
        //    {
        //        item = (NoiNhanTemp)gridViewNoiNhanTemp.GetRow(a);
        //        listDrawNoiNhanTemp.Add(item);

        //    }
        //    if (listDrawNoiNhanTemp.Count c> 0)
        //    {

        //        if (listDrewNoiNhanTemp.Count>0)
        //        {
        //            // xoa het cac item da add
        //            listDrawNoiNhanTemp.RemoveAll(m => listDrewNoiNhanTemp.Any(m2 => m2.id == m.id));
        //        }
        //        else
        //        {
        //            // tao moi lan dau tien
        //            listDrewNoiNhanTemp = new List<NoiNhanTemp>();
        //        }
        //        // them cac item da add vao list preview de luu :3 cho lan sau xoa
        //        //listDrewNoiNhanTemp.AddRange(listDrawNoiNhanTemp);


        //        // done
        //        DrawingNoiNhanTemp(listDrawNoiNhanTemp);


        //    }


        //}
        private void btnPreview_Click(object sender, EventArgs e)
        {
            NoiNhanTemp item = null;
            listDrawNoiNhanTemp.Clear();
            gridViewNoiNhanTemp.SelectAll();
            var rows = gridViewNoiNhanTemp.GetSelectedRows();

            //MemoryStream stream = new MemoryStream();

            //using (PdfDocumentProcessor processor = new PdfDocumentProcessor())
            //{
            //    processor.LoadDocument(FileNameOpen);
            //    using (PdfGraphics graphics = processor.CreateGraphics())
            //    {
            //        { //In anh chu ky 
            //            NguoiKy nguoiKy = new NguoiKy();
            //            nguoiKy = db.NguoiKies.Single(x => x.TenNguoiKy == cbxNguoiKiMD.Text);
            //            MemoryStream streamChuKy = new MemoryStream(nguoiKy.ChuKy);
            //            CommonFunction.InVungChuKy(processor, graphics, 150, 700, new Bitmap(streamChuKy),nguoiKy);
            //            graphics.AddToPageForeground(processor.Document.Pages[0], 72, 72);
            //        }
            //    }

            //    CommonFunction.AddWatermark("10", processor);

            //    processor.SaveDocument(stream);
            //    pdfViewer1.LoadDocument(stream);
            //}

            foreach (var a in rows)
            {
                item = (NoiNhanTemp)gridViewNoiNhanTemp.GetRow(a);
                listDrawNoiNhanTemp.Add(item);

            }
            if (listDrawNoiNhanTemp.Count > 0)
            {
                DrawingNoiNhanTemp(listDrawNoiNhanTemp);
            }
            else
            {
                { //in vung chu ky
                    PdfDocumentProcessor processor = new PdfDocumentProcessor();
                   
                    try
                    {
                        processor.LoadDocument(FileNameOpen);//lay pdf de xu li
                    }
                    catch
                    { 
                        processor.LoadDocument(FileStreamOpen);
                    }
                    using (PdfGraphics graphics = processor.CreateGraphics())
                    {

                        NguoiKy nguoiKy = db.NguoiKies.Single(x => x.TenNguoiKy == cbxNguoiKiMD.Text);
                        MemoryStream anhChuKy = new MemoryStream(nguoiKy.ChuKy);
                        //CommonFunction.InVungChuKy(processor, graphics, new Bitmap(anhChuKy), nguoiKy);
                        //graphics.AddToPageForeground(processor.Document.Pages[0], 72, 72);
                        if (tbDatChuKyTrang.Text == "0")
                        {

                        }
                        else if (pdfViewer1.PageCount >= int.Parse(tbDatChuKyTrang.Text))
                        {
                            MemoryStream ms2 = new MemoryStream();
                            CommonFunction.InVungChuKy(processor, graphics, new Bitmap(anhChuKy), nguoiKy, int.Parse(tbDatChuKyTrang.Text) - 1);
                            graphics.AddToPageForeground(processor.Document.Pages[int.Parse(tbDatChuKyTrang.Text) - 1], 72, 72);
                            processor.SaveDocument(ms2);
                            pdfViewer1.LoadDocument(ms2);
                        }
                        else
                        {
                            MessageBox.Show(string.Format("Trang tối đa hiện có thể là {0}", (pdfViewer1.PageCount).ToString(), "Thông báo"));
                            return;
                        }
                    }
                }
            }


        }

        private void chbPrint_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtAllignBottomIncludedSM_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        SMMgEntities db = new SMMgEntities();
        private void btnAddPlaceOfSending_Click(object sender, EventArgs e)
        {

            if (!CommonFunction.checkExistForm("frmAddPrinting", this))
            {
                frmAddPrinting frmAdd = new frmAddPrinting(() =>
                {
                    gridControl1.DataSource = db.NoiNhanTemps.ToList();
                    gridControl1.RefreshDataSource();
                    return false;
                });/**/

                //frmAdd.OnSubmitForm += OnSubmitNguoiNhan;
                frmAdd.ShowDialog();

            }
            else
            {
                CommonFunction.activateForm("frmAddPrinting", this);
            }
        }
        //public void OnSubmitNguoiNhan(List<NoiNhanTemp> list)
        //{

        //    DrawingNoiNhanTemp(list);
        //}

        private void gridControl1_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.NoiNhanTemps.ToList();
            gridControl1.RefreshDataSource();


        }

        private void btnRemovePlaceOfSending_Click(object sender, EventArgs e)
        {
            NoiNhanTemp noiNhanTemp = new NoiNhanTemp();
            try
            {

                noiNhanTemp.id = int.Parse(gridViewNoiNhanTemp.GetRowCellValue(gridViewNoiNhanTemp.FocusedRowHandle, "id").ToString());

            }
            catch
            {

            }
            deleteNoiNhanTemp(noiNhanTemp);
            void deleteNoiNhanTemp(NoiNhanTemp x)
            {
                NoiNhanTemp p = db.NoiNhanTemps.Find(x.id);
                db.NoiNhanTemps.Remove(p);
                db.SaveChanges();
            }
            MessageBox.Show("Đã Xóa", "Thông báo");
            gridControl1_Load(sender, e);
        }
        static void DrawImage(PdfGraphics graphics, float x, float y)
        {
            SMMgEntities db = new SMMgEntities();
            NguoiKy defaultNguoiKy = db.NguoiKies.SingleOrDefault(m => m.MacDinh == true);
            var stream = new MemoryStream(defaultNguoiKy.ChuKy);
            using (Image image = Image.FromStream(stream))
            {
                float width = image.Width;
                float height = image.Height;
                graphics.DrawImage(image, new RectangleF(x, y, width / 2, height / 2));
            }
        }

        private void gridViewNoiNhanTemp_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            CommonFunction.gridView_CustomDrawRowIndicator(sender, e, gridViewNoiNhanTemp);
        }

        private void cbxNguoiKiMD_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                SMMgEntities db = new SMMgEntities();
                NguoiKy SelectedNguoiKy = db.NguoiKies.SingleOrDefault(m => m.id == (int)cbxNguoiKiMD.SelectedValue);
                tbChucDanhMD.Text = SelectedNguoiKy.ChucDanh;
                var stream = new MemoryStream(SelectedNguoiKy.ChuKy);
                pbChuKiMD.Image = Image.FromStream(stream);
                pbChuKiMD.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch { }

        }
    }
}
