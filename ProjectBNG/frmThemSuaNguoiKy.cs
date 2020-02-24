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
using ProjectBNG.Models;

namespace ProjectBNG
{
    public partial class frmThemSuaNguoiKy : Form
    {
        public frmThemSuaNguoiKy()
        {
            InitializeComponent();
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
            //nguoiKy.ChuKy=
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";
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
