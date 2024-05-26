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
    public class BUS_HoaDonBan
    {
        DAL_HoaDonBan dalHDB = new DAL_HoaDonBan();
        public DataTable HienHDB()
        {
            try
            {
                return dalHDB.HienHDB();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return null;
            }
        }
        public bool KiemTraMa(string maHDB)
        {
            try
            {
                return dalHDB.KiemTraMa(maHDB);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return false;
            }
        }
        //public bool KiemTraLQ(string maHDB)
        //{
            //try
            //{
                //return dalHDB.KiemTraLQ(maHDB);
            //}
            //catch (Exception ex)
            //{
                //Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                //return false;
            //}
        //}
        public DataTable LayMaNV()
        {
            try
            {
                return dalHDB.LayMaNV();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return null;
            }
        }
        public bool ThemHDB(DTO_HoaDonBan hdb)
        {
            try
            {
                return dalHDB.ThemHDB(hdb);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return false;
            }
        }
        public bool SuaHDB(DTO_HoaDonBan hdb)
        {
            try
            {
                return dalHDB.SuaHDB(hdb);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return false;
            }
        }
        public bool XoaHDB(string MaHDB)
        {
            try
            {
                return dalHDB.XoaHDB(MaHDB);
            }
            catch (Exception ex)
            {
                throw new Exception($"Đã xảy ra lỗi khi xóa hóa đơn bán: {ex.Message}");
            }
        }
        // public bool XoaCTHDB(string MaHDB)
        //{
        // try
        //{
        // return dalHDB.XoaCTHDB(MaHDB);
        //}
        //catch (Exception ex)
        //{
        //Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
        //return false;
        // }
        //}

        public DataTable TimKiemHDB(DateTime tk)
        {
            try
            {
                return dalHDB.TimKiemHDB(tk);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return null;
            }
        }
    }
}
