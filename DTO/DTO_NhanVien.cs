using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{

    public class DTO_NhanVien
    {
        private string _NhanVien_MaNV;
        private string _NhanVien_TenNV;
        private string _NhanVien_NgaySinh;
        private string _NhanVien_GioiTinh;
        private string _NhanVien_QueQuan;
        private string _NhanVien_SDT;
        private string _NhanVien_TaiKhoan;
        private string _NhanVien_MatKhau;

        public string NhanVien_MaNV { get => _NhanVien_MaNV; set => _NhanVien_MaNV = value; }
        public string NhanVien_TenNV { get => _NhanVien_TenNV; set => _NhanVien_TenNV = value; }
        public string NhanVien_NgaySinh { get => _NhanVien_NgaySinh; set => _NhanVien_NgaySinh = value; }
        public string NhanVien_GioiTinh { get => _NhanVien_GioiTinh; set => _NhanVien_GioiTinh = value; }
        public string NhanVien_QueQuan { get => _NhanVien_QueQuan; set => _NhanVien_QueQuan = value; }
        public string NhanVien_SDT { get => _NhanVien_SDT; set => _NhanVien_SDT = value; }
        public string NhanVien_TaiKhoan { get => _NhanVien_TaiKhoan; set => _NhanVien_TaiKhoan = value; }
        public string NhanVien_MatKhau { get => _NhanVien_MatKhau; set => _NhanVien_MatKhau = value; }
        public DTO_NhanVien()
        {

        }

        public DTO_NhanVien(string manv, string tennv, string ngaysinh, string gioitinh, string quequan, string sdt, string taikhoan, string matkhau)
        {
            this.NhanVien_MaNV = manv;
            this.NhanVien_TenNV = tennv;
            this.NhanVien_NgaySinh = ngaysinh;
            this.NhanVien_GioiTinh = gioitinh;
            this.NhanVien_QueQuan = quequan;
            this.NhanVien_SDT = sdt;
            this.NhanVien_TaiKhoan = taikhoan;
            this.NhanVien_MatKhau = matkhau;
        }
    }
}
