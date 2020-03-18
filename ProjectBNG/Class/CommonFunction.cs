using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.ComponentModel;
using System.Windows.Forms;
using System.Data.Entity;
using ProjectBNG.Class;
using DevExpress.Pdf;
using System.Drawing;
using ProjectBNG;
using ProjectBNG.Models;
using System.Diagnostics;

namespace ProjectBNG.Class
{
    class CommonFunction
    {
        const float DrawingDpi = 72f;
        SMMgEntities db = new SMMgEntities();
        public static bool checkExistForm(string name, Form form)
        {
            bool check = false;
            foreach (Form newForm in form.MdiChildren)
            {
                if (newForm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        public static void activateForm(string name, Form form)
        {
            foreach (Form newForm in form.MdiChildren)
            {
                if (newForm.Name == name)
                {
                    newForm.Activate();
                    break;
                }
            }
        }
        public static bool cal(int _Width, GridView _View)
        {
            _View.IndicatorWidth = _View.IndicatorWidth < _Width ? _Width : _View.IndicatorWidth;
            return true;
        }

        public static void gridView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e, GridView gridView)
        {
            if (!gridView.IsGroupRow(e.RowHandle)) //Nếu không phải là Group
            {
                if (e.Info.IsRowIndicator) //Nếu là dòng Indicator
                {
                    if (e.RowHandle < 0)
                    {
                        e.Info.ImageIndex = 0;
                        e.Info.DisplayText = string.Empty;
                    }
                    else
                    {
                        e.Info.ImageIndex = -1; //Không hiển thị hình
                        e.Info.DisplayText = (e.RowHandle + 1).ToString(); //Số thứ tự tăng dần
                    }

                    //hàm này dùng thay đổi độ rộng mặc định của cột số thứ tự
                    var _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                    var _Width = Convert.ToInt32(_Size.Width) + 20;
                    //Control.BeginInvoke(new MethodInvoker(delegate { cal(_Width, gridView); }));
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", e.RowHandle * -1); //Nhân -1 để đánh lại số thứ tự tăng dần
                var _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                var _Width = Convert.ToInt32(_Size.Width) + 20;
                //BeginInvoke(new MethodInvoker(delegate { cal(_Width, gridView); }));
            }
        }

        public static void AddWatermark(string text, PdfDocumentProcessor documentProcessor)
        {
            SMMgEntities db = new SMMgEntities();
            TuyChinh tuyChinh = new TuyChinh();
            tuyChinh = db.TuyChinhs.Single(x => x.id == 1);

            string fontName = "Times New Roman";
            float fontSize = (float)tuyChinh.DauChimFont;
            PdfStringFormat stringFormat = PdfStringFormat.GenericTypographic;
            stringFormat.Alignment = PdfStringAlignment.Center;
            stringFormat.LineAlignment = PdfStringAlignment.Center;
            using (SolidBrush brush = new SolidBrush(Color.FromArgb((int)(tuyChinh.DauChimOpacity * 255), Color.FromArgb(int.Parse(tuyChinh.DauChimMauPdf.ToString())))))
            {
                using (Font font = new Font(fontName, fontSize))
                {
                    foreach (var page in documentProcessor.Document.Pages)
                    {
                        var watermarkSize = page.CropBox.Width;
                        using (PdfGraphics graphics = documentProcessor.CreateGraphics())
                        {
                            SizeF stringSize = graphics.MeasureString(text, font);
                            Single scale = Convert.ToSingle(watermarkSize / tuyChinh.DauChimRong);
                            graphics.TranslateTransform(Convert.ToSingle(tuyChinh.DauChimRong * 28.34645669291339), Convert.ToSingle(tuyChinh.DauChimCao * 28.34645669291339));
                            Debug.WriteLine(page.CropBox.Width);

                            graphics.RotateTransform(0);
                            graphics.TranslateTransform(Convert.ToSingle(-stringSize.Width * scale * 0.5), Convert.ToSingle(-stringSize.Height * scale * 0.5));
                            using (Font actualFont = new Font(fontName, (float)tuyChinh.DauChimFont))
                            {
                                RectangleF rect = new RectangleF(0, 0, stringSize.Width * scale, stringSize.Height * scale);
                                graphics.DrawString(text, actualFont, brush, rect, stringFormat);
                            }

                            graphics.AddToPageForeground(page, 72, 72);
                        }
                    }
                }
            }
        }
        public static void InVungChuKy(PdfDocumentProcessor processor, PdfGraphics graphics, Bitmap bitmap, NguoiKy nguoiKy,int inTrang)
        {
            SMMgEntities db = new SMMgEntities();

            TuyChinh tuyChinh = new TuyChinh();
            tuyChinh = db.TuyChinhs.Single(tc => tc.id == 1);
            int ngay = DateTime.Now.Day;
            int thang = DateTime.Now.Month;
            int nam = DateTime.Now.Year;
            string tieuDe = tuyChinh.TieuDe.ToString().Trim() + string.Format(", ngày {0} tháng {1} năm {2}", ngay, thang, nam);

            float dong1rong = (float)(tuyChinh.VungCkRong * 28.34645669291339);
            float dong1cao = (float)(tuyChinh.VungCkCao * 28.34645669291339);
            float dong2rong = (float)(tuyChinh.VungCkRong * 28.34645669291339) - 70;
            float dong2cao = (float)(tuyChinh.VungCkCao * 28.34645669291339) + 20;
            float vitriChukyRong = (float)(tuyChinh.VungCkRong * 28.34645669291339);
            float vitriChukyCao = (float)(tuyChinh.VungCkCao * 28.34645669291339) + 40 + (float)(tuyChinh.AnhCkCao1 * 28.34645669291339) / 2;
            float ChuKyRong = (float)(tuyChinh.AnhCkRong1 * 28.34645669291339);
            float ChuKyCao = (float)(tuyChinh.AnhCkCao1 * 28.34645669291339);
            float dong3rong = (float)(tuyChinh.VungCkRong * 28.34645669291339) + 10;
            float dong3cao = (float)(tuyChinh.VungCkCao * 28.34645669291339) + 60 + (float)(tuyChinh.AnhCkCao1 * 28.34645669291339);

            using (SolidBrush textBrush = new SolidBrush(Color.FromArgb(0, 0, 0)))
            {
                AddGraphics(processor, tieuDe, 10, textBrush, dong1rong, dong1cao,inTrang);
                AddGraphics(processor, nguoiKy.ChucDanh, 10, textBrush, dong2rong, dong2cao, inTrang);
            }
            using (Bitmap image = bitmap)
            {
                graphics.DrawImage(image, new RectangleF(vitriChukyRong, vitriChukyCao, ChuKyRong, ChuKyCao));
            }
            using (SolidBrush textBrush = new SolidBrush(Color.FromArgb(0, 0, 0)))
            {
                AddGraphics(processor, nguoiKy.TenNguoiKy, 10, textBrush, dong3rong, dong3cao, inTrang);
            }
            Debug.WriteLine("Dong 1 rong " + dong1rong);
            Debug.WriteLine("Dong 1 cao " + dong1cao);
            Debug.WriteLine("Dong 2 rong " + dong2rong);
            Debug.WriteLine("Dong 2 cao " + dong2cao);
            Debug.WriteLine("Vi tri chu ky rong " + vitriChukyRong);
            Debug.WriteLine("Vi tri chu ky cao " + vitriChukyCao);
            Debug.WriteLine("Chu ky rong " + ChuKyRong);
            Debug.WriteLine("Chu ky cao " + ChuKyCao);
            Debug.WriteLine("Dong 3 rong " + dong3rong);
            Debug.WriteLine("Dong 3 cao " + dong3cao);
        }

        public static void AddGraphics(PdfDocumentProcessor processor, string text, int fontSize, SolidBrush textBrush, float x, float y,int InTrang)
        {
            IList<PdfPage> pages = processor.Document.Pages;
                PdfPage page = pages[InTrang];
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
        public static SizeF PrepareGraphics(PdfPage page, PdfGraphics graphics)
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
    }

}