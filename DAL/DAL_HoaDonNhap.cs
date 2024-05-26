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
    public class DAL_HoaDonNhap : DBConnect
    {
        public DataTable HienHDN()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from HOADONNHAP", con);
                DataTable dtHDN = new DataTable();
                da.Fill(dtHDN);
                return dtHDN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return null;
            }
        }
        public DataTable LayMaNV()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select MaNV from NHANVIEN", con);
                DataTable dtHDN = new DataTable();
                da.Fill(dtHDN);
                return dtHDN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return null;
            }
        }

        public DataTable LayMaNCC()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select MaNCC from NCC", con);
                DataTable dtHDN = new DataTable();
                da.Fill(dtHDN);
                return dtHDN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return null;
            }
        }
        public bool KiemTraMa(string maHDN)
        {
            try
            {
                con.Open();
                string sql = "SELECT COUNT(*) FROM HOADONNHAP WHERE MaHDN = @MaHDN";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@MaHDN", maHDN);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
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
        public bool KiemTraLQ(string maHDN)
        {
            try
            {
                con.Open();
                string sql = "SELECT COUNT(*) FROM CHITIETHDN WHERE MaHDN = @MaHDN";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@MaHDN", maHDN);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
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

        public bool ThemHDN(DTO_HoaDonNhap hdn)
        {
            try
            {
                if (!KiemTraMa(hdn.HDN_MaHDN))
                {
                    con.Open();
                    string sql = $"insert into HOADONNHAP values ('{hdn.HDN_MaHDN}', '{hdn.HDN_MaNV}', '{hdn.HDN_MaNCC}', '{hdn.HDN_NgayNhap.ToString("yyyy-MM-dd")}')";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return false;
        }

        public bool SuaHDN(DTO_HoaDonNhap hdn)
        {
            try
            {
                con.Open();
                string sql = $"update HOADONNHAP set NgayNhap='{hdn.HDN_NgayNhap.ToString("yyyy-MM-dd")}' where MaHDN='{hdn.HDN_MaHDN}'";
                SqlCommand cmd = new SqlCommand(sql, con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return false;
        }

        public bool XoaHDN(string MaHDN)
        {
            try
            {
                con.Open();
                string sql = string.Format($"delete HOADONNHAP where MaHDN='{MaHDN}'");
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
        public bool XoaCTHDN(string maHDN)
        {
            try
            {
                con.Open();
                string sql = "DELETE FROM CHITIETHDN WHERE MaHDN = @MaHDN";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@MaHDN", maHDN);
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable TimKiemHDN(DateTime tk)
        {
            DataTable dt = new DataTable();
            try
            {
                string tim = tk.ToString("yyyy-MM-dd");
                string sql = $"select MaHDN, MaNV, MaNCC, NgayNhap from HOADONNHAP where NgayNhap like N'%{tim}%'";
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
