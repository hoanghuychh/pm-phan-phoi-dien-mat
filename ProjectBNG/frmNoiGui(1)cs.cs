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
using ProjectBNG.Models;

namespace ProjectBNG
{
    public partial class frmNoiGui_1_cs : Form
    {
        public frmNoiGui_1_cs()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            ProjectBNG.Models.SMMgEntities dbContext = new ProjectBNG.Models.SMMgEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.NoiGuis.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    noiGuisBindingSource.DataSource = dbContext.NoiGuis.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }
        SMMgEntities db = new SMMgEntities();
        private void btnThemNguoiGui_Click(object sender, EventArgs e)
        {
            var noiGui = new NoiGui();
            noiGui.Ma = tbMaNguoiGui.Text;
            noiGui.Ten = tbTenNguoiGui.Text;
            db.NoiGuis.Add(noiGui);
            db.SaveChanges();
            gridControl1_Load(sender, e);
            MessageBox.Show("Thêm thành công");
        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.NoiGuis.ToList();
            gridControl1.RefreshDataSource();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult de = MessageBox.Show("Xóa thông tin này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (de == DialogResult.Yes)
            {
                NoiGui noiGui = new NoiGui();
                noiGui.id = int.Parse(gridviewNoiGui.GetRowCellValue(gridviewNoiGui.FocusedRowHandle, "id").ToString());
                deleteNoiGui(noiGui);
                MessageBox.Show("Đã Xóa");
                gridControl1_Load(sender, e);
            }
            void deleteNoiGui(NoiGui noiGui)
            {
                NoiGui p = db.NoiGuis.Find(noiGui.id);
                db.NoiGuis.Remove(p);
                db.SaveChanges();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}