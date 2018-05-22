using QLKho.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKho.GUI.Sua
{
    public partial class frmSuaCH : Form
    {
        private int MaCH;
        public frmSuaCH()
        {
            InitializeComponent();
        }
        public frmSuaCH(int ma)
        {
            MaCH = ma;
            InitializeComponent();
            loadDuLieu();
        }
        private void loadDuLieu()
        {
            DataTable dt = CuaHangControl.layThongTin(MaCH);
            txtTenCu.Text = dt.Rows[0]["TenCH"].ToString();
            txtDiaChiCu.Text = dt.Rows[0]["DiaChi"].ToString();
            txtSDTCu.Text = dt.Rows[0]["SDT"].ToString();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string ten = txtTenMoi.Text;
            string diachi = txtDiaChiMoi.Text;
            string sdt = txtSDTMoi.Text;
            int ketqua = CuaHangControl.suaDuLieu(MaCH, ten, diachi, sdt);
            if (ketqua > 0)
            {
                this.Close();
            }
        }
    }
}
