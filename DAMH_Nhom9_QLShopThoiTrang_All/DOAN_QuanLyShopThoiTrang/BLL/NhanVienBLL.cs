using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BLL
{
    public class NhanVienBLL
    {
        NhanVienDAL nv = new NhanVienDAL();
        public NhanVienBLL()
        { }

        public DataTable SearchNV(string tenNV)
        {
            return nv.getDataNhanVien(tenNV);
        }
        public DataTable LoadNV()
        {
            return nv.getDataNhanVien();
        }

        public bool themNV(string hoTenNV, DateTime ngaySinh, string diaChi, DateTime ngayVL, string hinh, int LCB, string sdt, string matKhau, int maBoPhan)
        {
            return nv.themNV(hoTenNV, ngaySinh, diaChi, ngayVL, hinh, LCB, sdt, matKhau, maBoPhan);
        }

        public bool xoaNV(int pMaNV)
        {
            return nv.xoaNV(pMaNV);
        }

        public bool suaNV(string hoTenNV, string ngaySinh, string diaChi, string ngayVL, string hinh, int LCB, string sdt, string matKhau, int maBoPhan, int maNV)
        {
            return nv.suaNV(hoTenNV, ngaySinh, diaChi, ngayVL, hinh, LCB, sdt, matKhau, maBoPhan, maNV);
        }

        public List<int> getMaBoPhan(string pSDT)
        {
            return nv.getMaBoPhan(pSDT);
        }

        public DataTable getDataNhanVienBySDT(string sdt)
        {
            return nv.getDataNhanVienBySDT(sdt);
        }
    }
}
