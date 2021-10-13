using DAL.QLShopThoiTrangTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SanPhamDAL
    {
        SanPhamTableAdapter daSP = new SanPhamTableAdapter();

        public SanPhamDAL() { }

        public DataTable getDataSanPham()
        {
            return daSP.GetData();
        }

        public DataTable getDataDSSP()
        {
            return daSP.GetDataBySanPham();
        }

        public DataTable getDataSPByMaSP(int maSP)
        {
            return daSP.GetDataByMaSP(maSP);
        }

        public bool updateSP(int slt, int maSP)
        {
            try
            {
                daSP.UpdateSLT(slt,maSP);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public DataTable TimKiemTheoMaSP(int maSP)
        {
            return daSP.TimKiemTheoMaSP(maSP);
        }

        public DataTable TimKiemTheoTenSP(string tenSP)
        {
            return daSP.TimKiemTheoTenSP(tenSP);
        }

        public bool themSP(string tenSP, string hinhAnh, string moTa, int SLT, int maLoai, int maDonGia)
        {
            try
            {
                daSP.Insert(tenSP, hinhAnh, moTa, SLT, maLoai, maDonGia);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool xoaSP(int pMaSP)
        {
            try
            {
                daSP.DeleteQuery(pMaSP);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool suaSP(string tenSP, string hinhAnh, string moTa, int SLT, int maLoai, int maDonGia, int maSanPham)
        {
            try
            {
                daSP.UpdateQuery(tenSP, hinhAnh, moTa, SLT, maLoai, maDonGia, maSanPham);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
