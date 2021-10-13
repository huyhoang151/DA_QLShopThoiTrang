using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class CT_PhieuNhapBLL
    {
        CT_PhieuNhapDAL ctpn = new CT_PhieuNhapDAL();

        public DataTable loadCTPNbyMaPN(string pMaPN)
        {
            return ctpn.loadCTPNbyMaPN(pMaPN);
        }
        public bool KTTC(string maPN, int maSP)
        {
            return ctpn.KTKC(maPN, maSP);
        }

        public DataTable getCTPN(string maPN, int maSP)
        {
            return ctpn.getCTPN(maPN, maSP);
        }

        public bool suaCTPN(int? soLuong, int? thanhTien, string maPN, int maSP)
        {
            return ctpn.suaCTPN(soLuong, thanhTien, maPN, maSP);

        }

        public DataTable getDataCTPN(string maPN)
        {
            return ctpn.getDataCTPN(maPN);
        }

        public DataTable getData()
        {
            return ctpn.getData();
        }

        public int? KTMaPN(string maPN)
        {
            return ctpn.KTMaPN(maPN);
        }

        public bool themCTPN(string maHD, int maSP, int? soLuong, int? dongia, int? thanhTien)
        {
            return ctpn.themCTPN(maHD, maSP, soLuong, dongia, thanhTien);

        }

        public bool xoaCTPN(string maPN, int maSP)
        {
            return ctpn.xoaCTPN(maPN, maSP);
        }

        public bool delete(string maPN)
        {
            return ctpn.delete(maPN);
        }
    }
}
