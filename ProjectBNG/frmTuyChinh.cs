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
    public partial class frmTuyChinh : Form
    {
        public frmTuyChinh()
        {
            InitializeComponent();
        }
        
       

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SMMgEntities db = new SMMgEntities();
        TuyChinh tuyChinh = new TuyChinh();
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Chọn thư mục lưu file điện !";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                tbLuuFile.Text = fbd.SelectedPath;
                tuyChinh = db.TuyChinhs.Single(x => x.id == 1);
                tuyChinh.LuuFile = tbLuuFile.Text;
            }
        }

        private void frmTuyChinh_Load(object sender, EventArgs e)
        {

            tuyChinh = db.TuyChinhs.Single(x => x.id == 1);
            tbLuuFile.Text = tuyChinh.LuuFile;

            tbDauChimCao.Text = tuyChinh.DauChimCao.ToString();
            tbDauChimFont.Text = tuyChinh.DauChimFont.ToString();
            tbDauChimRong.Text = tuyChinh.DauChimRong.ToString();
            tbDauChimOpacity.Text = tuyChinh.DauChimOpacity.ToString();

            colorPickEditPdf.Color = Color.FromArgb(int.Parse(tuyChinh.DauChimMauPdf.ToString()));

            tbVungCkTieuDe.Text = tuyChinh.TieuDe.ToString();

            tbAnhCkCao1.Text = tuyChinh.AnhCkCao1.ToString();
            tbAnhCkCao2.Text = tuyChinh.AnhCkCao2.ToString();
            tbAnhCkRong1.Text = tuyChinh.AnhCkRong1.ToString();
            tbAnhCkRong2.Text = tuyChinh.AnhCkRong2.ToString();

            tbVungCkCao.Text = tuyChinh.VungCkCao.ToString();
            tbVungCkRong.Text = tuyChinh.VungCkRong.ToString();
            tbVungCkLeDuoi.Text = tuyChinh.VungCkLeDuoi.ToString();

            cmbCoSo.DataSource = db.CoSoes.ToList();
            cmbCoSo.DisplayMember = "TenCoSo";
            cmbCoSo.Invalidate();
            cmbIn2Mat.DataSource= db.TuyChinhComboboxes.ToList();
            cmbIn2Mat.DisplayMember = "TrangThaiTuyChinh";
            cmbIn2Mat.Invalidate();
            cmbDien.DataSource= db.TuyChinhComboboxes.ToList();
            cmbDien.DisplayMember = "GiayIn";
            cmbDien.Invalidate();
            cmbFax.DataSource= db.TuyChinhComboboxes.ToList();
            cmbFax.DisplayMember = "GiayIn";
            cmbFax.Invalidate();
            cmbKhanGiay.DataSource= db.TuyChinhComboboxes.ToList();
            cmbKhanGiay.DisplayMember = "TrangThaiTuyChinh";
            cmbKhanGiay.Invalidate();

        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            tuyChinh.DauChimCao = (float)Convert.ToDouble(tbDauChimCao.Text);
            tuyChinh.DauChimFont = (float)Convert.ToDouble(tbDauChimFont.Text);
            tuyChinh.DauChimRong = (float)Convert.ToDouble(tbDauChimRong.Text);
            tuyChinh.DauChimOpacity = (float)Convert.ToDouble(tbDauChimOpacity.Text);

            tuyChinh.TieuDe = tbVungCkTieuDe.Text.ToString().Trim();
            tuyChinh.VungCkCao = (float)Convert.ToDouble(tbVungCkCao.Text); 
            tuyChinh.VungCkRong = (float)Convert.ToDouble(tbVungCkRong.Text);
            tuyChinh.VungCkLeDuoi= (float)Convert.ToDouble(tbVungCkLeDuoi.Text);
            tuyChinh.AnhCkCao1 = (float)Convert.ToDouble(tbAnhCkCao1.Text);
            tuyChinh.AnhCkRong1 = (float)Convert.ToDouble(tbAnhCkRong1.Text);
            db.SaveChanges();
            MessageBox.Show("Thông số đã được thay đổi", "Thông báo");
            this.Close();
        }

        private void colorPickEditPdf_EditValueChanged(object sender, EventArgs e)
        {
            Color c = colorPickEditPdf.Color;

            tuyChinh = db.TuyChinhs.Single(x => x.id == 1);
            tuyChinh.DauChimMauPdf = c.ToArgb();

        }
    }
}
