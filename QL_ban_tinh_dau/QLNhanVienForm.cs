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
    public partial class QLNhanVienForm : Form
    {
        
        public static String conStr = ConfigurationManager.ConnectionStrings["data_base"].ConnectionString.ToString();

        public QLNhanVienForm()
        {
            InitializeComponent();
        }

        void load_nhanvien()
        {
            lwNhanVien.Items.Clear();
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tbl_nhanvien", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            ListViewItem item = new ListViewItem();
                            item.Text = dataReader["id_NV"].ToString();
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["tenNV"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["gioiTinh"] + ""));
                            item.SubItems.Add(String.Format("{0:dd/MM/yyyy}", dataReader["ngaySinh"]));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["Sdt"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["diaChi"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["tenTaiKhoanNV"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["matKhau"] + ""));
                            lwNhanVien.Items.Add(item);
                        }
                    }

                    conn.Close();
                }
            }
        }

        //Đưa dữ liệu từ ListView ra từng Textbox

        private void lwNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lwNhanVien.SelectedItems)
            {
                txtMa.Text = item.SubItems[0].Text;
                txtTenNV.Text = item.SubItems[1].Text;
                comboBox1.Text = item.SubItems[2].Text;
                dNgaySinh.Text = item.SubItems[3].Text;
                txtSdt.Text = item.SubItems[4].Text;
                textdiaChi.Text= item.SubItems[5].Text;
                txtTenTaiKhoan.Text = item.SubItems[6].Text;
                txtpassWord.Text = item.SubItems[7].Text;

            }

            btnThem.Enabled = false;
        }

            private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rbNu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void QLNhanVienForm_Load(object sender, EventArgs e)
        {
            load_nhanvien();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm.NeedToClose = false;
            this.Close();
            MainForm.mainform.Show();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtrepass.Text == "")
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtpassWord.Text != txtrepass.Text)
            {
                MessageBox.Show("Mật khẩu không trùng khớp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
           
            try
            {
                using (SqlConnection cnn = new SqlConnection(conStr))
                {
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "themNV";
                        cmd.Parameters.AddWithValue("@tenNV ", txtTenNV.Text);
                        cmd.Parameters.AddWithValue("@tenTaiKhoanNV ", txtTenTaiKhoan.Text);
                        cmd.Parameters.AddWithValue("@matKhau ", txtpassWord.Text);
                        cmd.Parameters.AddWithValue("@ngaySinh ", Convert.ToDateTime(dNgaySinh.Text));
                        cmd.Parameters.AddWithValue("@diaChi ", textdiaChi.Text);
                        cmd.Parameters.AddWithValue("@sdt ", txtSdt.Text);
                        cmd.Parameters.AddWithValue("@gioiTinh ", comboBox1.Text);

                        cnn.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            
                            MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cnn.Close();
                            load_nhanvien();
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
            if (txtpassWord.Text != txtrepass.Text)
            {
                MessageBox.Show("Mật khẩu không trùng khớp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                try
            {
                using (SqlConnection cnn = new SqlConnection(conStr))
                {
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "suaNV";
                        cmd.Parameters.AddWithValue("@id_NV ", txtMa.Text);
                        cmd.Parameters.AddWithValue("@tenNV ", txtTenNV.Text);
                        cmd.Parameters.AddWithValue("@tenTaiKhoanNV ", txtTenTaiKhoan.Text);
                        cmd.Parameters.AddWithValue("@matKhau ", txtpassWord.Text);
                        cmd.Parameters.AddWithValue("@ngaySinh ", Convert.ToDateTime(dNgaySinh.Text));
                        cmd.Parameters.AddWithValue("@diaChi ", textdiaChi.Text);
                        cmd.Parameters.AddWithValue("@sdt ", txtSdt.Text);
                        cmd.Parameters.AddWithValue("@gioiTinh ", comboBox1.Text);

                        cnn.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {

                            MessageBox.Show("Cập nhật nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cnn.Close();
                            load_nhanvien();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn chắc chắn  muốn xóa?", "Xóa  nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.No)
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
                        cmd.CommandText = "xoaNV";
                        cmd.Parameters.AddWithValue("@id_NV ", txtMa.Text);

                        cnn.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {

                            MessageBox.Show("Xóa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cnn.Close();
                            load_nhanvien();
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
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    c.ResetText();
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            lwNhanVien.Items.Clear();
            using (SqlConnection cnn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "timkiem_nv";
                    cmd.Parameters.AddWithValue("@Key ", txtTimKiem.Text);

                    cnn.Open();
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            ListViewItem item = new ListViewItem();
                            item.Text = dataReader["id_NV"].ToString();
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["tenNV"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["gioiTinh"] + ""));
                            item.SubItems.Add(String.Format("{0:dd/MM/yyyy}", dataReader["ngaySinh"]));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["Sdt"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["diaChi"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["tenTaiKhoanNV"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["matKhau"] + ""));
                            lwNhanVien.Items.Add(item);
                        }
                    }
                    cnn.Close();

                }
            }
        }

        private void btnHuysearch_Click(object sender, EventArgs e)
        {
            txtTimKiem.ResetText();
            lwNhanVien.Items.Clear();
            load_nhanvien();
        }
    }
}
    

