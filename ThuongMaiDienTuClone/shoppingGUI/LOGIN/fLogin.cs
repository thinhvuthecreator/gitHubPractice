using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
namespace shoppingGUI
{
    public partial class fLogin : Form
    {
  
        public fLogin()
        {
            InitializeComponent();
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
          if (tbPassword.Text == null || tbUsername.Text == null)
            {
                MessageBox.Show("vui lòng điền đầy đủ thông tin !");
            }
          else
            {
                if (login(tbUsername.Text,tbPassword.Text))
                {
                    // show form lên !
                }
                else
                {
                    MessageBox.Show("tài khoản hoặc mật khẩu không chính xác !");
                }
            }
        }
        private bool login(string tk, string mk)
        {
            return connectSQLDatabse.Instance.Login(tk, mk);
        }


    }
}
