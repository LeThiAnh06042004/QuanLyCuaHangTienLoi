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
    public class DAL_HoaDonBan : DBConnect
    {
        public DataTable HienHDB()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from HOADONBAN", con);
                DataTable dtHDB = new DataTable();
                da.Fill(dtHDB);
                return dtHDB;
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
                DataTable dtHDB = new DataTable();
                da.Fill(dtHDB);
                return dtHDB;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return null;
            }
        }
        public bool KiemTraMa(string maHDB)
        {
            bool tonTai = false;
            try
            {
                con.Open();
                string sql = "SELECT COUNT(*) FROM HOADONBAN WHERE MaHDB = @MaHDB";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@MaHDB", maHDB);
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
        //public bool KiemTraLQ(string maHDB)
        //{
            //try
            //{
                //con.Open();
                //string sql = "SELECT COUNT(*) FROM CHITIETHDB WHERE MaHDB = @MaHDB";
                //SqlCommand cmd = new SqlCommand(sql, con);
                //cmd.Parameters.AddWithValue("@MaHDB", maHDB);
                //int count = (int)cmd.ExecuteScalar();
                //return count > 0;
            //}
            //catch (Exception ex)
           // {
                //Console.WriteLine("Lỗi: " + ex.Message);
            //}
            //finally
            //{
                //con.Close();
            //}
            //return false;
        //}

        public bool ThemHDB(DTO_HoaDonBan hdb)
        {
            try
            {
                if (!KiemTraMa(hdb.HDB_MaHDB))
                {
                    con.Open();
                    string sql = $"INSERT INTO HOADONBAN VALUES ('{hdb.HDB_MaHDB}', '{hdb.HDB_MaNV}', N'{hdb.HDB_TenKH}', '{hdb.HDB_SdtKH}', '{hdb.HDB_NgayBan.ToString("yyyy-MM-dd")}')";
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

        public bool SuaHDB(DTO_HoaDonBan hdb)
        {
            try
            {
                con.Open();
                string sql = $"update HOADONBAN set TenKH=N'{hdb.HDB_TenKH}', SdtKH=N'{hdb.HDB_SdtKH}', NgayBan='{hdb.HDB_NgayBan.ToString("yyyy-MM-dd")}' where MaHDB='{hdb.HDB_MaHDB}'";
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

        public bool XoaHDB(string MaHDB)
        {
            try
            {
                con.Open();
                string sql = string.Format($"delete HOADONBAN where MaHDB='{MaHDB}'");
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
        //public bool XoaCTHDB(string maHDB)
        //{
            //try
            //{
                //con.Open();
                //string sql = "DELETE FROM CHITIETHDB WHERE MaHDB = @MaHDB";
                //SqlCommand cmd = new SqlCommand(sql, con);
                //cmd.Parameters.AddWithValue("@MaHDB", maHDB);
                //int rowsAffected = cmd.ExecuteNonQuery();
                //return rowsAffected > 0;
            //}
            //catch (Exception ex)
            //{
                //Console.WriteLine("Lỗi: " + ex.Message);
                //return false;
            //}
            //finally
            //{
                //con.Close();
            //}
        //}

        public DataTable TimKiemHDB(DateTime tk)
        {
            DataTable dt = new DataTable();
            try
            {
                string tim = tk.ToString("yyyy-MM-dd");
                string sql = $"SELECT MaHDB, MaNV, TenKH, SdtKH, NgayBan FROM HOADONBAN WHERE NgayBan = '{tim}'";
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
