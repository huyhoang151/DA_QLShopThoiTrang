using DAL.QLShopThoiTrangTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhanVienDAL
    {
        NhanVienTableAdapter daNV = new NhanVienTableAdapter();
        public NhanVienDAL() { }
        public DataTable getDataNhanVien()
        {
            return daNV.GetData();
        }

        public DataTable getDataNhanVien(string tenNV)
        {
            return daNV.SearchNV(tenNV);
        }

        public bool themNV(string hoTenNV, DateTime ngaySinh, string diaChi, DateTime ngayVL, string hinh, int LCB, string sdt, string matKhau, int maBoPhan)
        {
            try
            {
                daNV.Insert(hoTenNV, ngaySinh, diaChi, ngayVL, hinh, LCB, sdt, matKhau, maBoPhan);
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
                daNV.DeleteQuery(pMaNV);
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
                daNV.UpdateQuery(hoTenNV, ngaySinh, diaChi, ngayVL, hinh, LCB, sdt, matKhau, maBoPhan, maNV);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<int> getMaBoPhan(string pSDT)
        {
            List<int> DSMNND = new List<int>();
            DataTable dtkq = daNV.getMaBoPhanBySDT(pSDT);
            for (int i = 0; i < dtkq.Rows.Count; i++)
            {
                DSMNND.Add(int.Parse(dtkq.Rows[i].ItemArray[9].ToString()));
            }
            return DSMNND;
        }

        public DataTable getDataNhanVienBySDT(string sdt)
        {
            return daNV.GetDataByNVTheoSDT(sdt);
        }
    }
}
