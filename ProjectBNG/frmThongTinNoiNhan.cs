using ProjectBNG.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ProjectBNG
{
    public partial class frmThongTinNoiNhan : Form
    {
        public frmThongTinNoiNhan()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                var newNoiNhan = new NoiNhan();
                newNoiNhan.MaNoiNhan = tbTenVietTat.Text;
                newNoiNhan.TenNoiNhan = tbTenDayDu.Text;
                newNoiNhan.Loai = cmbLoai.Text;
                newNoiNhan.Nhom = cmbNhom.Text;
                newNoiNhan.SoBaoMat = Convert.ToInt32(tbSoBaoMat.Text);
                newNoiNhan.SoThuTu = Convert.ToInt32(tbSoThuTu.Text);
                newNoiNhan.CoBi = cbCoBi.Checked;
                newNoiNhan.DangHoatDong = cbHoatDong.Checked;
                newNoiNhan.CoSo = cmbCoSo.Text;

                var db = new SMMgEntities();
                db.NoiNhans.Add(newNoiNhan);
                db.SaveChanges();
                this.Close();
                frmNoinhan frmNoinhan = new frmNoinhan();
                frmNoinhan.reloadFormNoiNhan();
            }
            catch
            {
                MessageBox.Show("Điền thông tin chính xác vào mẫu");
            }
        }

        private void tbSoBaoMat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbSoThuTu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
