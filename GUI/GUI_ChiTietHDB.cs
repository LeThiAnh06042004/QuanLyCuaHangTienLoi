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
    public partial class GUI_ChiTietHDB : Form
    {
        public GUI_ChiTietHDB()
        {
            InitializeComponent();
        }

        BUS_ChiTietHDB busCTHDB = new BUS_ChiTietHDB();

        public void Refresh()
        {
            cboMaHDB.Text = "";
            cboSP.Text = "";
            txtTenSP.Clear();
            txtSL.Clear();
            txtGiaBan.Clear();
            txtSL.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboMaHDB.Text.Trim() != "" && cboSP.Text.Trim() != "" && txtSL.Text != "" && txtGiaBan.Text != "" && txtTenSP.Text != "")
            {
                DTO_ChiTietHDB dtoCTHDB = new DTO_ChiTietHDB(cboMaHDB.Text.Trim(), cboSP.Text.Trim(), txtTenSP.Text, Convert.ToInt32(txtSL.Text), Convert.ToInt32(txtGiaBan.Text));
                if (busCTHDB.ThemCTHDB(dtoCTHDB))
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgCTHDB.DataSource = busCTHDB.HienCTHDB();
                    Refresh();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công hoặc chi tiết hóa đơn bán này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Thông tin không hợp lệ. Xin hãy nhập đầy đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void cboSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = cboSP.SelectedItem as DataRowView;
            string sp = drv.Row[0].ToString();
            DataTable dtTenSP = busCTHDB.LayTenSP(sp);
            string tenSP = dtTenSP.Rows[0]["TenSP"].ToString();
            txtTenSP.Text = tenSP;

            DataTable dtGia = busCTHDB.LayGiaBan(sp);
            string gia = dtGia.Rows[0]["GiaBan"].ToString();
            txtGiaBan.Text = gia;
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (cboMaHDB.Text.Trim() != "" && cboSP.Text.Trim() != "" && txtTenSP.Text != "" && txtSL.Text != "" && txtGiaBan.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn sửa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DTO_ChiTietHDB dtoCTHDB = new DTO_ChiTietHDB(cboMaHDB.Text.Trim(), cboSP.Text.Trim(), txtTenSP.Text, Convert.ToInt32(txtSL.Text), Convert.ToInt32(txtGiaBan.Text));
                    if (busCTHDB.SuaCTHDB(dtoCTHDB))
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgCTHDB.DataSource = busCTHDB.HienCTHDB();
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

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (cboMaHDB.Text.Trim() != "" && cboSP.Text.Trim() != "" && txtTenSP.Text != "" && txtSL.Text != "" && txtGiaBan.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (busCTHDB.XoaCTHDB(cboMaHDB.Text, cboSP.Text))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgCTHDB.DataSource = busCTHDB.HienCTHDB();
                        Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            dgCTHDB.DataSource = busCTHDB.TimKiemCTHDB(txtTimKiem.Text);
            Refresh();
            txtTimKiem.Focus();
        }

        private void btnVe_Click_1(object sender, EventArgs e)
        {
            GUI_TaoHDB frm = new GUI_TaoHDB();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GUI_ChiTietHDB_Load_1(object sender, EventArgs e)
        {
            dgCTHDB.DataSource = busCTHDB.HienCTHDB();
            cboMaHDB.DataSource = busCTHDB.LayMaHDB();
            cboMaHDB.DisplayMember = "MaHDB";
            cboSP.DataSource = busCTHDB.LayMaSP();
            cboSP.DisplayMember = "MaSP";

            toolTip.SetToolTip(btnThem, "Thêm");
            toolTip.SetToolTip(btnSua, "Sửa");
            toolTip.SetToolTip(btnXoa, "Xóa");
            toolTip.SetToolTip(btnVe, "Về trang chủ");
            toolTip.SetToolTip(btnThoat, "Thoát");
            toolTip.SetToolTip(btnTimKiem, "Tìm kiếm");
        }

        private void dgCTHDB_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            cboMaHDB.Text = dgCTHDB[0, hang].Value.ToString();
            cboSP.Text = dgCTHDB[1, hang].Value.ToString();
            txtTenSP.Text = dgCTHDB[2, hang].Value.ToString();
            txtSL.Text = dgCTHDB[3, hang].Value.ToString();
            txtGiaBan.Text = dgCTHDB[4, hang].Value.ToString();
        }

        private void cboSP_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataRowView drv = cboSP.SelectedItem as DataRowView;
            string sp = drv.Row[0].ToString();
            DataTable dtTenSP = busCTHDB.LayTenSP(sp);
            string tenSP = dtTenSP.Rows[0]["TenSP"].ToString();
            txtTenSP.Text = tenSP;

            DataTable dtGia = busCTHDB.LayGiaBan(sp);
            string gia = dtGia.Rows[0]["GiaBan"].ToString();
            txtGiaBan.Text = gia;
        }
    }
}
