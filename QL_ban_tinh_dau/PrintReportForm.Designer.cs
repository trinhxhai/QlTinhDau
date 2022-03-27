
namespace QL_ban_tinh_dau
{
    partial class PrintReportForm
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
            this.crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptSanPham = new QL_ban_tinh_dau.rpt.rptSanPham();
            this.rptLoaiSanPham = new QL_ban_tinh_dau.rpt.rptLoaiSanPham();
            this.rptNhanVien = new QL_ban_tinh_dau.rpt.rptNhanVien();
            this.rptKhachHang = new QL_ban_tinh_dau.rpt.rptKhachHang();
            this.SuspendLayout();
            // 
            // crystalReportViewer
            // 
            this.crystalReportViewer.ActiveViewIndex = -1;
            this.crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer.Name = "crystalReportViewer";
            this.crystalReportViewer.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewer.TabIndex = 0;
            // 
            // PrintReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewer);
            this.Name = "PrintReportForm";
            this.Text = "PrintReportForm";
            this.Load += new System.EventHandler(this.PrintReportForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer;
        private rpt.rptSanPham rptSanPham;
        private rpt.rptLoaiSanPham rptLoaiSanPham;
        private rpt.rptNhanVien rptNhanVien;
        private rpt.rptKhachHang rptKhachHang;
    }
}