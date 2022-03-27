using QL_ban_tinh_dau.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_ban_tinh_dau
{
    public partial class PrintReportForm : Form
    {
        public string type = "";
        public object list_data;
        public DateTime dFrom;
        public DateTime dTo;
        public int TongThanhTien;

        public PrintReportForm()
        {
            InitializeComponent();
        }

        public PrintReportForm(string type, object list_data, DateTime dFrom, DateTime dTo, int TongThanhTien)
        {
            InitializeComponent();
            this.type = type;
            this.list_data = list_data;
            this.dFrom = dFrom;
            this.dTo = dTo;
            this.TongThanhTien = TongThanhTien;
        }

        private void PrintReportForm_Load(object sender, EventArgs e)
        {
            switch (this.type)
            {
                case "SanPham":
                    var list = (List<BCTK_SanPham>)this.list_data;
                    rptSanPham.SetDataSource(list);
                    rptSanPham.SetParameterValue("NVId", GlobalValue.NhanVienId);
                    rptSanPham.SetParameterValue("NVTen", GlobalValue.Username);
                    rptSanPham.SetParameterValue("dFrom", dFrom.ToString("dd/MM/yyyy"));
                    rptSanPham.SetParameterValue("dTo", dTo.ToString("dd/MM/yyyy"));
                    rptSanPham.SetParameterValue("printDate", DateTime.Now.ToString("dd/MM/yyyy"));
                    rptSanPham.SetParameterValue("TongThanhTien", TongThanhTien.ToString());

                    crystalReportViewer.ReportSource = rptSanPham;
                    break;

                case "LoaiSanPham":
                    var list2 = (List<BCTK_LoaiSanPham>)this.list_data;
                    rptLoaiSanPham.SetDataSource(list2);
                    rptLoaiSanPham.SetParameterValue("NVId", GlobalValue.NhanVienId);
                    rptLoaiSanPham.SetParameterValue("NVTen", GlobalValue.Username);
                    rptLoaiSanPham.SetParameterValue("dFrom", dFrom.ToString("dd/MM/yyyy"));
                    rptLoaiSanPham.SetParameterValue("dTo", dTo.ToString("dd/MM/yyyy"));
                    rptLoaiSanPham.SetParameterValue("printDate", DateTime.Now.ToString("dd/MM/yyyy"));
                    rptLoaiSanPham.SetParameterValue("TongThanhTien", TongThanhTien.ToString());
                    crystalReportViewer.ReportSource = rptLoaiSanPham;
                    break;

                case "KhachHang":
                    var list3 = (List<BCTK_KhachHang>)this.list_data;
                    rptKhachHang.SetDataSource(list3);
                    rptKhachHang.SetParameterValue("NVId", GlobalValue.NhanVienId);
                    rptKhachHang.SetParameterValue("NVTen", GlobalValue.Username);
                    rptKhachHang.SetParameterValue("dFrom", dFrom.ToString("dd/MM/yyyy"));
                    rptKhachHang.SetParameterValue("dTo", dTo.ToString("dd/MM/yyyy"));
                    rptKhachHang.SetParameterValue("printDate", DateTime.Now.ToString("dd/MM/yyyy"));
                    rptKhachHang.SetParameterValue("TongThanhTien", TongThanhTien.ToString());
                    crystalReportViewer.ReportSource = rptKhachHang;
                    break;

                case "NhanVien":
                    var list4 = (List<BCTK_NhanVien>)this.list_data;
                    rptNhanVien.SetDataSource(list4);
                    rptNhanVien.SetParameterValue("NVId", GlobalValue.NhanVienId);
                    rptNhanVien.SetParameterValue("NVTen", GlobalValue.Username);
                    rptNhanVien.SetParameterValue("dFrom", dFrom.ToString("dd/MM/yyyy"));
                    rptNhanVien.SetParameterValue("dTo", dTo.ToString("dd/MM/yyyy"));
                    rptNhanVien.SetParameterValue("printDate", DateTime.Now.ToString("dd/MM/yyyy"));
                    rptNhanVien.SetParameterValue("TongThanhTien", TongThanhTien.ToString());
                    crystalReportViewer.ReportSource = rptNhanVien;
                    break;
            }
            crystalReportViewer.Refresh();
        }
    }
}
