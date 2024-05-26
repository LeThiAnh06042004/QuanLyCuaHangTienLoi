using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DTO_ChiTietHDB
   {
        private string _CTHDB_MaHDB;
        private string _CTHDB_MaSP;
        private string _CTHDB_TenSP;
        private int _CTHDB_SL;
        private int _CTHDB_GiaBan;

        public string CTHDB_MaHDB { get => _CTHDB_MaHDB; set => _CTHDB_MaHDB = value; }
        public string CTHDB_MaSP { get => _CTHDB_MaSP; set => _CTHDB_MaSP = value; }
        public string CTHDB_TenSP { get => _CTHDB_TenSP; set => _CTHDB_TenSP = value; }
        public int CTHDB_SL { get => _CTHDB_SL; set => _CTHDB_SL = value; }
        public int CTHDB_GiaBan { get => _CTHDB_GiaBan; set => _CTHDB_GiaBan = value; }


        public DTO_ChiTietHDB()
        {

        }
        public DTO_ChiTietHDB(string mahdb, string masp, string tensp, int sl, int giaban)
        {
            this.CTHDB_MaHDB = mahdb;
            this.CTHDB_MaSP = masp;
            this.CTHDB_TenSP = tensp;
            this.CTHDB_SL = sl;
            this.CTHDB_GiaBan = giaban;
        }
    }
}
