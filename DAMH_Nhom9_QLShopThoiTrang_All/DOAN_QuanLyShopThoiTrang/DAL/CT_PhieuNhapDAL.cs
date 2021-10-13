using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.QLShopThoiTrangTableAdapters;
using System.Data;

namespace DAL
{
    public class CT_PhieuNhapDAL
    {
        CT_PhieuNhapTableAdapter ctpn = new CT_PhieuNhapTableAdapter();
        CTPNTamTableAdapter tam = new CTPNTamTableAdapter();

        public DataTable loadCTPNbyMaPN(string pMaPN)
        {
            return tam.GetData(pMaPN);
        }
        public bool KTKC(string maPN, int maSP)
        {
            try
            {
                if (ctpn.KTKC(maPN, maSP) > 0)
                {
                    return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable getCTPN(string maPN, int maSP)
        {
            return ctpn.GetDataByCTPN(maPN, maSP);
        }

        public bool suaCTPN(int? soLuong, int? thanhTien, string maPN, int maSP)
        {
            try
            {
                ctpn.UpdateCTPN(soLuong, thanhTien, maPN, maSP);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable getDataCTPN(string maPN)
        {
            return ctpn.GetDataByMaPN(maPN);
        }

        public DataTable getData()
        {
            return ctpn.GetData();
        }

        public int? KTMaPN(string maPN)
        {
            return ctpn.KTMaPN(maPN);
        }

        public bool themCTPN(string maPN, int maSP, int? soLuong, int? dongia, int? thanhTien)
        {
            try
            {
                ctpn.Insert(maPN, maSP, soLuong, dongia, thanhTien);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool xoaCTPN(string maPN, int maSP)
        {
            try
            {
                ctpn.DeleteCTPN(maPN, maSP);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool delete(string maPN)
        {
            try
            {
                ctpn.DeleteQuery(maPN);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
