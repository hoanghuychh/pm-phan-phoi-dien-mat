using ProjectBNG.Class;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
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

        private void phânPhốiĐiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmPrinting"))
            {
                frmPrinting fprint = new frmPrinting();
                fprint.MdiParent = this;
                SMMgEntities db = new SMMgEntities();

                db.Database.ExecuteSqlCommand("delete from NoiNhanTemp", new object[] { });
                fprint.Show();
            }
            else
            {
                ActiveChildForm("frmPrinting");
            }
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmLogin"))
            {
                frmLogin flogin = new frmLogin();
                flogin.MdiParent = this;
                flogin.Show();
            }
            else
            {
                ActiveChildForm("frmLogin");
            }
        }

        private void ngườiDuyệtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmNguoiDuyet"))
            {
                frmNguoiDuyet fngduyet = new frmNguoiDuyet();
                fngduyet.MdiParent = this;
                fngduyet.Show();
            }
            else
            {
                ActiveChildForm("frmNguoiDuyet");
            }
        }

        private void nơiNhậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmNoinhan"))
            {
                frmNoinhan fnoinhan = new frmNoinhan();
                fnoinhan.MdiParent = this;
                fnoinhan.Show();
            }
            else
            {
                ActiveChildForm("frmNoinhan");
            }
        }

        private void nơiGửiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmNoiGui_1_"))
            {
                frmNoiGui_1_cs fnoigui = new frmNoiGui_1_cs();
                fnoigui.MdiParent = this;
                fnoigui.Show();
            }
            else
            {
                ActiveChildForm("frmNoiGui_1_");
            }
        }

        private void ngườiKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmNguoiKy"))
            {
                frmNguoiKy fngky = new frmNguoiKy();
                fngky.MdiParent = this;
                fngky.Show();
            }
            else
            {
                ActiveChildForm("frmNguoiKy");
            }
        }

        private void tùyChọnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmDoiMK"))
            {
                frmDoiMK fdmk = new frmDoiMK();
                fdmk.MdiParent = this;
                fdmk.Show();
            }
            else
            {
                ActiveChildForm("frmDoiMK");
            }
        }

        private void ngườiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmNguoiDung"))
            {
                frmNguoiDung fngdung = new frmNguoiDung();
                fngdung.MdiParent = this;
                fngdung.Show();
            }
            else
            {
                ActiveChildForm("frmNguoiDung");
            }
        }

        private void điệnMậtĐãPhânPhốiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonFunction.checkExistForm("frmDienPhanPhoi",this))
            {
                frmDienPhanPhoi fDienPhanPhoi = new frmDienPhanPhoi();
                fDienPhanPhoi.MdiParent = this;
                fDienPhanPhoi.Show();
            }
            else
            {
                CommonFunction.activateForm("frmDienPhanPhoi", this);
            }
        }

        private void bifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonFunction.checkExistForm("frmBiThu",this)){
                frmBiThu frmBiThu = new frmBiThu();
                frmBiThu.MdiParent = this;
                frmBiThu.Show();

            }
            else
            {
                CommonFunction.activateForm("frmBiThu", this);
            }
        }

        private void kcĐiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CommonFunction.checkExistForm("frmKiemChungDien", this))
            {
                frmKiemChungDien frmKiemChungDien = new frmKiemChungDien();
                frmKiemChungDien.MdiParent = this;
                frmKiemChungDien.Show();

            }
            else
            {
                CommonFunction.activateForm("frmKiemChungDien", this);
            }
        }

        private void tùyChọnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!CommonFunction.checkExistForm("frmTuyChinh", this))
            {
                frmTuyChinh frmTuyChinh = new frmTuyChinh();
                frmTuyChinh.MdiParent = this;
                frmTuyChinh.Show();
            }
            else
                CommonFunction.activateForm("frmTuyChinh", this);
        }
    }
}
