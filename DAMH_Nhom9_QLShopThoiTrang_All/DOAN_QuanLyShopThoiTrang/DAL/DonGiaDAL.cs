using DAL.QLShopThoiTrangTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DonGiaDAL
    {
        DonGiaTableAdapter dg = new DonGiaTableAdapter();
        public DataTable getDonGia()
        {
            return dg.GetData();
        }
    }
}
