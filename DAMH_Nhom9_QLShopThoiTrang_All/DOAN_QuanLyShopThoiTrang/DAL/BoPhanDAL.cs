using DAL.QLShopThoiTrangTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BoPhanDAL
    {
        BoPhanTableAdapter daBP = new BoPhanTableAdapter();

        public DataTable getCBBBoPhan()
        {
            return daBP.GetData();
        }
        public DataTable getMaBoPhan()
        {
            return daBP.getMaBP();
        }
    }
}
