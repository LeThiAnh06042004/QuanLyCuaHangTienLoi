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
    public class BUS_SanPham
    {
        DAL_SanPham dalSP = new DAL_SanPham();
        public DataTable HienSP()
        {
            try
            {
                return dalSP.HienSP();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return null;
            }
        }
        public bool KiemTraMa(string maSP)
        {
            try
            {
                return dalSP.KiemTraMa(maSP);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return false;
            }
        }
        public bool ThemSP(DTO_SanPham sp)
        {
            try
            {
                return dalSP.ThemSP(sp);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return false;
            }
        }
        public bool SuaSP(DTO_SanPham sp)
        {
            try
            {
                return dalSP.SuaSP(sp);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return false;
            }
        }
        public bool XoaSP(string MaSP)
        {
            try
            {
                return dalSP.XoaSP(MaSP);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return false;
            }
        }
        public DataTable TimKiemSP(string tk)
        {
            try
            {
                return dalSP.TimKiemSP(tk);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return null;
            }
        }
        public DataTable ThongKeSPTheoNgay(string ngayBan, bool chay)
        {
            try
            {
                return dalSP.ThongKeSPTheoNgay(ngayBan, chay);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return null;
            }
        }

        public DataTable ThongKeSPTheoThang(string thang, bool chay)
        {
            try
            {
                return dalSP.ThongKeSPTheoThang(thang, chay);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return null;
            }
        }

        public DataTable ThongKeSPTheoNam(string nam, bool chay)
        {
            try
            {
                return dalSP.ThongKeSPTheoNam(nam, chay);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return null;
            }
        }
    }
}
