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
    public partial class BCTKForm : Form
    {
        public static string currentTab = "SanPham";
        public static object currentList = "";
        public static int currentTotal = 0;
        public BCTKForm()
        {
            InitializeComponent();
        }

        public void Reload()
        {
            switch (currentTab)
            {
                case "SanPham":
                    LoadBCTKSanPham();
                    break;
                case "LoaiSanPham":
                    LoadBCTKLoaiSanPham();
                    break;
                case "KhachHang":
                    LoadBCTKKhachHang();
                    break;

                case "NhanVien":
                    LoadBCTKNhanVien();
                    break;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm.NeedToClose = false;
            this.Close();
            MainForm.mainform.Show();
        }

        private void BCTKForm_Load(object sender, EventArgs e)
        {
            LoadBCTKSanPham();
            lwSanPham.Show();
            lwLoaiSanPham.Hide();
            lwKhachHang.Hide();
            lwNhanVien.Hide();
        }

        private void LoadBCTKSanPham()
        {
            currentTab = "SanPham";
            lwSanPham.Show();
            lwLoaiSanPham.Hide();
            lwKhachHang.Hide();
            lwNhanVien.Hide();

            lbTitle.Text = "Báo cáo thống kê theo Sản phẩm";
            List<BCTK_SanPham> src = BaoCaoThongKe.GetBCTKSanPham(dpFrom.Value, dpTo.Value);
            if (src == null) return;
            currentList = src;

            int total = 0;
            lwSanPham.Items.Clear();
            foreach (var data in src)
            {
                ListViewItem item = new ListViewItem(data.IdSanPham.ToString());
                item.SubItems.Add(data.TenSanPham);
                item.SubItems.Add(data.GiaBan.ToString());
                item.SubItems.Add(data.TongSoLuongDaBan.ToString());
                item.SubItems.Add(data.TongThanhTien.ToString());
                lwSanPham.Items.Add(item);
                total += data.TongThanhTien;
            }
            currentTotal = total;
            lbTongTien.Text = total.ToString();
        }

        private void LoadBCTKLoaiSanPham()
        {
            currentTab = "LoaiSanPham";
            lwSanPham.Hide();
            lwLoaiSanPham.Show();
            lwKhachHang.Hide();
            lwNhanVien.Hide();

            lbTitle.Text = "Báo cáo thống kê theo Loại sản phẩm";
            List<BCTK_LoaiSanPham> src = BaoCaoThongKe.GetBCTKLoaiSanPham(dpFrom.Value, dpTo.Value);
            if (src == null) return;
            currentList = src;

            int total = 0;
            lwLoaiSanPham.Items.Clear();
            foreach (var data in src)
            {
                ListViewItem item = new ListViewItem(data.IdLoaiSanPham.ToString());
                item.SubItems.Add(data.tenLoaiSanPham);
                item.SubItems.Add(data.TongSoLuongDaBan.ToString());
                item.SubItems.Add(data.TongThanhTien.ToString());
                lwLoaiSanPham.Items.Add(item);
                total += data.TongThanhTien;
            }
            currentTotal = total;
            lbTongTien.Text = total.ToString();
        }

        private void LoadBCTKKhachHang()
        {
            currentTab = "KhachHang";
            lwSanPham.Hide();
            lwLoaiSanPham.Hide();
            lwKhachHang.Show();
            lwNhanVien.Hide();

            lbTitle.Text = "Báo cáo thống kê theo Khách hàng";
            List<BCTK_KhachHang> src = BaoCaoThongKe.GetBCTKKhachHang(dpFrom.Value, dpTo.Value);
            if (src == null) return;
            currentList = src;

            int total = 0;
            lwKhachHang.Items.Clear();
            foreach (var data in src)
            {
                ListViewItem item = new ListViewItem(data.IdKhachHang.ToString());
                item.SubItems.Add(data.TenKhachHang);
                item.SubItems.Add(data.TongSoLuongDaBan.ToString());
                item.SubItems.Add(data.TongThanhTien.ToString());
                lwKhachHang.Items.Add(item);
                total += data.TongThanhTien;
            }
            currentTotal = total;
            lbTongTien.Text = total.ToString();
        }

        private void LoadBCTKNhanVien()
        {
            currentTab = "NhanVien";
            lwSanPham.Hide();
            lwLoaiSanPham.Hide();
            lwKhachHang.Hide();
            lwNhanVien.Show();

            lbTitle.Text = "Báo cáo thống kê theo Nhân viên";
            List<BCTK_NhanVien> src = BaoCaoThongKe.GetBCTKNhanVien(dpFrom.Value, dpTo.Value);
            if (src == null) return;
            currentList = src;

            int total = 0;
            lwNhanVien.Items.Clear();
            foreach (var data in src)
            {
                ListViewItem item = new ListViewItem(data.NhanVienId.ToString());
                item.SubItems.Add(data.TenNhanVien);
                item.SubItems.Add(data.TongSoLuongDaBan.ToString());
                item.SubItems.Add(data.TongThanhTien.ToString());
                lwNhanVien.Items.Add(item);
                total += data.TongThanhTien;
            }
            currentTotal = total;
            lbTongTien.Text = total.ToString();
        }

        private void dpFrom_ValueChanged(object sender, EventArgs e)
        {
            if (dpFrom.Value > dpTo.Value)
            {
                dpTo.Value = dpFrom.Value;
                MessageBox.Show("Khoảng thời gian không hợp lệ, mời chọn lại!");
                return;
            }
            Reload();
        }

        private void dpTo_ValueChanged(object sender, EventArgs e)
        {
            if (dpFrom.Value > dpTo.Value)
            {
                dpFrom.Value = dpTo.Value;
                MessageBox.Show("Khoảng thời gian không hợp lệ, mời chọn lại!");
                return;
            }
            Reload();
        }

        private void bntTKSanPham_Click(object sender, EventArgs e)
        {
            LoadBCTKSanPham();
        }

        private void bntTKLoaiSanPham_Click(object sender, EventArgs e)
        {
            LoadBCTKLoaiSanPham();
        }

        private void bntTKKhachHang_Click(object sender, EventArgs e)
        {
            LoadBCTKKhachHang();
        }

        private void bntTKNhanVien_Click(object sender, EventArgs e)
        {
            LoadBCTKNhanVien();
        }

        private void btnPrintStatic_Click(object sender, EventArgs e)
        {
            using (PrintReportForm prf = new PrintReportForm(currentTab, currentList, dpFrom.Value, dpTo.Value, currentTotal))
            {
                prf.ShowDialog();
            }
        }
    }
}
