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
    public partial class GUI_HoaDonBan : Form
    {
        public GUI_HoaDonBan()
        {
            InitializeComponent();
        }

        BUS_HoaDonBan busHDB = new BUS_HoaDonBan();

        private void GUI_HoaDonBan_Load(object sender, EventArgs e)
        {
            dgHDB.DataSource = busHDB.HienHDB();
            cboNV.DataSource = busHDB.LayMaNV();
            cboNV.DisplayMember = "MaNV";

            toolTip.SetToolTip(btnThem, "Thêm");
            toolTip.SetToolTip(btnSua, "Sửa");
            toolTip.SetToolTip(btnXoa, "Xóa");
            toolTip.SetToolTip(btnVe, "Về trang chủ");
            toolTip.SetToolTip(btnThoat, "Thoát");
            toolTip.SetToolTip(btnTim, "Tìm kiếm");
        }

        private void dgHDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMaHD.Text = dgHDB[0, hang].Value.ToString();
            cboNV.Text = dgHDB[1, hang].Value.ToString();
            txtTenKH.Text = dgHDB[2, hang].Value.ToString();
            txtSDT.Text = dgHDB[3, hang].Value.ToString();
            dtNgayBan.Text = dgHDB[4, hang].Value.ToString();
        }

        public void Refresh()
        {
            txtMaHD.Clear();
            cboNV.Text = "";
            txtTenKH.Clear();
            txtSDT.Clear();
            txtMaHD.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtSDT.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải có 10 số, vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtMaHD.Text != "" && cboNV.Text != "" && txtTenKH.Text != "" && txtSDT.Text != "" && dtNgayBan.Text != "")
            {
                string ngayBan = dtNgayBan.Value.ToString("yyyy-MM-dd");

                DTO_HoaDonBan dtoHDB = new DTO_HoaDonBan(txtMaHD.Text, cboNV.Text.Trim(), txtTenKH.Text, txtSDT.Text, DateTime.Parse(ngayBan));
                if (busHDB.ThemHDB(dtoHDB))
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgHDB.DataSource = busHDB.HienHDB();
                    Refresh();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công hoặc mã hóa đơn bán đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Thông tin không hợp lệ. Xin hãy nhập đầy đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text.Trim() != "" && txtTenKH.Text.Trim() != "" && txtSDT.Text != "" && dtNgayBan.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn sửa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string ngayBan = dtNgayBan.Value.ToString("yyyy-MM-dd");

                    DTO_HoaDonBan dtoHDB = new DTO_HoaDonBan(txtMaHD.Text, cboNV.Text.Trim(), txtTenKH.Text, txtSDT.Text, DateTime.Parse(ngayBan));
                    if (busHDB.SuaHDB(dtoHDB))
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgHDB.DataSource = busHDB.HienHDB();
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
            if (txtMaHD.Text.Trim() != "" && txtTenKH.Text.Trim() != "" && txtSDT.Text != "" && dtNgayBan.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (busHDB.XoaHDB(txtMaHD.Text))
                        {
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgHDB.DataSource = busHDB.HienHDB();
                            Refresh();
                        }
                        else
                        {
                            MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            DateTime tk = dtTimKiem.Value;
            dgHDB.DataSource = busHDB.TimKiemHDB(tk);
            Refresh();
            dtTimKiem.Focus();
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

        public void GanHDB(out string mahdb, out string manv, out string tenkh, out string sdt, out string ngayban)
        {
            mahdb = txtMaHD.Text;
            manv = cboNV.Text;
            tenkh = txtTenKH.Text;
            sdt = txtSDT.Text;
            ngayban = dtNgayBan.Text;
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
