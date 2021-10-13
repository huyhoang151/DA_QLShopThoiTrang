namespace GUI
{
    partial class frmPhanQuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanQuyen));
            this.dgvPhanQuyen = new System.Windows.Forms.DataGridView();
            this.dgvBoPhan = new System.Windows.Forms.DataGridView();
            this.MABOPHAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENBOPHAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaManHinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenManHinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoQuyen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoPhan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhanQuyen
            // 
            this.dgvPhanQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhanQuyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaManHinh,
            this.TenManHinh,
            this.CoQuyen});
            this.dgvPhanQuyen.Location = new System.Drawing.Point(341, 73);
            this.dgvPhanQuyen.Name = "dgvPhanQuyen";
            this.dgvPhanQuyen.Size = new System.Drawing.Size(378, 288);
            this.dgvPhanQuyen.TabIndex = 5;
            // 
            // dgvBoPhan
            // 
            this.dgvBoPhan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvBoPhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoPhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MABOPHAN,
            this.TENBOPHAN});
            this.dgvBoPhan.Location = new System.Drawing.Point(12, 73);
            this.dgvBoPhan.Name = "dgvBoPhan";
            this.dgvBoPhan.Size = new System.Drawing.Size(256, 288);
            this.dgvBoPhan.TabIndex = 4;
            this.dgvBoPhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBoPhan_CellClick);
            // 
            // MABOPHAN
            // 
            this.MABOPHAN.DataPropertyName = "MaBoPhan";
            this.MABOPHAN.HeaderText = "Mã bộ phận";
            this.MABOPHAN.Name = "MABOPHAN";
            // 
            // TENBOPHAN
            // 
            this.TENBOPHAN.DataPropertyName = "TENBOPHAN";
            this.TENBOPHAN.HeaderText = "Tên bộ phận";
            this.TENBOPHAN.Name = "TENBOPHAN";
            // 
            // MaManHinh
            // 
            this.MaManHinh.DataPropertyName = "MaManHinh";
            this.MaManHinh.HeaderText = "Mã màn hình";
            this.MaManHinh.Name = "MaManHinh";
            // 
            // TenManHinh
            // 
            this.TenManHinh.DataPropertyName = "TenManHinh";
            this.TenManHinh.HeaderText = "Tên màn hình";
            this.TenManHinh.Name = "TenManHinh";
            this.TenManHinh.Width = 150;
            // 
            // CoQuyen
            // 
            this.CoQuyen.DataPropertyName = "CoQuyen";
            this.CoQuyen.HeaderText = "Có Quyền";
            this.CoQuyen.Name = "CoQuyen";
            this.CoQuyen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CoQuyen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(12, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(112, 39);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 418);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvPhanQuyen);
            this.Controls.Add(this.dgvBoPhan);
            this.Name = "frmPhanQuyen";
            this.Text = "frmPhanQuyen";
            this.Load += new System.EventHandler(this.frmPhanQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoPhan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhanQuyen;
        private System.Windows.Forms.DataGridView dgvBoPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MABOPHAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENBOPHAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaManHinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenManHinh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CoQuyen;
        private Guna.UI2.WinForms.Guna2Button btnSave;
    }
}