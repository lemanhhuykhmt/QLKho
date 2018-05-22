using QLKho.GUI.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKho.GUI
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void btnVatTu_Click(object sender, EventArgs e)
        {
            pnlNoiDung.Controls.Clear();
            ucVatTu frm = new ucVatTu();
            frm.Size = new Size(pnlNoiDung.Width, pnlNoiDung.Height);
            frm.Visible = true;
            pnlNoiDung.Controls.Add(frm);
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            pnlNoiDung.Controls.Clear();
            ucNhaCungCap frm = new ucNhaCungCap();
            frm.Size = new Size(pnlNoiDung.Width, pnlNoiDung.Height);
            frm.Visible = true;
            pnlNoiDung.Controls.Add(frm);
        }
    }
}
