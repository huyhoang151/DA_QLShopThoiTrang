using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using System.IO;
using System.Drawing.Imaging;

namespace GUI
{
    public partial class frmBanHang : Form
    {
        SanPhamBLL sp = new SanPhamBLL();
        NhanVienBLL nv = new NhanVienBLL();
        KhachHangBLL kh = new KhachHangBLL();
        CT_HoaDonBLL cthd = new CT_HoaDonBLL();
        HoaDonBLL hd = new HoaDonBLL();
        int maNV;
        int maKH;
        public static string tenNV;
        public static string maHD;
        public static string tenKH;
        public static DateTime ngayLap;
        public static int tongThanhTien;
        public frmBanHang()
        {
            InitializeComponent();
        }

        private void chkKhachHang_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKhachHang.Checked == true)
            {
                cbKhachHang.Visible = true;
                txtKhachHang.Visible = false;
                //LoadcbKH();
            }
            else
            {
                cbKhachHang.Visible = false;
                txtKhachHang.Visible = true;
            }
        }

        private void load_DGVSanPham()
        {
            dgvDSSanPham.DataSource = sp.LoadDSSP();
        }

        private void load_CBKhachHang()
        {
            cbKhachHang.DataSource = kh.loadKhachHang();
            cbKhachHang.DisplayMember = kh.loadKhachHang().Columns[1].ToString();
            cbKhachHang.ValueMember = kh.loadKhachHang().Columns[0].ToString();
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            load_DGVSanPham();
            load_CBKhachHang();

            foreach (DataRow dr in nv.getDataNhanVienBySDT(frmLogin.tendn).Rows)
            {
                maNV = int.Parse(dr["MaNhanVien"].ToString());
                tenNV = dr["HoTenNhanVien"].ToString();
            }
            txtNhanVien.Text = tenNV;

            btnXoa.Enabled = false;
            btnLamMoi.Enabled = false;
            btnThanhToan.Enabled = false;

        }

        private void dgvDSSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (e.RowIndex == -1) return;
            txtMaSP.Text = dgvDSSanPham.Rows[index].Cells[0].Value.ToString().Trim();
            txtTenSP.Text = dgvDSSanPham.Rows[index].Cells[1].Value.ToString().Trim();
            txtDonGia.Text = dgvDSSanPham.Rows[index].Cells[8].Value.ToString().Trim();
            string hinhanh = dgvDSSanPham.Rows[index].Cells[2].Value.ToString().Trim();
            try
            {
                if (hinhanh != " " && hinhanh != "" && hinhanh != null)
                {
                    picHinh.ImageLocation = string.Format(@"img\{0}", dgvDSSanPham.Rows[index].Cells[2].Value.ToString().Trim());
                }
                else
                {
                    picHinh.ImageLocation = string.Format(@"img\noimage.jpg");
                }
            }
            catch (Exception)
            {
                picHinh.ImageLocation = string.Format(@"img\noimage.jpg");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaHoaDon.Text == "" || txtNhanVien.Text == "")
                {
                    MessageBox.Show("Không được để trống");
                }
                else
                {
                    btnXoa.Enabled = true;
                    btnLamMoi.Enabled = true;
                    btnThanhToan.Enabled = true;
                    int soluongtrukhimua = 1;
                    int soluong = 1;
                    int tong = 0;
                    tongThanhTien = 0;
                    maHD = txtMaHoaDon.Text;
                    int masanpham = int.Parse(txtMaSP.Text.Trim());
                    string tensanpham = txtTenSP.Text.Trim();

                    int dongia = int.Parse(txtDonGia.Text.Trim());
                    tenKH = "";
                    if (chkKhachHang.Checked == true)
                    {
                        int makh = int.Parse(cbKhachHang.SelectedValue.ToString().Trim());
                        foreach (DataRow dr in kh.getKhachHangMaKH(makh).Rows)
                        {
                            tenKH = dr["HoTenKhachHang"].ToString();
                        }
                    }
                    else
                    {
                        if (txtKhachHang.Text == "")
                        {
                            MessageBox.Show("Không được để trống");
                            return;
                        }
                        else
                        {
                            tenKH = txtKhachHang.Text.Trim();
                            kh.themKH(tenKH);
                        }

                    }

                    int thanhtien = dongia * soluong;


                    if (cthd.KTTC(maHD, masanpham) == false)
                    {
                        MessageBox.Show("Sản phẩm đã có trong giỏ hàng của bạn");
                        return;
                    }

                    if (cthd.KTMaHD(maHD) > 0)
                    {
                        int slt1 = 0;
                        foreach (DataRow dr in sp.getDataSPByMaSP(masanpham).Rows)
                        {
                            slt1 = int.Parse(dr["SoLuongTon"].ToString());
                        }
                        if (slt1 == 0)
                        {
                            MessageBox.Show("Sản phẩm đã hết");
                            return;
                        }

                        cthd.themCTHD(maHD, masanpham, soluong, dongia);

                        foreach (DataRow dr in cthd.getDataCTHD(maHD).Rows)
                        {
                            tong += int.Parse(dr["SoLuong"].ToString());
                            tongThanhTien += int.Parse(dr["ThanhTien"].ToString());
                        }

                        lbSoLuong.Text = tong.ToString() + " sản phẩm";



                        int tru1khiclickthem1 = slt1 - soluongtrukhimua;

                        sp.updateSP(tru1khiclickthem1, masanpham);

                        load_DGVSanPham();

                        lbTongTien.Text = tongThanhTien.ToString("0,00.##") + " VNĐ";
                        load_DGVSanPham();
                        dgvChiTietHoaDon.DataSource = cthd.getDataCTHD(maHD);
                        return;
                    }
                    int slt = 0;
                    foreach (DataRow dr in sp.getDataSPByMaSP(int.Parse(txtMaSP.Text)).Rows)
                    {
                        slt = int.Parse(dr["SoLuongTon"].ToString());
                    }
                    if (slt == 0)
                    {
                        MessageBox.Show("Sản phẩm đã hết");
                        return;
                    }
                    

                    foreach (DataRow dr in kh.getKhachHangTenKH(tenKH).Rows)
                    {
                        maKH = int.Parse(dr["MaKhachHang"].ToString());
                    }
                    ngayLap = dtpNgayLap.Value;
                    hd.themHD(maHD, ngayLap, 0, maNV, maKH);

                    cthd.themCTHD(maHD, masanpham, soluong, dongia);

                    foreach (DataRow dr in cthd.getDataCTHD(maHD).Rows)
                    {
                        tong += int.Parse(dr["SoLuong"].ToString());
                        tongThanhTien += int.Parse(dr["ThanhTien"].ToString());
                    }
                    lbSoLuong.Text = tong.ToString() + " sản phẩm";
                    lbTongTien.Text = tongThanhTien.ToString("0,00.##") + " VNĐ";
                    int tru1khiclickthem = slt - soluongtrukhimua;

                    sp.updateSP(tru1khiclickthem, masanpham);

                    load_DGVSanPham();

                    dgvChiTietHoaDon.DataSource = cthd.getDataCTHD(maHD);

                    load_CBKhachHang();

                }
                
            }
            catch
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void chkMaNgauNhien_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMaNgauNhien.Checked == true)
            {
                int Numrd;

                Random rd = new Random();
                Numrd = rd.Next(1, 100);
                txtMaHoaDon.Text = "HD0" + rd.Next(1000, 99999).ToString();
                txtMaHoaDon.Enabled = false;
                chkMaNgauNhien.Enabled = false;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaHoaDon.Enabled = true;
            chkMaNgauNhien.Enabled = true;
            chkMaNgauNhien.Checked = false;
            chkKhachHang.Checked = false;
            cbKhachHang.Visible = false;
            string mahoadon = txtMaHoaDon.Text.Trim();
            //cthd.xoaCTHD(mahoadon);
            load_DGVSanPham();
            string mahoadon1 = "";
            dgvChiTietHoaDon.DataSource = cthd.getDataCTHD(mahoadon1);
            txtMaHoaDon.Text = "";
            txtKhachHang.Text = "";
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtDonGia.Text = "";
            lbTongTien.Text = "0 VNĐ";
            lbSoLuong.Text = "0 sản phẩm";
            txtSoLuong.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoaCTHD();
        }

        public void xoaCTHD()
        {
            int tongThanhTien = 0;
            int tong = 0;
            string mahoadon = txtMaHoaDon.Text.Trim();
            int masanpham = int.Parse(dgvChiTietHoaDon.CurrentRow.Cells[1].Value.ToString());
            int slsp = 0;
            int sltronggio = 0;
            foreach (DataRow dr in cthd.getCTHD(mahoadon, masanpham).Rows)
            {
                sltronggio = int.Parse(dr["SoLuong"].ToString());
            }
            foreach (DataRow dr in sp.getDataSPByMaSP(masanpham).Rows)
            {
                slsp = int.Parse(dr["SoLuongTon"].ToString());
            }
            int soluonghoantra = slsp + sltronggio;
            sp.updateSP(soluonghoantra, masanpham);
            load_DGVSanPham();
            cthd.deleteCTHD(mahoadon, masanpham);

            foreach (DataRow dr in cthd.getDataCTHD(mahoadon).Rows)
            {
                tong += int.Parse(dr["SoLuong"].ToString());
                tongThanhTien += int.Parse(dr["ThanhTien"].ToString());
            }
            lbSoLuong.Text = tong.ToString() + " sản phẩm";
            lbTongTien.Text = tongThanhTien.ToString("0,00.##") + " VNĐ";
            load_DGVSanPham();
            dgvChiTietHoaDon.DataSource = cthd.getDataCTHD(mahoadon);
        }

        private void btnThemSoLuong_Click(object sender, EventArgs e)
        {
            int tong = 0;
            int slsp = 0;
            int masanpham = int.Parse(txtMaSP.Text.Trim());
            string mahoadon = txtMaHoaDon.Text.Trim();
            int sl = int.Parse(txtSoLuong.Text);
            int dongia = 0;
            int tongThanhTien = 0;
            foreach (DataRow dr in sp.getDataSPByMaSP(masanpham).Rows)
            {
                dongia = int.Parse(dr["DonGiaMoi"].ToString());
                slsp = int.Parse(dr["SoLuongTon"].ToString());
            }
            int sltronggio = 0;
            foreach (DataRow dr in cthd.getCTHD(mahoadon, masanpham).Rows)
            {
                sltronggio = int.Parse(dr["SoLuong"].ToString());
            }
            int soluonghoantra = slsp + sltronggio;
            sp.updateSP(soluonghoantra, masanpham);
            int slsp2 = 0;
            foreach (DataRow dr in sp.getDataSPByMaSP(masanpham).Rows)
            {
                slsp2 = int.Parse(dr["SoLuongTon"].ToString());
            }
            int slupdate = slsp2 - sl;

            if (slupdate < 0)
            {

                MessageBox.Show("Số lượng trong kho không đủ");
                sp.updateSP(slsp, masanpham);

                return;
            }
            sp.updateSP(slupdate, masanpham);

            int thanhtien = dongia * sl;

            cthd.suaCTHD(sl, thanhtien, mahoadon, masanpham);

            foreach (DataRow dr in cthd.getDataCTHD(mahoadon).Rows)
            {
                tong += int.Parse(dr["SoLuong"].ToString());
                tongThanhTien += int.Parse(dr["ThanhTien"].ToString());
            }
            lbSoLuong.Text = tong.ToString() + " sản phẩm";
            lbTongTien.Text = tongThanhTien.ToString("0,00.##") + " VNĐ";
            load_DGVSanPham();
            dgvChiTietHoaDon.DataSource = cthd.getDataCTHD(mahoadon);
        }

        private void dgvChiTietHoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            xoaCTHD();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            tongThanhTien = 0;
            string mahoadon = txtMaHoaDon.Text.Trim();
            foreach (DataRow dr in cthd.getDataCTHD(mahoadon).Rows)
            {
                tongThanhTien += int.Parse(dr["ThanhTien"].ToString());
            }

            hd.updateThanhTien(tongThanhTien, mahoadon);

            frmThanhToan tt = new frmThanhToan();
            tt.ShowDialog();


            txtMaHoaDon.Enabled = true;
            chkMaNgauNhien.Enabled = true;
            chkMaNgauNhien.Checked = false;
            chkKhachHang.Checked = false;
            cbKhachHang.Visible = false;
            load_DGVSanPham();
            string mahoadon1 = "";
            dgvChiTietHoaDon.DataSource = cthd.getDataCTHD(mahoadon1);
            txtMaHoaDon.Text = "";
            txtKhachHang.Text = "";
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtDonGia.Text = "";
            lbTongTien.Text = "0 VNĐ";
            lbSoLuong.Text = "0 sản phẩm";
            txtSoLuong.Text = "";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            timKiem_Button();
        }

        public void timKiem_Button()
        {
            if (txtTimKiem.Text != "" || cbTimKiem.SelectedItem.ToString() != "")
            {
                try
                {
                    if (cbTimKiem.SelectedItem.ToString() == "Mã Sản Phẩm")
                    {
                        dgvDSSanPham.DataSource = sp.TimKiemTheoMaSP(int.Parse(txtTimKiem.Text));
                    }
                    if (cbTimKiem.SelectedItem.ToString() == "Tên Sản Phẩm")
                    {
                        dgvDSSanPham.DataSource = sp.TimKiemTheoTenSP(txtTimKiem.Text);
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi chưa tìm kiếm được! Vui lòng thử lại!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm kiếm!", "Cảnh Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            load_DGVSanPham();
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            timKiem_Button();
        }
        
       
    }
}
