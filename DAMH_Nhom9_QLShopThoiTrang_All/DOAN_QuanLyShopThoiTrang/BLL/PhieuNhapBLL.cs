using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class PhieuNhapBLL
    {
        PhieuNhapDAL pn = new PhieuNhapDAL();

        public DataTable getDataPN()
        {
            return pn.getDataPN();
        }

        public DataTable getDataPN(string pMaPN)
        {
            return pn.getDataPN(pMaPN);
        }
        public DataTable getDataPN(DateTime pFrom, DateTime pTo)
        {
            return pn.getDataPN(pFrom, pTo);
        }
        public bool themPN(string maPN, DateTime ngaynhap, int ncc,int maNV, int tongTien)
        {
            return pn.themPN(maPN, ngaynhap, ncc,maNV, tongTien);
        }

        public bool updateTongTien(int tongTien, string maPN)
        {
            return pn.updateTongTien(tongTien, maPN);
        }
    }
}
