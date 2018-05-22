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
    public partial class ucNhaCungCap : UserControl
    {
        public ucNhaCungCap()
        {
            InitializeComponent();
            loadDuLieu();
        }
        private void loadDuLieu()
        {
            dgvDanhSach.Rows.Clear();
            DataTable dt = NhaCungCapControl.layDanhSach();

            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                dgvDanhSach.Rows.Add(dt.Rows[i]["MaNCC"], dt.Rows[i]["TenNCC"], dt.Rows[i]["DiaChi"], dt.Rows[i]["SDT"]);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemNCC frm = new frmThemNCC();
            frm.ShowDialog();
            loadDuLieu();
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int ma = Convert.ToInt32(dgvDanhSach.Rows[e.RowIndex].Cells["colMa"].Value.ToString());
            if (e.ColumnIndex == dgvDanhSach.Columns["colSua"].Index)
            {
                frmSuaNCC frm = new frmSuaNCC(ma);
                frm.ShowDialog();
                loadDuLieu();
            }
            else if (e.ColumnIndex == dgvDanhSach.Columns["colXoa"].Index)
            {
                int ketqua = NhaCungCapControl.xoaDuLieu(ma);
                if (ketqua > 0)
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
            DataTable dt = NhaCungCapControl.timKiem(value);
            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                dgvDanhSach.Rows.Add(dt.Rows[i]["MaNCC"], dt.Rows[i]["TenNCC"], dt.Rows[i]["DiaChi"], dt.Rows[i]["SDT"]);
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
                loadDuLieu();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadDuLieu();
        }
    }
}
