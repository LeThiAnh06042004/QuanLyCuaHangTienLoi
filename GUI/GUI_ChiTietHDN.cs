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
    public partial class GUI_ChiTietHDN : Form
    {
        public GUI_ChiTietHDN()
        {
            InitializeComponent();
        }

        BUS_ChiTietHDN busCTHDN = new BUS_ChiTietHDN();

        private void GUI_ChiTietHDN_Load(object sender, EventArgs e)
        {
            dgCTHDN.DataSource = busCTHDN.HienCTHDN();
            cboMaHDN.DataSource = busCTHDN.LayMaHDN();
            cboMaHDN.DisplayMember = "MaHDN";
            cboSP.DataSource = busCTHDN.LayMaSP();
            cboSP.DisplayMember = "MaSP";

            toolTip.SetToolTip(btnThem, "Thêm");
            toolTip.SetToolTip(btnSua, "Sửa");
            toolTip.SetToolTip(btnXoa, "Xóa");
            toolTip.SetToolTip(btnVe, "Về trang chủ");
            toolTip.SetToolTip(btnThoat, "Thoát");
            toolTip.SetToolTip(btnTimKiem, "Tìm kiếm");
        }

        private void dgCTHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            cboMaHDN.Text = dgCTHDN[0, hang].Value.ToString();
            cboSP.Text = dgCTHDN[1, hang].Value.ToString();
            txtTenSP.Text = dgCTHDN[2, hang].Value.ToString();
            txtSL.Text = dgCTHDN[3, hang].Value.ToString();
            txtGiaNhap.Text = dgCTHDN[4, hang].Value.ToString();
        }

        public void Refresh()
        {
            txtTenSP.Clear();
            txtSL.Clear();
            txtGiaNhap.Clear();
            txtSL.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboMaHDN.Text.Trim() != "" && cboSP.Text.Trim() != "" && txtSL.Text != "" && txtGiaNhap.Text != "" && txtTenSP.Text != "")
            {
                DTO_ChiTietHDN dtoCTHDN = new DTO_ChiTietHDN(cboMaHDN.Text.Trim(), cboSP.Text.Trim(), txtTenSP.Text, Convert.ToInt32(txtSL.Text), Convert.ToInt32(txtGiaNhap.Text));
                if (busCTHDN.ThemCTHDN(dtoCTHDN))
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgCTHDN.DataSource = busCTHDN.HienCTHDN();
                    Refresh();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công hoặc chi tiết hóa đơn nhập này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Thông tin không hợp lệ. Xin hãy nhập đầy đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (cboMaHDN.Text.Trim() != "" && cboSP.Text.Trim() != "" && txtTenSP.Text != "" && txtSL.Text != "" && txtGiaNhap.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn sửa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DTO_ChiTietHDN dtoCTHDN = new DTO_ChiTietHDN(cboMaHDN.Text.Trim(), cboSP.Text.Trim(), txtTenSP.Text, Convert.ToInt32(txtSL.Text), Convert.ToInt32(txtGiaNhap.Text));
                    if (busCTHDN.SuaCTHDN(dtoCTHDN))
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgCTHDN.DataSource = busCTHDN.HienCTHDN();
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
                MessageBox.Show("Thông tin không hợp lệ. Xin hãy nhập đầy đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cboMaHDN.Text.Trim() != "" && cboSP.Text.Trim() != "" && txtTenSP.Text != "" && txtSL.Text != "" && txtGiaNhap.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DTO_ChiTietHDN dtoCTHDN = new DTO_ChiTietHDN(cboMaHDN.Text.Trim(), cboSP.Text.Trim(), txtTenSP.Text, Convert.ToInt32(txtSL.Text), Convert.ToInt32(txtGiaNhap.Text));
                    if (busCTHDN.XoaCTHDN(cboMaHDN.Text, cboSP.Text))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgCTHDN.DataSource = busCTHDN.HienCTHDN();
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
            dgCTHDN.DataSource = busCTHDN.TimKiemCTHDN(txtTimKiem.Text);
            Refresh();
            txtTimKiem.Focus();
        }

        private void btnVe_Click(object sender, EventArgs e)
        {
            GUI_TaoHDN frm = new GUI_TaoHDN();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cboSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = cboSP.SelectedItem as DataRowView;
            string sp = drv.Row[0].ToString();
            DataTable dtTenSP = busCTHDN.LayTenSP(sp);
            string tenSP = dtTenSP.Rows[0]["TenSP"].ToString();
            txtTenSP.Text = tenSP;
        }
    }
}
