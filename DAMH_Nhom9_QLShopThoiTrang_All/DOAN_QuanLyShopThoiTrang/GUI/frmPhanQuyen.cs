using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;
namespace GUI
{
    public partial class frmPhanQuyen : Form
    {
        BoPhanBLL bp = new BoPhanBLL();
        PhanQuyenBLL pq = new PhanQuyenBLL();
        public frmPhanQuyen()
        {
            InitializeComponent();
        }

        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            loadBoPhan_DataGridView();
            //loadPhanQuyen_DataGridView();
        }

        public void loadBoPhan_DataGridView()
        {
            dgvBoPhan.DataSource = bp.getCBBBoPhan();
        }

        public void loadPhanQuyen_DataGridView(int pMaBoPhan)
        {
            dgvPhanQuyen.DataSource = pq.getDataPhanQuyen(pMaBoPhan);
        }

        private void dgvBoPhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int maBoPhan = int.Parse(dgvBoPhan.CurrentRow.Cells[0].Value.ToString());
            loadPhanQuyen_DataGridView(maBoPhan);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int maBoPhan = int.Parse(dgvBoPhan.CurrentRow.Cells[0].Value.ToString());
            foreach (DataGridViewRow item in dgvPhanQuyen.Rows)
            {
                if (item.Index >= dgvPhanQuyen.Rows.Count - 1)
                    return;
                else
                {
                    pq.capNhapQuyen((bool)item.Cells[1].Value, maBoPhan, int.Parse(item.Cells[0].Value.ToString()));
                    loadBoPhan_DataGridView();
                }
            }
            MessageBox.Show("Phân quyền thành công");
        }
    }
}
