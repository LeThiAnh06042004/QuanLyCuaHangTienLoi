using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class GUI_DangNhap : Form
    {
        public GUI_DangNhap()
        {
            InitializeComponent();
        }

        BUS_NhanVien busNV = new BUS_NhanVien();
        public static string vaiTro;


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtTaiKhoan.Text.Trim() != "" && txtMatKhau.Text.Trim() != "")
                {
                    vaiTro = busNV.DangNhap(txtTaiKhoan.Text, txtMatKhau.Text);
                    if (vaiTro != null)
                    {
                        if (vaiTro == "Quản lý")
                        {
                            MessageBox.Show("Đăng nhập thành công với vai trò Quản lý!");
                            GUI_TrangChuQL frm = new GUI_TrangChuQL();
                            frm.Show();
                            this.Hide();
                        }
                        else if (vaiTro == "Nhân viên")
                        {
                            MessageBox.Show("Đăng nhập thành công với vai trò Nhân viên!");
                            GUI_TrangChuQL frm = new GUI_TrangChuQL();
                            frm.AnQuyenNV(); // Ẩn các nút không được cấp quyền cho nhân viên
                            frm.Show();
                            this.Hide();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thất bại do tài khoản hoặc mật khẩu không chính xác!");
                        txtTaiKhoan.Clear();
                        txtMatKhau.Clear();
                        txtTaiKhoan.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Không thể đăng nhập do thiếu thiếu thông tin, vui lòng đăng nhập lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GUI_QuenMK frm = new GUI_QuenMK();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void GUI_DangNhap_Load(object sender, EventArgs e)
        {
            toolTip.SetToolTip(linkLabel1, "Đổi mật khẩu mới để đăng nhập");
        }
    }
}
