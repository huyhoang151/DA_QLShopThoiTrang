using DAL.QLShopThoiTrangTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhaCungCapDAL
    {
        NhaCungCapTableAdapter ncc = new NhaCungCapTableAdapter();

        public DataTable getData()
        {
            return ncc.GetData();
        }

        public DataTable getDataByMaNCC(int mancc)
        {
            return ncc.GetDataByMaNCC(mancc);
        }
    }
}
