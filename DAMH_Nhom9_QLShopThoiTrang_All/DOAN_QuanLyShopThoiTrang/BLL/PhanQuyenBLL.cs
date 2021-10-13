using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhanQuyenBLL
    {
        PhanQuyenDAL pq = new PhanQuyenDAL();
        public DataTable getDataPhanQuyen()
        {
            return pq.getDataPhanQuyen();
        }

        public DataTable getDataPhanQuyen(int pMaBoPhan)
        {
            return pq.getDataPhanQuyen(pMaBoPhan);
        }
        public bool themQuyen(int pMaBoPhan, int pMaManHinh, bool pCoQuyen)
        {
            return pq.themQuyen(pMaBoPhan, pMaManHinh, pCoQuyen);
        }
        public bool capNhapQuyen(bool pCoQuyen, int pMaBoPhan, int pMaManHinh)
        {
            return pq.capNhapQuyen(pCoQuyen,pMaBoPhan,pMaManHinh);
        }
    }
}
