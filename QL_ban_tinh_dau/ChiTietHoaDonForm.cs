using QL_ban_tinh_dau.Business;
using QL_ban_tinh_dau.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_ban_tinh_dau
{
    public partial class ChiTietHoaDonForm : Form
    {
        public static String conStr = ConfigurationManager.ConnectionStrings["data_base"].ConnectionString.ToString();

        public static int hoadonId;

        private List<CTHD> oriListCTHDs = new List<CTHD>();
        private List<CTHD> listCTHDs = new List<CTHD>();

        private List<SanPham> listSanPhams = new List<SanPham>();

        private CTHD SelectedCTHD;
        private SanPham SelectedSanpham;

        private bool IsEditing = false;


        public static int ClosedCode = -1;// -1 Thoat, 1: Them Thanh Cong, 2: Sua Thanh Cong

        public ChiTietHoaDonForm()
        {
            InitializeComponent();

            if (QLHoaDonForm.isThemHoaDon == false) {
                btnThemHoaDon.Text = "Lưu hóa đơn";
            }
            hoadonId = QLHoaDonForm.qlHDForm.selectedHoaDonId;
        }

        private void ChiTietHoaDonForm_Load(object sender, EventArgs e)
        {
            load_CTHD();
            load_sanphamCTHD();
        }

        void load_CTHD()
        {
            int tongThanhTien = 0;
            listCTHDs.Clear();
            oriListCTHDs.Clear();
            lwCTHD.Items.Clear();

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from v_CTHD where idHoadon = "+ hoadonId, conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            ListViewItem item = new ListViewItem(dataReader["idSanpham"].ToString());
                            item.Text = dataReader["idSanpham"].ToString();
                            item.SubItems.Add( dataReader["tenSanpham"] + "");
                            item.SubItems.Add( dataReader["fSoluongmua"] + "");
                            item.SubItems.Add(dataReader["fGiaban"] + "");
                            item.SubItems.Add(dataReader["fKhuyenmai"] + "");
                            item.SubItems.Add(dataReader["fthanhTien"] + "");

                            lwCTHD.Items.Add(item);
                            listCTHDs.Add(new CTHD
                            {
                                HoaDonId = hoadonId,
                                SanPhamId = int.Parse(dataReader["idSanpham"].ToString()),
                                SoLuong = double.Parse(dataReader["fSoluongmua"].ToString()),
                                KhuyenMai = double.Parse(dataReader["fKhuyenmai"].ToString()),
                                ThanhTien = float.Parse(dataReader["fthanhTien"].ToString()),
                                TenSanPham = dataReader["tenSanpham"].ToString(),
                                GiaBan = int.Parse(dataReader["fGiaban"].ToString()),

                            });
                            oriListCTHDs.Add(new CTHD
                            {
                                HoaDonId = hoadonId,
                                SanPhamId = int.Parse(dataReader["idSanpham"].ToString()),
                                SoLuong = double.Parse(dataReader["fSoluongmua"].ToString()),
                                KhuyenMai = double.Parse(dataReader["fKhuyenmai"].ToString()),
                                ThanhTien = float.Parse(dataReader["fthanhTien"].ToString()),
                                TenSanPham = dataReader["tenSanpham"].ToString(),
                                GiaBan = int.Parse(dataReader["fGiaban"].ToString()),
                            });

                            tongThanhTien += int.Parse(dataReader["fthanhTien"].ToString());
                        }
                    }

                    lbTong.Text = tongThanhTien.ToString();

                    conn.Close();
                }
            }
        }

        void load_sanphamCTHD()
        {
            lwSanpham.Items.Clear();
            listSanPhams.Clear();
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tbl_Sanpham", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            ListViewItem item = new ListViewItem(dataReader["idSanpham"].ToString());
                            item.Text = dataReader["idSanpham"].ToString();
                            item.SubItems.Add( dataReader["tenSanpham"] + "");
                            item.SubItems.Add( dataReader["sthetich"] + "");
                            item.SubItems.Add( dataReader["mota"] + "");
                            item.SubItems.Add( dataReader["fGiaban"] + "");
                            item.SubItems.Add( dataReader["idLoaisanpham"] + "");

                            lwSanpham.Items.Add(item);
                            listSanPhams.Add(new SanPham
                            {
                                Id = int.Parse(dataReader["idSanpham"].ToString()),
                                TheTich = dataReader["sthetich"].ToString(),
                                Mota = dataReader["mota"].ToString(),
                                GiaBan = int.Parse(dataReader["fGiaban"].ToString() ),
                                LoaiSanPhamId = int.Parse(dataReader["idLoaisanpham"].ToString()),
                                Ten = dataReader["tenSanpham"].ToString(),
                            });


                        }
                    }

                    conn.Close();
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
            ClosedCode = -1;
            QLHoaDonForm.needToClose = false;
            QLHoaDonForm.qlHDForm.Show();
        }

        public void SuaCTHDMode()
        {
            btnThem.Text = "Lưu sản phẩm";
            btnXoaCTHD.Enabled = true;
        }

        public void ThemCTHDMode()
        {
            btnThem.Text = "Thêm sản phẩm";
            txtKhuyenMai.Text = "0";
            txtSoLuong.Text = "0";
            btnXoaCTHD.Enabled = false;
            UpdateThanhTien();
        }
        public void ClearInputs()
        {
            txtKhuyenMai.Text = "0";
            txtSoLuong.Text = "0";
            UpdateThanhTien();
        }

        public void DisabledMode()
        {
            ClearInputs();
            txtSoLuong.Enabled = false;
            txtKhuyenMai.Enabled = false;
            btnThem.Enabled = false;
            btnXoaCTHD.Enabled = false;
        }
        public void EnabledMode()
        {
            txtSoLuong.Enabled = true;
            txtKhuyenMai.Enabled = true;
            btnThem.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            int soluong = int.Parse(txtSoLuong.Text);
            int khuyenmai = int.Parse(txtKhuyenMai.Text);
            int thanhtien = int.Parse(txtThanhTien.Text);

            // Lưu hay thêm ?
            if (SelectedCTHD == null)
            {
                listCTHDs.Add(
                new CTHD
                {
                    HoaDonId = hoadonId,
                    SanPhamId = SelectedSanpham.Id,
                    SoLuong = soluong,
                    KhuyenMai = khuyenmai,
                    ThanhTien = thanhtien,
                    TenSanPham = SelectedSanpham.Ten,
                    GiaBan = SelectedSanpham.GiaBan,
                });

                reloadLwCTHD();
                lwCTHD.Refresh();

                lwSanpham.Refresh();
                DisabledMode();

            }
            else{

                //Sua
                SelectedCTHD.SoLuong = soluong;
                SelectedCTHD.KhuyenMai = khuyenmai;
                SelectedCTHD.ThanhTien = thanhtien;

                reloadLwCTHD();

            }
            
        }

        private void reloadLwCTHD()
        {
            // listCTHDs -> lwCTHD
            lwCTHD.Items.Clear();
            int tongThanhTien = 0;
            foreach(var e in listCTHDs)
            {
                ListViewItem item = new ListViewItem(e.SanPhamId.ToString());
                item.Text = e.SanPhamId.ToString();
                item.SubItems.Add(e.TenSanPham);
                item.SubItems.Add(e.SoLuong.ToString());
                item.SubItems.Add(e.GiaBan.ToString());
                item.SubItems.Add(e.KhuyenMai.ToString());
                item.SubItems.Add(e.ThanhTien.ToString());

                tongThanhTien += (int)e.ThanhTien;

                lwCTHD.Items.Add(item);
            }

            lwCTHD.Refresh();
            lbTong.Text = tongThanhTien.ToString();
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            int sl;

            if (int.TryParse(txtSoLuong.Text, out sl))
            {
                UpdateThanhTien();
                btnThem.Enabled = true;
                return;
            }

            txtSoLuong.Text = "";
            btnThem.Enabled = false;
            UpdateThanhTien();
        }

        private void txtKhuyenMai_TextChanged(object sender, EventArgs e)
        {

            int km;

            if (int.TryParse(txtKhuyenMai.Text, out km))
            {
                if (0<=km && km <= 100)
                {
                    UpdateThanhTien();
                    btnThem.Enabled = true;
                    return;
                }
               
            }

            txtKhuyenMai.Text = "";
            btnThem.Enabled = false;
            UpdateThanhTien();
        }

        private void UpdateThanhTien()
        {
            int soluong, khuyenmai;
            
            if (!int.TryParse(txtSoLuong.Text, out soluong) || !int.TryParse(txtKhuyenMai.Text, out khuyenmai) || SelectedSanpham == null)
            {
                txtThanhTien.Text = "";
                btnThem.Enabled = false;
                return;
            }
            btnThem.Enabled = true;
            var thanhtien = (double)( soluong * SelectedSanpham.GiaBan )  / 100 * (100 - khuyenmai);
            txtThanhTien.Text = thanhtien.ToString();
        }


        private void lwSanpham_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

            if (e.IsSelected) {
                EnabledMode();
                txtSoLuong.Enabled = true;
                txtKhuyenMai.Enabled = true;
                btnThem.Enabled = true;

                // CO 2 TH, CHỌn VÀo 1 SP ĐÃ CÓ => sỬa ,  CHỌn VÀo 1 SP cHƯa CÓ THÊM
                SelectedSanpham = listSanPhams.FirstOrDefault(sp => sp.Id.ToString() == e.Item.Text);

                SelectedCTHD = SelectedSanpham == null ? null : listCTHDs.FirstOrDefault(cthd => cthd.SanPhamId == SelectedSanpham.Id);

                if (SelectedCTHD != null)
                {
                    // Sua
                    SuaCTHDMode();
                    IsEditing = true;
                    txtSoLuong.Text = SelectedCTHD.SoLuong.ToString();
                    txtKhuyenMai.Text = SelectedCTHD.KhuyenMai.ToString();
                    txtThanhTien.Text = SelectedCTHD.ThanhTien.ToString();
                }
                else
                {
                    //Them
                    IsEditing = false;
                    ThemCTHDMode();
                    UpdateThanhTien();
                }
            }
            else
            {
                DisabledMode();
            }
            
            
        }

 
        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            // Chú ý các Hóa đơn Id, trong chi tiết hóa đơn , trong th Thêm HD mới sẽ có id là -1, cần thay trước khi thêm thật

            if (hoadonId == -1)
            {
                ChiTietHoaDonForm.ClosedCode = 1;
                // Them hoa don moi + cac chi tiet hd hientai
                // tao hoa don moi => hoa don id *

                int newHDId = QLHoaDon.Add(GlobalValue.NhanVienId, QLHoaDonForm.qlHDForm.khachHangId);
                // hoa don id * => tao ca CTHD voi id nay

                foreach(var cthd in listCTHDs)
                {
                    cthd.HoaDonId = newHDId;
                    QLChiTietHoaDon.Add(cthd);
                }

            }
            else
            {
                ChiTietHoaDonForm.ClosedCode = 2;
                // sua hoa don
                foreach (var cthd in listCTHDs)
                {
                    if (oriListCTHDs.FirstOrDefault(oriCTHD => oriCTHD.SanPhamId == cthd.SanPhamId) != null)
                    {
                        QLChiTietHoaDon.Edit(cthd);
                    }
                    else
                    {

                        QLChiTietHoaDon.Add(cthd);
                    }
                }

                foreach(var oriCTHD in oriListCTHDs)
                {
                    if (listCTHDs.FirstOrDefault(CTHD => CTHD.SanPhamId == oriCTHD.SanPhamId) == null)
                    {
                        QLChiTietHoaDon.Remove(oriCTHD);
                    }
                }
                
            }


            QLHoaDonForm.needToClose = false;
            QLHoaDonForm.qlHDForm.Show();
            this.Close();

        }

        private void lwCTHD_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            
            if (e.IsSelected)
            {
                EnabledMode();
                SuaCTHDMode();

                SelectedCTHD = listCTHDs.FirstOrDefault(sube => sube.SanPhamId.ToString() == e.Item.Text);
                SelectedSanpham = listSanPhams.FirstOrDefault(sp => sp.Id == SelectedCTHD.SanPhamId);
                txtKhuyenMai.Text = SelectedCTHD.KhuyenMai.ToString();
                txtSoLuong.Text = SelectedCTHD.SoLuong.ToString();
                txtThanhTien.Text = SelectedCTHD.ThanhTien.ToString();

            }
            else
            {
                DisabledMode();
                ThemCTHDMode();
                SelectedCTHD = null;
            }
        }

        private void btnXoaCTHD_Click(object sender, EventArgs e)
        {
            listCTHDs.Remove(SelectedCTHD);
            reloadLwCTHD();
            DisabledMode();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
          
        }

        private void btnHuyTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.ResetText();
            lwSanpham.Items.Clear();
            load_CTHD();
        }
    }
}
