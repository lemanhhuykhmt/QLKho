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
    public partial class frmThemVT : Form
    {
        public frmThemVT()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text;
            string dvd = txtDVD.Text;
            int sl = Convert.ToInt32(txtSoLuong.Text);
            if(kiemTraDuLieu(ten, dvd, sl))
            {
                int ketqua = VatTuControl.themDuLieu(ten, dvd, sl);
                if(ketqua > 0)
                {
                    this.Close();
                }
            }
        }
        private bool kiemTraDuLieu(string ten, string dvd, int sl)
        {
            return true;
        }
    }
}
