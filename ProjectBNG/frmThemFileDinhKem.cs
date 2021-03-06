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

namespace ProjectBNG
{
    public partial class frmThemFileDinhKem : Form
    {
        int maDienMat;
        public frmThemFileDinhKem(int MaDienMat)
        {
            InitializeComponent();
            maDienMat = MaDienMat;
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            ProjectBNG.Models.SMMgEntities dbContext = new ProjectBNG.Models.SMMgEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.FileDinhKemDienMats.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                fileDinhKemDienMatsBindingSource.DataSource = db.FileDinhKemDienMats
                .Where(x => x.MaDienMat == maDienMat)
                .Select(x => new
                {
                    MaDienMat = x.MaDienMat,
                    FileDinhKem = x.FileDinhKem,
                    id=x.id

                }).ToList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());


        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        SMMgEntities db = new SMMgEntities();
        private void btnThem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "(PDF file)|*.pdf|(Docx file)|*.docx" };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileDinhKemDienMat fileDinhKemDienMat = new FileDinhKemDienMat();
                try
                {
                    SMMgEntities db = new SMMgEntities();
                    fileDinhKemDienMat.MaDienMat = Convert.ToInt32(maDienMat);
                    fileDinhKemDienMat.FileDinhKem = openFileDialog.FileName;
                    db.FileDinhKemDienMats.Add(fileDinhKemDienMat);
                    db.SaveChanges();
                    frmThemFileDinhKem_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Chưa điền thông tin số điện", "Thông báo");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            FileDinhKemDienMat xoaFileDinhKem = new FileDinhKemDienMat();
            try
            {

                xoaFileDinhKem.id = int.Parse(gridViewDinhKem.GetRowCellValue(gridViewDinhKem.FocusedRowHandle, "id").ToString());

            }
            catch
            {

            }
            delete(xoaFileDinhKem);
            MessageBox.Show("Đã Xóa");
            frmThemFileDinhKem_Load(sender, e);
            void delete(FileDinhKemDienMat xoa)
            {
                FileDinhKemDienMat p = db.FileDinhKemDienMats.Find(xoa.id);
                db.FileDinhKemDienMats.Remove(p);
                db.SaveChanges();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmThemFileDinhKem_Load(object sender, EventArgs e)
        {
            SMMgEntities db = new SMMgEntities();
            fileDinhKemDienMatsBindingSource.DataSource = db.FileDinhKemDienMats
                 .Where(x => x.MaDienMat == maDienMat)
                 .Select(x => new
                 {
                     MaDienMat = x.MaDienMat,
                     FileDinhKem = x.FileDinhKem,

                     id = x.id

                 }).ToList();
            gridControlDinhKem.RefreshDataSource();
        }
    }
}
