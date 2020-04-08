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
    public partial class frmDoiMK : Form
    {
        public frmDoiMK()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            SMMgEntities db = new SMMgEntities();
            int idUser = int.Parse(frmLogin.userID.ToString());
            var userSelect = db.USERs.Single(x => x.ID == idUser);
            if (tbMKCu.Text == userSelect.Password)
            {
                if (tbMKMoi.Text == tbMKMoi2.Text)
                {

                    db.Database.ExecuteSqlCommand("	 update [USER] set Password={0} where ID={1}", tbMKMoi2.Text, userSelect.ID);
                    db.SaveChanges();
                    MessageBox.Show("Đổi mật khẩu thành công ", "Thông báo");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu mới xác nhận không thành công", "Có lỗi xảy ra");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không đúng", "Có lỗi xảy ra");
            }

        }
    }
}
