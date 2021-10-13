using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class KhachHangBLL
    {
        KhachHangDAL kh = new KhachHangDAL();

        public DataTable getDGVKhachHang()
        {
            return kh.getDGVKhachHang();
        }

        public DataTable loadKhachHang()
        {
            return kh.getKhachHang();
        }

        public DataTable getKhachHangMaKH(int maKH)
        {
            return kh.getKhachHangMaKH(maKH);
        }

        public DataTable getKhachHangTenKH(string tenKH)
        {
            return kh.getKhachHangTenKH(tenKH);
        }

        public bool themKH(string hoTenKH)
        {
            return kh.themKH(hoTenKH);
        }

        public bool themKhachHang(string hoTen, string sdt, string diaChi)
        {
            return kh.themKhachHang(hoTen, sdt, diaChi);
        }

        public bool xoaKhachHang(int pMaKH)
        {
            return kh.xoaKhachHang(pMaKH);
        }

        public bool suaKhachHang(string tenKH, string sdt, string diachi, int makh)
        {
            return kh.suaKhachHang(tenKH, sdt, diachi, makh);
        }

        public DataTable getDataKhachHangSearch(string tenKH)
        {
            return kh.getDataKhachHangSearch(tenKH);
        }
    }
}
