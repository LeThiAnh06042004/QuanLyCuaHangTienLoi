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
    public partial class GUI_BaoCao : Form
    {
        public GUI_BaoCao()
        {
            InitializeComponent();
        }

        BUS_ChiTietHDB busCTB = new BUS_ChiTietHDB();

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            string tg = dtNgayBan.Value.ToString("yyyy-MM-dd");
            string loaitg = "";

            //kiểm tra rdb đc chọn
            if (rdbNgay.Checked)
            {
                loaitg = "Ngày"; // nếu rdbNgay đc chọn thì gán gt Ngày cho loaitg
            }
            else if (rdbThang.Checked)
            {
                loaitg = "Tháng";
            }
            else if (rdbNam.Checked)
            {
                loaitg = "Năm";
            }

            try
            {
                DataTable dt = busCTB.BaoCaoDT(loaitg, tg);
                if (dt != null && dt.Rows.Count > 0)
                {
                    dgBaoCao.DataSource = dt;

                    int tongHoaDon = 0;
                    double tongNhap = 0;
                    double tongBan = 0;
                    double tongLoi = 0;

                    foreach (DataRow row in dt.Rows)
                    {
                        tongHoaDon++;
                        tongNhap += Convert.ToDouble(row["Tổng tiền nhập"]);
                        tongBan += Convert.ToDouble(row["Tổng tiền bán"]);
                        tongLoi += Convert.ToDouble(row["Tổng tiền lãi"]);
                    }

                    txtSL.Text = tongHoaDon.ToString();
                    txtTongNhap.Text = tongNhap.ToString();
                    txtTongBan.Text = tongBan.ToString();
                    txtTongLai.Text = tongLoi.ToString();
                }
                else
                {
                    MessageBox.Show("Cửa hàng nghỉ vào ngày này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            GUI_TrangChuQL frm = new GUI_TrangChuQL();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GUI_BaoCao_Load(object sender, EventArgs e)
        {
            toolTip.SetToolTip(rdbNam, "Báo cáo theo năm");
            toolTip.SetToolTip(rdbThang, "Báo cáo theo tháng");
            toolTip.SetToolTip(rdbNgay, "Báo cáo theo ngày");
            toolTip.SetToolTip(dtNgayBan, "Chọn thời gian cần báo cáo");
            toolTip.SetToolTip(btnBaoCao, "Báo cáo doanh thu");
            toolTip.SetToolTip(btnVe, "Về trang chủ");
            toolTip.SetToolTip(btnThoat, "Thoát");
        }
    }
}
