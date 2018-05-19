using QLKho.Extend;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKho.Control
{
    class VatTuControl
    {
        public static DataTable layDanhSach()
        {
            string query = "select * from VatTu";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public static int themDuLieu(string ten, string dvd, int soluong)
        {
            string query = "exec themvt @ten , @dvd , @soluong";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { ten, dvd, soluong});
        }
    }
}
