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
    public class DAL_ChiTietHDB:DBConnect
    {
        public DataTable HienCTHDB()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select MaHDB, SANPHAM.MaSP, TenSP, SLBan, CHITIETHDB.GiaBan from CHITIETHDB inner join SANPHAM on CHITIETHDB.MaSP = SANPHAM.MaSP", con);
                DataTable dtCTHDB = new DataTable();
                da.Fill(dtCTHDB);
                return dtCTHDB;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return null;
            }
        }
        public DataTable LayMaHDB()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select MaHDB from HOADONBAN", con);
                DataTable dtCTHDB = new DataTable();
                da.Fill(dtCTHDB);
                return dtCTHDB;
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
                DataTable dtCTHDB = new DataTable();
                da.Fill(dtCTHDB);
                return dtCTHDB;
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
                DataTable dtCTHDB = new DataTable();
                da.Fill(dtCTHDB);
                return dtCTHDB;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return null;
            }
        }
        public DataTable LayGiaBan(string masp)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter($"select GiaBan from SANPHAM where MaSP='{masp}'", con);
                DataTable dtCTHDB = new DataTable();
                da.Fill(dtCTHDB);
                return dtCTHDB;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return null;
            }
        }
        public bool KiemTraMa(string maHDB, string maSP)
        {
            bool tonTai = false;
            try
            {
                con.Open();
                string sql = "SELECT COUNT(*) FROM CHITIETHDB WHERE MaHDB = @MaHDB and MaSP=@MaSP";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@MaHDB", maHDB);
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

        public bool ThemCTHDB(DTO_ChiTietHDB ct)
        {
            try
            {
                if (!KiemTraMa(ct.CTHDB_MaHDB, ct.CTHDB_MaSP))
                {
                    con.Open();
                    string sql = string.Format("insert into CHITIETHDB values ('{0}', '{1}', '{2}', '{3}')", ct.CTHDB_MaHDB, ct.CTHDB_MaSP, ct.CTHDB_SL, ct.CTHDB_GiaBan);
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

        public bool SuaCTHDB(DTO_ChiTietHDB ct)
        {
            try
            {
                con.Open();
                string sql = string.Format($"update CHITIETHDB set SLBan='{ct.CTHDB_SL}' where MaHDB='{ct.CTHDB_MaHDB}' and MaSP='{ct.CTHDB_MaSP}'");
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

        public bool XoaCTHDB(string MaHDB, string MaSP)
        {
            try
            {
                con.Open();
                string sql = string.Format($"delete CHITIETHDB where MaHDB='{MaHDB}' and MaSP='{MaSP}'");
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

        public DataTable TimKiemCTHDB(string tk)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = $"select MaHDB, SANPHAM.MaSP, TenSP, SLBan, SANPHAM.GiaBan from CHITIETHDB inner join SANPHAM on CHITIETHDB.MaSP=SANPHAM.MaSP where TenSP like N'%{tk}%'";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
            }
            return dt;
        }

        public DataTable BaoCaoDT(string loaitg, string tg)
        {
            try
            {
                con.Open();
                string sql = "select HDB.MaHDB, SP.MaSP, SUM(CTB.SLBan) as [Tổng số lượng], sum(CTB.SLBan * CTB.GiaBan) as [Tổng tiền bán], " +
                             "sum(CTB.SLBan * CTN.GiaNhap) as [Tổng tiền nhập], sum(CTB.SLBan * CTB.GiaBan) - sum(CTB.SLBan * CTN.GiaNhap) as [Tổng tiền lãi] " +
                             "from HOADONBAN HDB join CHITIETHDB CTB on HDB.MaHDB=CTB.MaHDB JOIN SANPHAM SP ON CTB.MaSP=SP.MaSP " +
                             "JOIN CHITIETHDN CTN ON SP.MaSP=CTN.MaSP ";

                if (loaitg == "Ngày")
                {
                    sql += "WHERE HDB.NgayBan = @NgayBan ";
                }
                else if (loaitg == "Tháng")
                {
                    sql += "WHERE MONTH(HDB.NgayBan) = MONTH(@Thang) AND YEAR(HDB.NgayBan) = YEAR(@Thang) ";
                }
                else if (loaitg == "Năm")
                {
                    sql += "WHERE YEAR(HDB.NgayBan) = YEAR(@Nam) ";
                }

                sql += "GROUP BY HDB.MaHDB, SP.MaSP ";


                SqlCommand cmd = new SqlCommand(sql, con);

                if (loaitg == "Ngày")
                {
                    cmd.Parameters.AddWithValue("@NgayBan", tg); //dựa theo tg thêm các tham số ngày, tháng, năm vào sqlcommand
                }
                else if (loaitg == "Tháng")
                {
                    cmd.Parameters.AddWithValue("@Thang", tg);
                }
                else if (loaitg == "Năm")
                {
                    cmd.Parameters.AddWithValue("@Nam", tg);
                }

                // tải dữ liệu vào dt
                DataTable dt = new DataTable(); 
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
