using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HoaDonBan
    {
        private string _HDB_MaHDB;
        private string _HDB_MaNV;
        private string _HDB_TenKH;
        private string _HDB_SdtKH;
        private DateTime _HDB_NgayBan;

        public string HDB_MaHDB { get => _HDB_MaHDB; set => _HDB_MaHDB = value; }
        public string HDB_MaNV { get => _HDB_MaNV; set => _HDB_MaNV = value; }
        public string HDB_TenKH { get => _HDB_TenKH; set => _HDB_TenKH = value; }
        public string HDB_SdtKH { get => _HDB_SdtKH; set => _HDB_SdtKH = value; }
        public DateTime HDB_NgayBan { get => _HDB_NgayBan; set => _HDB_NgayBan = value; }

        public DTO_HoaDonBan()
        {

        }
        public DTO_HoaDonBan(string mahdb, string manv, string tenkh, string sdtkh, DateTime ngayban)
        {
            this.HDB_MaHDB = mahdb;
            this.HDB_MaNV = manv;
            this.HDB_TenKH = tenkh;
            this.HDB_SdtKH = sdtkh;
            this.HDB_NgayBan = ngayban;
        }
    }
}
