using DAL.QLShopThoiTrangTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoaiDAL
    {
        LoaiSanPhamTableAdapter loai = new LoaiSanPhamTableAdapter();

        public DataTable getLoaiSP()
        {
            return loai.GetData();
        }
    }
}
