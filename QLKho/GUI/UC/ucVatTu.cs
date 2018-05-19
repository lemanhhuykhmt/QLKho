using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKho.Control;

namespace QLKho.GUI.UC
{
    public partial class ucVatTu : UserControl
    {
        public ucVatTu()
        {
            InitializeComponent();
            loadDuLieu();
        }
        private void loadDuLieu()
        {
            DataTable dt = VatTuControl.layDanhSach();

            for(int i = 0; i < dt.Rows.Count; ++i)
            {
                dgvDanhSach.Rows.Add(dt.Rows[i]["MaVT"], dt.Rows[i]["TenVT"], dt.Rows[i]["DonVi"], dt.Rows[i]["SoLuong"]);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
