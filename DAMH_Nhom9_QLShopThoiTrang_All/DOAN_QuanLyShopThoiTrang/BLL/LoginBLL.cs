using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class LoginBLL
    {
        LoginDAL nv = new LoginDAL();
        public LoginBLL() { }

        public DataTable getDataDangNhap(string pSDT, string pMatKhau)
        {
            return nv.getDataDangNhap(pSDT, pMatKhau);
        }

        public DataTable getDGVNhanVien()
        {
            return nv.getDGVNhanVien();
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
    }
}
