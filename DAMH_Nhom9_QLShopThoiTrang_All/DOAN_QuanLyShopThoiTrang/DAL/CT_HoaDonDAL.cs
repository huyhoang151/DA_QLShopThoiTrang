using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.QLShopThoiTrangTableAdapters;
using System.Data;

namespace DAL
{
    public class CT_HoaDonDAL
    {
        CT_HoaDonTableAdapter cthd = new CT_HoaDonTableAdapter();
        CTHDTamTableAdapter tam = new CTHDTamTableAdapter();

        public DataTable loadCTHDbyMaHD(string pMaHD)
        {
            return tam.GetData(pMaHD);
        }
        public bool KTKC(string MaHD, int MaSP)
        {
            try
            {
                if (cthd.KTKC(MaHD,MaSP)>0)
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

        public int? KTMaHD(string maHD)
        {
            return cthd.KTMaHD(maHD);
        }

        public bool themCTHD(string maHD, int maSP, int? soLuong,  int? thanhTien)
        {
            try
            {
                cthd.Insert(maHD, maSP, soLuong, thanhTien);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool xoaCTHD(string maHD)
        {
            try
            {
                cthd.DeleteCTHD(maHD);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable getDataCTHD(string maHD)
        {
            return cthd.GetDataByMaHD(maHD);
        }

        public DataTable getCTHD(string maHD,int maSP)
        {
            return cthd.GetDataByCTHD(maHD,maSP);
        }

        public bool deleteCTHD(string maHD, int maSP)
        {
            try
            {
                cthd.DeleteQuery(maHD,maSP);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool suaCTHD(int? soLuong, int? thanhTien,string maHD, int maSP)
        {
            try
            {
                cthd.UpdateCTHD(soLuong, thanhTien,maHD, maSP);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
