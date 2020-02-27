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
    public partial class frmSuaNguoiDuyet : Form
    {

        Func<bool> onSubmit;
        public frmSuaNguoiDuyet(Func<bool> onSub,NguoiDuyet nguoiDuyet)
        {
            InitializeComponent();
            this.onSubmit = onSub;
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
