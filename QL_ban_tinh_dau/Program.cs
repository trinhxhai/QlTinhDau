using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_ban_tinh_dau
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login());

            Login frmLogin = new Login();
            Application.Run(frmLogin);
            if (frmLogin.IsLogin == true)
            {
                Application.Run(new MainForm());
            }
        }
    }
}
