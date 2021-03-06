using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using ProjectBNG.Models;
using ProjectBNG.Class;

namespace ProjectBNG
{
    public partial class frmNguoiKy : Form
    {
        

        public frmNguoiKy()
        {
            InitializeComponent();

            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext

            SMMgEntities db = new SMMgEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            db.NguoiKies.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                nguoiKiesBindingSource1.DataSource = db.NguoiKies.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        SMMgEntities db = new SMMgEntities();
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
            if (!CheckExistForm("frmThemNguoiKy"))
            { 
                frmThemNguoiKy fthemsuangky = new frmThemNguoiKy(() => {

                    SMMgEntities db = new SMMgEntities();
                    gridControlNguoiKy.DataSource = db.NguoiKies.ToList();
                    gridControlNguoiKy.RefreshDataSource();
                    return false;
                });
                //fthemsuangky.MdiParent = this.MdiParent;
                fthemsuangky.ShowDialog(this);
            }
            else
            {
                ActiveChildForm("frmThemNguoiKy");
            }
        }


        public delegate void PassData(NguoiKy nk);
        public PassData passData;

        public void btnSuaNgKy_Click(object sender, EventArgs e)
        {
        
        NguoiKy getNguoiKy = new NguoiKy();
            if (!CheckExistForm("frmSuaNguoiKy"))
            {
                
                try
                {
                    getNguoiKy = (NguoiKy)gridViewNguoiKy.GetRow(gridViewNguoiKy.FocusedRowHandle);
                         // lay thong tin id cua nguoi ky
                        //int.Parse(gridViewNguoiKy.GetRowCellValue(gridViewNguoiKy.FocusedRowHandle, "id").ToString());
                }
                catch { }
                //int idNguoiKySelected;
                //idNguoiKySelected = getNguoiKy.id;
                //fSuaNguoiKy.getIdSelect(getNguoiKy);
                
                frmSuaNguoiKy fSuaNguoiKy = new frmSuaNguoiKy(() => {
                    SMMgEntities db2 = new SMMgEntities();
                    db2.NguoiKies.LoadAsync().ContinueWith(loadTask =>
                    {
                        // Bind data to control when loading complete
                        nguoiKiesBindingSource1.DataSource = db2.NguoiKies.Local.ToBindingList();
                        gridControlNguoiKy.RefreshDataSource();
                    }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());

                    return false;
                }, getNguoiKy);
                // ok done =)))))
                
                fSuaNguoiKy.ShowDialog(this);

                frmNguoiKy_Load(sender, e);
            }
            else
            {
                ActiveChildForm("frmSuaNguoiKy");
            }
        }

        private void btnXoaNgKy_Click(object sender, EventArgs e)
        {
            NguoiKy delNguoiKy = new NguoiKy();
            try
            {
                delNguoiKy.id = int.Parse(gridViewNguoiKy.GetRowCellValue(gridViewNguoiKy.FocusedRowHandle, "id").ToString());
            }
            catch { }
            NguoiKy d = db.NguoiKies.Find(delNguoiKy.id);
            db.NguoiKies.Remove(d);
            db.SaveChanges();
            //deleteNguoiKy(delNguoiKy);


            frmNguoiKy_Load(sender, e);
            MessageBox.Show("Đã xóa thành công ", "Thông báo");
            //void deleteNguoiKy(NguoiKy idNgKy)
            //{
                
            //    NguoiKy d= db.NguoiKies.Find(idNgKy.id);
            //    db.NguoiKies.Remove(d);
            //    db.SaveChanges();
            //}
        }

        private void frmNguoiKy_Load(object sender, EventArgs e)
        {
            SMMgEntities db3 = new SMMgEntities();
            gridControlNguoiKy.DataSource = db3.NguoiKies.ToList();
            gridControlNguoiKy.RefreshDataSource();

        }

        private void gridViewNguoiKy_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            CommonFunction.gridView_CustomDrawRowIndicator(sender, e, gridViewNguoiKy);
        }
    }
}
