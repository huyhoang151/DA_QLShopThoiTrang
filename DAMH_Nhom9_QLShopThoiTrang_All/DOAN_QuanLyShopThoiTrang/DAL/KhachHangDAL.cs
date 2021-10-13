using DAL.QLShopThoiTrangTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhachHangDAL
    {
        KhachHangTableAdapter daKh = new KhachHangTableAdapter();

        public DataTable getDGVKhachHang()
        {
            return daKh.GetData();
        }

        public DataTable getKhachHang()
        {
            return daKh.GetData();
        }

        public DataTable getKhachHangMaKH(int maKH)
        {
            return daKh.GetDataByMaKH(maKH);
        }

        public DataTable getKhachHangTenKH(string tenKH)
        {
            return daKh.GetDataBy1(tenKH);
        }

        public bool themKH(string hoTenKH)
        {
            try
            {
                daKh.ThemKH(hoTenKH);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool themKhachHang(string hoTen, string sdt, string diaChi)
        {
            try
            {
                daKh.Insert(hoTen, sdt, diaChi);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool xoaKhachHang(int pMaKH)
        {
            try
            {
                daKh.DeleteQuery(pMaKH);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool suaKhachHang(string tenKH, string diachi, string sdt, int makh)
        {
            try
            {
                daKh.UpdateQuery(tenKH, diachi, sdt, makh);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable getDataKhachHangSearch(string tenkh)
        {
            return daKh.SearchKH(tenkh);
        }

    }
}
