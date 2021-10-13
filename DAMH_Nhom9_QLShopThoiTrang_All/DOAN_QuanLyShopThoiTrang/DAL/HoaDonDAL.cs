using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.QLShopThoiTrangTableAdapters;
using System.Data;

namespace DAL
{
    public class HoaDonDAL
    {
        HoaDonTableAdapter hd = new HoaDonTableAdapter();

        public HoaDonDAL() 
        { 
        }
        public DataTable getDataHoaDon()
        {
            return hd.GetDataHD();
        }

        public DataTable getDataHoaDon(DateTime pFrom, DateTime pTo)
        {
            return hd.GetDataHDTheoNgay(pFrom, pTo);
        }

        public DataTable getDataCTHD(string pMaHoaDon)
        {
            return hd.getDataCTHD(pMaHoaDon);
        }
        public bool themHD(string maHD,DateTime ngayLap, int tongTien, int maNV, int maKH)
        {
            try
            {
                hd.Insert(maHD,ngayLap, tongTien, maNV, maKH);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool updateThanhTien(int tongTien, string maHD)
        {
            try
            {
                hd.UpdateTongTien(tongTien, maHD);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
