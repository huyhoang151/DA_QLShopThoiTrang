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
    public partial class frmQLNhanVien : Form
    {
        LoginBLL nv = new LoginBLL();
        BoPhanBLL bp = new BoPhanBLL();
        NhanVienBLL _nv = new NhanVienBLL();
        public frmQLNhanVien()
        {
            InitializeComponent();
        }

        private void frmQLNhanVien_Load(object sender, EventArgs e)
        {
            load_DGVNhanVien();
            load_CBBBoPhan();
            btnSave.Enabled = txtMaNV.Enabled = false;
        }

        private void load_DGVNhanVien()
        {
            dgvNhanVien.DataSource = nv.getDGVNhanVien();
        }

        private void load_CBBBoPhan()
        {
            cbbBoPhan.DataSource = bp.getCBBBoPhan();
            cbbBoPhan.DisplayMember = bp.getCBBBoPhan().Columns[1].ToString();
            cbbBoPhan.ValueMember = bp.getCBBBoPhan().Columns[0].ToString();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                ptbNhanVien.Image = new Bitmap(open.FileName);
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0)
            {
                DataGridViewRow row = this.dgvNhanVien.Rows[e.RowIndex];

                txtMaNV.Text = row.Cells[0].Value.ToString();
                txtTenNV.Text = row.Cells[1].Value.ToString();
                dtpNgaySinh.Text = row.Cells[2].Value.ToString();
                txtDiaChi.Text = row.Cells[3].Value.ToString();
                dtpNgayVaoLam.Text = row.Cells[4].Value.ToString();

                txtLuongCB.Text = row.Cells[6].Value.ToString();
                txtSDT.Text = row.Cells[7].Value.ToString();
                txtPass.Text = row.Cells[8].Value.ToString();
                cbbBoPhan.SelectedValue = row.Cells[9].Value;

            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            reset();
            btnAdd.Enabled = false;
        }

        public void reset()
        {
            txtTenNV.Text = string.Empty;
            dtpNgaySinh.Value =  DateTime.Parse("01/01/1990");
            txtDiaChi.Text = string.Empty;
            dtpNgayVaoLam.Value = DateTime.Now;
            txtLuongCB.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtPass.Text = string.Empty;
            cbbBoPhan.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Xác nhận thêm nhân viên", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                if (nv.themNV(txtTenNV.Text, dtpNgaySinh.Value, txtDiaChi.Text, dtpNgayVaoLam.Value, "Abc", int.Parse(txtLuongCB.Text), txtSDT.Text, txtPass.Text, int.Parse(cbbBoPhan.SelectedValue.ToString())) == true)
                {
                    MessageBox.Show("Thêm thành công");
                    load_DGVNhanVien();
                    btnAdd.Enabled = true;
                    reset();
                }
                else
                    MessageBox.Show("Thất bại");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
             DialogResult r = MessageBox.Show("Bạn có muốn xóa nhân viên", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (r == DialogResult.Yes)
             {
                 nv.xoaNV(int.Parse(dgvNhanVien.CurrentRow.Cells[0].Value.ToString()));
                 load_DGVNhanVien();
             }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn thay đổi thông tin nhân viên này", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                if (nv.suaNV(txtTenNV.Text, dtpNgaySinh.Text, txtDiaChi.Text, dtpNgayVaoLam.Text, "Abc", int.Parse(txtLuongCB.Text), txtSDT.Text, txtPass.Text, int.Parse(cbbBoPhan.SelectedValue.ToString()),int.Parse(txtMaNV.Text)) == true)
                {
                    MessageBox.Show("Cập nhập thành công");
                    load_DGVNhanVien();
                    btnAdd.Enabled = true;
                    reset();
                }
                else
                    MessageBox.Show("Thất bại");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTenNV.Text != string.Empty)
                dgvNhanVien.DataSource=_nv.SearchNV(txtTimKiem.Text);
            else
                MessageBox.Show("Vui lòng nhập tên nhân viên cần tìm");
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            dgvNhanVien.DataSource = _nv.SearchNV(txtTimKiem.Text);
        }

    }
}
