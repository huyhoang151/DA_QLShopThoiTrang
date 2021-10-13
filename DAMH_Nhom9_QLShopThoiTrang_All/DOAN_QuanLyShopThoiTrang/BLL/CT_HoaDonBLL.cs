using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class CT_HoaDonBLL
    {
        CT_HoaDonDAL cthd = new CT_HoaDonDAL();
        public DataTable loadCTHDbyMaHD(string pMaHD)
        {
            return cthd.loadCTHDbyMaHD(pMaHD);
        }
        public bool KTTC(string MaHD,int MaSP){
            return cthd.KTKC(MaHD, MaSP);
        }

        public int? KTMaHD(string maHD)
        {
            return cthd.KTMaHD(maHD);
        }

        public bool themCTHD(string maHD, int maSP, int? soLuong, int? thanhTien)
        {
            return cthd.themCTHD(maHD, maSP, soLuong, thanhTien);
           
        }

        public DataTable getDataCTHD(string maHD)
        {
            return cthd.getDataCTHD(maHD);
        }

        public bool xoaCTHD(string maHD)
        {
            return cthd.xoaCTHD(maHD);
        }

        public DataTable getCTHD(string maHD, int maSP)
        {
            return cthd.getCTHD(maHD, maSP);
        }

        public bool deleteCTHD(string maHD, int maSP)
        {
            return cthd.deleteCTHD(maHD, maSP);
        }

        public bool suaCTHD(int? soLuong, int? thanhTien, string maHD, int maSP)
        {
            return cthd.suaCTHD(soLuong, thanhTien, maHD, maSP);
        }
    }
}
