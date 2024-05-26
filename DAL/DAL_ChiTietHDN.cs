using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_ChiTietHDN:DBConnect
    {
        public DataTable HienCTHDN()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select MaHDN, SANPHAM.MaSP, TenSP, SLNhap, GiaNhap from CHITIETHDN inner join SANPHAM on CHITIETHDN.MaSP = SANPHAM.MaSP", con);
                DataTable dtCTHDN = new DataTable();
                da.Fill(dtCTHDN);
                return dtCTHDN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return null;
            }
        }
        public DataTable LayMaHDN()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select MaHDN from HOADONNHAP", con);
                DataTable dtCTHDN = new DataTable();
                da.Fill(dtCTHDN);
                return dtCTHDN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return null;
            }
        }
        public DataTable LayMaSP()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select MaSP from SANPHAM", con);
                DataTable dtCTHDN = new DataTable();
                da.Fill(dtCTHDN);
                return dtCTHDN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return null;
            }
        }
        public DataTable LayTenSP(string masp)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter($"select TenSP from SANPHAM where MaSP='{masp}'", con);
                DataTable dtCTHDN = new DataTable();
                da.Fill(dtCTHDN);
                return dtCTHDN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return null;
            }
        }
        public bool KiemTraMa(string maHDN, string maSP)
        {
            bool tonTai = false;
            try
            {
                con.Open();
                string sql = "SELECT COUNT(*) FROM CHITIETHDN WHERE MaHDN = @MaHDN and MaSP=@MaSP";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@MaHDN", maHDN);
                cmd.Parameters.AddWithValue("@MaSP", maSP);
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    tonTai = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return tonTai;
        }

        public bool ThemCTHDN(DTO_ChiTietHDN ct)
        {
            try
            {
                if (!KiemTraMa(ct.CTHDN_MaHDN, ct.CTHDN_MaSP))
                {
                    con.Open();
                    string sql = string.Format("insert into CHITIETHDN values ('{0}', '{1}', '{2}', '{3}')", ct.CTHDN_MaHDN, ct.CTHDN_MaSP, ct.CTHDN_SL, ct.CTHDN_GiaNhap);
                    SqlCommand cmd = new SqlCommand(sql, con);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return false;
        }

        public bool SuaCTHDN(DTO_ChiTietHDN ct)
        {
            try
            {
                con.Open();
                string sql = string.Format($"update CHITIETHDN set SLNhap='{ct.CTHDN_SL}', GiaNhap='{ct.CTHDN_GiaNhap}' where MaHDN='{ct.CTHDN_MaHDN}' and MaSP='{ct.CTHDN_MaSP}'");
                SqlCommand cmd = new SqlCommand(sql, con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return false;
        }

        public bool XoaCTHDN(string MaHDN, string MaSP)
        {
            try
            {
                con.Open();
                string sql = string.Format($"delete CHITIETHDN where MaHDN='{MaHDN}' and MaSP='{MaSP}'");
                SqlCommand cmd = new SqlCommand(sql, con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return false;
        }

        public DataTable TimKiemCTHDN(string tk)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = $"select MaHDN, SANPHAM.MaSP, TenSP, SLNhap, GiaNhap from CHITIETHDN inner join SANPHAM on CHITIETHDN.MaSP=SANPHAM.MaSP where TenSP like N'%{tk}%'";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
            }
            return dt;
        }
    }
}
