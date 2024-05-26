using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChiTietHDN
    {
        private string _CTHDN_MaHDN;
        private string _CTHDN_MaSP;
        private string _CTHDN_TenSP;
        private int _CTHDN_SL;
        private int _CTHDN_GiaNhap;

        public string CTHDN_MaHDN { get => _CTHDN_MaHDN; set => _CTHDN_MaHDN = value; }
        public string CTHDN_MaSP { get => _CTHDN_MaSP; set => _CTHDN_MaSP = value; }
        public string CTHDN_TenSP { get => _CTHDN_TenSP; set => _CTHDN_TenSP = value; }
        public int CTHDN_SL { get => _CTHDN_SL; set => _CTHDN_SL = value; }
        public int CTHDN_GiaNhap { get => _CTHDN_GiaNhap; set => _CTHDN_GiaNhap = value; }


        public DTO_ChiTietHDN()
        {

        }
        public DTO_ChiTietHDN(string mahdn, string masp, string tensp, int sl, int gianhap)
        {
            this.CTHDN_MaHDN = mahdn;
            this.CTHDN_MaSP = masp;
            this.CTHDN_TenSP = tensp;
            this.CTHDN_SL = sl;
            this.CTHDN_GiaNhap = gianhap;
        }
    }
}
