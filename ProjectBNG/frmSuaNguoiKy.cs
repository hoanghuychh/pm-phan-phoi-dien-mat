using ProjectBNG.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectBNG
{
    public partial class frmSuaNguoiKy : Form
    {
        Func<bool> onSubmit;
        public frmSuaNguoiKy(Func<bool> onSub)
        {
            InitializeComponent();
            this.onSubmit = onSub;
        }
        SMMgEntities db = new SMMgEntities();
        NguoiKy currentNguoiKy = new NguoiKy();
        public void frmSuaNguoiKy_Load(object sender, EventArgs e)
        { 
            
            frmNguoiKy fNguoiKy = new frmNguoiKy();
            fNguoiKy.passData = new frmNguoiKy.PassData(GetPassedData);

            tbTenNguoiKy.Text = currentNguoiKy.TenNguoiKy;
            tbChucDanh.Text = currentNguoiKy.ChucDanh;
            cbMacDinh.Checked = currentNguoiKy.MacDinh.HasValue;
        }
        //public object getIdSelect(NguoiKy nguoiKy)
        //{
        //    return nguoiKy.id;
        //}
        public void GetPassedData(NguoiKy nk)
        {
            currentNguoiKy = nk;
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {

            this.onSubmit.Invoke();
        }
    }
}
