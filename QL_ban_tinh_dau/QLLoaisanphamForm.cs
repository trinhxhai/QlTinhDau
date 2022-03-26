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
    public partial class QLLoaisanphamForm : Form
    {
        public static String conStr = ConfigurationManager.ConnectionStrings["data_base"].ConnectionString.ToString();

        public QLLoaisanphamForm()
        {
            InitializeComponent();
        }


        void load_Loaisanpham()
        {
            lwLoaisanpham.Items.Clear();
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tbl_loaisanpham", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            ListViewItem item = new ListViewItem();
                            item.Text = dataReader["idLoaisanpham"].ToString();
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["tenLoaisanpham"] + ""));
                            lwLoaisanpham.Items.Add(item);
                        }
                    }

                    conn.Close();
                }
            }
        }

        private void QLLoaisanpham_load(object sender, EventArgs e)
        {
            load_Loaisanpham();
        }


        private void lwLoaisanpham_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lwLoaisanpham.SelectedItems)
            {
                txtMaLSP.Text = item.SubItems[0].Text;
                txtTenLSP.Text = item.SubItems[1].Text;

            }

           btnThem.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            /*foreach (Control c in groupBox2.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty)
                    {
                        MessageBox.Show("Dữ liệu không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }*/
            try
            {
                using (SqlConnection cnn = new SqlConnection(conStr))
                {
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "themLoaisanpham";
                        cmd.Parameters.AddWithValue("@tenLoaisanpham ", txtTenLSP.Text);

                        cnn.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {

                            MessageBox.Show("Thêm loại sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cnn.Close();
                            load_Loaisanpham();
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
            using (SqlConnection cnn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "suaLoaisanpham";
                    cmd.Parameters.AddWithValue("@idLoaisanpham ", txtMaLSP.Text);
                    cmd.Parameters.AddWithValue("@tenLoaisanpham ", txtTenLSP.Text);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {

                        MessageBox.Show("Cập nhật Loại sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cnn.Close();
                        load_Loaisanpham();
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xóa loại sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                            cmd.CommandText = "xoaLoaisanpham";
                            cmd.Parameters.AddWithValue("@idLoaisanpham ", txtMaLSP.Text);

                            cnn.Open();
                            int i = cmd.ExecuteNonQuery();
                            if (i > 0)
                            {

                                MessageBox.Show("Xóa loại sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cnn.Close();
                                load_Loaisanpham();
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm.NeedToClose = false;
            this.Close();
            MainForm.mainform.Show();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            /*lwLoaisanpham.Items.Clear();
            using (SqlConnection cnn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "timkiem_LoaiSP";
                    cmd.Parameters.AddWithValue("@Key ", txtTimKiem.Text);

                    cnn.Open();
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            ListViewItem item = new ListViewItem();
                            item.Text = dataReader["idLoaisanpham"].ToString();
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["tenLoaisanpham"] + ""));
                            lwLoaisanpham.Items.Add(item);
                        }
                    }
                    cnn.Close();

                }
            }*/
        }

        private void btnHuysearch_Click(object sender, EventArgs e)
        {
            txtTimKiem.ResetText();
            lwLoaisanpham.Items.Clear();
            load_Loaisanpham();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            lwLoaisanpham.Items.Clear();
            using (SqlConnection cnn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "timkiem_LoaiSP";
                    cmd.Parameters.AddWithValue("@Key ", txtTimKiem.Text);

                    cnn.Open();
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            ListViewItem item = new ListViewItem();
                            item.Text = dataReader["idLoaisanpham"].ToString();
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["tenLoaisanpham"] + ""));
                            lwLoaisanpham.Items.Add(item);
                        }
                    }
                    cnn.Close();

                }
            }
        }
    }
}


