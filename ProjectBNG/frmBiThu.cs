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
            if (!gridViewBiThu0.IsGroupRow(e.RowHandle)) //Nếu không phải là Group
            {
                if (e.Info.IsRowIndicator) //Nếu là dòng Indicator
                {
                    if (e.RowHandle < 0)
                    {
                        e.Info.ImageIndex = 0;
                        e.Info.DisplayText = string.Empty;
                    }
                    else
                    {
                        e.Info.ImageIndex = -1; //Không hiển thị hình
                        e.Info.DisplayText = (e.RowHandle + 1).ToString(); //Số thứ tự tăng dần
                    }

                    //hàm này dùng thay đổi độ rộng mặc định của cột số thứ tự
                    var _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                    var _Width = Convert.ToInt32(_Size.Width) + 20;
                    BeginInvoke(new MethodInvoker(delegate { CommonFunction.cal(_Width, gridViewBiThu0); }));
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", e.RowHandle * -1); //Nhân -1 để đánh lại số thứ tự tăng dần
                var _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                var _Width = Convert.ToInt32(_Size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { CommonFunction.cal(_Width, gridViewBiThu0); }));
            }
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
