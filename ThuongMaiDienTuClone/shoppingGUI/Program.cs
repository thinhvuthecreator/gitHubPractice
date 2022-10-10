using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using shoppingGUI.HOADON;
using shoppingGUI.KHACHHANG;
using shoppingGUI.HANGHOA;
using shoppingGUI.NHANVIEN;
using shoppingGUI.GeneralGUI;

namespace shoppingGUI
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
            Application.Run(new fGeneralGUI());
        }
    }
}
