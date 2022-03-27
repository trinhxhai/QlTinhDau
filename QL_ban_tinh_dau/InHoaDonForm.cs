using QL_ban_tinh_dau.Business;
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
    public partial class InHoaDonForm : Form
    {
        private int HoaDonId = -1;
        public InHoaDonForm()
        {
            InitializeComponent();
        }

        public InHoaDonForm(int HoaDonId)
        {
            InitializeComponent();
            this.HoaDonId = HoaDonId;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

            var hd = QLHoaDon.GetById(HoaDonId);

            var listCTHD = QLChiTietHoaDon.GetList(HoaDonId);
            rptHoaDon1.SetDataSource(listCTHD);
            rptHoaDon1.SetParameterValue("ngayIn", DateTime.Now.ToString());
            rptHoaDon1.SetParameterValue("maHD", HoaDonId.ToString());
            rptHoaDon1.SetParameterValue("tenKH", hd.TenKhachHang);
            rptHoaDon1.SetParameterValue("tenNV", hd.TenNhanVien);

            crystalReportViewer.ReportSource = rptHoaDon1;

        }

        private void InHoaDonForm_Load(object sender, EventArgs e)
        {

        }
    }
}
