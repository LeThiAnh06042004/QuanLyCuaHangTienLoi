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
    public partial class GUI_NhanVien : Form
    {
        public GUI_NhanVien()
        {
            InitializeComponent();
        }

        BUS_NhanVien busNV = new BUS_NhanVien();

        private void GUI_NhanVien_Load(object sender, EventArgs e)
        {
            dgNhanVien.DataSource = busNV.HienNV();
            toolTip.SetToolTip(btnThem, "Thêm");
            toolTip.SetToolTip(btnSua, "Sửa");
            toolTip.SetToolTip(btnXoa, "Xóa");
            toolTip.SetToolTip(btnVe, "Về trang chủ");
            toolTip.SetToolTip(btnThoat, "Thoát");
            toolTip.SetToolTip(btnTimKiem, "Tìm kiếm");
        }

        private void dgNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMaNV.Text = dgNhanVien[0, hang].Value.ToString();
            txtTenNV.Text = dgNhanVien[1, hang].Value.ToString();
            dtNgaySinh.Text = dgNhanVien[2, hang].Value.ToString();
            cboGT.Text = dgNhanVien[3, hang].Value.ToString().Trim();
            txtQQ.Text = dgNhanVien[4, hang].Value.ToString();
            txtSdt.Text = dgNhanVien[5, hang].Value.ToString();
            txtTaiKhoan.Text = dgNhanVien[6, hang].Value.ToString();
            txtMatKhau.Text = dgNhanVien[7, hang].Value.ToString();
        }

        public void Refresh()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            cboGT.Text = "";
            txtQQ.Clear();
            txtSdt.Clear();
            txtTimKiem.Clear();
            txtTaiKhoan.Clear();
            txtMatKhau.Clear();
            txtMaNV.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtSdt.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải có 10 số, vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtMaNV.Text.Trim() != "" && txtTenNV.Text.Trim() != "" && dtNgaySinh.Text.Trim() != "" && cboGT.Text.Trim() != "" && txtQQ.Text.Trim() != "" && txtSdt.Text.Trim() != "" && txtTaiKhoan.Text.Trim() != "" && txtMatKhau.Text.Trim() != "")
            {
                DTO_NhanVien dtoNV = new DTO_NhanVien(txtMaNV.Text, txtTenNV.Text, dtNgaySinh.Text, cboGT.Text, txtQQ.Text, txtSdt.Text, txtTaiKhoan.Text, txtMatKhau.Text.Trim());
                if (busNV.ThemNV(dtoNV))
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgNhanVien.DataSource = busNV.HienNV();
                    Refresh();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công hoặc mã nhân viên đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Thông tin không hợp lệ. Xin hãy nhập đầy đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text.Trim() != "" && txtTenNV.Text.Trim() != "" && dtNgaySinh.Text.Trim() != "" && cboGT.Text.Trim() != "" && txtQQ.Text.Trim() != "" && txtSdt.Text.Trim() != "" && txtTaiKhoan.Text.Trim() != "" && txtMatKhau.Text.Trim() != "")
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn sửa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DTO_NhanVien nv = new DTO_NhanVien(txtMaNV.Text, txtTenNV.Text, dtNgaySinh.Text, cboGT.Text, txtQQ.Text, txtSdt.Text, txtTaiKhoan.Text, txtMatKhau.Text);
                    if (busNV.SuaNV(nv))
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgNhanVien.DataSource = busNV.HienNV();
                        Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Thông tin không hợp lệ, hãy nhập đầy đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (busNV.XoaNV(txtMaNV.Text))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgNhanVien.DataSource = busNV.HienNV();
                    Refresh();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgNhanVien.DataSource = busNV.TimKiemNV(txtTimKiem.Text);
            Refresh();
        }

        private void btnVe_Click(object sender, EventArgs e)
        {
            GUI_TrangChuQL ql = new GUI_TrangChuQL();
            this.Hide();
            ql.ShowDialog();
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập số và phím Backspace để sửa lỗi
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ cho phép nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSdt_TextChanged(object sender, EventArgs e)
        {
            // Giới hạn độ dài chuỗi nhập vào là 10 ký tự
            if (txtSdt.Text.Length > 10)
            {
                txtSdt.Text = txtSdt.Text.Substring(0, 10);
                // Di chuyển con trỏ về cuối chuỗi
                txtSdt.SelectionStart = txtSdt.Text.Length;
            }
        }
    }
}
