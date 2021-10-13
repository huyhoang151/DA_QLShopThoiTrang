using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class HoaDonBLL
    {
        HoaDonDAL hd = new HoaDonDAL();
        public HoaDonBLL() { }
        public DataTable getDataHoaDon()
        {
            return hd.getDataHoaDon();
        }

        public DataTable getDataHoaDon(DateTime pFrom, DateTime pTo)
        {
            return hd.getDataHoaDon(pFrom, pTo);
        }

        public DataTable getDataCTHD(string pMaHD)
        {
            return hd.getDataCTHD(pMaHD);
        }
        public bool themHD(string maHD,DateTime ngayLap, int tongTien, int maNV, int maKH)
        {
            return hd.themHD(maHD, ngayLap, tongTien, maNV, maKH);
        }
        public bool updateThanhTien(int tongTien, string maHD)
        {
            return hd.updateThanhTien(tongTien, maHD);
        }
    }
}
