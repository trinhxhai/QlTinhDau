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
    public partial class QLHoaDonForm : Form
    {
        public static String conStr = ConfigurationManager.ConnectionStrings["data_base"].ConnectionString.ToString();

        public static bool isThemHoaDon = true;

        public int selectedHoaDonId = -1;
        public int selectedNhanVienId = -1;
        public int selectedKhachHangId = -1;

        public int khachHangId = -1;

        public static QLHoaDonForm qlHDForm;
        public static bool needToClose = true;

        private List<HoaDon> listHD;
        public QLHoaDonForm()
        {
            InitializeComponent();
            /* dCreateTimeFrom.Format = DateTimePickerFormat.Custom;
             dCreateTimeTo.Format = DateTimePickerFormat.Custom;
             dCreateTimeFrom.CustomFormat = "yyyy-MM-dd";
             dCreateTimeTo.CustomFormat = "yyyy-MM-dd";*/
            qlHDForm = this;

        }
        private void QLHoaDonForm_Load(object sender, EventArgs e)
        {
            load_hoadon();
            loadCombobox();
            isThemHoaDon = true;
        }
        void load_hoadon()
        {
            listHD = new List<HoaDon>();
            lwHoadon.Items.Clear();
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from v_hoadon", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            ListViewItem item = new ListViewItem();
                            item.Text = dataReader["idHoadon"].ToString();
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["tenKH"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["tenNV"] + ""));
                            item.SubItems.Add(String.Format("{0:dd/MM/yyyy}", dataReader["dNgaymua"]));
                            item.SubItems.Add(String.Format("{0:dd/MM/yyyy}", dataReader["dThoigiantao"]));
                            item.SubItems.Add(String.Format("{0:dd/MM/yyyy}", dataReader["dThoigiansua"]));
                            lwHoadon.Items.Add(item);

                            /*
                            listHD.Add(new HoaDon { 
                                Id = int.Parse(dataReader["idHoadon"].ToString()),

                            })
                            */

                        }
                    }

                    conn.Close();
                }
            }
        }

        void load_to_CTHD()
        {
            lwCTHD.Items.Clear();
            int tongThanhTien = 0;
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from v_CTHD where idHoadon = '"+txtMa.Text+"' ", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            ListViewItem item = new ListViewItem();
                            item.Text = dataReader["idSanpham"].ToString();
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["tenSanpham"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["fSoluongmua"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["fGiaban"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["fKhuyenmai"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["fthanhTien"] + ""));
                            lwCTHD.Items.Add(item);

                            tongThanhTien += int.Parse(dataReader["fthanhTien"].ToString());


                        }

                    }

                    conn.Close();
                }


            }


            lbTong.Text = tongThanhTien.ToString();
        }

        private void lwHoadon_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            //hoaDonId = e.Item.Text;
            

            foreach (ListViewItem item in lwHoadon.SelectedItems)
            {
                txtMa.Text = item.SubItems[0].Text;
                cbKH.Text = item.SubItems[1].Text;
                load_to_CTHD();
              //  tinhTong();

            }

           // btnThem.Enabled = false;

        }

        void loadCombobox()

        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tbl_khachhang", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(dataReader);
                    cbKH.DisplayMember = "tenKH";
                    cbKH.DataSource = dt;
                    cbKH.ValueMember = "id_KH";

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChiTietHoaDonForm CTHD  = new ChiTietHoaDonForm();
            this.khachHangId = int.Parse(cbKH.SelectedValue.ToString());
            this.Hide();
            needToClose = true;
            CTHD.FormClosed += CloseHD;
            CTHD.FormClosed += showCloseMessage;
            CTHD.ShowDialog();
        }


        private void showCloseMessage(object sender, EventArgs e)
        {
            if (ChiTietHoaDonForm.ClosedCode == 1)
            {
                MessageBox.Show("Thêm thành công");

                load_hoadon();
                lwHoadon.Refresh();
                //load_to_CTHD();
                //lwCTHD.Refresh();

            }
            else if (ChiTietHoaDonForm.ClosedCode == 2) {
                MessageBox.Show("Sửa thành công");
                load_to_CTHD();
                lwCTHD.Refresh();
            }
        }
        public void CloseHD(object sender, EventArgs e)
        {
            if (needToClose)
            {
                this.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm.mainform.Show();
            MainForm.NeedToClose = false;
            this.Close();
        }

        private void lvtoCTHD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dCreateTimeFrom_ValueChanged(object sender, EventArgs e)
        {

            lwHoadon.Items.Clear();
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tbl_hoadon where dNgaymua between '" +dCreateTimeFrom.Text+ "' And '" +dCreateTimeTo.Text+ "'", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            ListViewItem item = new ListViewItem();
                            item.Text = dataReader["idHoadon"].ToString();
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["tenKH"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["tenNV"] + ""));
                            item.SubItems.Add(String.Format("{0:dd/MM/yyyy}", dataReader["dNgaymua"]));
                            item.SubItems.Add(String.Format("{0:dd/MM/yyyy}", dataReader["dThoigiantao"]));
                            item.SubItems.Add(String.Format("{0:dd/MM/yyyy}", dataReader["dThoigiansua"]));
                            lwHoadon.Items.Add(item);
                          
                        }
                    }

                    conn.Close();
                }
            }
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            isThemHoaDon = true;
            clearInputs();
            this.selectedHoaDonId = -1;
            lwHoadon.Refresh();
            lwCTHD.Refresh();
            button1.Text = "Thêm hóa đơn";
        }

        private void clearInputs()
        {
            txtMa.Text = "";
            cbKH.Refresh();
        }

        private void lwHoadon_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //e.Item.Text; // 

            isThemHoaDon = !e.IsSelected;
            selectedHoaDonId = int.Parse(e.Item.Text);
            button1.Text = "Sửa chi tiết hóa đơn";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            QLHoaDon.Edit(selectedHoaDonId, int.Parse(cbKH.SelectedValue.ToString()));
            load_hoadon();
            lwHoadon.Refresh();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            QLHoaDon.Remove(selectedHoaDonId);
            load_hoadon();
            lwHoadon.Refresh();
        }

        private void btninHD_Click(object sender, EventArgs e)
        {
            InHoaDonForm fPrint = new InHoaDonForm(selectedHoaDonId);
            fPrint.ShowDialog();;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            lwHoadon.Items.Clear();
            using (SqlConnection cnn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "timkiem_HD";
                    cmd.Parameters.AddWithValue("@Key ", txtTimKiem.Text);

                    cnn.Open();
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            ListViewItem item = new ListViewItem();
                            item.Text = dataReader["idHoadon"].ToString();
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["id_KH"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["id_NV"] + ""));
                            item.SubItems.Add(String.Format("{0:dd/MM/yyyy}", dataReader["dNgaymua"]));
                            item.SubItems.Add(String.Format("{0:dd/MM/yyyy}", dataReader["dThoigiantao"]));
                            item.SubItems.Add(String.Format("{0:dd/MM/yyyy}", dataReader["dThoigiansua"]));
                            lwHoadon.Items.Add(item);
                        }
                    }
                    cnn.Close();

                }
            }
        }

        private void btnHuysearch_Click(object sender, EventArgs e)
        {
            txtTimKiem.ResetText();
            lwHoadon.Items.Clear();
            load_hoadon();
        }
    }
}
