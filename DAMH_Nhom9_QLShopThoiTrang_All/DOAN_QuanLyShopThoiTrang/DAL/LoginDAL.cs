using DAL.QLShopThoiTrangTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoginDAL
    {
        NhanVienTableAdapter daNv = new NhanVienTableAdapter();
        public LoginDAL() { }

        public DataTable getDataDangNhap(string pSDT, string pMatKhau)
        {
            return daNv.GetDataByDangNhap(pSDT, pMatKhau);
        }

        public DataTable getDGVNhanVien()
        {
            return daNv.GetData();
        }

        public bool themNV(string hoTenNV, DateTime ngaySinh, string diaChi, DateTime ngayVL, string hinh, int LCB, string sdt, string matKhau, int maBoPhan)
        {
            try
            {
                daNv.Insert(hoTenNV, ngaySinh, diaChi, ngayVL, hinh, LCB, sdt, matKhau, maBoPhan);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool xoaNV(int pMaNV)
        {
            try
            {
                daNv.DeleteQuery(pMaNV);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool suaNV(string hoTenNV, string ngaySinh, string diaChi, string ngayVL, string hinh, int LCB, string sdt, string matKhau, int maBoPhan, int maNV)
        {
            try
            {
                daNv.UpdateQuery(hoTenNV, ngaySinh, diaChi, ngayVL, hinh, LCB, sdt, matKhau, maBoPhan, maNV);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
