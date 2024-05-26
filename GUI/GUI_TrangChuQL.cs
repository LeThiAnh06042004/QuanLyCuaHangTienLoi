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
    public partial class GUI_TrangChuQL : Form
    {
        public GUI_TrangChuQL()
        {
            InitializeComponent();
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            GUI_NhanVien frm = new GUI_NhanVien();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            GUI_SanPham frm = new GUI_SanPham();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            GUI_NhaCungCap frm = new GUI_NhaCungCap();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void btnHDB_Click(object sender, EventArgs e)
        {
            GUI_HoaDonBan frm = new GUI_HoaDonBan();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void btnHDN_Click(object sender, EventArgs e)
        {
            GUI_HoaDonNhap frm = new GUI_HoaDonNhap();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            GUI_ThongKe frm = new GUI_ThongKe();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            GUI_BaoCao frm = new GUI_BaoCao();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            GUI_DangNhap frm = new GUI_DangNhap();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void AnQuyenNV()
        {
            // Ẩn các nút không được cấp quyền cho nhân viên
            btnNV.Enabled = false;
            btnNCC.Enabled = false;
            btnThongKe.Enabled = false;
        }

        private void GUI_TrangChuQL_Shown(object sender, EventArgs e)
        {
            if (GUI_DangNhap.vaiTro == "Nhân viên")
            {
                AnQuyenNV();
            }
        }

        private void btnTaoHDB_Click_1(object sender, EventArgs e)
        {
            GUI_TaoHDB frm = new GUI_TaoHDB();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void btnTaoHDN_Click_1(object sender, EventArgs e)
        {
            GUI_TaoHDN frm = new GUI_TaoHDN();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void GUI_TrangChuQL_Load(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnThoat, "Thoát");
            toolTip.SetToolTip(btnDangXuat, "Đăng xuất");
        }
    }
}
