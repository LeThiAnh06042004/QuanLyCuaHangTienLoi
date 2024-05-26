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
    public class BUS_ChiTietHDB
    {
        DAL_ChiTietHDB dalCTHDB = new DAL_ChiTietHDB();
        public DataTable HienCTHDB()
        {
            try
            {
                return dalCTHDB.HienCTHDB();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return null;
            }
        }
        public bool KiemTraMa(string maHDB, string maSP)
        {
            try
            {
                return dalCTHDB.KiemTraMa(maHDB, maSP);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return false;
            }
        }
        public DataTable LayMaHDB()
        {
            try
            {
                return dalCTHDB.LayMaHDB();
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
                return dalCTHDB.LayMaSP();
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
                return dalCTHDB.LayTenSP(masp);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return null;
            }
        }
        public DataTable LayGiaBan(string masp)
        {
            try
            {
                return dalCTHDB.LayGiaBan(masp);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return null;
            }
        }
        public bool ThemCTHDB(DTO_ChiTietHDB ct)
        {
            try
            {
                return dalCTHDB.ThemCTHDB(ct);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return false;
            }
        }
        public bool SuaCTHDB(DTO_ChiTietHDB ct)
        {
            try
            {
                return dalCTHDB.SuaCTHDB(ct);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return false;
            }
        }
        public bool XoaCTHDB(string MaHDB, string MaSP)
        {
            try
            {
                return dalCTHDB.XoaCTHDB(MaHDB, MaSP);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return false;
            }
        }
        public DataTable TimKiemCTHDB(string tk)
        {
            try
            {
                return dalCTHDB.TimKiemCTHDB(tk);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return null;
            }
        }
        public DataTable BaoCaoDT(string loaitg, string tg)
        {
            try
            {
                return dalCTHDB.BaoCaoDT(loaitg, tg);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return null;
            }
        }
    }
}
