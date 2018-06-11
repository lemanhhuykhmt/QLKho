
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKho.Control
{
    class CuaHangControl
    {
        public static DataTable layDanhSach()
        {
            string query = "select * from CuaHang";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public static int themDuLieu(string ten, string diachi, string sdt)
        {
            string query = "exec themch @ten , @diachi , @sdt";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { ten, diachi, sdt });
        }
        public static int xoaDuLieu(int ma)
        {
            string query = "exec xoach @ma";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { ma });
        }
        public static int suaDuLieu(int ma, string ten, string diachi, string sdt)
        {
            string query = "exec suach @ma , @ten , @diachi , @sdt";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { ma, ten, diachi, sdt });
        }
        public static DataTable timKiem(string value)
        {
            string keyword = "%" + value + "%";
            string query = "select * from CuaHang where TenCH like @ten or DiaChi like @diachi or SDT like @sdt";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { keyword, keyword, keyword });
        }
        public static DataTable layThongTin(int ma)
        {
            string query = "select * from CuaHang where MaCH = @ma";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { ma });
        }
    }
}
