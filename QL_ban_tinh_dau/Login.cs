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
    public partial class Login : Form
    {
        public static String conStr = ConfigurationManager.ConnectionStrings["data_base"].ConnectionString.ToString();

        public bool IsLogin { get; private set; }

        public Login()
        {
            InitializeComponent();
        }

     
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tbl_nhanvien where tenTaiKhoanNV ='" + txtTenTaiKhoan.Text + "' and matKhau='" + txtMatKhau.Text + "'", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.Read() == true)
                    {
                        //MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);      
                        IsLogin = true;
                        GlobalValue.FullName = dataReader["tenNV"].ToString();
                        GlobalValue.NhanVienId = int.Parse(dataReader["id_NV"].ToString());
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập không thành công, hãy thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    conn.Close();
                }
            }


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
