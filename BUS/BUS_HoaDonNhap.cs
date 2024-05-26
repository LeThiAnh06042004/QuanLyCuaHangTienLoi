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
    public class BUS_HoaDonNhap
    {
        DAL_HoaDonNhap dalHDN = new DAL_HoaDonNhap();
        public DataTable HienHDN()
        {
            try
            {
                return dalHDN.HienHDN();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return null;
            }
        }
        public bool KiemTraMa(string maHDN)
        {
            try
            {
                return dalHDN.KiemTraMa(maHDN);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return false;
            }
        }
        public bool KiemTraLQ(string maHDN)
        {
            try
            {
                return dalHDN.KiemTraLQ(maHDN);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return false;
            }
        }
        public DataTable LayMaNV()
        {
            try
            {
                return dalHDN.LayMaNV();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return null;
            }
        }
        public DataTable LayMaNCC()
        {
            try
            {
                return dalHDN.LayMaNCC();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return null;
            }
        }
        public bool ThemHDN(DTO_HoaDonNhap hdn)
        {
            try
            {
                return dalHDN.ThemHDN(hdn);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return false;
            }
        }
        public bool SuaHDN(DTO_HoaDonNhap hdn)
        {
            try
            {
                return dalHDN.SuaHDN(hdn);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return false;
            }
        }
        public bool XoaHDN(string MaHDN)
        {
            try
            {
                // Xóa các chi tiết hóa đơn nhập trước
                if (!dalHDN.XoaCTHDN(MaHDN))
                {
                    return false;
                }
                // Sau đó xóa hóa đơn nhập
                return dalHDN.XoaHDN(MaHDN);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return false;
            }
        }
        public bool XoaCTHDN(string MaHDN)
        {
            try
            {
                return dalHDN.XoaCTHDN(MaHDN);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return false;
            }
        }

        public DataTable TimKiemHDN(DateTime tk)
        {
            try
            {
                return dalHDN.TimKiemHDN(tk);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return null;
            }
        }
    }
}
