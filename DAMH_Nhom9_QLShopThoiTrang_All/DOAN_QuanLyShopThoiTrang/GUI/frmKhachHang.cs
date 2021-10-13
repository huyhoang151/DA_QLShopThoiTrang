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
    public partial class frmKhachHang : Form
    {
        KhachHangBLL kh = new KhachHangBLL();
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            loadDGVKhachHang();
            btnLuu.Enabled = txtMaKH.Enabled = false;
        }

        public void loadDGVKhachHang()
        {
            dgvKhachHang.DataSource = kh.getDGVKhachHang();
        }

        public void reset()
        {
            txtTenKH.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtSDT.Text = string.Empty;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            reset();
            btnThem.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn xóa khách hàng", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                kh.xoaKhachHang(int.Parse(dgvKhachHang.CurrentRow.Cells[0].Value.ToString()));
                loadDGVKhachHang();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn thay đổi thông tin khách hàng này", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                if (kh.suaKhachHang(txtTenKH.Text, txtSDT.Text, txtDiaChi.Text, int.Parse(txtTenKH.Text)) == true)
                {
                    MessageBox.Show("Cập nhập thành công");
                    loadDGVKhachHang();
                    btnThem.Enabled = true;
                    reset();
                }
                else
                    MessageBox.Show("Thất bại");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Xác nhận thêm khách hàng", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (txtTenKH.Text == string.Empty || txtSDT.Text == string.Empty || txtDiaChi.Text == string.Empty)
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin");
            else if (r == DialogResult.Yes)
            {
                if (kh.themKhachHang(txtTenKH.Text, txtDiaChi.Text, txtSDT.Text))
                {
                    MessageBox.Show("Thêm thành công");
                    loadDGVKhachHang();
                    btnThem.Enabled = true;
                    reset();
                }
                else
                    MessageBox.Show("Thất bại");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text != string.Empty)
                dgvKhachHang.DataSource = kh.getDataKhachHangSearch(txtTimKiem.Text);
            else
                MessageBox.Show("Vui lòng nhập tên khách hàng cần tìm");
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvKhachHang.Rows[e.RowIndex];

                txtMaKH.Text = row.Cells[0].Value.ToString();
                txtTenKH.Text = row.Cells[1].Value.ToString();
                txtDiaChi.Text = row.Cells[2].Value.ToString();
                txtSDT.Text = row.Cells[3].Value.ToString();
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
