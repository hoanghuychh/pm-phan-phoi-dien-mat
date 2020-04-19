using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ProjectBNG
{
    public partial class rptThongKeDien : DevExpress.XtraReports.UI.XtraReport
    {
        public rptThongKeDien()
        {
            InitializeComponent();
        }

        public void initData(int banIn)
        {
            pSoBanIn.Value = banIn;

        }
    }
}
