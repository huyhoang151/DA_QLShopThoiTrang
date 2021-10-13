using BLL;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMain : Form
    {
        private int ImageNumber = 1;
        private Guna2Button currentButton;
        private Panel leftBorderBtn;
        private string _SoDienThoai;
        NhanVienBLL nv = new NhanVienBLL();
        PhanQuyenBLL pq = new PhanQuyenBLL();
        public string SoDienThoai
        {
            get { return _SoDienThoai; }
            set { _SoDienThoai = value; }
        }
        public frmMain()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 45);
            panelSlideMenu.Controls.Add(leftBorderBtn);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
      

        private void frmMain_Load(object sender, EventArgs e)
        {
            //customizeDesing(); 
            List<int> boPhans = nv.getMaBoPhan(SoDienThoai);
            foreach (int item in boPhans)
            {
                DataTable dsQuyen = pq.getDataPhanQuyen(item);
                foreach (DataRow mh in dsQuyen.Rows)
                {
                    foreach (Control control in panelSlideMenu.Controls)
                    {
                        if (control is Guna2Button)
                        {
                            Guna2Button btn = (Guna2Button)control;
                            bool kq = Convert.ToBoolean(mh[1].ToString());
                            if (string.Equals(mh[2].ToString(),btn.Tag))
                            {
                                btn.Enabled = kq;
                                btn.Visible = kq;
                            }
                        }
                    }
                }
            }        
        }

        private void phanQuyenMenu()
        {
            foreach(Guna2Button btn in panelSlideMenu.Controls)
            {
                    
            }
        }


        //public void customizeDesing()
        //{
        //    panelSubHeThong.Visible = false;
        //    panelSubSanPham.Visible = false;
        //}

        //public void hideSubMenu()
        //{
        //    if (panelSubHeThong.Visible == true)
        //        panelSubHeThong.Visible = false;
        //    if (panelSubSanPham.Visible == true)
        //        panelSubSanPham.Visible = false;
        //}

        //public void showSubMenu(Panel subMenu)
        //{
        //    if (subMenu.Visible == false)
        //    {
        //        hideSubMenu();
        //        subMenu.Visible = true;
        //    }
        //    else
        //        subMenu.Visible = false;
        //}

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            frmQLNhanVien frm = new frmQLNhanVien();
            frm.TopLevel = false;
            panelContainer.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            this.Close();
        }

        

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.login.Show();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {                                                       
            if (WindowState == FormWindowState.Normal)          
                WindowState = FormWindowState.Maximized;        
            else                                                
                WindowState = FormWindowState.Normal;           
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(24, 06, 200);
        }

        private void ActivateButton(object btnsender, Color color)
        {
            if (btnsender != null)
            {
                DisableButton();

                currentButton = (Guna2Button)btnsender;
                currentButton.BackColor = Color.FromArgb(37, 37, 81);
                currentButton.ForeColor = color;
                currentButton.TextAlign = HorizontalAlignment.Center;
                currentButton.ImageAlign = HorizontalAlignment.Right;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentButton.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                btnHome.Image = currentButton.Image;
                btnHome.Text = currentButton.Text;
                btnHome.BackColor = currentButton.BackColor;
                btnHome.ForeColor = currentButton.ForeColor;    
            }
        }

        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.Transparent;
                currentButton.ForeColor = Color.White;
                currentButton.TextAlign = HorizontalAlignment.Left;
                currentButton.ImageAlign = HorizontalAlignment.Left;
            }
        }

        private void btnHome_Click(object sender, EventArgs e){
            //hideSubMenu();
            Reset();
        }

        private void panelLogo_Click(object sender, EventArgs e){
            //hideSubMenu();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            //hideSubMenu();
            leftBorderBtn.Visible = false;

            string resourceKey = "home";
            this.btnHome.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject(resourceKey);           
            btnHome.Text = "Home";
            btnHome.ForeColor = Color.White;
            panelContainer.Controls.Clear();
        }

        private void btnQLNV_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);

            this.panelContainer.Controls.Clear();
            frmQLNhanVien frm = new frmQLNhanVien();
            frm.TopLevel = false;
            panelContainer.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnBanHang_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);

            this.panelContainer.Controls.Clear();
            frmBanHang frm = new frmBanHang();
            frm.TopLevel = false;
            panelContainer.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }



        private void btnQLKhachHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            this.panelContainer.Controls.Clear();
            frmKhachHang frm = new frmKhachHang();
            frm.TopLevel = false;
            panelContainer.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnQLSanPham_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            this.panelContainer.Controls.Clear();
            frmQLSanPham frm = new frmQLSanPham();
            frm.TopLevel = false;
            panelContainer.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnQLHoaDon_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            this.panelContainer.Controls.Clear();
            frmQLHoaDon frm = new frmQLHoaDon();
            frm.TopLevel = false;
            panelContainer.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            this.panelContainer.Controls.Clear();
            frmQLNhapHang frm = new frmQLNhapHang();
            frm.TopLevel = false;
            panelContainer.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnNhaCC_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            this.panelContainer.Controls.Clear();
            frmQLNhaCungCap frm = new frmQLNhaCungCap();
            frm.TopLevel = false;
            panelContainer.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnDangXuat_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            this.Close();
        }

        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            this.panelContainer.Controls.Clear();
            frmPhanQuyen frm = new frmPhanQuyen();
            frm.TopLevel = false;
            panelContainer.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void Slider()
        {
            if (ImageNumber == 4)
            {
                ImageNumber = 1;
            }
            pictureBox1.ImageLocation = string.Format(@"Slider\{0}.jpg", ImageNumber);
            ImageNumber++;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Slider();
        }

    }
}
