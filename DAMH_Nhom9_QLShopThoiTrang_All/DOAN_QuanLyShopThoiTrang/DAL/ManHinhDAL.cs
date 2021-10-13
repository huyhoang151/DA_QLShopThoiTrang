using DAL.QLShopThoiTrangTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ManHinhDAL
    {
        public ManHinhDAL()
        { }
        ManHinhTableAdapter mh = new ManHinhTableAdapter();

        public DataTable getDataMH()
        {
            return mh.GetData();
        }
    }
}
