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
    public class DAL_NhaCungCap : DBConnect
    {
        public DataTable HienNCC()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from NCC", con);
                DataTable dtNhaCungCap = new DataTable();
                da.Fill(dtNhaCungCap);
                return dtNhaCungCap;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return null;
            }
        }
        public bool KiemTraMa(string maNCC)
        {
            bool tonTai = false;
            try
            {
                con.Open();
                string sql = "SELECT COUNT(*) FROM NCC WHERE MaNCC = @MaNCC";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@MaNCC", maNCC);
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
        public bool ThemNCC(DTO_NhaCungCap ncc)
        {
            try
            {
                if (!KiemTraMa(ncc.NCC_MaNCC))
                {
                    con.Open();
                    string sql = string.Format("insert into NCC values ('{0}', N'{1}', N'{2}', '{3}')", ncc.NCC_MaNCC, ncc.NCC_TenNCC, ncc.NCC_DiaChi, ncc.NCC_SdtNCC);
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

        public bool SuaNCC(DTO_NhaCungCap ncc)
        {
            try
            {
                con.Open();
                string sql = string.Format($"update NCC set TenNCC=N'{ncc.NCC_TenNCC}', DiaChi=N'{ncc.NCC_DiaChi}', SdtNCC='{ncc.NCC_SdtNCC}' where MaNCC='{ncc.NCC_MaNCC}'");
                SqlCommand cmd = new SqlCommand(sql, con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
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

        public bool XoaNCC(string MaNCC)
        {
            try
            {
                con.Open();
                string sql = string.Format($"delete NCC where MaNCC='{MaNCC}'");
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

        public DataTable TimKiemNCC(string tk)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = $"select MaNCC, TenNCC, DiaChi, SdtNCC from NCC where tenncc like N'%{tk}%'";
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
