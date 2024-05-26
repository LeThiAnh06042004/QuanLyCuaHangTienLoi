
namespace GUI
{
    partial class GUI_TaoHDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_TaoHDB));
            this.gbThanhToan = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtTongTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSLSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.gbBanHang = new System.Windows.Forms.GroupBox();
            this.btnChiTietHDB = new Guna.UI2.WinForms.Guna2Button();
            this.cboMaSP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnMoi = new Guna.UI2.WinForms.Guna2Button();
            this.btnChonSP = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.txtThanhTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTenSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGiaBan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSL = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgGioHang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbHoaDon = new System.Windows.Forms.GroupBox();
            this.btnMoiHDB = new Guna.UI2.WinForms.Guna2Button();
            this.btnThoat = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnChonHD = new Guna.UI2.WinForms.Guna2Button();
            this.dtNgayBan = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnVe = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMaNV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaHD = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.gbThanhToan.SuspendLayout();
            this.gbBanHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGioHang)).BeginInit();
            this.gbHoaDon.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbThanhToan
            // 
            this.gbThanhToan.BackColor = System.Drawing.SystemColors.Control;
            this.gbThanhToan.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.gbThanhToan.Controls.Add(this.txtTongTien);
            this.gbThanhToan.Controls.Add(this.label7);
            this.gbThanhToan.Controls.Add(this.txtSLSP);
            this.gbThanhToan.Controls.Add(this.label12);
            this.gbThanhToan.CustomBorderColor = System.Drawing.Color.DarkSeaGreen;
            this.gbThanhToan.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThanhToan.ForeColor = System.Drawing.Color.Black;
            this.gbThanhToan.Location = new System.Drawing.Point(9, 344);
            this.gbThanhToan.Margin = new System.Windows.Forms.Padding(2);
            this.gbThanhToan.Name = "gbThanhToan";
            this.gbThanhToan.Size = new System.Drawing.Size(286, 125);
            this.gbThanhToan.TabIndex = 17;
            this.gbThanhToan.Text = "Thanh toán";
            // 
            // txtTongTien
            // 
            this.txtTongTien.AutoRoundedCorners = true;
            this.txtTongTien.BorderColor = System.Drawing.Color.Black;
            this.txtTongTien.BorderRadius = 10;
            this.txtTongTien.BorderThickness = 0;
            this.txtTongTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTongTien.DefaultText = "";
            this.txtTongTien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTongTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTongTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongTien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongTien.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.txtTongTien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongTien.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtTongTien.ForeColor = System.Drawing.Color.White;
            this.txtTongTien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongTien.Location = new System.Drawing.Point(108, 90);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.PasswordChar = '\0';
            this.txtTongTien.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtTongTien.PlaceholderText = "";
            this.txtTongTien.SelectedText = "";
            this.txtTongTien.Size = new System.Drawing.Size(152, 23);
            this.txtTongTien.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 99);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tổng tiền:";
            // 
            // txtSLSP
            // 
            this.txtSLSP.AutoRoundedCorners = true;
            this.txtSLSP.BorderColor = System.Drawing.Color.Black;
            this.txtSLSP.BorderRadius = 10;
            this.txtSLSP.BorderThickness = 0;
            this.txtSLSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSLSP.DefaultText = "";
            this.txtSLSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSLSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSLSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSLSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSLSP.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.txtSLSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSLSP.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtSLSP.ForeColor = System.Drawing.Color.White;
            this.txtSLSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSLSP.Location = new System.Drawing.Point(165, 53);
            this.txtSLSP.Margin = new System.Windows.Forms.Padding(4);
            this.txtSLSP.Name = "txtSLSP";
            this.txtSLSP.PasswordChar = '\0';
            this.txtSLSP.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtSLSP.PlaceholderText = "";
            this.txtSLSP.SelectedText = "";
            this.txtSLSP.Size = new System.Drawing.Size(95, 23);
            this.txtSLSP.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 62);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 15);
            this.label12.TabIndex = 12;
            this.label12.Text = "Số lượng sản phẩm:";
            // 
            // gbBanHang
            // 
            this.gbBanHang.BackColor = System.Drawing.Color.White;
            this.gbBanHang.Controls.Add(this.btnChiTietHDB);
            this.gbBanHang.Controls.Add(this.cboMaSP);
            this.gbBanHang.Controls.Add(this.btnMoi);
            this.gbBanHang.Controls.Add(this.btnChonSP);
            this.gbBanHang.Controls.Add(this.btnSua);
            this.gbBanHang.Controls.Add(this.btnXoa);
            this.gbBanHang.Controls.Add(this.btnThem);
            this.gbBanHang.Controls.Add(this.txtThanhTien);
            this.gbBanHang.Controls.Add(this.label11);
            this.gbBanHang.Controls.Add(this.txtTenSP);
            this.gbBanHang.Controls.Add(this.label6);
            this.gbBanHang.Controls.Add(this.txtGiaBan);
            this.gbBanHang.Controls.Add(this.txtSL);
            this.gbBanHang.Controls.Add(this.label8);
            this.gbBanHang.Controls.Add(this.label9);
            this.gbBanHang.Controls.Add(this.label10);
            this.gbBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBanHang.Location = new System.Drawing.Point(9, 11);
            this.gbBanHang.Margin = new System.Windows.Forms.Padding(2);
            this.gbBanHang.Name = "gbBanHang";
            this.gbBanHang.Padding = new System.Windows.Forms.Padding(2);
            this.gbBanHang.Size = new System.Drawing.Size(287, 307);
            this.gbBanHang.TabIndex = 15;
            this.gbBanHang.TabStop = false;
            this.gbBanHang.Text = "Thông tin mua hàng";
            // 
            // btnChiTietHDB
            // 
            this.btnChiTietHDB.AutoRoundedCorners = true;
            this.btnChiTietHDB.BorderRadius = 13;
            this.btnChiTietHDB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChiTietHDB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChiTietHDB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChiTietHDB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChiTietHDB.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btnChiTietHDB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnChiTietHDB.ForeColor = System.Drawing.Color.White;
            this.btnChiTietHDB.Image = ((System.Drawing.Image)(resources.GetObject("btnChiTietHDB.Image")));
            this.btnChiTietHDB.Location = new System.Drawing.Point(206, 14);
            this.btnChiTietHDB.Margin = new System.Windows.Forms.Padding(2);
            this.btnChiTietHDB.Name = "btnChiTietHDB";
            this.btnChiTietHDB.Size = new System.Drawing.Size(34, 29);
            this.btnChiTietHDB.TabIndex = 25;
            this.btnChiTietHDB.Click += new System.EventHandler(this.btnChiTietHDN_Click);
            // 
            // cboMaSP
            // 
            this.cboMaSP.AutoRoundedCorners = true;
            this.cboMaSP.BackColor = System.Drawing.Color.Transparent;
            this.cboMaSP.BorderColor = System.Drawing.Color.Black;
            this.cboMaSP.BorderRadius = 17;
            this.cboMaSP.BorderThickness = 0;
            this.cboMaSP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMaSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaSP.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.cboMaSP.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMaSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMaSP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboMaSP.ForeColor = System.Drawing.Color.White;
            this.cboMaSP.ItemHeight = 30;
            this.cboMaSP.Location = new System.Drawing.Point(108, 55);
            this.cboMaSP.Margin = new System.Windows.Forms.Padding(2);
            this.cboMaSP.Name = "cboMaSP";
            this.cboMaSP.Size = new System.Drawing.Size(155, 36);
            this.cboMaSP.TabIndex = 21;
            this.cboMaSP.SelectedIndexChanged += new System.EventHandler(this.cboMaSP_SelectedIndexChanged);
            // 
            // btnMoi
            // 
            this.btnMoi.AutoRoundedCorners = true;
            this.btnMoi.BorderRadius = 13;
            this.btnMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMoi.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btnMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnMoi.ForeColor = System.Drawing.Color.White;
            this.btnMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnMoi.Image")));
            this.btnMoi.Location = new System.Drawing.Point(19, 251);
            this.btnMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(39, 29);
            this.btnMoi.TabIndex = 20;
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click);
            // 
            // btnChonSP
            // 
            this.btnChonSP.AutoRoundedCorners = true;
            this.btnChonSP.BorderRadius = 13;
            this.btnChonSP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChonSP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChonSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChonSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChonSP.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btnChonSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnChonSP.ForeColor = System.Drawing.Color.White;
            this.btnChonSP.Location = new System.Drawing.Point(244, 14);
            this.btnChonSP.Margin = new System.Windows.Forms.Padding(2);
            this.btnChonSP.Name = "btnChonSP";
            this.btnChonSP.Size = new System.Drawing.Size(39, 29);
            this.btnChonSP.TabIndex = 19;
            this.btnChonSP.Text = "+";
            this.btnChonSP.Click += new System.EventHandler(this.btnChonSP_Click);
            // 
            // btnSua
            // 
            this.btnSua.AutoRoundedCorners = true;
            this.btnSua.BorderRadius = 13;
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSua.Location = new System.Drawing.Point(155, 251);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(39, 29);
            this.btnSua.TabIndex = 18;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoRoundedCorners = true;
            this.btnXoa.BorderRadius = 13;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(220, 251);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(39, 29);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.AutoRoundedCorners = true;
            this.btnThem.BorderRadius = 13;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(83, 251);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(39, 29);
            this.btnThem.TabIndex = 15;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.AutoRoundedCorners = true;
            this.txtThanhTien.BorderColor = System.Drawing.Color.Black;
            this.txtThanhTien.BorderRadius = 10;
            this.txtThanhTien.BorderThickness = 0;
            this.txtThanhTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThanhTien.DefaultText = "";
            this.txtThanhTien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtThanhTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtThanhTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThanhTien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.txtThanhTien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThanhTien.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtThanhTien.ForeColor = System.Drawing.Color.Black;
            this.txtThanhTien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThanhTien.Location = new System.Drawing.Point(535, 29);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.PasswordChar = '\0';
            this.txtThanhTien.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtThanhTien.PlaceholderText = "";
            this.txtThanhTien.SelectedText = "";
            this.txtThanhTien.Size = new System.Drawing.Size(152, 23);
            this.txtThanhTien.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(456, 29);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 15);
            this.label11.TabIndex = 12;
            this.label11.Text = "Thành tiền:";
            // 
            // txtTenSP
            // 
            this.txtTenSP.AutoRoundedCorners = true;
            this.txtTenSP.BorderColor = System.Drawing.Color.Black;
            this.txtTenSP.BorderRadius = 10;
            this.txtTenSP.BorderThickness = 0;
            this.txtTenSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenSP.DefaultText = "";
            this.txtTenSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenSP.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.txtTenSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenSP.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtTenSP.ForeColor = System.Drawing.Color.White;
            this.txtTenSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenSP.Location = new System.Drawing.Point(108, 106);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.PasswordChar = '\0';
            this.txtTenSP.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtTenSP.PlaceholderText = "";
            this.txtTenSP.ReadOnly = true;
            this.txtTenSP.SelectedText = "";
            this.txtTenSP.Size = new System.Drawing.Size(155, 23);
            this.txtTenSP.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 110);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tên sản phẩm:";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.AutoRoundedCorners = true;
            this.txtGiaBan.BorderColor = System.Drawing.Color.Black;
            this.txtGiaBan.BorderRadius = 10;
            this.txtGiaBan.BorderThickness = 0;
            this.txtGiaBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaBan.DefaultText = "";
            this.txtGiaBan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiaBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiaBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaBan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaBan.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.txtGiaBan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaBan.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtGiaBan.ForeColor = System.Drawing.Color.White;
            this.txtGiaBan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaBan.Location = new System.Drawing.Point(108, 187);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.PasswordChar = '\0';
            this.txtGiaBan.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtGiaBan.PlaceholderText = "";
            this.txtGiaBan.ReadOnly = true;
            this.txtGiaBan.SelectedText = "";
            this.txtGiaBan.Size = new System.Drawing.Size(155, 23);
            this.txtGiaBan.TabIndex = 7;
            // 
            // txtSL
            // 
            this.txtSL.AutoRoundedCorners = true;
            this.txtSL.BorderColor = System.Drawing.Color.Black;
            this.txtSL.BorderRadius = 10;
            this.txtSL.BorderThickness = 0;
            this.txtSL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSL.DefaultText = "";
            this.txtSL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSL.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.txtSL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSL.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtSL.ForeColor = System.Drawing.Color.White;
            this.txtSL.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSL.Location = new System.Drawing.Point(108, 146);
            this.txtSL.Margin = new System.Windows.Forms.Padding(4);
            this.txtSL.Name = "txtSL";
            this.txtSL.PasswordChar = '\0';
            this.txtSL.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtSL.PlaceholderText = "";
            this.txtSL.SelectedText = "";
            this.txtSL.Size = new System.Drawing.Size(155, 23);
            this.txtSL.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 69);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Mã sản phẩm:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 187);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Giá bán:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 149);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 15);
            this.label10.TabIndex = 4;
            this.label10.Text = "Số lượng:";
            // 
            // dgGioHang
            // 
            this.dgGioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgGioHang.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGioHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgGioHang.Location = new System.Drawing.Point(308, 184);
            this.dgGioHang.Margin = new System.Windows.Forms.Padding(2);
            this.dgGioHang.Name = "dgGioHang";
            this.dgGioHang.RowHeadersWidth = 62;
            this.dgGioHang.RowTemplate.Height = 28;
            this.dgGioHang.Size = new System.Drawing.Size(577, 285);
            this.dgGioHang.TabIndex = 16;
            this.dgGioHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgGioHang_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã sản phẩm";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên sản phẩm";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số lượng";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Giá bán";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // gbHoaDon
            // 
            this.gbHoaDon.BackColor = System.Drawing.Color.White;
            this.gbHoaDon.Controls.Add(this.btnMoiHDB);
            this.gbHoaDon.Controls.Add(this.btnThoat);
            this.gbHoaDon.Controls.Add(this.btnLuu);
            this.gbHoaDon.Controls.Add(this.btnChonHD);
            this.gbHoaDon.Controls.Add(this.dtNgayBan);
            this.gbHoaDon.Controls.Add(this.btnVe);
            this.gbHoaDon.Controls.Add(this.label1);
            this.gbHoaDon.Controls.Add(this.cboMaNV);
            this.gbHoaDon.Controls.Add(this.label5);
            this.gbHoaDon.Controls.Add(this.txtMaHD);
            this.gbHoaDon.Controls.Add(this.label4);
            this.gbHoaDon.Controls.Add(this.txtTenKH);
            this.gbHoaDon.Controls.Add(this.txtSDT);
            this.gbHoaDon.Controls.Add(this.label3);
            this.gbHoaDon.Controls.Add(this.label2);
            this.gbHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHoaDon.Location = new System.Drawing.Point(308, 14);
            this.gbHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.gbHoaDon.Name = "gbHoaDon";
            this.gbHoaDon.Padding = new System.Windows.Forms.Padding(2);
            this.gbHoaDon.Size = new System.Drawing.Size(577, 155);
            this.gbHoaDon.TabIndex = 14;
            this.gbHoaDon.TabStop = false;
            this.gbHoaDon.Text = "Thông tin hóa đơn";
            // 
            // btnMoiHDB
            // 
            this.btnMoiHDB.AutoRoundedCorners = true;
            this.btnMoiHDB.BorderRadius = 13;
            this.btnMoiHDB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMoiHDB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMoiHDB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMoiHDB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMoiHDB.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btnMoiHDB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnMoiHDB.ForeColor = System.Drawing.Color.White;
            this.btnMoiHDB.Image = ((System.Drawing.Image)(resources.GetObject("btnMoiHDB.Image")));
            this.btnMoiHDB.Location = new System.Drawing.Point(367, 20);
            this.btnMoiHDB.Margin = new System.Windows.Forms.Padding(2);
            this.btnMoiHDB.Name = "btnMoiHDB";
            this.btnMoiHDB.Size = new System.Drawing.Size(39, 29);
            this.btnMoiHDB.TabIndex = 18;
            this.btnMoiHDB.Click += new System.EventHandler(this.btnMoiHDB_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AutoRoundedCorners = true;
            this.btnThoat.BorderRadius = 13;
            this.btnThoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThoat.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(513, 20);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(39, 29);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.AutoRoundedCorners = true;
            this.btnLuu.BorderRadius = 13;
            this.btnLuu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuu.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(410, 20);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(39, 29);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnChonHD
            // 
            this.btnChonHD.AutoRoundedCorners = true;
            this.btnChonHD.BorderRadius = 10;
            this.btnChonHD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChonHD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChonHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChonHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChonHD.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btnChonHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnChonHD.ForeColor = System.Drawing.Color.White;
            this.btnChonHD.Location = new System.Drawing.Point(281, 29);
            this.btnChonHD.Margin = new System.Windows.Forms.Padding(2);
            this.btnChonHD.Name = "btnChonHD";
            this.btnChonHD.Size = new System.Drawing.Size(31, 23);
            this.btnChonHD.TabIndex = 12;
            this.btnChonHD.Text = "+";
            this.btnChonHD.Click += new System.EventHandler(this.btnChonHD_Click);
            // 
            // dtNgayBan
            // 
            this.dtNgayBan.AutoRoundedCorners = true;
            this.dtNgayBan.BorderRadius = 10;
            this.dtNgayBan.Checked = true;
            this.dtNgayBan.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.dtNgayBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtNgayBan.ForeColor = System.Drawing.Color.White;
            this.dtNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayBan.Location = new System.Drawing.Point(410, 110);
            this.dtNgayBan.Margin = new System.Windows.Forms.Padding(2);
            this.dtNgayBan.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtNgayBan.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtNgayBan.Name = "dtNgayBan";
            this.dtNgayBan.Size = new System.Drawing.Size(142, 23);
            this.dtNgayBan.TabIndex = 11;
            this.dtNgayBan.Value = new System.DateTime(2024, 3, 17, 9, 48, 39, 950);
            // 
            // btnVe
            // 
            this.btnVe.AutoRoundedCorners = true;
            this.btnVe.BorderRadius = 13;
            this.btnVe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVe.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btnVe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnVe.ForeColor = System.Drawing.Color.White;
            this.btnVe.Image = ((System.Drawing.Image)(resources.GetObject("btnVe.Image")));
            this.btnVe.Location = new System.Drawing.Point(470, 20);
            this.btnVe.Margin = new System.Windows.Forms.Padding(2);
            this.btnVe.Name = "btnVe";
            this.btnVe.Size = new System.Drawing.Size(39, 29);
            this.btnVe.TabIndex = 16;
            this.btnVe.Click += new System.EventHandler(this.btnVe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // cboMaNV
            // 
            this.cboMaNV.AutoRoundedCorners = true;
            this.cboMaNV.BackColor = System.Drawing.Color.Transparent;
            this.cboMaNV.BorderColor = System.Drawing.Color.Black;
            this.cboMaNV.BorderRadius = 17;
            this.cboMaNV.BorderThickness = 0;
            this.cboMaNV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaNV.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.cboMaNV.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMaNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMaNV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboMaNV.ForeColor = System.Drawing.Color.White;
            this.cboMaNV.ItemHeight = 30;
            this.cboMaNV.Location = new System.Drawing.Point(120, 65);
            this.cboMaNV.Margin = new System.Windows.Forms.Padding(2);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(155, 36);
            this.cboMaNV.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(308, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày bán:";
            // 
            // txtMaHD
            // 
            this.txtMaHD.AutoRoundedCorners = true;
            this.txtMaHD.BorderColor = System.Drawing.Color.Black;
            this.txtMaHD.BorderRadius = 10;
            this.txtMaHD.BorderThickness = 0;
            this.txtMaHD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaHD.DefaultText = "";
            this.txtMaHD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaHD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaHD.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.txtMaHD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaHD.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtMaHD.ForeColor = System.Drawing.Color.White;
            this.txtMaHD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaHD.Location = new System.Drawing.Point(121, 29);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.PasswordChar = '\0';
            this.txtMaHD.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtMaHD.PlaceholderText = "";
            this.txtMaHD.SelectedText = "";
            this.txtMaHD.Size = new System.Drawing.Size(154, 23);
            this.txtMaHD.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mã nhân viên:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.AutoRoundedCorners = true;
            this.txtTenKH.BorderColor = System.Drawing.Color.Black;
            this.txtTenKH.BorderRadius = 10;
            this.txtTenKH.BorderThickness = 0;
            this.txtTenKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenKH.DefaultText = "";
            this.txtTenKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKH.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.txtTenKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKH.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtTenKH.ForeColor = System.Drawing.Color.White;
            this.txtTenKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKH.Location = new System.Drawing.Point(121, 118);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.PasswordChar = '\0';
            this.txtTenKH.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtTenKH.PlaceholderText = "";
            this.txtTenKH.SelectedText = "";
            this.txtTenKH.Size = new System.Drawing.Size(154, 23);
            this.txtTenKH.TabIndex = 5;
            // 
            // txtSDT
            // 
            this.txtSDT.AutoRoundedCorners = true;
            this.txtSDT.BorderColor = System.Drawing.Color.Black;
            this.txtSDT.BorderRadius = 10;
            this.txtSDT.BorderThickness = 0;
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.DefaultText = "";
            this.txtSDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.txtSDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtSDT.ForeColor = System.Drawing.Color.White;
            this.txtSDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.Location = new System.Drawing.Point(411, 65);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PasswordChar = '\0';
            this.txtSDT.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtSDT.PlaceholderText = "";
            this.txtSDT.SelectedText = "";
            this.txtSDT.Size = new System.Drawing.Size(141, 23);
            this.txtSDT.TabIndex = 7;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(308, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số điện thoại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên khách hàng:";
            // 
            // toolTip
            // 
            this.toolTip.AllowLinksHandling = true;
            this.toolTip.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // GUI_TaoHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(901, 480);
            this.Controls.Add(this.gbThanhToan);
            this.Controls.Add(this.gbBanHang);
            this.Controls.Add(this.dgGioHang);
            this.Controls.Add(this.gbHoaDon);
            this.DoubleBuffered = true;
            this.Name = "GUI_TaoHDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo hóa đơn bán";
            this.Load += new System.EventHandler(this.GUI_TaoHDB_Load);
            this.gbThanhToan.ResumeLayout(false);
            this.gbThanhToan.PerformLayout();
            this.gbBanHang.ResumeLayout(false);
            this.gbBanHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGioHang)).EndInit();
            this.gbHoaDon.ResumeLayout(false);
            this.gbHoaDon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbThanhToan;
        private Guna.UI2.WinForms.Guna2TextBox txtTongTien;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtSLSP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox gbBanHang;
        private Guna.UI2.WinForms.Guna2ComboBox cboMaSP;
        private Guna.UI2.WinForms.Guna2Button btnMoi;
        private Guna.UI2.WinForms.Guna2Button btnChonSP;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2TextBox txtThanhTien;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox txtTenSP;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaBan;
        private Guna.UI2.WinForms.Guna2TextBox txtSL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgGioHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox gbHoaDon;
        private Guna.UI2.WinForms.Guna2Button btnThoat;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2Button btnChonHD;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtNgayBan;
        private Guna.UI2.WinForms.Guna2Button btnVe;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cboMaNV;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtMaHD;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtTenKH;
        private Guna.UI2.WinForms.Guna2TextBox txtSDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnMoiHDB;
        private Guna.UI2.WinForms.Guna2Button btnChiTietHDB;
        private Guna.UI2.WinForms.Guna2HtmlToolTip toolTip;
    }
}