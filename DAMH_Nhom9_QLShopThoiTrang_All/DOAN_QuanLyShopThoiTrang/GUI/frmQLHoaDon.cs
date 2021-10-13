using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmQLHoaDon : Form
    {
        HoaDonBLL hd = new HoaDonBLL();
        PhieuNhapBLL pn = new PhieuNhapBLL();
        public static string _maHD;

        public frmQLHoaDon()
        {
            InitializeComponent();
          
        }

        private void frmQLHoaDon_Load(object sender, EventArgs e)
        {
            loadHoaDonBan_DataGridView();
            loadHoaDonNhap_DataGridView();
            loadChonKy_ComboBox();
            dgvHDB.Visible = tsHDB.Checked;
            dgvHDN.Visible = tsHDN.Checked;
        }

        public void loadHoaDonBan_DataGridView()
        {
            dgvHDB.DataSource = hd.getDataHoaDon();
        }

        public void loadHoaDonNhap_DataGridView()
        {
            dgvHDN.DataSource = pn.getDataPN();
        }

        public void loadHoaDonBanTheoNgay_DataGridView()
        {
            dgvHDB.DataSource = hd.getDataHoaDon(dtpFrom.Value, dtpTo.Value);
        }

        public void loadHoaDonNhapTheoNgay_DataGridView()
        {
            dgvHDN.DataSource = pn.getDataPN(dtpFrom.Value, dtpTo.Value);
        }

        public void loadChonKy_ComboBox()
        {
            var table = DateTime.Now.GetDateOfWeek();
            cboChonKy.DataSource = table;
            cboChonKy.DisplayMember = "name";
            cboChonKy.ValueMember = "id";
            cboChonKy.SelectedIndex = 1;
        }
        private void cboChonKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedValue = (DataRowView)cboChonKy.SelectedItem;
            string from = selectedValue.Row["from"].ToString();
            string to = selectedValue.Row["to"].ToString();
            dtpFrom.Value = DateTime.ParseExact(from, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            dtpTo.Value = DateTime.ParseExact(to, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            loadHoaDonBanTheoNgay_DataGridView();
            loadHoaDonNhapTheoNgay_DataGridView();
        }

        private void tsHDN_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = string.Empty;
            dgvHDN.Visible = tsHDN.Checked;
            label7.Text += "HÓA ĐƠN NHẬP";
        }

        private void tsHDB_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = string.Empty;
            dgvHDB.Visible = tsHDB.Checked;
            label7.Text += "HÓA ĐƠN BÁN";
        }

        private void dgvHDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _maHD = dgvHDB.CurrentRow.Cells[0].Value.ToString();
            frmCTHDB frm = new frmCTHDB();
            frm.ShowDialog();
        }

        private void dgvHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _maHD = dgvHDN.CurrentRow.Cells[0].Value.ToString();
            frmCTHDN frm = new frmCTHDN();
            frm.ShowDialog();
        }


    }
}
