﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using ProjectBNG.Class;

namespace ProjectBNG
{
    public partial class frmBiThu : Form
    {
        public frmBiThu()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            ProjectBNG.Models.SMMgEntities dbContext = new ProjectBNG.Models.SMMgEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.BiThus.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                biThusBindingSource.DataSource = dbContext.BiThus.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());

            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.BiThus.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    biThusBindingSource2.DataSource = dbContext.BiThus.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void gridViewBiThu0_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            CommonFunction.gridView_CustomDrawRowIndicator(sender, e, gridViewBiThu0);
        }

        private void gridViewBiThu0_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            string DanhSachDien= gridViewBiThu0.GetRowCellValue(gridViewBiThu0.FocusedRowHandle, "DanhSachDienMat").ToString();
            if (!CommonFunction.checkExistForm("frmChiTietBiThu", this))
            {

                frmChiTietBiThu frmChiTietBiThu = new frmChiTietBiThu(DanhSachDien);
                frmChiTietBiThu.ShowDialog();
            }
            else
                CommonFunction.activateForm("frmChiTietBiThu", this);

            /*NguoiDuyet selectNguoiDuyet = new NguoiDuyet();
                try
                {
                    selectNguoiDuyet = (NguoiDuyet)gridViewNguoiDuyet.GetRow(gridViewNguoiDuyet.FocusedRowHandle);

                }
                catch { }
                frmSuaNguoiDuyet frmSuaNguoiDuyet = new frmSuaNguoiDuyet(() =>
                {
                    ProjectBNG.Models.SMMgEntities dbContext = new ProjectBNG.Models.SMMgEntities();
                    // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
                    dbContext.NguoiDuyets.LoadAsync().ContinueWith(loadTask =>
                    {
                        // Bind data to control when loading complete
                        nguoiDuyetsBindingSource.DataSource = dbContext.NguoiDuyets.Local.ToBindingList();
                    }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
                    return false;
                }, selectNguoiDuyet);
                frmSuaNguoiDuyet.ShowDialog(this);*/
        }
    }

}
