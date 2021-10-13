namespace GUI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panelSlideMenu = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.panelHome = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelTitleBar = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2Button();
            this.btnMaximize = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnDangXuat = new Guna.UI2.WinForms.Guna2Button();
            this.btnPhanQuyen = new Guna.UI2.WinForms.Guna2Button();
            this.btnNhaCC = new Guna.UI2.WinForms.Guna2Button();
            this.btnNhapHang = new Guna.UI2.WinForms.Guna2Button();
            this.btnQLHoaDon = new Guna.UI2.WinForms.Guna2Button();
            this.btnQLSanPham = new Guna.UI2.WinForms.Guna2Button();
            this.btnQLKhachHang = new Guna.UI2.WinForms.Guna2Button();
            this.btnQLNV = new Guna.UI2.WinForms.Guna2Button();
            this.btnBanHang = new Guna.UI2.WinForms.Guna2Button();
            this.panelLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelSlideMenu.SuspendLayout();
            this.panelHome.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSlideMenu
            // 
            this.panelSlideMenu.Controls.Add(this.btnDangXuat);
            this.panelSlideMenu.Controls.Add(this.btnPhanQuyen);
            this.panelSlideMenu.Controls.Add(this.btnNhaCC);
            this.panelSlideMenu.Controls.Add(this.btnNhapHang);
            this.panelSlideMenu.Controls.Add(this.btnQLHoaDon);
            this.panelSlideMenu.Controls.Add(this.btnQLSanPham);
            this.panelSlideMenu.Controls.Add(this.btnQLKhachHang);
            this.panelSlideMenu.Controls.Add(this.btnQLNV);
            this.panelSlideMenu.Controls.Add(this.btnBanHang);
            this.panelSlideMenu.Controls.Add(this.panelLogo);
            this.panelSlideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlideMenu.FillColor = System.Drawing.Color.Black;
            this.panelSlideMenu.FillColor2 = System.Drawing.Color.Black;
            this.panelSlideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSlideMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelSlideMenu.Name = "panelSlideMenu";
            this.panelSlideMenu.ShadowDecoration.Parent = this.panelSlideMenu;
            this.panelSlideMenu.Size = new System.Drawing.Size(207, 700);
            this.panelSlideMenu.TabIndex = 2;
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.panelContainer);
            this.panelHome.Controls.Add(this.panelTitleBar);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.Location = new System.Drawing.Point(207, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.ShadowDecoration.Parent = this.panelHome;
            this.panelHome.Size = new System.Drawing.Size(993, 700);
            this.panelHome.TabIndex = 3;
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.pictureBox1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 70);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(993, 630);
            this.panelContainer.TabIndex = 6;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.Controls.Add(this.label1);
            this.panelTitleBar.Controls.Add(this.btnHome);
            this.panelTitleBar.Controls.Add(this.panel1);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.FillColor = System.Drawing.Color.Black;
            this.panelTitleBar.FillColor2 = System.Drawing.Color.Silver;
            this.panelTitleBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.ShadowDecoration.Parent = this.panelTitleBar;
            this.panelTitleBar.Size = new System.Drawing.Size(993, 70);
            this.panelTitleBar.TabIndex = 5;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(362, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ SHOP THỜI TRANG";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnMaximize);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(894, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(96, 33);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::GUI.Properties.Resources._3;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(993, 630);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BorderColor = System.Drawing.Color.Transparent;
            this.btnHome.CheckedState.Parent = this.btnHome;
            this.btnHome.CustomImages.Parent = this.btnHome;
            this.btnHome.FillColor = System.Drawing.Color.Transparent;
            this.btnHome.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.HoverState.Parent = this.btnHome;
            this.btnHome.Image = global::GUI.Properties.Resources.home;
            this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.Location = new System.Drawing.Point(0, 35);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.ShadowDecoration.Parent = this.btnHome;
            this.btnHome.Size = new System.Drawing.Size(241, 35);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.CheckedState.Parent = this.btnMinimize;
            this.btnMinimize.CustomImages.Parent = this.btnMinimize;
            this.btnMinimize.FillColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.HoverState.Parent = this.btnMinimize;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(6, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.CheckedState.Parent = this.btnMaximize;
            this.btnMaximize.CustomImages.Parent = this.btnMaximize;
            this.btnMaximize.FillColor = System.Drawing.Color.Transparent;
            this.btnMaximize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.HoverState.Parent = this.btnMaximize;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(37, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.ShadowDecoration.Parent = this.btnMaximize;
            this.btnMaximize.Size = new System.Drawing.Size(25, 25);
            this.btnMaximize.TabIndex = 4;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.FillColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(68, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 3;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDangXuat.BackColor = System.Drawing.Color.Transparent;
            this.btnDangXuat.BorderColor = System.Drawing.Color.Transparent;
            this.btnDangXuat.CheckedState.Parent = this.btnDangXuat;
            this.btnDangXuat.CustomImages.Parent = this.btnDangXuat;
            this.btnDangXuat.FillColor = System.Drawing.Color.Transparent;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.HoverState.Parent = this.btnDangXuat;
            this.btnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Image")));
            this.btnDangXuat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 651);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ShadowDecoration.Parent = this.btnDangXuat;
            this.btnDangXuat.Size = new System.Drawing.Size(207, 45);
            this.btnDangXuat.TabIndex = 21;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click_1);
            // 
            // btnPhanQuyen
            // 
            this.btnPhanQuyen.Animated = true;
            this.btnPhanQuyen.BackColor = System.Drawing.Color.Transparent;
            this.btnPhanQuyen.BorderColor = System.Drawing.Color.Transparent;
            this.btnPhanQuyen.CheckedState.Parent = this.btnPhanQuyen;
            this.btnPhanQuyen.CustomImages.Parent = this.btnPhanQuyen;
            this.btnPhanQuyen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPhanQuyen.FillColor = System.Drawing.Color.Transparent;
            this.btnPhanQuyen.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnPhanQuyen.ForeColor = System.Drawing.Color.White;
            this.btnPhanQuyen.HoverState.Parent = this.btnPhanQuyen;
            this.btnPhanQuyen.Image = ((System.Drawing.Image)(resources.GetObject("btnPhanQuyen.Image")));
            this.btnPhanQuyen.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPhanQuyen.Location = new System.Drawing.Point(0, 450);
            this.btnPhanQuyen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPhanQuyen.Name = "btnPhanQuyen";
            this.btnPhanQuyen.ShadowDecoration.Parent = this.btnPhanQuyen;
            this.btnPhanQuyen.Size = new System.Drawing.Size(207, 45);
            this.btnPhanQuyen.TabIndex = 20;
            this.btnPhanQuyen.Tag = "Phân Quyền";
            this.btnPhanQuyen.Text = "Quản lý phân quyền";
            this.btnPhanQuyen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPhanQuyen.Click += new System.EventHandler(this.btnPhanQuyen_Click);
            // 
            // btnNhaCC
            // 
            this.btnNhaCC.Animated = true;
            this.btnNhaCC.BackColor = System.Drawing.Color.Transparent;
            this.btnNhaCC.BorderColor = System.Drawing.Color.Transparent;
            this.btnNhaCC.CheckedState.Parent = this.btnNhaCC;
            this.btnNhaCC.CustomImages.Parent = this.btnNhaCC;
            this.btnNhaCC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhaCC.FillColor = System.Drawing.Color.Transparent;
            this.btnNhaCC.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnNhaCC.ForeColor = System.Drawing.Color.White;
            this.btnNhaCC.HoverState.Parent = this.btnNhaCC;
            this.btnNhaCC.Image = ((System.Drawing.Image)(resources.GetObject("btnNhaCC.Image")));
            this.btnNhaCC.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNhaCC.Location = new System.Drawing.Point(0, 405);
            this.btnNhaCC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNhaCC.Name = "btnNhaCC";
            this.btnNhaCC.ShadowDecoration.Parent = this.btnNhaCC;
            this.btnNhaCC.Size = new System.Drawing.Size(207, 45);
            this.btnNhaCC.TabIndex = 17;
            this.btnNhaCC.Tag = "Quản lý nhà cung cấp";
            this.btnNhaCC.Text = "Quản lý nhà cung cấp";
            this.btnNhaCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNhaCC.Click += new System.EventHandler(this.btnNhaCC_Click);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.Animated = true;
            this.btnNhapHang.BackColor = System.Drawing.Color.Transparent;
            this.btnNhapHang.BorderColor = System.Drawing.Color.Transparent;
            this.btnNhapHang.CheckedState.Parent = this.btnNhapHang;
            this.btnNhapHang.CustomImages.Parent = this.btnNhapHang;
            this.btnNhapHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhapHang.FillColor = System.Drawing.Color.Transparent;
            this.btnNhapHang.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnNhapHang.ForeColor = System.Drawing.Color.White;
            this.btnNhapHang.HoverState.Parent = this.btnNhapHang;
            this.btnNhapHang.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapHang.Image")));
            this.btnNhapHang.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNhapHang.Location = new System.Drawing.Point(0, 360);
            this.btnNhapHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.ShadowDecoration.Parent = this.btnNhapHang;
            this.btnNhapHang.Size = new System.Drawing.Size(207, 45);
            this.btnNhapHang.TabIndex = 16;
            this.btnNhapHang.Tag = "Quản lý nhập hàng";
            this.btnNhapHang.Text = "Quản lý nhập hàng";
            this.btnNhapHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // btnQLHoaDon
            // 
            this.btnQLHoaDon.Animated = true;
            this.btnQLHoaDon.BackColor = System.Drawing.Color.Transparent;
            this.btnQLHoaDon.BorderColor = System.Drawing.Color.Transparent;
            this.btnQLHoaDon.CheckedState.Parent = this.btnQLHoaDon;
            this.btnQLHoaDon.CustomImages.Parent = this.btnQLHoaDon;
            this.btnQLHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLHoaDon.FillColor = System.Drawing.Color.Transparent;
            this.btnQLHoaDon.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnQLHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnQLHoaDon.HoverState.Parent = this.btnQLHoaDon;
            this.btnQLHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnQLHoaDon.Image")));
            this.btnQLHoaDon.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQLHoaDon.Location = new System.Drawing.Point(0, 315);
            this.btnQLHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQLHoaDon.Name = "btnQLHoaDon";
            this.btnQLHoaDon.ShadowDecoration.Parent = this.btnQLHoaDon;
            this.btnQLHoaDon.Size = new System.Drawing.Size(207, 45);
            this.btnQLHoaDon.TabIndex = 15;
            this.btnQLHoaDon.Tag = "Quản lý hóa đơn";
            this.btnQLHoaDon.Text = "Quản lý hóa đơn";
            this.btnQLHoaDon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQLHoaDon.Click += new System.EventHandler(this.btnQLHoaDon_Click);
            // 
            // btnQLSanPham
            // 
            this.btnQLSanPham.Animated = true;
            this.btnQLSanPham.BackColor = System.Drawing.Color.Transparent;
            this.btnQLSanPham.BorderColor = System.Drawing.Color.Transparent;
            this.btnQLSanPham.CheckedState.Parent = this.btnQLSanPham;
            this.btnQLSanPham.CustomImages.Parent = this.btnQLSanPham;
            this.btnQLSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLSanPham.FillColor = System.Drawing.Color.Transparent;
            this.btnQLSanPham.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnQLSanPham.ForeColor = System.Drawing.Color.White;
            this.btnQLSanPham.HoverState.Parent = this.btnQLSanPham;
            this.btnQLSanPham.Image = ((System.Drawing.Image)(resources.GetObject("btnQLSanPham.Image")));
            this.btnQLSanPham.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQLSanPham.ImageSize = new System.Drawing.Size(20, 25);
            this.btnQLSanPham.Location = new System.Drawing.Point(0, 270);
            this.btnQLSanPham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQLSanPham.Name = "btnQLSanPham";
            this.btnQLSanPham.ShadowDecoration.Parent = this.btnQLSanPham;
            this.btnQLSanPham.Size = new System.Drawing.Size(207, 45);
            this.btnQLSanPham.TabIndex = 14;
            this.btnQLSanPham.Tag = "Quản lý sản phẩm";
            this.btnQLSanPham.Text = "Quản lý sản phẩm";
            this.btnQLSanPham.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQLSanPham.Click += new System.EventHandler(this.btnQLSanPham_Click);
            // 
            // btnQLKhachHang
            // 
            this.btnQLKhachHang.Animated = true;
            this.btnQLKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.btnQLKhachHang.BorderColor = System.Drawing.Color.Transparent;
            this.btnQLKhachHang.CheckedState.Parent = this.btnQLKhachHang;
            this.btnQLKhachHang.CustomImages.Parent = this.btnQLKhachHang;
            this.btnQLKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLKhachHang.FillColor = System.Drawing.Color.Transparent;
            this.btnQLKhachHang.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnQLKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnQLKhachHang.HoverState.Parent = this.btnQLKhachHang;
            this.btnQLKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("btnQLKhachHang.Image")));
            this.btnQLKhachHang.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQLKhachHang.Location = new System.Drawing.Point(0, 225);
            this.btnQLKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQLKhachHang.Name = "btnQLKhachHang";
            this.btnQLKhachHang.ShadowDecoration.Parent = this.btnQLKhachHang;
            this.btnQLKhachHang.Size = new System.Drawing.Size(207, 45);
            this.btnQLKhachHang.TabIndex = 13;
            this.btnQLKhachHang.Tag = "Quản lý khách hàng";
            this.btnQLKhachHang.Text = "Quản lý khách hàng";
            this.btnQLKhachHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQLKhachHang.Click += new System.EventHandler(this.btnQLKhachHang_Click);
            // 
            // btnQLNV
            // 
            this.btnQLNV.Animated = true;
            this.btnQLNV.BackColor = System.Drawing.Color.Transparent;
            this.btnQLNV.BorderColor = System.Drawing.Color.Transparent;
            this.btnQLNV.CheckedState.Parent = this.btnQLNV;
            this.btnQLNV.CustomImages.Parent = this.btnQLNV;
            this.btnQLNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLNV.FillColor = System.Drawing.Color.Transparent;
            this.btnQLNV.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnQLNV.ForeColor = System.Drawing.Color.White;
            this.btnQLNV.HoverState.Parent = this.btnQLNV;
            this.btnQLNV.Image = ((System.Drawing.Image)(resources.GetObject("btnQLNV.Image")));
            this.btnQLNV.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQLNV.Location = new System.Drawing.Point(0, 180);
            this.btnQLNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.ShadowDecoration.Parent = this.btnQLNV;
            this.btnQLNV.Size = new System.Drawing.Size(207, 45);
            this.btnQLNV.TabIndex = 12;
            this.btnQLNV.Tag = "Quản lý nhân viên";
            this.btnQLNV.Text = "Quản lý nhân viên";
            this.btnQLNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQLNV.Click += new System.EventHandler(this.btnQLNV_Click_1);
            // 
            // btnBanHang
            // 
            this.btnBanHang.Animated = true;
            this.btnBanHang.BackColor = System.Drawing.Color.Transparent;
            this.btnBanHang.BorderColor = System.Drawing.Color.Transparent;
            this.btnBanHang.CheckedState.Parent = this.btnBanHang;
            this.btnBanHang.CustomImages.Parent = this.btnBanHang;
            this.btnBanHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBanHang.FillColor = System.Drawing.Color.Transparent;
            this.btnBanHang.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnBanHang.ForeColor = System.Drawing.Color.White;
            this.btnBanHang.HoverState.Parent = this.btnBanHang;
            this.btnBanHang.Image = ((System.Drawing.Image)(resources.GetObject("btnBanHang.Image")));
            this.btnBanHang.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBanHang.ImageSize = new System.Drawing.Size(20, 25);
            this.btnBanHang.Location = new System.Drawing.Point(0, 135);
            this.btnBanHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.ShadowDecoration.Parent = this.btnBanHang;
            this.btnBanHang.Size = new System.Drawing.Size(207, 45);
            this.btnBanHang.TabIndex = 11;
            this.btnBanHang.Tag = "Bán Hàng";
            this.btnBanHang.Text = "Bán hàng";
            this.btnBanHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click_1);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Transparent;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Image = ((System.Drawing.Image)(resources.GetObject("panelLogo.Image")));
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.ShadowDecoration.Parent = this.panelLogo;
            this.panelLogo.Size = new System.Drawing.Size(207, 135);
            this.panelLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.panelLogo.TabIndex = 3;
            this.panelLogo.TabStop = false;
            this.panelLogo.Click += new System.EventHandler(this.panelLogo_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panelSlideMenu);
            this.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panelSlideMenu.ResumeLayout(false);
            this.panelHome.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel panelSlideMenu;
        private Guna.UI2.WinForms.Guna2GradientPanel panelHome;
        private System.Windows.Forms.Panel panelContainer;
        private Guna.UI2.WinForms.Guna2GradientPanel panelTitleBar;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnMinimize;
        private Guna.UI2.WinForms.Guna2Button btnMaximize;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnNhaCC;
        private Guna.UI2.WinForms.Guna2Button btnNhapHang;
        private Guna.UI2.WinForms.Guna2Button btnQLHoaDon;
        private Guna.UI2.WinForms.Guna2Button btnQLSanPham;
        private Guna.UI2.WinForms.Guna2Button btnQLKhachHang;
        private Guna.UI2.WinForms.Guna2Button btnQLNV;
        private Guna.UI2.WinForms.Guna2Button btnBanHang;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnDangXuat;
        private Guna.UI2.WinForms.Guna2Button btnPhanQuyen;
        private Guna.UI2.WinForms.Guna2PictureBox panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;




    }
}