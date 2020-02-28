using ProjectBNG.Models;
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

namespace ProjectBNG
{
    public partial class frmSuaNguoiDuyet : Form
    {

        Func<bool> onSubmit;
        NguoiDuyet selectNguoiDuyet;
        SMMgEntities db = new SMMgEntities();
        public frmSuaNguoiDuyet(Func<bool> onSub,NguoiDuyet nguoiDuyet)
        {
            InitializeComponent();
            this.onSubmit = onSub;
            selectNguoiDuyet = nguoiDuyet;
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.PNG)|*.PNG| ALL files(*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tbChuKy.Text = openFileDialog.FileName;
                pbChuKy.Image = new Bitmap(openFileDialog.FileName);
                pbChuKy.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NguoiDuyet updateNguoiDuyet = db.NguoiDuyets.SingleOrDefault(x => x.id == selectNguoiDuyet.id);

            updateNguoiDuyet.TenNguoiDuyet = tbTenNguoiDuyet.Text;
            updateNguoiDuyet.MacDinh = cbMacDinh.Checked;

            MemoryStream stream = new MemoryStream();
            try
            {
                pbChuKy.Image.Save(stream, ImageFormat.Bmp);
            }
            catch { }
            db.SaveChanges();
            MessageBox.Show("Thông tin người duyệt đã được thay đổi", "Thông báo");
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSuaNguoiDuyet_Load(object sender, EventArgs e)
        {
            NguoiDuyet loadNguoiDuyet = db.NguoiDuyets.SingleOrDefault(x => x.id == selectNguoiDuyet.id);
            tbTenNguoiDuyet.Text = loadNguoiDuyet.TenNguoiDuyet;
            cbMacDinh.Checked = loadNguoiDuyet.MacDinh.HasValue;
            var stream = new MemoryStream(loadNguoiDuyet.ChuKy);
            pbChuKy.Image = Image.FromStream(stream);
            pbChuKy.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
