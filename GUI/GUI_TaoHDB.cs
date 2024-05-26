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
    public partial class GUI_TaoHDB : Form
    {
        public GUI_TaoHDB()
        {
            InitializeComponent();
        }

        BUS_ChiTietHDB busCTHDB = new BUS_ChiTietHDB();
        BUS_HoaDonBan busHDB = new BUS_HoaDonBan();


        private void btnMoi_Click(object sender, EventArgs e)
        {
            cboMaSP.Text = "";
            txtTenSP.Clear();
            txtSL.Clear();
            txtGiaBan.Clear();
            txtSL.Focus();
        }

        private void dgGioHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cboMaSP.Text = dgGioHang[0, e.RowIndex].Value.ToString();
            txtTenSP.Text = dgGioHang[1, e.RowIndex].Value.ToString();
            txtSL.Text = dgGioHang[2, e.RowIndex].Value.ToString();
            txtGiaBan.Text = dgGioHang[3, e.RowIndex].Value.ToString();
        }

        private DTO_ChiTietHDB TaoDTO_ChiTietHDB(string maHDB, string maSP, string tenSP, int soLuong, int giaBan)
        {
            DTO_ChiTietHDB ct = new DTO_ChiTietHDB();
            ct.CTHDB_MaHDB = maHDB;
            ct.CTHDB_MaSP = maSP;
            ct.CTHDB_TenSP = tenSP;
            ct.CTHDB_SL = soLuong;
            ct.CTHDB_GiaBan = giaBan;
            return ct;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaHD.Text.Trim() != "" && cboMaSP.Text.Trim() != "" && txtTenSP.Text != "" && txtSL.Text != "" && txtGiaBan.Text != "")
                {
                    if (busCTHDB.KiemTraMa(txtMaHD.Text.Trim(), cboMaSP.Text.Trim()))
                    {
                        MessageBox.Show("Chi tiết hóa đơn bán này đã tồn tại! Vui lòng tạo mới", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        dgGioHang.Rows.Add(cboMaSP.Text, txtTenSP.Text, txtSL.Text, txtGiaBan.Text);
                        TinhTien();

                        DTO_ChiTietHDB ct = TaoDTO_ChiTietHDB(txtMaHD.Text, cboMaSP.Text, txtTenSP.Text, int.Parse(txtSL.Text), int.Parse(txtGiaBan.Text));
                        if (!busCTHDB.ThemCTHDB(ct))
                        {
                            MessageBox.Show("Không thể lưu chi tiết hóa đơn bán !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GUI_TaoHDB_Load(object sender, EventArgs e)
        {
            cboMaNV.DataSource = busHDB.LayMaNV();
            cboMaNV.DisplayMember = "MaNV";
            cboMaSP.DataSource = busCTHDB.LayMaSP();
            cboMaSP.DisplayMember = "MaSP";

            toolTip.SetToolTip(btnChiTietHDB, "Xem chi tiết hóa đơn bán");
            toolTip.SetToolTip(btnChonSP, "Chọn sản phẩm cần bán");
            toolTip.SetToolTip(btnMoi, "Làm mới");
            toolTip.SetToolTip(btnThem, "Thêm");
            toolTip.SetToolTip(btnSua, "Sửa");
            toolTip.SetToolTip(btnXoa, "Xóa");
            toolTip.SetToolTip(btnMoiHDB, "Làm mới");
            toolTip.SetToolTip(btnLuu, "Lưu");
            toolTip.SetToolTip(btnVe, "Về trang chủ");
            toolTip.SetToolTip(btnThoat, "Thoát");
        }

        private void cboMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = cboMaSP.SelectedItem as DataRowView;
            string sp = drv.Row[0].ToString();
            DataTable dtTenSP = busCTHDB.LayTenSP(sp);
            string tenSP = dtTenSP.Rows[0]["TenSP"].ToString();
            txtTenSP.Text = tenSP;

            DataTable dtGia = busCTHDB.LayGiaBan(sp);
            string gia = dtGia.Rows[0]["GiaBan"].ToString();
            txtGiaBan.Text = gia;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgGioHang.Rows.Count - 1; i++)
            {
                if (dgGioHang[0, i].Value.ToString() == cboMaSP.Text)
                {
                    dgGioHang[2, i].Value = txtSL.Text;
                    TinhTien();

                    DTO_ChiTietHDB ct = TaoDTO_ChiTietHDB(txtMaHD.Text, cboMaSP.Text, txtTenSP.Text, int.Parse(txtSL.Text), int.Parse(txtGiaBan.Text));

                    if (!busCTHDB.SuaCTHDB(ct))
                    {
                        MessageBox.Show("Không thể cập nhật chi tiết hóa đơn bán!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgGioHang.Rows.Count - 1; i++)
            {
                if (dgGioHang[0, i].Value.ToString() == cboMaSP.Text)
                {
                    string maHD = txtMaHD.Text;
                    string maSP = cboMaSP.Text;

                    if (!busCTHDB.XoaCTHDB(maHD, maSP))
                    {
                        MessageBox.Show("Không thể xóa chi tiết hóa đơn bán!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dgGioHang.Rows.RemoveAt(i);
                        TinhTien();
                    }
                }
            }
        }

        private void btnChonHD_Click(object sender, EventArgs e)
        {
            GUI_HoaDonBan hdb = new GUI_HoaDonBan();
            if (hdb.ShowDialog() == DialogResult.Cancel)
            {
                hdb.GanHDB(out string mahdb, out string manv, out string tenkh, out string sdt, out string ngayban);
                txtMaHD.Text = mahdb;
                cboMaNV.Text = manv;
                txtTenKH.Text = tenkh;
                txtSDT.Text = sdt;
                dtNgayBan.Text = ngayban;
            }
        }

        private void btnChonSP_Click(object sender, EventArgs e)
        {
            GUI_SanPham sp = new GUI_SanPham();
            if (sp.ShowDialog() == DialogResult.Cancel)
            {
                sp.GanSP(out string ma, out string ten, out string giaban);
                cboMaSP.Text = ma;
                txtTenSP.Text = ten;
                txtGiaBan.Text = giaban;
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
                    double giaBan = Convert.ToDouble(dgGioHang.Rows[i].Cells[3].Value.ToString());
                    tong += soLuong * giaBan;
                    sp += soLuong;
                }
            }
            txtSLSP.Text = sp.ToString();
            txtTongTien.Text = tong.ToString();
        }

        private void btnVe_Click(object sender, EventArgs e)
        {
            GUI_TrangChuQL ql = new GUI_TrangChuQL();
            this.Hide();
            ql.ShowDialog();
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (txtSDT.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải có 10 số, vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtMaHD.Text.Trim() != "" && cboMaNV.Text != "" && txtTenKH.Text != "" && txtSDT.Text != "" && dtNgayBan.Text != "")
            {
                
                if (busHDB.KiemTraMa(txtMaHD.Text.Trim()))
                {
                    MessageBox.Show("Hóa đơn bán đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    string ngayBan = dtNgayBan.Value.ToString("yyyy-MM-dd");
                    DTO_HoaDonBan dtoHDB = new DTO_HoaDonBan(txtMaHD.Text.Trim(), cboMaNV.Text.Trim(), txtTenKH.Text, txtSDT.Text, DateTime.Parse(ngayBan));

                    if (!busHDB.ThemHDB(dtoHDB))
                    {
                        MessageBox.Show("Không thể lưu hóa đơn bán!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMoiHDB_Click(object sender, EventArgs e)
        {
            txtMaHD.Clear();
            cboMaNV.Text = "";
            txtTenKH.Clear();
            txtSDT.Clear();
            txtMaHD.Focus();
        }

        private void btnChiTietHDN_Click(object sender, EventArgs e)
        {
            GUI_ChiTietHDB frm = new GUI_ChiTietHDB();
            this.Hide();
            frm.ShowDialog();
            this.Close();
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
