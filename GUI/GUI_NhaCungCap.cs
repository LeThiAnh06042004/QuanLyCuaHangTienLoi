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
    public partial class GUI_NhaCungCap : Form
    {
        public GUI_NhaCungCap()
        {
            InitializeComponent();
        }

        BUS_NhaCungCap busNCC = new BUS_NhaCungCap();

        private void GUI_NhaCungCap_Load(object sender, EventArgs e)
        {
            dgNCC.DataSource = busNCC.HienNCC();
            toolTip.SetToolTip(btnThem, "Thêm");
            toolTip.SetToolTip(btnSua, "Sửa");
            toolTip.SetToolTip(btnXoa, "Xóa");
            toolTip.SetToolTip(btnVe, "Về trang chủ");
            toolTip.SetToolTip(btnThoat, "Thoát");
            toolTip.SetToolTip(btnTim, "Tìm kiếm");
        }

        private void dgNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMa.Text = dgNCC[0, hang].Value.ToString();
            txtTen.Text = dgNCC[1, hang].Value.ToString();
            txtDiaChi.Text = dgNCC[2, hang].Value.ToString();
            txtSDT.Text = dgNCC[3, hang].Value.ToString();
        }

        public void Refresh()
        {
            txtMa.Clear();
            txtTen.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtTimKiem.Clear();
            txtMa.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtSDT.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải có 10 số, vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtTen.Text.Trim() != "" && txtDiaChi.Text != "" && txtSDT.Text != "")
            {
                DTO_NhaCungCap dtoNCC = new DTO_NhaCungCap(txtMa.Text, txtTen.Text, txtDiaChi.Text, txtSDT.Text);
                if (busNCC.ThemNCC(dtoNCC))
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgNCC.DataSource = busNCC.HienNCC();
                    Refresh();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công hoặc mã nhà cung cấp đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Thông tin không hợp lệ. Xin hãy nhập đầy đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Trim() != "" && txtDiaChi.Text.Trim() != "" && txtSDT.Text.Trim() != "")
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn sửa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DTO_NhaCungCap ncc = new DTO_NhaCungCap(txtMa.Text, txtTen.Text, txtDiaChi.Text, txtSDT.Text);
                    if (busNCC.SuaNCC(ncc))
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgNCC.DataSource = busNCC.HienNCC();
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
            if (txtTen.Text.Trim() != "" && txtDiaChi.Text.Trim() != "" && txtSDT.Text.Trim() != "")
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (busNCC.XoaNCC(txtMa.Text))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgNCC.DataSource = busNCC.HienNCC();
                        Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dgNCC.DataSource = busNCC.TimKiemNCC(txtTimKiem.Text);
            Refresh();
            txtTimKiem.Focus();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
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

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            // Giới hạn độ dài chuỗi nhập vào là 10 ký tự
            if (txtSDT.Text.Length > 10)
            {
                txtSDT.Text = txtSDT.Text.Substring(0, 10);
                // Di chuyển con trỏ về cuối chuỗi
                txtSDT.SelectionStart = txtSDT.Text.Length;
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập số và phím Backspace để sửa lỗi
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ cho phép nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
