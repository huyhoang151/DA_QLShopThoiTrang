using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace GUI
{
    public partial class frmLogin : Form
    {
        LoginBLL login = new LoginBLL();

        public static string tendn, matkhau;

        int imgindex;
        string Dirpath;
        public frmLogin()
        {
            InitializeComponent();
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            loadListPicture();
            timer1.Interval = 1500;
            timer1.Start();
            guna2GradientPanel1.Focus();
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Gray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void ckShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !ckShowPass.Checked;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (imgindex < listBox1.Items.Count - 1)
            {
                imgindex += 1;
                listBox1.SelectedIndex = imgindex;
            }
            else if (imgindex == listBox1.Items.Count - 1)
            {
                imgindex = 0;
                listBox1.SelectedIndex = imgindex;
            } 
        }
        public void loadListPicture()
        {
            listBox1.Items.Clear();
            Dirpath = @"G:\CongNghePhanMem\3\DOAN_QuanLyShopThoiTrang\GUI\images\slideshow";
            string[] files = Directory.GetFiles(Dirpath, "*.jpg");
            foreach (string file in files)
            {
                int pos = file.LastIndexOf("||");
                string FName = file.Substring(pos + 1);
                listBox1.Items.Add(FName);
            }
            listBox1.SelectedIndex = imgindex = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = listBox1.SelectedItem.ToString();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                int count = login.getDataDangNhap(txtUsername.Text, txtPassword.Text).Rows.Count;
                if (txtUsername.Text == "Username" && txtPassword.Text == "Password")
                    MessageBox.Show("Yêu cầu nhập tài khoản và mật khẩu");
                else if (txtUsername.Text == "Username")
                    MessageBox.Show("Chưa nhập tài khoản");
                else if (txtPassword.Text == "Password")
                    MessageBox.Show("Chưa nhập mật khẩu");
                else if (count != 0)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    if (Program.main == null || Program.main.IsDisposed)
                        Program.main = new frmMain();
                    this.Visible = false;
                    Program.main.SoDienThoai = txtUsername.Text;
                    Program.main.Show();
                }
                else
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối!!!");
            }         
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
