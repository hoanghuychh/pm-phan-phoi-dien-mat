using ProjectBNG.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectBNG
{
    public partial class frmThemNguoiDung : Form
    {
        private SMMgEntities publishQuyen;

        public frmThemNguoiDung()
        {
            InitializeComponent();
            publishQuyen = new SMMgEntities();
            cmbQuyen.DataSource = publishQuyen.Permisions.ToList();
            cmbQuyen.DisplayMember = "NamePer";
            cmbQuyen.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            try
            {
                var newUser = new USER();
                newUser.Username = tbUsername.Text;
                newUser.Password = tbPassword.Text;
                newUser.PerUser = cmbQuyen.Text;
                newUser.NameUser = tbNameUser.Text;
                var db = new SMMgEntities();
                db.USERs.Add(newUser);
                db.SaveChanges();
                frmThemNguoiDung_Load(sender, e);
                MessageBox.Show("Thêm người sử dụng thành công");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Tên đăng nhập đã được sử dụng", "Thông báo");
            }
            
        }
        void frmThemNguoiDung_Load(object sender,EventArgs e)
        {
            frmNguoiDung frmNguoiDung = new frmNguoiDung();
            frmNguoiDung.gridControl1_Load(sender, e);
        }
        private void frmThemNguoiDung_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmNguoiDung frmNguoiDung = new frmNguoiDung();
            frmNguoiDung.gridControl1_Load(sender, e);
        }
    }
}
