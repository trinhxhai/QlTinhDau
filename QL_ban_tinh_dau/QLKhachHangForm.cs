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
    public partial class QLKhachHangForm : Form
    {
        public static String conStr = ConfigurationManager.ConnectionStrings["data_base"].ConnectionString.ToString();

        public QLKhachHangForm()
        {
            InitializeComponent();
        }

        void load_KhachHang()
        {
            lwKhachHang.Items.Clear();
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tbl_khachhang", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            ListViewItem item = new ListViewItem();
                            item.Text = dataReader["id_KH"].ToString();
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["tenKH"] + ""));
                            item.SubItems.Add(String.Format("{0:dd/MM/yyyy}", dataReader["ngaySinh"]));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["diaChi"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["Sdt"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["maSothue"] + ""));
                            lwKhachHang.Items.Add(item);
                        }
                    }

                    conn.Close();
                }
            }
        }



        private void QLKhachHangForm_load(object sender, EventArgs e)
        {
            load_KhachHang();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm.NeedToClose = false;
            this.Close();
            MainForm.mainform.Show();
        }

        private void lwKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lwKhachHang.SelectedItems)
            {
                txtMaKH.Text = item.SubItems[0].Text;
                txtTenKH.Text = item.SubItems[1].Text;
                dNgaySinh.Text = item.SubItems[2].Text;
                txtdiaChi.Text = item.SubItems[3].Text;
                txtSdt.Text = item.SubItems[4].Text;
                txtmaSothue.Text = item.SubItems[5].Text;

            }

            btnThem.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (txtTenKH.Text == string.Empty && txtdiaChi.Text == string.Empty && txtSdt.Text == string.Empty && txtmaSothue.Text == string.Empty)
            {
                MessageBox.Show("Dữ liệu không được để  trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else 

            try
            {
                using (SqlConnection cnn = new SqlConnection(conStr))
                {
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "themKH";
                        cmd.Parameters.AddWithValue("@tenKH ", txtTenKH.Text);
                        cmd.Parameters.AddWithValue("@ngaySinh ", Convert.ToDateTime(dNgaySinh.Text));
                        cmd.Parameters.AddWithValue("@diaChi ", txtdiaChi.Text);
                        cmd.Parameters.AddWithValue("@sdt ", txtSdt.Text);
                        cmd.Parameters.AddWithValue("@maSothue", txtmaSothue.Text);

                        cnn.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {

                            MessageBox.Show("Thêm khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cnn.Close();
                            load_KhachHang();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //   try
            {
                using (SqlConnection cnn = new SqlConnection(conStr))
                {
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SuaKH";
                        cmd.Parameters.AddWithValue("@id_KH ", txtMaKH.Text);
                        cmd.Parameters.AddWithValue("@tenKH ", txtTenKH.Text);
                        cmd.Parameters.AddWithValue("@ngaySinh ", Convert.ToDateTime(dNgaySinh.Text));
                        cmd.Parameters.AddWithValue("@diaChi ", txtdiaChi.Text);
                        cmd.Parameters.AddWithValue("@sdt ", txtSdt.Text);
                        cmd.Parameters.AddWithValue("@maSothue", txtmaSothue.Text);

                        cnn.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {

                            MessageBox.Show("Cập nhật khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cnn.Close();
                            load_KhachHang();
                        }
                    }
                }
            }
            /* catch (Exception)
             {
                 MessageBox.Show("Không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
             } */
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn chắc chắn  muốn xóa?", "Xóa  khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.No)
            {
                return;
            }
            else

                try
                {
                    using (SqlConnection cnn = new SqlConnection(conStr))
                    {
                        using (SqlCommand cmd = cnn.CreateCommand())
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "XoaKH";
                            cmd.Parameters.AddWithValue("@id_KH ", txtMaKH.Text);

                            cnn.Open();
                            int i = cmd.ExecuteNonQuery();
                            if (i > 0)
                            {

                                MessageBox.Show("Xóa khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cnn.Close();
                                load_KhachHang();
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox2.Controls)
            {
                if (c is TextBox)
                {
                    c.ResetText();
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            lwKhachHang.Items.Clear();
            using (SqlConnection cnn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "timkiem_kh";
                    cmd.Parameters.AddWithValue("@Key ", txtTimKiem.Text);

                    cnn.Open();
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            ListViewItem item = new ListViewItem();
                            item.Text = dataReader["id_KH"].ToString();
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["tenKH"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["ngaySinh"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["diaChi"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["Sdt"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["maSothue"] + ""));
                            lwKhachHang.Items.Add(item);
                        }
                    }
                    cnn.Close();

                }
            }
        }

        private void btnHuysearch_Click(object sender, EventArgs e)
        {
            txtTimKiem.ResetText();
            lwKhachHang.Items.Clear();
            load_KhachHang();
        }
    }
}

