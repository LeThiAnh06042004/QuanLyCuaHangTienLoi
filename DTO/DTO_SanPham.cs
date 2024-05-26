using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SanPham
    {
        private string _SanPham_MaSP;
        private string _SanPham_TenSP;
        private int _SanPham_SLTon;
        private int _SanPham_Giaban;

        public string SanPham_MaSP { get => _SanPham_MaSP; set => _SanPham_MaSP = value; }
        public string SanPham_TenSP { get => _SanPham_TenSP; set => _SanPham_TenSP = value; }
        public int SanPham_SLTon { get => _SanPham_SLTon; set => _SanPham_SLTon = value; }
        public int SanPham_Giaban { get => _SanPham_Giaban; set => _SanPham_Giaban = value; }

        public DTO_SanPham()
        {

        }

        public DTO_SanPham(string masp, string tensp, int slton, int giaban)
        {
            this.SanPham_MaSP = masp;
            this.SanPham_TenSP = tensp;
            this.SanPham_SLTon = slton;
            this.SanPham_Giaban = giaban;
        }
    }
}
