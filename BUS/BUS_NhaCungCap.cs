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
    public class BUS_NhaCungCap
    {
        DAL_NhaCungCap dalNCC = new DAL_NhaCungCap();
        public DataTable HienNCC()
        {
            try
            {
                return dalNCC.HienNCC();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return null;
            }
        }
        public bool KiemTraMa(string maNCC)
        {
            try
            {
                return dalNCC.KiemTraMa(maNCC);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return false;
            }
        }
        public bool ThemNCC(DTO_NhaCungCap ncc)
        {
            try
            {
                return dalNCC.ThemNCC(ncc);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return false;
            }
        }
        public bool SuaNCC(DTO_NhaCungCap ncc)
        {
            try
            {
                return dalNCC.SuaNCC(ncc);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return false;
            }
        }
        public bool XoaNCC(string MaNCC)
        {
            try
            {
                return dalNCC.XoaNCC(MaNCC);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return false;
            }
        }
        public DataTable TimKiemNCC(string tk)
        {
            try
            {
                return dalNCC.TimKiemNCC(tk);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return null;
            }
        }
    }
}
