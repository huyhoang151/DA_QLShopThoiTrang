using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.QLShopThoiTrangTableAdapters;
using System.Data;

namespace DAL
{
    public class PhieuNhapDAL
    {
        PhieuNhapTableAdapter pn = new PhieuNhapTableAdapter();

        public DataTable getDataPN()
        {
            return pn.GetDataPN();
        }

        public DataTable getDataPN(string pMaPN)
        {
            return pn.GetDataPNByMaPN(pMaPN);
        }

        public DataTable getDataPN(DateTime pFrom, DateTime pTo)
        {
            return pn.GetDataPNbyDate(pFrom, pTo);
        }
        public bool themPN(string maPN,DateTime ngaynhap,int ncc, int maNV,int tongTien)
        {
            try
            {
                pn.Insert(maPN,ngaynhap,ncc,maNV,tongTien);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool updateTongTien(int tongTien, string maPN)
        {
            try
            {
                pn.UpdateTongTien(tongTien, maPN);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
