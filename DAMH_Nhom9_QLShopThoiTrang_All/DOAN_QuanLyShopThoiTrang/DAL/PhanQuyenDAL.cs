using DAL.QLShopThoiTrangTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhanQuyenDAL
    {
        PhanQuyenTableAdapter daPQ = new PhanQuyenTableAdapter();
        PhanQuyen1TableAdapter pq = new PhanQuyen1TableAdapter();
        public PhanQuyenDAL()
        { }
        public DataTable getDataPhanQuyen()
        {
            return daPQ.GetData();
        }

        public DataTable getDataPhanQuyen(int pMaBoPhan)
        {
            return daPQ.GetDataBy(pMaBoPhan);
        }

        public bool themQuyen(int pMaBoPhan, int pMaManHinh, bool? pCoQuyen)
        {
            try
            {
                pq.InsertQuery(pMaBoPhan, pMaManHinh, pCoQuyen);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool capNhapQuyen(bool pCoQuyen, int pMaBoPhan, int pMaManHinh)
        {
            try
            {
                pq.UpdateQuery(pCoQuyen, pMaBoPhan, pMaManHinh);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
