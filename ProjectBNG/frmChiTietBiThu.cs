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
    public partial class frmChiTietBiThu : Form
    {
        string danhSachDien = "";
        public frmChiTietBiThu( string danhSachDienMat)
        {
            InitializeComponent();
            danhSachDien = danhSachDienMat;
        }

        private void frmChiTietBiThu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sMMgDataSet.DienMat' table. You can move, or remove it, as needed.
            this.dienMatTableAdapter.Fill(this.sMMgDataSet.DienMat);
            

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("celldbclick");
        }
    }
}
