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
    public partial class frmThanhToan : Form
    {
        public frmThanhToan()
        {
            InitializeComponent();
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            lbMaHD.Text = frmBanHang.maHD;
            lbKhachHang.Text = frmBanHang.tenKH;
            lbNhanVien.Text = frmBanHang.tenNV;
            lbThoiGian.Text = frmBanHang.ngayLap.ToString();
            lbTongTien.Text = frmBanHang.tongThanhTien.ToString();
        }

        private void txtKHTT_Leave(object sender, EventArgs e)
        {
            try
            {
                int tongtien = int.Parse(lbTongTien.Text);
                int tientra = 0;
                int tien = 0;
                tien = int.Parse(txtKHTT.Text);


                tientra = tien - tongtien;
                if (tien < tongtien)
                {
                    MessageBox.Show("Tiền bạn nhập không đủ");
                    return;
                }

                lbTienThua.Text = tientra.ToString("0,00.##") + " VNĐ";
            }
            catch { MessageBox.Show("Lỗi vui lòng thử lại"); }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            frmInHoaDon frm = new frmInHoaDon();
            frm.ShowDialog();
        }
    }
}
