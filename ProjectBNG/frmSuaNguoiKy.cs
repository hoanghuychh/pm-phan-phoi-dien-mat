using ProjectBNG.Models;
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
        
        public void frmSuaNguoiKy_Load(object sender, EventArgs e)
        { 
            
           

            tbTenNguoiKy.Text = nguoiKy.TenNguoiKy;
            tbChucDanh.Text = nguoiKy.ChucDanh;
            cbMacDinh.Checked = nguoiKy.MacDinh.HasValue;
            var fileImage = new MemoryStream(nguoiKy.ChuKy);

            pbxChuKy.Image = Image.FromStream(fileImage);
        }
        //public object getIdSelect(NguoiKy nguoiKy)
        //{
        //    return nguoiKy.id;
        //}
         
        private void btnCapNhat_Click(object sender, EventArgs e)
        {

            this.onSubmit.Invoke();
        }
    }
}
