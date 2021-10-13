using BLL;
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
    public partial class frmCTHDN : Form
    {
        PhieuNhapBLL pn = new PhieuNhapBLL();
        CT_PhieuNhapBLL ctpn = new CT_PhieuNhapBLL();
        NhanVienBLL nv = new NhanVienBLL();
        NhaCungCapBLL ncc = new NhaCungCapBLL();
        SanPhamBLL sp = new SanPhamBLL();
        public frmCTHDN()
        {
            InitializeComponent();
        }

        private void frmCTHDN_Load(object sender, EventArgs e)
        {
            loadDataHDN();
        }
        public void loadDataHDN()
        {
            string maPN = frmQLHoaDon._maHD;
            loadMaNhanVien_ComboBox();
            loadMaNCC_ComboBox();
            loadMaSanPham_ComboBox();
            loadMaNCC_ComboBox();
            loadMaPhieuNhap_ComboBox();
            cboTimKiem.Text = maPN;
            cboMaHang.Text = string.Empty;
            DataTable dt = pn.getDataPN(maPN);
            txtMaPN.Text = dt.Rows[0][0].ToString();
            txtNgayLap.Text = dt.Rows[0][1].ToString();
            cboMaNV.Text = dt.Rows[0][3].ToString();
            txtTenNV.Text = dt.Rows[0][5].ToString();
            cboMaNCC.Text = dt.Rows[0][2].ToString();
            txtTenNCC.Text = dt.Rows[0][6].ToString();
            lblTongTien.Text = dt.Rows[0][4].ToString();
            dgvChiTietHoaDon.DataSource = ctpn.loadCTPNbyMaPN(maPN);
        }

        public void loadMaNhanVien_ComboBox()
        {
            cboMaNV.DataSource = nv.LoadNV();
            cboMaNV.ValueMember = "MaNhanVien";
            cboMaNV.DisplayMember = "MaNhanVien";
        }

        public void loadMaNCC_ComboBox()
        {
            //cboMaNCC.DataSource = ncc.();
            //cboMaKH.ValueMember = "MaNhaCungCap";
            //cboMaKH.DisplayMember = "TenNhaCungCap";
        }

        public void loadMaSanPham_ComboBox()
        {
            cboMaHang.DataSource = sp.LoadSP();
            cboMaHang.ValueMember = "MaSanPham";
            cboMaHang.DisplayMember = "MaSanPham";
        }


        public void loadMaPhieuNhap_ComboBox()
        {
            cboTimKiem.DataSource = pn.getDataPN();
            cboTimKiem.ValueMember = "MaPhieuNhap";
            cboTimKiem.DisplayMember = "MaPhieuNhap";
        }


        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cboMaNV.SelectedIndex > 0 ? cboMaNV.SelectedIndex : 0;
            txtTenNV.Text = nv.LoadNV().Rows[index][1].ToString();
        }

        private void cboMaNCC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cboMaHang.SelectedIndex > 0 ? cboMaHang.SelectedIndex : 0;
            txtTenHang.Text = sp.LoadSP().Rows[index][1].ToString();
        }

        private void dgvChiTietHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cboMaHang.Text = dgvChiTietHoaDon.CurrentRow.Cells[0].Value.ToString();
            txtTenHang.Text = dgvChiTietHoaDon.CurrentRow.Cells[1].Value.ToString();
            txtSoLuong.Text = dgvChiTietHoaDon.CurrentRow.Cells[2].Value.ToString();
            txtDonGiaMoi.Text = dgvChiTietHoaDon.CurrentRow.Cells[3].Value.ToString();
            txtThanhTien.Text = dgvChiTietHoaDon.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            frmQLHoaDon._maHD = cboTimKiem.SelectedValue.ToString();
            loadDataHDN();
        }

       


    }
}
