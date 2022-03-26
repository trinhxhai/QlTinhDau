using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_ban_tinh_dau
{
    public partial class QLSanphamForm : Form
    {
        public static String conStr = ConfigurationManager.ConnectionStrings["data_base"].ConnectionString.ToString();

        public QLSanphamForm()
        {
            InitializeComponent();
        }

        void load_Sanpham()
        {
            lwSanpham.Items.Clear();
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
                            ListViewItem item = new ListViewItem();
                            item.Text = dataReader["idSanpham"].ToString();
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["tenSanpham"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["sthetich"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["mota"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["iSoluongdaban"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["fGiaban"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["idLoaisanpham"] + ""));
                            lwSanpham.Items.Add(item);
                        }
                    }

                    conn.Close();
                }
            }
        }


        private void lwNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lwSanpham.SelectedItems)
            {
                txtMa.Text = item.SubItems[0].Text;
                txttenSP.Text = item.SubItems[1].Text;
                txtthetich.Text = item.SubItems[2].Text;
                txtmota.Text = item.SubItems[3].Text;
                txtSoluongdaban.Text = item.SubItems[4].Text;
                txtGiaban.Text = item.SubItems[5].Text;
                cbloaisp.Text = item.SubItems[6].Text;

               byte[] getImg = new byte[0];
               using (SqlConnection conn = new SqlConnection(conStr))
                {
                    using (SqlCommand cmd = new SqlCommand("select hinhanh from tbl_Sanpham where tenSanpham = N'" + item.SubItems[1].Text + "'", conn))
                    {
                        conn.Open();
                        cmd.CommandType = CommandType.Text;
                        SqlDataAdapter da = new SqlDataAdapter();
                        DataSet ds = new DataSet();
                        da.SelectCommand = cmd;
                        da.Fill(ds);
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            getImg = (byte[])dr["hinhanh"];
                        }
                        byte[] imgData = getImg;
                        MemoryStream stream = new MemoryStream(imgData);
                        picBox.Image = Image.FromStream(stream);
                        conn.Close();
                    }
                }
            }

           

            btnThem.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm.NeedToClose = false;
            this.Close();
            MainForm.mainform.Show();
        }

        private void QLSanphamForm_Load(object sender, EventArgs e)
        {
            load_Sanpham();
            loadCombobox();
        }

        void loadCombobox()

        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tbl_loaisanpham", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(dataReader);
                    cbloaisp.DisplayMember = "tenLoaisanpham";
                    cbloaisp.DataSource = dt;
                    cbloaisp.ValueMember = "idLoaisanpham";

                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void InsertPic(byte[] image)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand("update tbl_Sanpham set hinhanh = @image where idSanpham = '" + txtMa.Text + "'", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@image", image);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        byte[] ConvertImageToBytes(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();

            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(conStr))
                {
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "themsanpham";
                        cmd.Parameters.AddWithValue("@tenSanpham ", txttenSP.Text);
                        cmd.Parameters.AddWithValue("@sthetich", txtthetich.Text);
                        cmd.Parameters.AddWithValue("@mota", txtmota.Text);
                        cmd.Parameters.AddWithValue("@iSoluongdaban", txtSoluongdaban.Text);
                        cmd.Parameters.AddWithValue("@fGiaban", txtGiaban.Text);
                        cmd.Parameters.AddWithValue("@idLoaisanpham", cbloaisp.SelectedValue);
                        cnn.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                         
                            MessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cnn.Close();
                            load_Sanpham();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(cbloaisp.SelectedValue.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void bntAddPic_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image Files|*.jpg;*.jpeg;*.png", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picBox.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "suaSP";
                    cmd.Parameters.AddWithValue("@idSanpham ", txtMa.Text);
                    cmd.Parameters.AddWithValue("@tenSanpham ", txttenSP.Text);
                    cmd.Parameters.AddWithValue("@sthetich", txtthetich.Text);
                    cmd.Parameters.AddWithValue("@mota", txtmota.Text);
                    cmd.Parameters.AddWithValue("@iSoluongdaban", txtSoluongdaban.Text);
                    cmd.Parameters.AddWithValue("@fGiaban", txtGiaban.Text);
                    cmd.Parameters.AddWithValue("@idLoaisanpham", cbloaisp.SelectedValue);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        InsertPic(ConvertImageToBytes(picBox.Image));
                        MessageBox.Show("Cập nhật sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cnn.Close();
                        load_Sanpham();

                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xóa  sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                            cmd.CommandText = "xoaSP";
                            cmd.Parameters.AddWithValue("@idSanpham ", txtMa.Text);

                            cnn.Open();
                            int i = cmd.ExecuteNonQuery();
                            if (i > 0)
                            {
            
                                MessageBox.Show("Xóa sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                resetText();
                                cnn.Close();
                                load_Sanpham();
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        void resetText()
        {
            txtMa.ResetText();
            txttenSP.ResetText();
            txtthetich.ResetText();
            txtmota.ResetText();
            txtSoluongdaban.ResetText();
            txtGiaban.ResetText();
            picBox.Image = picBox.InitialImage;
        }


        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    c.ResetText();
                }
            }
            btnThem.Enabled = true;
            picBox.Image = picBox.InitialImage;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            lwSanpham.Items.Clear();
            using (SqlConnection cnn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "timkiem_SP";
                    cmd.Parameters.AddWithValue("@Key ", txtTimKiem.Text);

                    cnn.Open();
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            ListViewItem item = new ListViewItem();
                            item.Text = dataReader["idSanpham"].ToString();
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["tenSanpham"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["sthetich"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["mota"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["iSoluongdaban"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["fGiaban"] + ""));
                            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dataReader["idLoaisanpham"] + ""));
                            lwSanpham.Items.Add(item);
                        }
                    }
                    cnn.Close();

                }
            }
        }

        private void btnHuysearch_Click(object sender, EventArgs e)
        {
            txtTimKiem.ResetText();
            lwSanpham.Items.Clear();
            load_Sanpham();
        }
    }
}
