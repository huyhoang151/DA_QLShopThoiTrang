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
    public partial class frmCTHDB : Form
    {
        HoaDonBLL hd = new HoaDonBLL();
        CT_HoaDonBLL cthd = new CT_HoaDonBLL();
        NhanVienBLL nv = new NhanVienBLL();
        KhachHangBLL kh = new KhachHangBLL();
        SanPhamBLL sp = new SanPhamBLL();
        public frmCTHDB()
        {
            InitializeComponent();
            loadDataHDB();
        }

        public void loadDataHDB()
        {
            string maHD = frmQLHoaDon._maHD;
            loadMaNhanVien_ComboBox();
            loadMaKhachHang_ComboBox();
            loadMaSanPham_ComboBox();
            loadMaHoaDon_ComboBox();
            cboTimKiem.Text = maHD;
            cboMaHang.Text = string.Empty;
            DataTable dt = hd.getDataCTHD(maHD);
            txtMaHD.Text = dt.Rows[0][0].ToString();
            txtNgayLap.Text = dt.Rows[0][1].ToString();
            cboMaNV.Text = dt.Rows[0][3].ToString();
            txtTenNV.Text = dt.Rows[0][5].ToString();
            cboMaKH.Text = dt.Rows[0][4].ToString();
            txtTenKH.Text = dt.Rows[0][6].ToString();
            txtDiaChi.Text = dt.Rows[0][7].ToString();
            txtSDT.Text = dt.Rows[0][8].ToString();
            lblTongTien.Text = dt.Rows[0][2].ToString();
            dgvChiTietHoaDon.DataSource = cthd.loadCTHDbyMaHD(maHD);
            
        }

        private void dgvChiTietHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cboMaHang.Text = dgvChiTietHoaDon.CurrentRow.Cells[0].Value.ToString();
            txtTenHang.Text = dgvChiTietHoaDon.CurrentRow.Cells[1].Value.ToString();
            txtSoLuong.Text = dgvChiTietHoaDon.CurrentRow.Cells[2].Value.ToString();
            txtDonGiaMoi.Text = dgvChiTietHoaDon.CurrentRow.Cells[3].Value.ToString();
            txtThanhTien.Text = dgvChiTietHoaDon.CurrentRow.Cells[4].Value.ToString();
        }

        public void loadMaNhanVien_ComboBox()
        {
            cboMaNV.DataSource = nv.LoadNV();
            cboMaNV.ValueMember = "MaNhanVien";
            cboMaNV.DisplayMember = "MaNhanVien";
        }

        public void loadMaKhachHang_ComboBox()
        {
            cboMaKH.DataSource = kh.loadKhachHang();
            cboMaKH.ValueMember = "MaKhachHang";
            cboMaKH.DisplayMember = "MaKhachHang";
        }

        public void loadMaSanPham_ComboBox()
        {
            cboMaHang.DataSource = sp.LoadSP();
            cboMaHang.ValueMember = "MaSanPham";
            cboMaHang.DisplayMember = "MaSanPham";
        }

        public void loadMaHoaDon_ComboBox()
        {
            cboTimKiem.DataSource = hd.getDataHoaDon();
            cboTimKiem.ValueMember = "MaHoaDon";
            cboTimKiem.DisplayMember = "MaHoaDon";
        }
        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cboMaNV.SelectedIndex > 0 ? cboMaNV.SelectedIndex : 0;
            txtTenNV.Text = nv.LoadNV().Rows[index][1].ToString();
        }

        private void cboMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cboMaHang.SelectedIndex > 0 ? cboMaHang.SelectedIndex : 0;
            txtTenHang.Text = sp.LoadSP().Rows[index][1].ToString();
        }

        private void cboMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cboMaKH.SelectedIndex > 0 ? cboMaKH.SelectedIndex : 0;
            txtTenKH.Text = kh.loadKhachHang().Rows[index][1].ToString();
            txtDiaChi.Text = kh.loadKhachHang().Rows[index][2].ToString();
            txtSDT.Text = kh.loadKhachHang().Rows[index][3].ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            frmQLHoaDon._maHD = cboTimKiem.SelectedValue.ToString();
            loadDataHDB();
        }

        
    }
}
