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
using QLKho.GUI.Them;
using QLKho.GUI.Sua;

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
            dgvDanhSach.Rows.Clear();
            DataTable dt = VatTuControl.layDanhSach();

            for(int i = 0; i < dt.Rows.Count; ++i)
            {
                dgvDanhSach.Rows.Add(dt.Rows[i]["MaVT"], dt.Rows[i]["TenVT"], dt.Rows[i]["DonVi"], dt.Rows[i]["SoLuong"]);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemVT frm = new frmThemVT();
            frm.ShowDialog();
            loadDuLieu();
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int maVT = Convert.ToInt32(dgvDanhSach.Rows[e.RowIndex].Cells["colMa"].Value.ToString());
            if(e.ColumnIndex == dgvDanhSach.Columns["colSua"].Index)
            {
                frmSuaVT frm = new frmSuaVT(maVT);
                frm.ShowDialog();
                loadDuLieu();
            }
            else if(e.ColumnIndex == dgvDanhSach.Columns["colXoa"].Index)
            {
                int ketqua = VatTuControl.xoaDuLieu(maVT);
                if(ketqua > 0)
                {
                    loadDuLieu();
                }
            }
        }

        private void timKiem()
        {
            string value = txtTimKiem.Text;
            if (value.Length == 0)
            {
                loadDuLieu();
                return;
            }
            dgvDanhSach.Rows.Clear();
            DataTable dt = VatTuControl.timKiem(value);
            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                dgvDanhSach.Rows.Add(dt.Rows[i]["MaVT"], dt.Rows[i]["TenVT"], dt.Rows[i]["DonVi"], dt.Rows[i]["SoLuong"]);
            }
        }
        private void txtTimKiem_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                timKiem();
            }
            else if (e.KeyValue == 27)
            {
                txtTimKiem.Text = "";
            }
        }
    }
}
