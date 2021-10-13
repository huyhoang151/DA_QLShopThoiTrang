using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmInHoaDon : Form
    {
        public frmInHoaDon()
        {
            InitializeComponent();
        }
        

        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.Visible = true;
            ReportHoaDon rpt = new ReportHoaDon();
            rpt.SetDatabaseLogon("shiro", "sa2012", "SHIRO\\SQLEXPRESS", "QL_ShopThoiTrang");
            rpt.SetParameterValue("HD", frmBanHang.maHD);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.DisplayToolbar = true;
            crystalReportViewer1.DisplayStatusBar = false;
            crystalReportViewer1.Refresh();
        }
    }
}
