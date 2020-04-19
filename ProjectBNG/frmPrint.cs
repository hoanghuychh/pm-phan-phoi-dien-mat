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
    public partial class frmPrint : Form
    {
        public frmPrint()
        {
            InitializeComponent();
        }
        public void PrintClick(int banIn)
        {
            rptThongKeDien rptThongKeDien = new rptThongKeDien();
            rptThongKeDien.initData(banIn);
            //documentViewer1.DocumentSource=rptThongKeDien
        }
    }
}
