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
        public static int xoaDuLieu(int ma)
        {
            string query = "exec xoavt @ma";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { ma});
        }
        public static int suaDuLieu(int ma, string ten, string dvd, int soluong)
        {
            string sl = "";
            if(soluong >= 0)
            {
                sl = soluong.ToString();
            }
            string query = "exec suavt @ma , @ten , @dvd , @soluong";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { ma, ten, dvd, sl});
        }
        public static DataTable timKiem(string value)
        {
            string keyword = "%" + value + "%";
            string query = "select * from VatTu where TenVT like @ten or DonVi like @dvd";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { keyword, keyword});
        }
        public static DataTable layThongTin(int ma)
        {
            string query = "select * from VatTu where MaVT = @ma";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { ma});
        }
    }
}
