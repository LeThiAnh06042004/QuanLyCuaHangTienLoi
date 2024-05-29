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
    public class DAL_SanPham : DBConnect
    {
        public DataTable HienSP()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from SANPHAM", con);
                DataTable dtSanPham = new DataTable();
                da.Fill(dtSanPham);
                return dtSanPham;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return null;
            }
        }

        public bool KiemTraMa(string maSP)
        {
            bool tonTai = false;
            try
            {
                con.Open();
                string sql = "SELECT COUNT(*) FROM SANPHAM WHERE MaSP = @MaSP";
                SqlCommand cmd = new SqlCommand(sql, con);
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

        public bool ThemSP(DTO_SanPham sp)
        {
            try
            {
                if (!KiemTraMa(sp.SanPham_MaSP))
                {
                    con.Open();
                    string sql = string.Format("insert into SANPHAM values ('{0}', N'{1}', '{2}', '{3}')", sp.SanPham_MaSP, sp.SanPham_TenSP, sp.SanPham_SLTon, sp.SanPham_Giaban);
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

        public bool SuaSP(DTO_SanPham sp)
        {
            try
            {
                con.Open();
                string sql = string.Format($"update SANPHAM set TenSP=N'{sp.SanPham_TenSP}', SLTon='{sp.SanPham_SLTon}', GiaBan=N'{sp.SanPham_Giaban}' where MaSP='{sp.SanPham_MaSP}'");
                SqlCommand cmd = new SqlCommand(sql, con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
            return false;
        }

        public bool XoaSP(string MaSP)
        {
            try
            {
                con.Open();
                string sql = string.Format($"delete SANPHAM where MaSP='{MaSP}'");
                SqlCommand cmd = new SqlCommand(sql, con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
            return false;
        }

        public DataTable TimKiemSP(string tk)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = $"select MaSP, TenSP, SLTon, GiaBan from SANPHAM where tensp like N'%{tk}%'";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
            }
            return dt;
        }

        public DataTable ThongKeSPTheoNgay(string ngayBan, bool chay)
        {
            con.Open();
            string sql = "SELECT SP.MaSP, SP.TenSP, " +
                         "       SUM(CASE WHEN HDB.NgayBan = @NgayBan THEN CT.SLBan ELSE 0 END) AS SoLuongBan, " +
                         "       SUM(CASE WHEN HDB.NgayBan = @NgayBan THEN CT.SLBan * CT.GiaBan ELSE 0 END) AS DoanhThu " +
                         "FROM SANPHAM SP " +
                         "LEFT JOIN CHITIETHDB CT ON SP.MaSP = CT.MaSP " +
                         "LEFT JOIN HOADONBAN HDB ON CT.MaHDB = HDB.MaHDB " +
                         "GROUP BY SP.MaSP, SP.TenSP ";

            if (chay)
            {
                sql += "ORDER BY SoLuongBan DESC";
            }
            else
            {
                sql += "ORDER BY SoLuongBan ASC";
            }

            SqlCommand cmd = new SqlCommand(sql, con); // tạo thực thi sqlcommand vs tham số @ngaybans
            cmd.Parameters.AddWithValue("@NgayBan", ngayBan);

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader()); // tải kq vào 1 dataTable
            con.Close();
            return dt;
        }

        public DataTable ThongKeSPTheoThang(string thang, bool chay)
        {
            con.Open();
            string sql = "SELECT SP.MaSP, SP.TenSP, " +
                         "       SUM(CASE WHEN MONTH(HDB.NgayBan) = MONTH(@Thang) AND YEAR(HDB.NgayBan) = YEAR(@Thang) THEN CT.SLBan ELSE 0 END) AS SoLuongBan, " +
                         "       SUM(CASE WHEN MONTH(HDB.NgayBan) = MONTH(@Thang) AND YEAR(HDB.NgayBan) = YEAR(@Thang) THEN CT.SLBan * CT.GiaBan ELSE 0 END) AS DoanhThu " +
                         "FROM SANPHAM SP " +
                         "LEFT JOIN CHITIETHDB CT ON SP.MaSP = CT.MaSP " +
                         "LEFT JOIN HOADONBAN HDB ON CT.MaHDB = HDB.MaHDB " +
                         "GROUP BY SP.MaSP, SP.TenSP ";
                         
            if (chay)
            {
                sql += "ORDER BY SoLuongBan DESC";
            }
            else
            {
                sql += "ORDER BY SoLuongBan ASC";
            }

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Thang", thang);

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;
        }

        public DataTable ThongKeSPTheoNam(string nam, bool chay)
        {
            con.Open();
            string sql = "SELECT SP.MaSP, SP.TenSP, " +
                 "       SUM(CASE WHEN YEAR(HDB.NgayBan) = YEAR(@Nam) THEN CT.SLBan ELSE 0 END) AS SoLuongBan, " +
                 "       SUM(CASE WHEN YEAR(HDB.NgayBan) = YEAR(@Nam) THEN CT.SLBan * CT.GiaBan ELSE 0 END) AS DoanhThu " +
                 "FROM SANPHAM SP " +
                 "LEFT JOIN CHITIETHDB CT ON SP.MaSP = CT.MaSP " +
                 "LEFT JOIN HOADONBAN HDB ON CT.MaHDB = HDB.MaHDB " +
                 "GROUP BY SP.MaSP, SP.TenSP ";

            if (chay)
            {
                sql += "ORDER BY SoLuongBan DESC";
            }
            else
            {
                sql += "ORDER BY SoLuongBan ASC";
            }

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Nam", nam);

             DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;
    }
    }
}
