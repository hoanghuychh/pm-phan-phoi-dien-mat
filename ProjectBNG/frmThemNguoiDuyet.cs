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
    public partial class frmThemNguoiDuyet : Form
    {
        Func<bool> onSubmit;
        public frmThemNguoiDuyet(Func<bool> onSub)
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
            var nguoiDuyet = new NguoiDuyet();
            nguoiDuyet.TenNguoiDuyet = tbTenNguoiDuyet.Text;
            nguoiDuyet.MacDinh = cbMacDinh.Checked;

            MemoryStream fileImageSave = new MemoryStream();
            try
            {
                pbChuKy.Image.Save(fileImageSave, ImageFormat.Bmp);
            }
            catch { }
            nguoiDuyet.ChuKy = fileImageSave.ToArray();
            fileImageSave.Dispose();
            if (nguoiDuyet.MacDinh == true)
            {
                db.Database.ExecuteSqlCommand("update  NguoiDuyet set MacDinh = 0 ");
            }
            db.NguoiDuyets.Add(nguoiDuyet);
            db.SaveChanges();
            this.onSubmit.Invoke();
            MessageBox.Show("Thêm thông tin người duyệt thành công ", "Thông báo");
            this.Close();
        }

        private void tbChuKy_TextChanged(object sender, EventArgs e)
        {

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
                    pbChuKy.Image = new Bitmap(openFileDialog.FileName);


                    pbChuKy.SizeMode = PictureBoxSizeMode.StretchImage;


                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error image load");
            }
        }
    }
}
