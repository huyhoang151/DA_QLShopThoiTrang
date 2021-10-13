using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class SanPhamBLL
    {
        SanPhamDAL sp = new SanPhamDAL();
        public SanPhamBLL()
        { }

        public DataTable LoadSP()
        {
            return sp.getDataSanPham();
        }

        public DataTable LoadDSSP()
        {
            return sp.getDataDSSP();
        }

        public DataTable getDataSPByMaSP(int maSP)
        {
            return sp.getDataSPByMaSP(maSP);
        }

        public bool updateSP(int slt, int maSP)
        {
            return sp.updateSP(slt, maSP);
              
        }

        public DataTable TimKiemTheoMaSP(int maSP)
        {
            return sp.TimKiemTheoMaSP(maSP);
        }

        public DataTable TimKiemTheoTenSP(string tenSP)
        {
            return sp.TimKiemTheoTenSP(tenSP);
        }

        public bool themSP(string tenSP, string hinhAnh, string moTa, int SLT, int maLoai, int maDonGia)
        {
            return sp.themSP(tenSP, hinhAnh, moTa, SLT, maLoai, maDonGia);
        }

        public bool xoaSP(int pMaSP)
        {
            return sp.xoaSP(pMaSP);
        }

        public bool suaSP(string tenSP, string hinhAnh, string moTa, int SLT, int maLoai, int maDonGia, int maSanPham)
        {
            return sp.suaSP(tenSP, hinhAnh, moTa, SLT, maLoai, maDonGia, maSanPham);
        }
    }
}
