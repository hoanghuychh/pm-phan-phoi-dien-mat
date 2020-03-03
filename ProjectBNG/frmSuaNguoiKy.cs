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
    public partial class frmSuaNguoiKy : Form
    {
        Func<bool> onSubmit;
        NguoiKy nguoiKy;
        public frmSuaNguoiKy(Func<bool> onSub, NguoiKy nguoiKy)
        {
            InitializeComponent();
            this.onSubmit = onSub;
            this.nguoiKy = nguoiKy;
        }
        SMMgEntities db = new SMMgEntities();
        
        private bool checkExistForm(string name)
        {
            bool check = false;
            foreach(Form form in this.MdiChildren)
            {
                if (form.Name == name)
                {
                    check = true;
                    break;
                }
                
            }
            return check;
        }
        private void activateChildForm(string name)
        {
            foreach(Form form in this.MdiChildren)
            {
                if (form.Name == name)
                {
                    form.Activate();
                    break;
                }
            }
        }

        public void frmSuaNguoiKy_Load(object sender, EventArgs e)
        { 
            
            tbTenNguoiKy.Text = nguoiKy.TenNguoiKy;
            tbChucDanh.Text = nguoiKy.ChucDanh;
            cbMacDinh.Checked = nguoiKy.MacDinh==true;
            var fileImage = new MemoryStream(nguoiKy.ChuKy);
            pbxChuKy.Image = Image.FromStream(fileImage);
            pbxChuKy.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        //public object getIdSelect(NguoiKy nguoiKy)
        //{
        //    return nguoiKy.id;
        //}
         
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            SMMgEntities db = new SMMgEntities();
            NguoiKy updateNguoiKy = db.NguoiKies.SingleOrDefault(x => x.id == nguoiKy.id);
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
            if (updateNguoiKy.MacDinh == true)
            {
                db.Database.ExecuteSqlCommand("update  NguoiKy set MacDinh = 0 where id != {0}", new object[] { nguoiKy.id });
                updateNguoiKy.MacDinh = true;
            }
            db.SaveChanges();
            this.onSubmit.Invoke();
            MessageBox.Show("Thông tin người ký đã được thay đổi ", "Thông báo");
            this.Close();
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.PNG)|*.PNG| ALL files(*.*)|*.*";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    tbChuKy.Text = openFile.FileName;
                    pbxChuKy.Image = new Bitmap(openFile.FileName);
                    pbxChuKy.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch
            {

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
