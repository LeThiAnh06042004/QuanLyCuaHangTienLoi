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
    public partial class GUI_ThongKe : Form
    {
        public GUI_ThongKe()
        {
            InitializeComponent();
        }

        BUS_SanPham busSP = new BUS_SanPham();

        private void btnBaoCaoSP_Click(object sender, EventArgs e)
        {
            if (cboTieuChiSP.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn tiêu chí thống kê!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tc = cboTieuChiSP.SelectedItem.ToString();
            DataTable dt = null;
            string ngay = dtThoiGian.Value.ToString("yyyy-MM-dd"); // Đảm bảo định dạng yyyy-MM-dd
            bool chay = false;

            if (cboTieuChiSP.SelectedItem.ToString() == "Sản phẩm bán chạy")
            {
                chay = true;
            }

            try
            {
                if (rdbNgay.Checked)
                {
                    dt = busSP.ThongKeSPTheoNgay(ngay, chay);
                }
                else if (rdbThang.Checked)
                {
                    dt = busSP.ThongKeSPTheoThang(ngay, chay);
                }
                else if (rdbNam.Checked)
                {
                    dt = busSP.ThongKeSPTheoNam(ngay, chay);
                }

                if (dt != null && dt.Rows.Count > 0)
                {
                    dgBaoCaoSP.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu trong thời gian này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVe_Click(object sender, EventArgs e)
        {
            GUI_TrangChuQL frm = new GUI_TrangChuQL();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GUI_ThongKe_Load(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnBaoCaoSP, "Thống kê sản phẩm");
            toolTip.SetToolTip(cboTieuChiSP, "Chọn tiêu chí cần thống kê");
            toolTip.SetToolTip(dtThoiGian, "Chọn thời gian cần thống kê");
            toolTip.SetToolTip(btnVe, "Về trang chủ");
            toolTip.SetToolTip(btnThoat, "Thoát");
            toolTip.SetToolTip(rdbNgay, "Thống kê theo ngày");
            toolTip.SetToolTip(rdbThang, "Thống kê theo tháng");
            toolTip.SetToolTip(rdbNam, "Thống kê theo năm");
        }
    }
}
