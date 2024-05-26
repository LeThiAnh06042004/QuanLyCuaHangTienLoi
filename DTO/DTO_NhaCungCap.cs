using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhaCungCap
    {
        private string _NCC_MaNCC;
        private string _NCC_TenNCC;
        private string _NCC_DiaChi;
        private string _NCC_SdtNCC;

        public string NCC_MaNCC { get => _NCC_MaNCC; set => _NCC_MaNCC = value; }
        public string NCC_TenNCC { get => _NCC_TenNCC; set => _NCC_TenNCC = value; }
        public string NCC_DiaChi { get => _NCC_DiaChi; set => _NCC_DiaChi = value; }
        public string NCC_SdtNCC { get => _NCC_SdtNCC; set => _NCC_SdtNCC = value; }

        public DTO_NhaCungCap()
        {

        }

        public DTO_NhaCungCap(string mancc, string tenncc, string diachi, string sdtncc)
        {
            this.NCC_MaNCC = mancc;
            this.NCC_TenNCC = tenncc;
            this.NCC_DiaChi = diachi;
            this.NCC_SdtNCC = sdtncc;
        }
    }
}
