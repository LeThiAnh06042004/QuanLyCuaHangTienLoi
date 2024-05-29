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
    public partial class GUI_SanPham : Form
    {
        public GUI_SanPham()
        {
            InitializeComponent();
        }

        BUS_SanPham busSP = new BUS_SanPham();

        private void GUI_SanPham_Load(object sender, EventArgs e)
        {
            dgKhoHang.DataSource = busSP.HienSP();
            toolTip.SetToolTip(btnThem, "Thêm");
            toolTip.SetToolTip(btnSua, "Sửa");
            toolTip.SetToolTip(btnXoa, "Xóa");
            toolTip.SetToolTip(btnVe, "Về trang chủ");
            toolTip.SetToolTip(btnThoat, "Thoát");
            toolTip.SetToolTip(btnTimKiem, "Tìm kiếm");
        }

        private void dgKhoHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMa.Text = dgKhoHang[0, hang].Value.ToString();
            txtTen.Text = dgKhoHang[1, hang].Value.ToString();
            txtSLTon.Text = dgKhoHang[2, hang].Value.ToString();
            txtGiaBan.Text = dgKhoHang[3, hang].Value.ToString();
        }

        public void Refresh()
        {
            txtMa.Clear();
            txtTen.Clear();
            txtSLTon.Clear();
            txtGiaBan.Clear();
            txtTimKiem.Clear();
            txtMa.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMa.Text != "" && txtTen.Text != "" && txtSLTon.Text != "" && txtGiaBan.Text != "")
            {
                DTO_SanPham dtoSP = new DTO_SanPham(txtMa.Text, txtTen.Text, Convert.ToInt32(txtSLTon.Text), Convert.ToInt32(txtGiaBan.Text));
                if (busSP.ThemSP(dtoSP))
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgKhoHang.DataSource = busSP.HienSP();
                    Refresh();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công hoặc mã sản phẩm đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Thông tin không hợp lệ. Xin hãy nhập đầy đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMa.Text != "" && txtTen.Text.Trim() != "" && txtSLTon.Text.Trim() != "" && txtGiaBan.Text.Trim() != "")
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn sửa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DTO_SanPham sp = new DTO_SanPham(txtMa.Text, txtTen.Text, Convert.ToInt32(txtSLTon.Text), Convert.ToInt32(txtGiaBan.Text));
                    if (busSP.SuaSP(sp))
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgKhoHang.DataSource = busSP.HienSP();
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
            if (txtTen.Text.Trim() != "" && txtSLTon.Text.Trim() != "" && txtGiaBan.Text.Trim() != "")
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (busSP.XoaSP(txtMa.Text))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgKhoHang.DataSource = busSP.HienSP();
                        Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgKhoHang.DataSource = busSP.TimKiemSP(txtTimKiem.Text);
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

        public void GanSP(out string masp, out string tensp, out string giaban)
        {
            masp = txtMa.Text;
            tensp = txtTen.Text;
            giaban = txtGiaBan.Text;
            //thông tin sau gán đc truyền qua ts out của pthuc, cho phép trả về từ pt và sd ngoài pt
        }

        public void LayTenSP(out string masp, out string tensp)
        {
            masp = txtMa.Text;
            tensp = txtTen.Text;
        }
    }
}
