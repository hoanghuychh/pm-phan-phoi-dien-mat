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
    public partial class frmThemNguoiDung : Form
    {
        private SMMgEntities publishQuyen;

        public frmThemNguoiDung()
        {
            InitializeComponent();
            publishQuyen = new SMMgEntities();
            cmoQuyen.DataSource = publishQuyen.USERs.ToList();
            cmoQuyen.DisplayMember = "PerUser";
            cmoQuyen.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            var newUser = new USER();
            newUser.Username = tbUsername.Text;
            newUser.Password = tbPassword.Text;
            newUser.PerUser = cmoQuyen.Text;
            newUser.NameUser = tbNameUser.Text;
            var db = new SMMgEntities();
            db.USERs.Add(newUser);
            db.SaveChanges();
        }
    }
}
