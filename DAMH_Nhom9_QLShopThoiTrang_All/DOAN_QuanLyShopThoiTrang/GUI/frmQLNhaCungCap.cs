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
    
    public partial class frmQLNhaCungCap : Form
    {
        NhaCungCapBLL ncc = new NhaCungCapBLL();
        public frmQLNhaCungCap()
        {
            InitializeComponent();
        }

        public void loadNCC_DataGridView()
        {
            dgvNCC.DataSource = ncc.getData();
        }

        private void frmQLNhaCungCap_Load(object sender, EventArgs e)
        {
            loadNCC_DataGridView();
        }

        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvNCC.Rows[e.RowIndex];

                txtMaNCC.Text = row.Cells[0].Value.ToString();
                txtTenNCC.Text = row.Cells[1].Value.ToString();
            }
        }
    }
}
