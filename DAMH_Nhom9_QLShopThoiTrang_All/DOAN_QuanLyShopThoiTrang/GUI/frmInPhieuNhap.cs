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
    public partial class frmInPhieuNhap : Form
    {
        public frmInPhieuNhap()
        {
            InitializeComponent();
        }

        private void frmInPhieuNhap_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.Visible = true;
            ReportPhieuNhap rpt = new ReportPhieuNhap();
            rpt.SetDatabaseLogon("shiro", "sa2012", "SHIRO\\SQLEXPRESS", "QL_ShopThoiTrang");
            rpt.SetParameterValue("SoPN", frmQLNhapHang.maphieunhap);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.DisplayToolbar = true;
            crystalReportViewer1.DisplayStatusBar = false;
            crystalReportViewer1.Refresh();
        }
    }
}
