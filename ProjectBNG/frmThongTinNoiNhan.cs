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

namespace ProjectBNG {
    public partial class frmThongTinNoiNhan : Form
    {
        Func<bool> onSubmit;
        public frmThongTinNoiNhan(Func<bool>  onSumit)
        {
            InitializeComponent();
            this.onSubmit = onSumit;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                SMMgEntities db = new SMMgEntities();
                var newNoiNhan = new NoiNhan();
                newNoiNhan.MaNoiNhan = tbTenVietTat.Text;
                newNoiNhan.TenNoiNhan = tbTenDayDu.Text;
                newNoiNhan.Loai = cmbLoai.Text;
                newNoiNhan.Nhom = cmbNhom.Text;
                newNoiNhan.SoBaoMat = Convert.ToInt32(tbSoBaoMat.Text);
                try
                {
                    NoiNhan noiNhanExist = db.NoiNhans.Single(nn => nn.SoBaoMat == newNoiNhan.SoBaoMat);
                    MessageBox.Show("Số bảo mật đã được sử dụng !", "Thông báo");
                    return;
                }
                catch { }
                
                newNoiNhan.SoThuTu = Convert.ToInt32(tbSoThuTu.Text);
                newNoiNhan.CoBi = cbCoBi.Checked;
                newNoiNhan.DangHoatDong = cbHoatDong.Checked;
                newNoiNhan.CoSo = cmbCoSo.Text;

                db.NoiNhans.Add(newNoiNhan);
                db.SaveChanges();
                frmNoiNhan_Load(sender,e);
                MessageBox.Show("Thêm thông tin thành công", "Thông báo");
                this.Close(); 
            }
            catch
            {
                MessageBox.Show("Điền thông tin chính xác vào mẫu");
            }
            this.onSubmit.Invoke();

        }
        void frmNoiNhan_Load(object sender,EventArgs e)
        {
            frmNoinhan frmNoinhan = new frmNoinhan();
            frmNoinhan.gridControl1_Load(sender,e);
            frmNoinhan.frmNoinhan_Load(sender, e);
        }
        private void tbSoBaoMat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbSoThuTu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void frmThongTinNoiNhan_Load(object sender, EventArgs e)
        {
            SMMgEntities db = new SMMgEntities();
            cmbLoai.DataSource = db.PhanLoaiNoiNhans.ToList();
            cmbLoai.DisplayMember = "PhanLoai";
            cmbNhom.DataSource = db.Nhoms.ToList();
            cmbNhom.DisplayMember = "TenNhom";
            cmbCoSo.DataSource = db.CoSoes.ToList();
            cmbCoSo.DisplayMember = "TenCoSo";
        }

        private void frmThongTinNoiNhan_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmNoinhan frmNoinhan = new frmNoinhan();
            frmNoinhan.gridControl1_Load(sender, e);
        }
    }
}
