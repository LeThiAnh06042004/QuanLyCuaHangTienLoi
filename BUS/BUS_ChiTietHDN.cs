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
    public class BUS_ChiTietHDN
    {
        DAL_ChiTietHDN dalCTHDN = new DAL_ChiTietHDN();
        public DataTable HienCTHDN()
        {
            try
            {
                return dalCTHDN.HienCTHDN();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return null;
            }
        }
        public bool KiemTraMa(string maHDN, string maSP)
        {
            try
            {
                return dalCTHDN.KiemTraMa(maHDN, maSP);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return false;
            }
        }
        public DataTable LayMaHDN()
        {
            try
            {
                return dalCTHDN.LayMaHDN();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return null;
            }
        }
        public DataTable LayMaSP()
        {
            try
            {
                return dalCTHDN.LayMaSP();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return null;
            }
        }
        public DataTable LayTenSP(string masp)
        {
            try
            {
                return dalCTHDN.LayTenSP(masp);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return null;
            }
        }
        public bool ThemCTHDN(DTO_ChiTietHDN ct)
        {
            try
            {
                return dalCTHDN.ThemCTHDN(ct);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return false;
            }
        }
        public bool SuaCTHDN(DTO_ChiTietHDN ct)
        {
            try
            {
                return dalCTHDN.SuaCTHDN(ct);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return false;
            }
        }
        public bool XoaCTHDN(string MaHDN, string MaSP)
        {
            try
            {
                return dalCTHDN.XoaCTHDN(MaHDN, MaSP);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return false;
            }
        }
        public DataTable TimKiemCTHDN(string tk)
        {
            try
            {
                return dalCTHDN.TimKiemCTHDN(tk);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return null;
            }
        }
    }
}
