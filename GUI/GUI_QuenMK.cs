using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class GUI_QuenMK : Form
    {
        public GUI_QuenMK()
        {
            InitializeComponent();
        }

        BUS_NhanVien busNV = new BUS_NhanVien();

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (txtMatKhau.Text != txtNhapLai.Text)
            {
                MessageBox.Show("Mật khẩu mới và mật khẩu nhập lại không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if(txtTaiKhoan.Text != "" && txtMatKhau.Text != "" && txtNhapLai.Text != "")
                {
                    if (busNV.KiemTraTaiKhoan(txtTaiKhoan.Text))
                    {
                        if (busNV.SuaMK(txtTaiKhoan.Text, txtMatKhau.Text))
                        {
                            MessageBox.Show("Đổi mật khẩu thành công, mời đăng nhập lại với tài khoản mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GUI_DangNhap frm = new GUI_DangNhap();
                            this.Hide();
                            frm.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Đổi mật khẩu không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtTaiKhoan.Clear();
                            txtMatKhau.Clear();
                            txtNhapLai.Clear();
                            txtTaiKhoan.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản này không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Không thể đổi mật khẩu do thiếu thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
