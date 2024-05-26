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
    public partial class GUI_HoaDonNhap : Form
    {
        public GUI_HoaDonNhap()
        {
            InitializeComponent();
        }

        BUS_HoaDonNhap busHDN = new BUS_HoaDonNhap();
        BUS_ChiTietHDN busCTHDN = new BUS_ChiTietHDN();

        private void GUI_HoaDonNhap_Load(object sender, EventArgs e)
        {
            dgHDN.DataSource = busHDN.HienHDN();
            cboNV.DataSource = busHDN.LayMaNV();
            cboNV.DisplayMember = "MaNV";
            cboNCC.DataSource = busHDN.LayMaNCC();
            cboNCC.DisplayMember = "MaNCC";

            toolTip.SetToolTip(btnThem, "Thêm");
            toolTip.SetToolTip(btnSua, "Sửa");
            toolTip.SetToolTip(btnXoa, "Xóa");
            toolTip.SetToolTip(btnVe, "Về trang chủ");
            toolTip.SetToolTip(btnThoat, "Thoát");
            toolTip.SetToolTip(btnTimKiem, "Tìm kiếm");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text.Trim() != "" && cboNV.Text.Trim() != "" && cboNCC.Text.Trim() != "" && dtNgayNhap.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn sửa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string NgayNhap = dtNgayNhap.Value.ToString("yyyy-MM-dd");
                    DTO_HoaDonNhap dtoHDN = new DTO_HoaDonNhap(txtMaHD.Text, cboNV.Text.Trim(), cboNCC.Text.Trim(), DateTime.Parse(NgayNhap));
                    if (busHDN.SuaHDN(dtoHDN))
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgHDN.DataSource = busHDN.HienHDN();
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text != "" && cboNV.Text != "" && cboNCC.Text != "" && dtNgayNhap.Text != "")
            {
                string NgayNhap = dtNgayNhap.Value.ToString("yyyy-MM-dd");
                DTO_HoaDonNhap dtoHDN = new DTO_HoaDonNhap(txtMaHD.Text, cboNV.Text.Trim(), cboNCC.Text.Trim(), DateTime.Parse(NgayNhap));
                if (busHDN.ThemHDN(dtoHDN))
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgHDN.DataSource = busHDN.HienHDN();
                    Refresh();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công hoặc mã hóa đơn nhập đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Thông tin không hợp lệ. Xin hãy nhập đầy đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMaHD.Text = dgHDN[0, hang].Value.ToString();
            cboNV.Text = dgHDN[1, hang].Value.ToString();
            cboNCC.Text = dgHDN[2, hang].Value.ToString();
            dtNgayNhap.Text = dgHDN[3, hang].Value.ToString();
        }

        public void Refresh()
        {
            txtMaHD.Clear();
            cboNV.Text = "";
            cboNCC.Text = "";
            txtMaHD.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text.Trim() != "" && cboNV.Text.Trim() != "" && cboNCC.Text.Trim() != "" && dtNgayNhap.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        string maHDN = txtMaHD.Text.Trim();

                        if (busHDN.XoaHDN(maHDN))
                        {
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgHDN.DataSource = busHDN.HienHDN();
                            Refresh();
                        }
                        else
                        {
                            MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DateTime tk = dtTimKiem.Value;
            dgHDN.DataSource = busHDN.TimKiemHDN(tk);
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
        public void GanHDN(out string mahdn, out string manv, out string mancc, out string ngaynhap)
        {
            mahdn = txtMaHD.Text;
            manv = cboNV.Text;
            mancc = cboNCC.Text;
            ngaynhap = dtNgayNhap.Text;
        }
    }
}
