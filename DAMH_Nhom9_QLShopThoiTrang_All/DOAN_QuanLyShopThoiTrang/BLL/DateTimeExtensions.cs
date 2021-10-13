using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class DateTimeExtensions
    {
       public static DataTable GetDateOfWeek(this DateTime date)
        {
            var table = new DataTable();
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("name", typeof(string));
            table.Columns.Add("from", typeof(string));
            table.Columns.Add("to", typeof(string));

            table.Rows.Add(1, "Hôm nay", date.Date.ToString("dd/MM/yyyy"), date.Date.ToString("dd/MM/yyyy"));
            table.Rows.Add(2, "Tháng này", date.ToString("01/MM/yyyy"), date.LastDayOfMonth().ToString("dd/MM/yyyy"));
            table.Rows.Add(3, "Đầu tháng đến hiện tại", date.ToString("01/MM/yyyy"), date.ToString("dd/MM/yyyy"));
            string _quyfrom="", _quyto = "";
            Get_Quarter(date, ref _quyfrom, ref _quyto);
            table.Rows.Add(4, "Quý này", _quyfrom, _quyto);
            table.Rows.Add(5, "Đầu quý đến hiện tại", _quyfrom, date.Date.ToString("dd/MM/yyyy"));
            table.Rows.Add(6, "Năm này", date.ToString("01/01/yyyy"), date.ToString("31/12/yyyy"));
            table.Rows.Add(7, "Đầu năm đến hiện tại", date.ToString("01/01/yyyy"), date.Date.ToString("dd/MM/yyyy"));
            table.Rows.Add(8, "6 tháng đầu năm", date.ToString("01/01/yyyy"), date.ToString("30/06/yyyy"));
            table.Rows.Add(9, "6 tháng cuối năm", date.ToString("01/07/yyyy"), date.ToString("31/12/yyyy"));
            table.Rows.Add(10, "Tháng 1", date.ToString("01/01/yyyy"), date.ToString("31/01/yyyy"));            
            table.Rows.Add(11, "Tháng 2", date.ToString("01/02/yyyy"), Convert.ToDateTime(date.ToString("01/02/yyyy")).LastDayOfMonth().ToString("dd/MM/yyyy"));
            table.Rows.Add(12, "Tháng 3", date.ToString("01/03/yyyy"), date.ToString("31/03/yyyy"));
            table.Rows.Add(13, "Tháng 4", date.ToString("01/04/yyyy"), date.ToString("30/04/yyyy"));
            table.Rows.Add(14, "Tháng 5", date.ToString("01/05/yyyy"), date.ToString("31/05/yyyy"));
            table.Rows.Add(15, "Tháng 6", date.ToString("01/06/yyyy"), date.ToString("30/06/yyyy"));
            table.Rows.Add(16, "Tháng 7", date.ToString("01/07/yyyy"), date.ToString("31/07/yyyy"));
            table.Rows.Add(17, "Tháng 8", date.ToString("01/08/yyyy"), date.ToString("31/08/yyyy"));
            table.Rows.Add(18, "Tháng 9", date.ToString("01/09/yyyy"), date.ToString("30/09/yyyy"));
            table.Rows.Add(19, "Tháng 10", date.ToString("01/10/yyyy"), date.ToString("31/10/yyyy"));
            table.Rows.Add(20, "Tháng 11", date.ToString("01/11/yyyy"), date.ToString("30/11/yyyy"));
            table.Rows.Add(21, "Tháng 12", date.ToString("01/12/yyyy"), date.ToString("31/12/yyyy"));
            table.Rows.Add(22, "Quý 1", date.ToString("01/01/yyyy"), date.ToString("31/03/yyyy"));
            table.Rows.Add(23, "Quý 2", date.ToString("01/04/yyyy"), date.ToString("30/06/yyyy"));
            table.Rows.Add(24, "Quý 3", date.ToString("01/07/yyyy"), date.ToString("30/09/yyyy"));
            table.Rows.Add(25, "Quý 4", date.ToString("01/10/yyyy"), date.ToString("31/12/yyyy"));
            return table;
        }

        public static void Get_Quarter(DateTime date, ref string from, ref string to)
        {
            int quarterNumber = (date.Month - 1) / 3 + 1;
            var firstDayOfQuarter = new DateTime(date.Year, (quarterNumber - 1) * 3 + 1, 1);
            from = new DateTime(date.Year, (quarterNumber - 1) * 3 + 1, 1).ToString("dd/MM/yyyy");
            to = firstDayOfQuarter.AddMonths(3).AddDays(-1).ToString("dd/MM/yyyy");
        }
        public static DateTime FirstDayOfWeek(this DateTime dt)
        {
            var culture = System.Threading.Thread.CurrentThread.CurrentCulture;
            var diff = dt.DayOfWeek - culture.DateTimeFormat.FirstDayOfWeek;
            if (diff < 0)
                diff += 7;
            return dt.AddDays(-diff + 1).Date;
        }

        public static DateTime LastDayOfWeek(this DateTime dt)
        {
            return dt.FirstDayOfWeek().AddDays(6);
        }

        public static DateTime FirstDayOfMonth(this DateTime dt)
        {
            return new DateTime(dt.Year, dt.Month, 1);
        }

        public static DateTime LastDayOfMonth(this DateTime dt)
        {
            return dt.FirstDayOfMonth().AddMonths(1).AddDays(-1);
        }

        public static DateTime FirstDayOfNextMonth(this DateTime dt)
        {
            return dt.FirstDayOfMonth().AddMonths(1);
        }
    }
    
    
}
