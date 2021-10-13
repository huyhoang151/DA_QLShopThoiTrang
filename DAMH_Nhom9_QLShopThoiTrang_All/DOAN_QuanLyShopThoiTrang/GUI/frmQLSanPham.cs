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
    public partial class frmQLSanPham : Form
    {
        SanPhamBLL sp = new SanPhamBLL();
        LoaiSanPhamBLL loai = new LoaiSanPhamBLL();
        DonGiaBLL dg = new DonGiaBLL();
        private string duongDan;
        public frmQLSanPham()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Xác nhận thêm sản phẩm", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                if (sp.themSP(txtTenSP.Text, "abc",txtMoTa.Text, int.Parse(txtSLT.Text), int.Parse(cbbLoaiSanPham.SelectedValue.ToString()), int.Parse(cbbDonGia.SelectedValue.ToString())) == true)
                {
                    MessageBox.Show("Thêm thành công");
                    load_DGVSanPham();
                    btnAdd.Enabled = true;
                    reset();
                }
                else
                    MessageBox.Show("Thất bại");
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picHinh.Image = new Bitmap(open.FileName);
            }
        }

        private void frmQLSanPham_Load(object sender, EventArgs e)
        {
            load_DGVSanPham();
            load_CBBLoai();
            load_CBBDonGia();
        }

        private void load_DGVSanPham()
        {
            dgvSanPham.DataSource = sp.LoadDSSP();
        }

        public void load_CBBLoai()
        {
            cbbLoaiSanPham.DataSource = loai.getLoai();
            cbbLoaiSanPham.DisplayMember = "TenLoai";
            cbbLoaiSanPham.ValueMember = "MaLoai";

        }

        public void load_CBBDonGia()
        {
            cbbDonGia.DataSource = dg.getDonGia();
            cbbDonGia.DisplayMember = "DonGiaMoi";
            cbbDonGia.ValueMember = "MaDonGia";

        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvSanPham.Rows[e.RowIndex];

                txtMaSP.Text = row.Cells[0].Value.ToString();
                txtTenSP.Text = row.Cells[1].Value.ToString();
                txtMoTa.Text = row.Cells[3].Value.ToString();
                txtSLT.Text = row.Cells[4].Value.ToString();
                cbbLoaiSanPham.Text = row.Cells[5].Value.ToString();
                cbbDonGia.Text = row.Cells[6].Value.ToString();
                string hinhanh = row.Cells[2].Value.ToString().Trim();
                try
                {
                    if (hinhanh != " " && hinhanh != "" && hinhanh != null)
                    {
                        picHinh.ImageLocation = string.Format(@"img\{0}", row.Cells[2].Value.ToString().Trim());
                        duongDan = picHinh.ImageLocation;
                        txtMaSP.Text = duongDan;
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
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            reset();
            btnAdd.Enabled = false;
        }

        public void reset()
        {
            txtTenSP.Text = string.Empty;
            txtMaSP.Text = string.Empty;
            txtSLT.Text = string.Empty;
            txtMoTa.Text = string.Empty;
            txtTimKiem.Text = string.Empty;
            cbbDonGia.SelectedIndex = -1;
            cbbLoaiSanPham.SelectedIndex = -1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn xóa sản phẩm", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                sp.xoaSP(int.Parse(dgvSanPham.CurrentRow.Cells[0].Value.ToString()));
                load_DGVSanPham();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool kq = sp.suaSP(txtTenSP.Text, dgvSanPham.CurrentRow.Cells[2].Value.ToString(), txtMoTa.Text, int.Parse(txtSLT.Text), int.Parse(cbbLoaiSanPham.SelectedValue.ToString()), int.Parse(cbbDonGia.SelectedValue.ToString()), int.Parse(txtMaSP.Text));
            if (kq)
                MessageBox.Show("Cập nhập thành công");
            else
                MessageBox.Show("Cập nhập không thành công");
            load_DGVSanPham();
        }

       

        public void timKiem_ClickButton()
        {
            if (txtTimKiem.Text != "" || cbTimKiem.SelectedItem.ToString() != "")
            {
                try
                {
                    if (cbTimKiem.SelectedItem.ToString() == "Mã Sản Phẩm")
                    {
                        dgvSanPham.DataSource = sp.TimKiemTheoMaSP(int.Parse(txtTimKiem.Text));
                    }
                    if (cbTimKiem.SelectedItem.ToString() == "Tên Sản Phẩm")
                    {
                        dgvSanPham.DataSource = sp.TimKiemTheoTenSP(txtTimKiem.Text);
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

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            timKiem_ClickButton();
        }

        private void btnTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            timKiem_ClickButton();
        }


    }
}
