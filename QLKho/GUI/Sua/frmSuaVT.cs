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
    public partial class frmSuaVT : Form
    {
        private int MaVT;
        public frmSuaVT()
        {
            InitializeComponent();
        }
        public frmSuaVT(int mavt)
        {
            MaVT = mavt;
            InitializeComponent();
            loadDuLieu();
        }
        private void loadDuLieu()
        {
            DataTable dt = VatTuControl.layThongTin(MaVT);
            txtTenCu.Text = dt.Rows[0]["TenVT"].ToString();
            txtDVDCu.Text = dt.Rows[0]["DonVi"].ToString();
            txtSoLuongCu.Text = dt.Rows[0]["SoLuong"].ToString();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string ten = txtTenMoi.Text;
            string donvi = txtDVDMoi.Text;
            int soluong = 0;
            if(txtSoLuongMoi.Text.Length > 0)
            {
                soluong = Convert.ToInt32(txtSoLuongMoi.Text);
            }
            int ketqua = VatTuControl.suaDuLieu(MaVT, ten, donvi, soluong);
            if(ketqua > 0)
            {
                this.Close();
            }
        }
    }
}
