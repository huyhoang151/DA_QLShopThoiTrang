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

namespace GUI
{
    public partial class frmQLNhapHang : Form
    {
        SanPhamBLL sp = new SanPhamBLL();
        NhanVienBLL nv = new NhanVienBLL();
        NhaCungCapBLL ncc = new NhaCungCapBLL();
        PhieuNhapBLL pn = new PhieuNhapBLL();
        CT_PhieuNhapBLL ctpn = new CT_PhieuNhapBLL();
        public static string maphieunhap;
        public static DateTime ngaynhap;
        public static string tenNV;
        int maNV;
        int maNCC;
        public static string tenNCC;
        public static int tongThanhTien;

        public frmQLNhapHang()
        {
            InitializeComponent();
        }

        private void frmQLNhapHang_Load(object sender, EventArgs e)
        {
            load_DGVSanPham();
            load_CBNhaCungCap();
            foreach (DataRow dr in nv.getDataNhanVienBySDT(frmLogin.tendn).Rows)
            {
                maNV = int.Parse(dr["MaNhanVien"].ToString());
                tenNV = dr["HoTenNhanVien"].ToString();
            }
            txtNhanVien.Text = tenNV;
            btnXoa.Enabled = false;
            btnLamMoi.Enabled = false;
            btnNhapKho.Enabled = false;
        }

        private void load_DGVSanPham()
        {
            dgvDSSanPham.DataSource = sp.LoadDSSP();
        }
        private void load_CBNhaCungCap()
        {
            cbNhaCungCap.DataSource = ncc.getData();
            cbNhaCungCap.DisplayMember = ncc.getData().Columns[1].ToString();
            cbNhaCungCap.ValueMember = ncc.getData().Columns[0].ToString();
        }


