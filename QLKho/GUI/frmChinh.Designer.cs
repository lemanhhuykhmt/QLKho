namespace QLKho.GUI
{
    partial class frmChinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPhieuMuon = new System.Windows.Forms.Button();
            this.btnNCC = new System.Windows.Forms.Button();
            this.btnVatTu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNoiDung = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPhieuMuon);
            this.groupBox1.Controls.Add(this.btnNCC);
            this.groupBox1.Controls.Add(this.btnVatTu);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 635);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa Chọn";
            // 
            // btnPhieuMuon
            // 
            this.btnPhieuMuon.Location = new System.Drawing.Point(3, 139);
            this.btnPhieuMuon.Name = "btnPhieuMuon";
            this.btnPhieuMuon.Size = new System.Drawing.Size(197, 43);
            this.btnPhieuMuon.TabIndex = 2;
            this.btnPhieuMuon.Text = "Phiếu Mượn";
            this.btnPhieuMuon.UseVisualStyleBackColor = true;
            // 
            // btnNCC
            // 
            this.btnNCC.Location = new System.Drawing.Point(3, 90);
            this.btnNCC.Name = "btnNCC";
            this.btnNCC.Size = new System.Drawing.Size(197, 43);
            this.btnNCC.TabIndex = 0;
            this.btnNCC.Text = "Sách";
            this.btnNCC.UseVisualStyleBackColor = true;
            this.btnNCC.Click += new System.EventHandler(this.btnNCC_Click);
            // 
            // btnVatTu
            // 
            this.btnVatTu.Location = new System.Drawing.Point(3, 41);
            this.btnVatTu.Name = "btnVatTu";
            this.btnVatTu.Size = new System.Drawing.Size(197, 43);
            this.btnVatTu.TabIndex = 0;
            this.btnVatTu.Text = "Độc Giả";
            this.btnVatTu.UseVisualStyleBackColor = true;
            this.btnVatTu.Click += new System.EventHandler(this.btnVatTu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 635);
            this.panel1.TabIndex = 3;
            // 
            // pnlNoiDung
            // 
            this.pnlNoiDung.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlNoiDung.Location = new System.Drawing.Point(209, 0);
            this.pnlNoiDung.Name = "pnlNoiDung";
            this.pnlNoiDung.Size = new System.Drawing.Size(938, 635);
            this.pnlNoiDung.TabIndex = 4;
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 635);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlNoiDung);
            this.Name = "frmChinh";
            this.Text = "frmChinh";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPhieuMuon;
        private System.Windows.Forms.Button btnNCC;
        private System.Windows.Forms.Button btnVatTu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlNoiDung;
    }
}