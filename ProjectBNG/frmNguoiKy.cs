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
    public partial class frmNguoiKy : Form
    {
        public frmNguoiKy()
        {
            InitializeComponent();
        }

        private bool CheckExistForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        private void ActiveChildForm(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmThemSuaNguoiKy"))
            {
                frmThemSuaNguoiKy fthemsuangky = new frmThemSuaNguoiKy();
                //fthemsuangky.MdiParent = this.MdiParent;
                fthemsuangky.Show();
            }
            else
            {
                ActiveChildForm("frmThemSuaNguoiKy");
            }
        }
    }
}
