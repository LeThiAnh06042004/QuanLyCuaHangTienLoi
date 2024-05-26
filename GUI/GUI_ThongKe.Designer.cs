
namespace GUI
{
    partial class GUI_ThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_ThongKe));
            this.btnThoat = new Guna.UI2.WinForms.Guna2Button();
            this.btnVe = new Guna.UI2.WinForms.Guna2Button();
            this.dtThoiGian = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbNam = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdbThang = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdbNgay = new Guna.UI2.WinForms.Guna2RadioButton();
            this.dgBaoCaoSP = new System.Windows.Forms.DataGridView();
            this.btnBaoCaoSP = new Guna.UI2.WinForms.Guna2Button();
            this.cboTieuChiSP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.toolTip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.dgBaoCaoSP)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.AutoRoundedCorners = true;
            this.btnThoat.BorderRadius = 18;
            this.btnThoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThoat.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageSize = new System.Drawing.Size(30, 30);
            this.btnThoat.Location = new System.Drawing.Point(544, 391);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(162, 38);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnVe
            // 
            this.btnVe.AutoRoundedCorners = true;
            this.btnVe.BorderRadius = 18;
            this.btnVe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVe.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btnVe.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVe.ForeColor = System.Drawing.Color.White;
            this.btnVe.Image = ((System.Drawing.Image)(resources.GetObject("btnVe.Image")));
            this.btnVe.ImageSize = new System.Drawing.Size(30, 30);
            this.btnVe.Location = new System.Drawing.Point(290, 391);
            this.btnVe.Margin = new System.Windows.Forms.Padding(2);
            this.btnVe.Name = "btnVe";
            this.btnVe.Size = new System.Drawing.Size(162, 38);
            this.btnVe.TabIndex = 6;
            this.btnVe.Text = "Trở về";
            this.btnVe.Click += new System.EventHandler(this.btnVe_Click);
            // 
            // dtThoiGian
            // 
            this.dtThoiGian.AutoRoundedCorners = true;
            this.dtThoiGian.BorderRadius = 17;
            this.dtThoiGian.Checked = true;
            this.dtThoiGian.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.dtThoiGian.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtThoiGian.ForeColor = System.Drawing.Color.White;
            this.dtThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtThoiGian.Location = new System.Drawing.Point(413, 97);
            this.dtThoiGian.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtThoiGian.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtThoiGian.Name = "dtThoiGian";
            this.dtThoiGian.Size = new System.Drawing.Size(294, 36);
            this.dtThoiGian.TabIndex = 1;
            this.dtThoiGian.Value = new System.DateTime(2024, 4, 29, 8, 50, 36, 83);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(420, 64);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 42;
            this.label5.Text = "Thời gian:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 41;
            this.label4.Text = "Tiêu chí:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 34);
            this.label2.TabIndex = 40;
            this.label2.Text = "Thống kê sản phẩm";
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbNam.CheckedState.BorderThickness = 0;
            this.rdbNam.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbNam.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbNam.CheckedState.InnerOffset = -4;
            this.rdbNam.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.rdbNam.Location = new System.Drawing.Point(628, 139);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(78, 19);
            this.rdbNam.TabIndex = 4;
            this.rdbNam.Text = "Theo năm";
            this.rdbNam.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbNam.UncheckedState.BorderThickness = 2;
            this.rdbNam.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbNam.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rdbThang
            // 
            this.rdbThang.AutoSize = true;
            this.rdbThang.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbThang.CheckedState.BorderThickness = 0;
            this.rdbThang.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbThang.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbThang.CheckedState.InnerOffset = -4;
            this.rdbThang.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.rdbThang.Location = new System.Drawing.Point(516, 139);
            this.rdbThang.Name = "rdbThang";
            this.rdbThang.Size = new System.Drawing.Size(87, 19);
            this.rdbThang.TabIndex = 3;
            this.rdbThang.Text = "Theo tháng";
            this.rdbThang.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbThang.UncheckedState.BorderThickness = 2;
            this.rdbThang.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbThang.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rdbNgay
            // 
            this.rdbNgay.AutoSize = true;
            this.rdbNgay.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbNgay.CheckedState.BorderThickness = 0;
            this.rdbNgay.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbNgay.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbNgay.CheckedState.InnerOffset = -4;
            this.rdbNgay.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNgay.Location = new System.Drawing.Point(412, 139);
            this.rdbNgay.Name = "rdbNgay";
            this.rdbNgay.Size = new System.Drawing.Size(83, 19);
            this.rdbNgay.TabIndex = 2;
            this.rdbNgay.Text = "Theo ngày";
            this.rdbNgay.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbNgay.UncheckedState.BorderThickness = 2;
            this.rdbNgay.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbNgay.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // dgBaoCaoSP
            // 
            this.dgBaoCaoSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgBaoCaoSP.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgBaoCaoSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBaoCaoSP.Location = new System.Drawing.Point(26, 177);
            this.dgBaoCaoSP.Margin = new System.Windows.Forms.Padding(2);
            this.dgBaoCaoSP.Name = "dgBaoCaoSP";
            this.dgBaoCaoSP.RowHeadersWidth = 62;
            this.dgBaoCaoSP.RowTemplate.Height = 28;
            this.dgBaoCaoSP.Size = new System.Drawing.Size(681, 200);
            this.dgBaoCaoSP.TabIndex = 36;
            // 
            // btnBaoCaoSP
            // 
            this.btnBaoCaoSP.AutoRoundedCorners = true;
            this.btnBaoCaoSP.BorderRadius = 18;
            this.btnBaoCaoSP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBaoCaoSP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBaoCaoSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBaoCaoSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBaoCaoSP.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btnBaoCaoSP.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCaoSP.ForeColor = System.Drawing.Color.White;
            this.btnBaoCaoSP.Image = ((System.Drawing.Image)(resources.GetObject("btnBaoCaoSP.Image")));
            this.btnBaoCaoSP.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBaoCaoSP.Location = new System.Drawing.Point(26, 391);
            this.btnBaoCaoSP.Margin = new System.Windows.Forms.Padding(2);
            this.btnBaoCaoSP.Name = "btnBaoCaoSP";
            this.btnBaoCaoSP.Size = new System.Drawing.Size(162, 38);
            this.btnBaoCaoSP.TabIndex = 5;
            this.btnBaoCaoSP.Text = "Thống kê";
            this.btnBaoCaoSP.Click += new System.EventHandler(this.btnBaoCaoSP_Click);
            // 
            // cboTieuChiSP
            // 
            this.cboTieuChiSP.AutoRoundedCorners = true;
            this.cboTieuChiSP.BackColor = System.Drawing.Color.Transparent;
            this.cboTieuChiSP.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.cboTieuChiSP.BorderRadius = 17;
            this.cboTieuChiSP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTieuChiSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTieuChiSP.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.cboTieuChiSP.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTieuChiSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTieuChiSP.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cboTieuChiSP.ForeColor = System.Drawing.Color.White;
            this.cboTieuChiSP.ItemHeight = 30;
            this.cboTieuChiSP.Items.AddRange(new object[] {
            "Sản phẩm bán chạy",
            "Sản phẩm bán ế"});
            this.cboTieuChiSP.Location = new System.Drawing.Point(26, 97);
            this.cboTieuChiSP.Margin = new System.Windows.Forms.Padding(2);
            this.cboTieuChiSP.Name = "cboTieuChiSP";
            this.cboTieuChiSP.Size = new System.Drawing.Size(289, 36);
            this.cboTieuChiSP.TabIndex = 0;
            // 
            // toolTip
            // 
            this.toolTip.AllowLinksHandling = true;
            this.toolTip.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // GUI_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(739, 445);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnVe);
            this.Controls.Add(this.dtThoiGian);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdbNam);
            this.Controls.Add(this.rdbThang);
            this.Controls.Add(this.rdbNgay);
            this.Controls.Add(this.dgBaoCaoSP);
            this.Controls.Add(this.btnBaoCaoSP);
            this.Controls.Add(this.cboTieuChiSP);
            this.DoubleBuffered = true;
            this.Name = "GUI_ThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.GUI_ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBaoCaoSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnThoat;
        private Guna.UI2.WinForms.Guna2Button btnVe;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtThoiGian;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2RadioButton rdbNam;
        private Guna.UI2.WinForms.Guna2RadioButton rdbThang;
        private Guna.UI2.WinForms.Guna2RadioButton rdbNgay;
        private System.Windows.Forms.DataGridView dgBaoCaoSP;
        private Guna.UI2.WinForms.Guna2Button btnBaoCaoSP;
        private Guna.UI2.WinForms.Guna2ComboBox cboTieuChiSP;
        private Guna.UI2.WinForms.Guna2HtmlToolTip toolTip;
    }
}