using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectBNG.Models;

namespace ProjectBNG
{
    public partial class frmThemNguoiKy : Form
    {
        Func<bool> onSubmit;
        public frmThemNguoiKy(Func<bool> onSub)
        {
            InitializeComponent();
            this.onSubmit = onSub;
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SMMgEntities db = new SMMgEntities();
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            var nguoiKy = new NguoiKy();
            nguoiKy.TenNguoiKy = tbTenNguoiKy.Text;
            nguoiKy.ChucDanh = tbChucDanh.Text;
            nguoiKy.MacDinh = cbMacDinh.Checked;
          
            MemoryStream fileImageSave = new MemoryStream();
            try
            {
                pbxChuKy.Image.Save(fileImageSave, ImageFormat.Bmp);
            }
            catch { }
            nguoiKy.ChuKy = fileImageSave.ToArray();
            fileImageSave.Dispose();

            if (nguoiKy.MacDinh == true)
            {
                db.Database.ExecuteSqlCommand("update  NguoiKy set MacDinh = 0 ");
            }

            db.NguoiKies.Add(nguoiKy);
            db.SaveChanges();
            this.onSubmit.Invoke();
            MessageBox.Show("Thêm thông tin người ký thành công ", "Thông báo");
            this.Close();
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "PNG files(*.png)|*.png| jpg files(*.jpg)|*.jpg|  All files(*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tbChuKy.Text = openFileDialog.FileName;
                    pbxChuKy.Image = new Bitmap(openFileDialog.FileName);
                    
                   
                    pbxChuKy.SizeMode = PictureBoxSizeMode.StretchImage;
                   
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error image load");
            }
        }
    }
}
