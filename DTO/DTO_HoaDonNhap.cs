using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HoaDonNhap
    {
        private string _HDN_MaHDN;
        private string _HDN_MaNV;
        private string _HDN_MaNCC;
        private DateTime _HDN_NgayNhap;

        public string HDN_MaHDN { get => _HDN_MaHDN; set => _HDN_MaHDN = value; }
        public string HDN_MaNV { get => _HDN_MaNV; set => _HDN_MaNV = value; }
        public string HDN_MaNCC { get => _HDN_MaNCC; set => _HDN_MaNCC = value; }
        public DateTime HDN_NgayNhap { get => _HDN_NgayNhap; set => _HDN_NgayNhap = value; }

        public DTO_HoaDonNhap()
        {

        }
        public DTO_HoaDonNhap(string mahdn, string manv, string mancc, DateTime ngaynhap)
        {
            this.HDN_MaHDN = mahdn;
            this.HDN_MaNV = manv;
            this.HDN_MaNCC = mancc;
            this.HDN_NgayNhap = ngaynhap;
        }
    }
}
