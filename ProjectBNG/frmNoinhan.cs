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
    public partial class frmNoinhan : Form
    {
        public frmNoinhan()
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

        private void btnThemNoiNhan_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmThongTinNoiNhan"))
            {
                frmThongTinNoiNhan fthongtinnoinhan = new frmThongTinNoiNhan();
                //fthongtinnoinhan.MdiParent = this.MdiParent;
                fthongtinnoinhan.Show();
            }
            else
            {
                ActiveChildForm("frmThongTinNoiNhan");
            }
        }
    }
}
