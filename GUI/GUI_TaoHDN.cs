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
    public partial class GUI_TaoHDN : Form
    {
        public GUI_TaoHDN()
        {
            InitializeComponent();
        }

        BUS_ChiTietHDN busCTHDN = new BUS_ChiTietHDN();
        BUS_HoaDonNhap busHDN = new BUS_HoaDonNhap();

        private void dgGioHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSP.Text = dgGioHang[0, e.RowIndex].Value.ToString();
            txtTenSP.Text = dgGioHang[1, e.RowIndex].Value.ToString();
            txtSL.Text = dgGioHang[2, e.RowIndex].Value.ToString();
            txtGiaNhap.Text = dgGioHang[3, e.RowIndex].Value.ToString();
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtSL.Clear();
            txtGiaNhap.Clear();
            txtSL.Focus();
        }
        private DTO_ChiTietHDN TaoDTO_ChiTietHDN(string maHDN, string maSP, string tenSP, int soLuong, int giaNhap)
        {
            DTO_ChiTietHDN ct = new DTO_ChiTietHDN();
            ct.CTHDN_MaHDN = maHDN;
            ct.CTHDN_MaSP = maSP;
            ct.CTHDN_TenSP = tenSP;
            ct.CTHDN_SL = soLuong;
            ct.CTHDN_GiaNhap = giaNhap;
            return ct;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaHD.Text.Trim() != "" && txtMaSP.Text.Trim() != "" && txtTenSP.Text != "" && txtSL.Text != "" && txtGiaNhap.Text != "")
                {
                    if (busCTHDN.KiemTraMa(txtMaHD.Text.Trim(), txtMaSP.Text.Trim()))
                    {
                        MessageBox.Show("Chi tiết hóa đơn nhập này đã tồn tại! Vui lòng tạo mới", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        dgGioHang.Rows.Add(txtMaSP.Text, txtTenSP.Text, txtSL.Text, txtGiaNhap.Text);
                        TinhTien();

                        DTO_ChiTietHDN ct = TaoDTO_ChiTietHDN(txtMaHD.Text, txtMaSP.Text, txtTenSP.Text, int.Parse(txtSL.Text), int.Parse(txtGiaNhap.Text));
                        if (!busCTHDN.ThemCTHDN(ct))
                        {
                            MessageBox.Show("Không thể lưu chi tiết hóa đơn nhập !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TinhTien()
        {
            double tong = 0;
            double sp = 0;
            for (int i = 0; i < dgGioHang.Rows.Count; i++)
            {
                if (dgGioHang.Rows[i].Cells[2].Value != null && dgGioHang.Rows[i].Cells[3].Value != null)
                {
                    double soLuong = Convert.ToDouble(dgGioHang.Rows[i].Cells[2].Value.ToString());
                    double giaNhap = Convert.ToDouble(dgGioHang.Rows[i].Cells[3].Value.ToString());
                    tong += soLuong * giaNhap;
                    sp += soLuong;
                }
            }
            txtSLSP.Text = sp.ToString();
            txtTongTien.Text = tong.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgGioHang.Rows.Count - 1; i++)
            {
                if (dgGioHang[0, i].Value.ToString() == txtMaSP.Text)
                {
                    dgGioHang[2, i].Value = txtSL.Text;
                    TinhTien();

                    DTO_ChiTietHDN ct = TaoDTO_ChiTietHDN(txtMaHD.Text, txtMaSP.Text, txtTenSP.Text, int.Parse(txtSL.Text), int.Parse(txtGiaNhap.Text));

                    if (!busCTHDN.SuaCTHDN(ct))
                    {
                        MessageBox.Show("Không thể cập nhật chi tiết hóa đơn nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgGioHang.Rows.Count - 1; i++)
            {
                if (dgGioHang[0, i].Value.ToString() == txtMaSP.Text)
                {
                    string maHD = txtMaHD.Text;
                    string maSP = txtMaSP.Text;

                    if (!busCTHDN.XoaCTHDN(maHD, maSP))
                    {
                        MessageBox.Show("Không thể xóa chi tiết hóa đơn nhập này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dgGioHang.Rows.RemoveAt(i);
                        TinhTien();
                    }
                }
            }
        }

        private void btnChonSP_Click(object sender, EventArgs e)
        {
            GUI_SanPham sp = new GUI_SanPham();
            if (sp.ShowDialog() == DialogResult.Cancel)
            {
                sp.LayTenSP(out string ma, out string ten);
                txtMaSP.Text = ma;
                txtTenSP.Text = ten;
            }
        }

        private void btnChonHDN_Click(object sender, EventArgs e)
        {
            GUI_HoaDonNhap hdn = new GUI_HoaDonNhap();
            if (hdn.ShowDialog() == DialogResult.Cancel)
            {
                hdn.GanHDN(out string mahdn, out string manv, out string mancc, out string ngaynhap);
                txtMaHD.Text = mahdn;
                cboMaNV.Text = manv;
                cboNCC.Text = mancc;
                dtNgayNhap.Text = ngaynhap;
            }
        }

        private void btnMoiHDN_Click(object sender, EventArgs e)
        {
            txtMaHD.Clear();
            cboMaNV.Text = "";
            cboNCC.Text = "";
            txtMaHD.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                //Lưu hóa đơn nhập
                if (txtMaHD.Text.Trim() != "" && cboMaNV.Text != "" && cboNCC.Text != "" && dtNgayNhap.Text != "")
                {

                    if (busHDN.KiemTraMa(txtMaHD.Text.Trim()))
                    {
                        MessageBox.Show("Hóa đơn nhập này đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        string ngayNhap = dtNgayNhap.Value.ToString("yyyy-MM-dd");
                        DTO_HoaDonNhap dtoHDN = new DTO_HoaDonNhap(txtMaHD.Text.Trim(), cboMaNV.Text.Trim(), cboNCC.Text.Trim(), DateTime.Parse(ngayNhap));

                        if (!busHDN.ThemHDN(dtoHDN))
                        {
                            MessageBox.Show("Không thể lưu hóa đơn nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GUI_TaoHDN_Load(object sender, EventArgs e)
        {
            cboMaNV.DataSource = busHDN.LayMaNV();
            cboMaNV.DisplayMember = "MaNV";
            cboNCC.DataSource = busHDN.LayMaNCC();
            cboNCC.DisplayMember = "MaNCC";

            toolTip.SetToolTip(btnChiTietHDN, "Xem chi tiết hóa đơn nhập");
            toolTip.SetToolTip(btnChonSP, "Chọn sản phẩm cần nhập");
            toolTip.SetToolTip(btnMoi, "Làm mới");
            toolTip.SetToolTip(btnThem, "Thêm");
            toolTip.SetToolTip(btnSua, "Sửa");
            toolTip.SetToolTip(btnXoa, "Xóa");
            toolTip.SetToolTip(btnMoiHDN, "Làm mới");
            toolTip.SetToolTip(btnLuu, "Lưu");
            toolTip.SetToolTip(btnVe, "Về trang chủ");
            toolTip.SetToolTip(btnThoat, "Thoát");
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

        private void btnChiTietHDN_Click(object sender, EventArgs e)
        {
            GUI_ChiTietHDN frm = new GUI_ChiTietHDN();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