        private void chkMaNgauNhien_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMaNgauNhien.Checked == true)
            {
                int Numrd;

                Random rd = new Random();
                Numrd = rd.Next(1, 100);
                txtMaPhieuNhap.Text = "PN0" + rd.Next(1000, 99999).ToString();
                txtMaPhieuNhap.Enabled = false;
                chkMaNgauNhien.Enabled = false;
            }
        }

        private void dgvDSSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (e.RowIndex == -1) return;
            txtMaSP.Text = dgvDSSanPham.Rows[index].Cells[0].Value.ToString().Trim();
            txtTenSP.Text = dgvDSSanPham.Rows[index].Cells[1].Value.ToString().Trim();
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
            txtMoTa.Text = dgvDSSanPham.Rows[index].Cells[3].Value.ToString().Trim();
            //txtSoLuong.Text = dgvDSSanPham.Rows[index].Cells[4].Value.ToString().Trim();
            txtLoai.Text = dgvDSSanPham.Rows[index].Cells[7].Value.ToString().Trim();
            txtDonGia.Text = dgvDSSanPham.Rows[index].Cells[8].Value.ToString().Trim();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaPhieuNhap.Text == "" || cbNhaCungCap.Text == "" || txtNhanVien.Text == "" || txtSoLuong.Text == "")
                {
                    MessageBox.Show("Không được để trống");
                }
                else
                {
                    btnXoa.Enabled = true;
                    btnLamMoi.Enabled = true;
                    btnNhapKho.Enabled = true;

                    int tong = 0;
                    int tongThanhTien = 0;
                    int masanpham = int.Parse(txtMaSP.Text.Trim());
                    string tensanpham = txtTenSP.Text.Trim();
                    int dongia = int.Parse(txtDonGia.Text.Trim());
                    maphieunhap = txtMaPhieuNhap.Text.Trim();
                    int soluongnhaphang = int.Parse(txtSoLuong.Text.Trim());
                    maNCC = int.Parse(cbNhaCungCap.SelectedValue.ToString().Trim());
                    foreach (DataRow dr in ncc.getDataByMaNCC(maNCC).Rows)
                    {
                        tenNCC = dr["TenNhaCungCap"].ToString();
                    }
                    tenNV = txtNhanVien.Text.Trim();
                    ngaynhap = dtpNgayLap.Value;

                    int thanhtien = dongia * soluongnhaphang;


                    if (ctpn.KTTC(maphieunhap, masanpham) == false)
                    {
                        MessageBox.Show("Sản phẩm đã có trong giỏ hàng của bạn");
                        return;
                    }

                    if (ctpn.KTMaPN(maphieunhap) > 0)
                    {
                        int slt1 = 0;
                        foreach (DataRow dr in sp.getDataSPByMaSP(masanpham).Rows)
                        {
                            slt1 = int.Parse(dr["SoLuongTon"].ToString());
                        }
                        ctpn.themCTPN(maphieunhap, masanpham, soluongnhaphang, dongia, thanhtien);
                        foreach (DataRow dr in ctpn.getDataCTPN(maphieunhap).Rows)
                        {
                            tong += int.Parse(dr["SoLuong"].ToString());
                            tongThanhTien += int.Parse(dr["ThanhTien"].ToString());
                        }
                        int soluongTang2 = slt1 + soluongnhaphang;
                        lbTongTien.Text = tongThanhTien.ToString("0,00.##") + " VNĐ";
                        lbSoLuong.Text = tong.ToString() + " sản phẩm";
                        sp.updateSP(soluongTang2, masanpham);
                        load_DGVSanPham();
                        dgvChiTietPhieuNhap.DataSource = ctpn.getDataCTPN(maphieunhap);
                        return;
                    }
                    int slt = 0;
                    foreach (DataRow dr in sp.getDataSPByMaSP(masanpham).Rows)
                    {
                        slt = int.Parse(dr["SoLuongTon"].ToString());
                    }
                    pn.themPN(maphieunhap, ngaynhap, maNCC, maNV, 0);

                    ctpn.themCTPN(maphieunhap, masanpham, soluongnhaphang, dongia, thanhtien);

                    foreach (DataRow dr in ctpn.getDataCTPN(maphieunhap).Rows)
                    {
                        tong += int.Parse(dr["SoLuong"].ToString());
                        tongThanhTien += int.Parse(dr["ThanhTien"].ToString());
                    }
                    int soluongTang1 = slt + soluongnhaphang;
                    sp.updateSP(soluongTang1, masanpham);
                    lbTongTien.Text = tongThanhTien.ToString("0,00.##") + " VNĐ";
                    lbSoLuong.Text = tong.ToString() + " sản phẩm";
                    load_DGVSanPham();
                    dgvChiTietPhieuNhap.DataSource = ctpn.getDataCTPN(maphieunhap);
                }
            }
            catch
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            int slsp = 0;
            int sltronggio = 0;
            maphieunhap = txtMaPhieuNhap.Text.Trim();
            int masanpham = int.Parse(dgvChiTietPhieuNhap.CurrentRow.Cells[1].Value.ToString());
            foreach (DataRow dr in sp.getDataSPByMaSP(masanpham).Rows)
            {
                slsp = int.Parse(dr["SoLuongTon"].ToString());
            }
            foreach (DataRow dr in ctpn.getCTPN(maphieunhap, masanpham).Rows)
            {
                sltronggio = int.Parse(dr["SoLuong"].ToString());
            }
            int soluonghoantra = slsp - sltronggio;
            sp.updateSP(soluonghoantra, masanpham);
            load_DGVSanPham();
            txtMaPhieuNhap.Enabled = true;
            chkMaNgauNhien.Enabled = true;
            chkMaNgauNhien.Checked = false;
            ctpn.delete(maphieunhap);
            string maphieunhap1 = "";
            dgvChiTietPhieuNhap.DataSource = ctpn.getDataCTPN(maphieunhap1);
            txtMaPhieuNhap.Text = "";
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtDonGia.Text = "";
            txtSoLuong.Text = "";
            txtMoTa.Text = "";
            txtLoai.Text = "";
            lbTongTien.Text = "0 VNĐ";
            lbSoLuong.Text = "0 sản phẩm";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int tongThanhTien = 0;
            int tong = 0;
            int slsp = 0;
            int sltronggio = 0;
            maphieunhap = txtMaPhieuNhap.Text.Trim();
            int masanpham = int.Parse(dgvChiTietPhieuNhap.CurrentRow.Cells[1].Value.ToString());
            foreach (DataRow dr in sp.getDataSPByMaSP(masanpham).Rows)
            {
                slsp = int.Parse(dr["SoLuongTon"].ToString());
            }
            foreach (DataRow dr in ctpn.getCTPN(maphieunhap, masanpham).Rows)
            {
                sltronggio = int.Parse(dr["SoLuong"].ToString());
            }
            int soluonghoantra = slsp - sltronggio;
            sp.updateSP(soluonghoantra, masanpham);
            load_DGVSanPham();
            ctpn.xoaCTPN(maphieunhap, masanpham);
            foreach (DataRow dr in ctpn.getDataCTPN(maphieunhap).Rows)
            {
                tong += int.Parse(dr["SoLuong"].ToString());
                tongThanhTien += int.Parse(dr["ThanhTien"].ToString());
            }

            lbTongTien.Text = tongThanhTien.ToString("0,00.##") + " VNĐ";
            lbSoLuong.Text = tong.ToString() + " sản phẩm";
            load_DGVSanPham();
            dgvChiTietPhieuNhap.DataSource = ctpn.getDataCTPN(maphieunhap);
        }


        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn in phiếu nhập không?", "THÔNG BÁO", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                tongThanhTien = 0;
                maphieunhap = txtMaPhieuNhap.Text.Trim();
                foreach (DataRow dr in ctpn.getDataCTPN(maphieunhap).Rows)
                {
                    tongThanhTien += int.Parse(dr["ThanhTien"].ToString());
                }
                pn.updateTongTien(tongThanhTien, maphieunhap);

                frmInPhieuNhap frm = new frmInPhieuNhap();
                frm.ShowDialog();
                
                txtMaPhieuNhap.Enabled = true;
                chkMaNgauNhien.Enabled = true;
                chkMaNgauNhien.Checked = false;
                string maphieunhap1="";
                load_DGVSanPham();
                dgvChiTietPhieuNhap.DataSource = ctpn.getDataCTPN(maphieunhap1);
                txtMaPhieuNhap.Text = "";
                txtMaSP.Text = "";
                txtTenSP.Text = "";
                txtDonGia.Text = "";
                txtSoLuong.Text = "";
                txtMoTa.Text = "";
                txtLoai.Text = "";
                lbTongTien.Text = "0 VNĐ";
                lbSoLuong.Text = "0 sản phẩm";
                return;
            }
            else if (dialogResult == DialogResult.No)
            {
                int tongThanhTien = 0;
                maphieunhap = txtMaPhieuNhap.Text.Trim();
                foreach (DataRow dr in ctpn.getDataCTPN(maphieunhap).Rows)
                {
                    tongThanhTien += int.Parse(dr["ThanhTien"].ToString());
                }
                pn.updateTongTien(tongThanhTien, maphieunhap);
                txtMaPhieuNhap.Enabled = true;
                chkMaNgauNhien.Enabled = true;
                chkMaNgauNhien.Checked = false;
                string maphieunhap2 = "";
                load_DGVSanPham();
                dgvChiTietPhieuNhap.DataSource = ctpn.getDataCTPN(maphieunhap2);
                txtMaPhieuNhap.Text = "";
                txtMaSP.Text = "";
                txtTenSP.Text = "";
                txtDonGia.Text = "";
                txtSoLuong.Text = "";
                txtMoTa.Text = "";
                txtLoai.Text = "";
                lbTongTien.Text = "0 VNĐ";
                lbSoLuong.Text = "0 sản phẩm";
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
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
            load_DGVSanPham();
        }

        private void btnThemSoLuong_Click(object sender, EventArgs e)
        {
            int tong = 0;
            int masanpham = int.Parse(txtMaSP.Text.Trim());
            maphieunhap = txtMaPhieuNhap.Text.Trim();
            int sl = int.Parse(txtSoLuong.Text.Trim());
            int dongiagoc = 0;
            int tongThanhTien = 0;
            int soluonggoc = 0;
            foreach (DataRow dr in sp.getDataSPByMaSP(masanpham).Rows)
            {
                dongiagoc = int.Parse(dr["DonGiaMoi"].ToString());
                soluonggoc = int.Parse(dr["SoLuongTon"].ToString());
            }

            int thanhtien = dongiagoc * (sl + soluonggoc);
            
            int slthem=0;
            if (txtThemSoLuong.Text == string.Empty)
                slthem = sl + int.Parse(txtThemSoLuong.Text);
            else
                MessageBox.Show("Vui lòng nhập số lượng thêm");

            int soluongsauupdate = slthem + (soluonggoc-sl);
            ctpn.suaCTPN(slthem, thanhtien, maphieunhap, masanpham);
            
            sp.updateSP(soluongsauupdate, masanpham);
            foreach (DataRow dr in ctpn.getDataCTPN(maphieunhap).Rows)
            {
                tong += int.Parse(dr["SoLuong"].ToString());
                tongThanhTien += int.Parse(dr["ThanhTien"].ToString());
            }

            lbTongTien.Text = tongThanhTien.ToString("0,00.##") + " VNĐ";
            lbSoLuong.Text = tong.ToString() + " sản phẩm";
            load_DGVSanPham();
            dgvChiTietPhieuNhap.DataSource = ctpn.getDataCTPN(maphieunhap);
        }
    }
}
