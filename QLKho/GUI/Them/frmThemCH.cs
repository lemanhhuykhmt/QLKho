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

namespace QLKho.GUI.Them
{
    public partial class frmThemCH : Form
    {
        public frmThemCH()
        {
            InitializeComponent();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text;
            string diachi = txtDiaChi.Text;
            string sdt = txtSDT.Text;
            if (kiemTraDuLieu(ten, diachi, sdt))
            {
                int ketqua = CuaHangControl.themDuLieu(ten, diachi, sdt);
                if (ketqua > 0)
                {
                    this.Close();
                }
            }
        }
        private bool kiemTraDuLieu(string ten, string dvd, string sdt)
        {
            return true;
        }
    }
}
