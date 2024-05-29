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
    public class DAL_NhanVien : DBConnect
    {
        public DataTable HienNV()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from NHANVIEN", con); // lấy dl từ bảng nv
                DataTable dtNhanVien = new DataTable();
                da.Fill(dtNhanVien); // lấy dl từ kq truy vấn vào dt và trả về kq
                return dtNhanVien;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return null;
            }
        }

        public bool KiemTraMa(string maNV)
        {
            bool tonTai = false;
            try
            {
                con.Open();
                string sql = "SELECT COUNT(*) FROM NHANVIEN WHERE MaNV = @MaNV";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@MaNV", maNV);
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
        public bool KiemTraTaiKhoan(string tk)
        {
            bool tonTai = false;
            try
            {
                con.Open();
                string sql = "SELECT COUNT(*) FROM NHANVIEN WHERE TaiKhoan = @tk";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Matk", tk); //thêm tham số @tk vào câu lệnh sql vs gt của biến tk
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

        public string DangNhap(string tk, string mk)
        {
            string cv = null;
            string sql = "SELECT COUNT(*) FROM NHANVIEN WHERE TaiKhoan = @TaiKhoan AND MatKhau = @MatKhau"; // đếm sl bản ghi trùng khớp vs gt đầu vào
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@TaiKhoan", tk); // thiết lập các gt taikhoan và matkhau vs gt của tk và mk
            cmd.Parameters.AddWithValue("@MatKhau", mk);

            try
            {
                con.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar()); // thực thi câu lệnh và lưu kq vào biến count
                if (count > 0)
                {
                    cv = tk == "LeThiAnh" && mk == "06042004" ? "Quản lý" : "Nhân viên"; //nếu tk là lta và mk là 06042004 thì gán vtro QL cho cv, nếu ko thì gán vtro NV
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close(); // Đóng kết nối sau khi hoàn thành công việc
            }
            return cv;
        }

        public bool PhanQuyen(string cv, string bang)
        {
            if (cv == "Quản lý")
            {
                return true; //truy cập đc all các bảng
            }
            else if (cv == "Nhân viên")
            {
                return bang == "SANPHAM" || bang == "HOADONBAN" || bang == "HOADONNHAP" || bang == "CHITIETHDN" || bang == "CHITIETHDB"; // chỉ truy cập đc các bảng...
            }
            else
            {
                return false; // ko có quyền truy cập
            }
        }

        public bool SuaMK(string tk, string mk)
        {
            try
            {
                con.Open();
                string sql = $"UPDATE NHANVIEN SET MatKhau = @MatKhauMoi WHERE TaiKhoan = @TaiKhoan";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@TaiKhoan", tk);
                cmd.Parameters.AddWithValue("@MatKhauMoi", mk);
                int result = cmd.ExecuteNonQuery(); //thực thi câu lệnh và trả về kq lưu vào biến result
                return result > 0; // trả về true nếu có ít nhất 1 dòng đc cập nhật và ngược lại
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

        public bool ThemNV(DTO_NhanVien nv)
        {
            try
            {
                if (!KiemTraMa(nv.NhanVien_MaNV))
                {
                    con.Open();
                    string sql = $"insert into NHANVIEN values ('{nv.NhanVien_MaNV}', N'{nv.NhanVien_TenNV}', '{nv.NhanVien_NgaySinh}', N'{nv.NhanVien_GioiTinh}', N'{nv.NhanVien_QueQuan}', '{nv.NhanVien_SDT}', N'{nv.NhanVien_TaiKhoan}', N'{nv.NhanVien_MatKhau}')";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    if (cmd.ExecuteNonQuery() > 0) // thực thi câu lệnh trả về số dòng bị ảnh hưởng, nếu >0 thì trả ra gt true
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

        public bool SuaNV(DTO_NhanVien nv)
        {
            try
            {
                con.Open();
                string sql = string.Format($"update NHANVIEN  set TenNV=N'{nv.NhanVien_TenNV}', NgaySinh='{nv.NhanVien_NgaySinh}', GioiTinh=N'{nv.NhanVien_GioiTinh}', QueQuan=N'{nv.NhanVien_QueQuan}', SdtNV='{nv.NhanVien_SDT}', TaiKhoan='{nv.NhanVien_TaiKhoan}', MatKhau='{nv.NhanVien_MatKhau}' where MaNV='{nv.NhanVien_MaNV}'");
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

        public bool XoaNV(string MaNV)
        {
            try
            {
                con.Open();
                string sql = string.Format("delete NHANVIEN where MaNV='{0}'", MaNV);
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

        public DataTable TimKiemNV(string tk)
        {
            DataTable dt = new DataTable(); // kb dt để lưu kq
            try
            {
                string sql = $"select MaNV, TenNV, NgaySinh, GioiTinh, QueQuan, SdtNV, TaiKhoan, MatKhau from NHANVIEN where tennv like N'%{tk}%'";
                SqlDataAdapter da = new SqlDataAdapter(sql, con); // thực thi và lấy dl từ csdl vào dt
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
