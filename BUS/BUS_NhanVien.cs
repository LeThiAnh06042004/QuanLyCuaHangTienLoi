using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_NhanVien
    {
        DAL_NhanVien dalNV = new DAL_NhanVien();
        public DataTable HienNV()
        {
            try
            {
                return dalNV.HienNV();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return null;
            }
        }

        public bool KiemTraMa(string maNV)
        {
            try
            {
                return dalNV.KiemTraMa(maNV);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return false;
            }
        }
        public bool KiemTraTaiKhoan(string tk)
        {
            try
            {
                return dalNV.KiemTraTaiKhoan(tk);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return false;
            }
        }

        public string DangNhap(string tk, string mk)
        {
            try
            {
                string vaiTro = dalNV.DangNhap(tk, mk);
                return vaiTro;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool PhanQuyen(string vaiTro, string bang)
        {
            try
            {
                bool quyen = dalNV.PhanQuyen(vaiTro, bang);
                return quyen;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool SuaMK(string tk, string mk)
        {
            try
            {
                return dalNV.SuaMK(tk, mk);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return false;
            }
        }
        public bool ThemNV(DTO_NhanVien nv)
        {
            try
            {
                return dalNV.ThemNV(nv);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return false;
            }
        }
        public bool SuaNV(DTO_NhanVien nv)
        {
            try
            {
                return dalNV.SuaNV(nv);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return false;
            }
        }
        public bool XoaNV(string MaNV)
        {
            try
            {
                return dalNV.XoaNV(MaNV);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return false;
            }
        }
        public DataTable TimKiemNV(string tk)
        {
            try
            {
                return dalNV.TimKiemNV(tk);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return null;
            }
        }
    }
}
