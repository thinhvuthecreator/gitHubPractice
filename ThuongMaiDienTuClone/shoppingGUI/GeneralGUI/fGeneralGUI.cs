using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace shoppingGUI.GeneralGUI
{
    public partial class fGeneralGUI : Form
    {
        public fGeneralGUI()
        {
            InitializeComponent();
            
        }

        private void btnNHANVIEN_Click(object sender, EventArgs e)
        {
            shoppingGUI.NHANVIEN.fNHANVIEN formNV = new shoppingGUI.NHANVIEN.fNHANVIEN();
            formNV.Show();
        }

        private void btnKHACHHANG_Click(object sender, EventArgs e)
        {
            shoppingGUI.KHACHHANG.fKHACHHANG formKH = new shoppingGUI.KHACHHANG.fKHACHHANG();
            formKH.Show();
        }

        private void btnHANGHOA_Click(object sender, EventArgs e)
        {
            shoppingGUI.HANGHOA.fSANPHAM formSP = new shoppingGUI.HANGHOA.fSANPHAM();
            formSP.Show();
        }

        private void btnHOADON_Click(object sender, EventArgs e)
        {
            shoppingGUI.HOADON.fHOADON formHD = new shoppingGUI.HOADON.fHOADON();
            formHD.Show();
        }
    }
}
