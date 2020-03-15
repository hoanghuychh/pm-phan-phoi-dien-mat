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

namespace ProjectBNG.Class
{
    class CommonFunction
    {
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

        public static void gridView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e,GridView gridView)
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
            tuyChinh = db.TuyChinhs.Single(x => x.id ==1);
            
            string fontName = "Times New Roman";
            float fontSize = (float)tuyChinh.DauChimFont;
            PdfStringFormat stringFormat = PdfStringFormat.GenericTypographic;
            stringFormat.Alignment = PdfStringAlignment.Center;
            stringFormat.LineAlignment = PdfStringAlignment.Center;
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(int.Parse(tuyChinh.DauChimOpacity.ToString()), Color.FromArgb(int.Parse(tuyChinh.DauChimMauPdf.ToString())))))
            {
                using (Font font = new Font(fontName, fontSize))
                {
                    foreach (var page in documentProcessor.Document.Pages)
                    {
                        var watermarkSize = page.CropBox.Width * tuyChinh.DauChimFont;
                        using (PdfGraphics graphics = documentProcessor.CreateGraphics())
                        {
                            SizeF stringSize = graphics.MeasureString(text, font);
                            Single scale = Convert.ToSingle(watermarkSize / tuyChinh.DauChimRong);
                            graphics.TranslateTransform(Convert.ToSingle(page.CropBox.Width * 0.5), Convert.ToSingle(page.CropBox.Height * 0.5));
                            graphics.RotateTransform(-45);
                            graphics.TranslateTransform(Convert.ToSingle(-tuyChinh.DauChimRong * scale * 0.5), Convert.ToSingle(-tuyChinh.DauChimCao * scale * 0.5));
                            using (Font actualFont = new Font(fontName, fontSize * scale))
                            {
                                RectangleF rect = new RectangleF(0, 0, (float)tuyChinh.DauChimRong * scale, (float)tuyChinh.DauChimCao * scale);
                                graphics.DrawString(text, actualFont, brush, rect, stringFormat);
                            }

                            graphics.AddToPageForeground(page, 72, 72);
                        }
                    }
                }
            }
        }
    }

}
