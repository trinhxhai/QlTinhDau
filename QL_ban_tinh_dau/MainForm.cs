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
    public partial class MainForm : Form
    {
        public static MainForm mainform;
        public static bool NeedToClose = false;

        public MainForm()
        {
            InitializeComponent();
            mainform = this;
        }

        private void QLNhanVienForm(object sender, EventArgs e)
        {
            QLNhanVienForm qlNhanVienForm = new QLNhanVienForm();
            this.Hide();
            qlNhanVienForm.ShowDialog();

            qlNhanVienForm.FormClosed += CloseMain;
            NeedToClose = true;
            qlNhanVienForm.ShowDialog();
        }

        private void btnQLloaiSP_Click(object sender, EventArgs e)
        {
            QLLoaisanphamForm qlLoaisanphamForm = new QLLoaisanphamForm();
            this.Hide();

            qlLoaisanphamForm.FormClosed += CloseMain;
            NeedToClose = true;
            qlLoaisanphamForm.ShowDialog();

        }

        private void btnQLKhachHang_Click(object sender, EventArgs e)
        {
            QLKhachHangForm qlKhachhangForm = new QLKhachHangForm();
            this.Hide();

            qlKhachhangForm.FormClosed += CloseMain;
            NeedToClose = true;
            qlKhachhangForm.ShowDialog();
        }

        private void btnQLsanpham_Click(object sender, EventArgs e)
        {
            QLSanphamForm qlSanphamForm = new QLSanphamForm();
            this.Hide();

            qlSanphamForm.FormClosed += CloseMain;
            NeedToClose = true;
            qlSanphamForm.ShowDialog();
        }

        private void btnQLHoaDon_Click(object sender, EventArgs e)
        {
            QLHoaDonForm qlHDform = new QLHoaDonForm();
            this.Hide();

            qlHDform.FormClosed += CloseMain;
            NeedToClose = true;
            qlHDform.ShowDialog();
        }

        public void CloseMain(object sender, EventArgs e)
        {
            if (NeedToClose)
            {
                this.Close();
            }
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn đăng xuất?", "Thông báo?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Restart();

            }
            else return;
            /*this.Hide();
            Login lg = new Login();
            lg.ShowDialog();*/
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
