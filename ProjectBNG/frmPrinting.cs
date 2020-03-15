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
        static public bool checkOpenpdf = false;
        static public float dpiDefault = 0;
        static public string FileName;
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
        //            processor.LoadDocument(FileName);//lay pdf de xu li
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

            MemoryStream pdfStream = new MemoryStream();
            MemoryStream ms2 = new MemoryStream();

            noiNhanTemps = n;
            noiNhanNoiBo = new List<NoiNhanTemp>();
            noiNhanNgoaiBo = new List<NoiNhanTemp>();

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
                PdfDocumentProcessor processor = new PdfDocumentProcessor();
                y = 250;
                processor.LoadDocument(FileName);//lay pdf de xu li
                foreach (var a in noiNhanNoiBo)
                {
                    using (SolidBrush textBrush = new SolidBrush(Color.FromArgb(0, 0, 0)))
                    {
                        AddGraphics(processor, "- " + a.TenNoiNhan, textBrush, x, y);
                        //DrawGraphics();
                    }
                    y += 20;
                }
                //preview chu ky
                using (PdfGraphics graphics = processor.CreateGraphics())
                {
                    DrawImage(graphics, 100, 700);
                    if (pdfViewer1.PageCount >= int.Parse(tbDatChuKyTrang.Text)-1)
                    {

                        graphics.AddToPageForeground(processor.Document.Pages[int.Parse(tbDatChuKyTrang.Text)-1], 72, 72);
                    }
                    else
                    {
                        MessageBox.Show("Trang tối đa hiện có thể là {0}", pdfViewer1.PageCount.ToString());
                    }
                }
                var NoiGuiSelection = db.NoiGuis.Single(x => x.Ten == cbxNoiGuiMD.Text);
                //watermark id noi gui
                CommonFunction.AddWatermark(NoiGuiSelection.id.ToString(),processor);
                    //fix exception throw :devexpress...
                    processor.SaveDocument(ms2);
                ms2.WriteTo(pdfStream);
                pdfViewer1.LoadDocument(ms2);

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
            cbxPrivateAttachedFile.Items.Add("Rõ");
            cbxPrivateAttachedFile.Items.Add("Mật");
            cbxPrivateAttachedFile.Items.Add("TM");
            cbxPrivateAttachedFile.Items.Add("Tuyệt mật");
            cbxPrivateAttachedFile.SelectedItem = cbxPrivateAttachedFile.Items[1];

            db.Database.ExecuteSqlCommand("delete from NoiNhanTemp", new object[] { });

            cbxNoiGuiMD.DataSource = db.NoiGuis.ToList();
            cbxNoiGuiMD.ValueMember = "id";
            cbxNoiGuiMD.DisplayMember = "Ten";

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

            tbDatChuKyTrang.Text = "1";

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
            using (OpenFileDialog ofd = new OpenFileDialog() { ValidateNames = true, Multiselect = false, Filter = "PDF Files(*.PDF)|*.PDF|All Files(*.*)|*.*" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {

                        pdfViewer1.LoadDocument(ofd.FileName);SizeF currentPageSize = pdfViewer1.GetPageSize(pdfViewer1.CurrentPageNumber);
                    float dpi = 110f;
                    float pageHeightPixel = currentPageSize.Height * dpi;
                    float topBottomOffset = 40f;
                    pdfViewer1.ZoomMode = PdfZoomMode.Custom;
                    pdfViewer1.ZoomFactor = ((float)pdfViewer1.ClientSize.Height - topBottomOffset) / pageHeightPixel * 100f;
                    dpiDefault = ((float)pdfViewer1.ClientSize.Height - topBottomOffset) / pageHeightPixel * 100f;
                    FileName = ofd.FileName;
                    tbFileNameDienMat.Text = FileName;
                    checkOpenpdf = true;
                    }
                    catch
                    {
                        MessageBox.Show("File được chọn không đúng định dạng", "Thông báo");
                    }
                    //chinh pdf vua khung 
                    
                }

            }
            if (listDrewNoiNhanTemp.Count > 0)
                listDrewNoiNhanTemp.Clear();
        }

        static void AddGraphics(PdfDocumentProcessor processor, string text, SolidBrush textBrush, float x, float y)
        {
            IList<PdfPage> pages = processor.Document.Pages;
            for (int i = 0; i < pages.Count; i++)
            {
                PdfPage page = pages[i];
                using (PdfGraphics graphics = processor.CreateGraphics())
                {
                    SizeF actualPageSize = PrepareGraphics(page, graphics);
                    using (Font font = new Font("Times New Roman", 12, FontStyle.Regular))
                    {
                        SizeF textSize = graphics.MeasureString(text, font, PdfStringFormat.GenericDefault);
                        PointF topLeft = new PointF(x, y);
                        //PointF bottomRight = new PointF(actualPageSize.Width - textSize.Width, actualPageSize.Height - textSize.Height);
                        graphics.DrawString(text, font, textBrush, topLeft);
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
            OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "(Docx file)|*.docx|(PDF file)|*.pdf" };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] parts = openFileDialog.FileName.Trim().Split('\\');
                txtAttachedFileName.Text += parts[parts.Length - 1] + "; ";
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
                }

                // luu dien mat vao dien mat da phan phoi
                if (isMaDiemMat)
                {
                    string timeSave = DateTime.Now.ToString("ddMMyyyyHHmm");
                    TuyChinh tuyChinh = new TuyChinh();
                    tuyChinh = db.TuyChinhs.Single(x => x.id == 1);
                    pdfViewer1.SaveDocument(tuyChinh.LuuFile + addDienMat.MaDienMat.ToString().Trim() + "_" + timeSave + ".pdf");

                    addDienMat.LuuFile = tuyChinh.LuuFile + addDienMat.MaDienMat.ToString().Trim() + "_" + timeSave + ".pdf";
                    //addDienMat.FileDinhKem=
                    addDienMat.NoiGui = cbxNoiGuiMD.Text;
                    addDienMat.TrichYeu = tbTrichYeu.Text;
                    addDienMat.DoMat = cbxPrivateFile.Text;
                    //addDienMat.DoMatFile=

                    addDienMat.Ngay = datetimeNgayLuu.Value;
                    addDienMat.GhiChu = tbGhiChu.Text;
                    addDienMat.NguoiDuyet = cbxNguoiDuyetMD.Text;
                    addDienMat.NguoiKy = cbxNguoiKiMD.Text;
                    addDienMat.ChucDanh = tbChucDanhMD.Text;
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
                    var NoiGuiSelect=db.NoiGuis.Single(x => x.Ten == cbxNoiGuiMD.Text);
                    biThu.SoPhieu = NoiGuiSelect.id;
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

                    // da luu thong tin vao kiem chung dien
                    MessageBox.Show("Đã lưu điện mật", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Mở tập tin điện mật", "Thông báo");
            }
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
        //    if (listDrawNoiNhanTemp.Count > 0)
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
            foreach (var a in rows)
            {
                item = (NoiNhanTemp)gridViewNoiNhanTemp.GetRow(a);
                listDrawNoiNhanTemp.Add(item);

            }
            if (listDrawNoiNhanTemp.Count > 0)
            {
                DrawingNoiNhanTemp(listDrawNoiNhanTemp);
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
