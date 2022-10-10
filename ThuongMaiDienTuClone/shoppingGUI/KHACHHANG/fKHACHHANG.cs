using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAL;
using Controls;

namespace shoppingGUI.KHACHHANG
{
    public partial class fKHACHHANG : Form
    {
        int choice;
        DTO.KHACHHANG khDTO = new DTO.KHACHHANG();
        KHACHHANG_CONTROLS khControl = new KHACHHANG_CONTROLS();
        public fKHACHHANG()
        {
            
            InitializeComponent();
            prePareControls();
        }

        #region methods
        void prePareControls()
        {
            cbGioiTinhKH.Items.Add("Nam");
            cbGioiTinhKH.Items.Add("Nữ");
         
        }
        void prePareForm()
        {
            dgvDanhSachKH.DataSource = connectSQLDatabse.Instance.ExecuteSQL("EXEC KhachHangSelect");
        }
            
        void en_dis(bool e)
        {
            tbMAKH.Enabled = e;
            tbTenKH.Enabled = e;
            tbSDTKH.Enabled = e;
            dtpNGSINHKH.Enabled = e;
            cbGioiTinhKH.Enabled = e;
            btnSaveChangesKH.Enabled = e;
            btnCancelChangeKH.Enabled = e;
            btnAddKH.Enabled = !e;
            btnDeleteKH.Enabled = !e;
            btnUpdateKH.Enabled = !e;
        }


        void binding()
        {
            tbMAKH.DataBindings.Clear();
            tbMAKH.DataBindings.Add("Text", dgvDanhSachKH.DataSource, "MAKH");

            tbTenKH.DataBindings.Clear();
            tbTenKH.DataBindings.Add("Text", dgvDanhSachKH.DataSource, "TENKH");

            tbSDTKH.DataBindings.Clear();
            tbSDTKH.DataBindings.Add("Text", dgvDanhSachKH.DataSource, "SDT");

            dtpNGSINHKH.DataBindings.Clear();
            dtpNGSINHKH.DataBindings.Add("Text", dgvDanhSachKH.DataSource, "NGSINH");

            cbGioiTinhKH.DataBindings.Clear();
            cbGioiTinhKH.DataBindings.Add("Text", dgvDanhSachKH.DataSource, "GIOITINH");

        }

        void clearControls()
        {
            tbMAKH.Text = "";
            tbTenKH.Text = "";
            tbSDTKH.Text = "";
            dtpNGSINHKH.Text = "";
        }

        int ConvertSDTKH(string text)
        {
            try
            {
                return int.Parse(text);
            }
            catch
            {
                MessageBox.Show("Số điện thoại không hợp lệ !");
                return -1;
            }

        }
        DTO.KHACHHANG taoDuLieuKhachHang(DTO.KHACHHANG khachhang)
        {

            khachhang.MaKH = tbMAKH.Text.Trim();
            khachhang.TenKH = tbTenKH.Text.Trim();
            khachhang.SoDienThoaiKH = tbSDTKH.Text.Trim();
            khachhang.GioiTinhKH = cbGioiTinhKH.Text.Trim();
            khachhang.NgSinhKH = DateTime.Parse(dtpNGSINHKH.Text);
            return khachhang;
        }

        #endregion

        /***********************************************************************/
        #region events
        private void fKHACHHANG_Load(object sender, EventArgs e)
        {
            prePareForm();
            en_dis(false);
            binding();
        }
        private void btnAddKH_Click(object sender, EventArgs e)
        {
            choice = 0;
            en_dis(true);
            clearControls();
        }
        private void btnUpdateKH_Click(object sender, EventArgs e)
        {
            choice = 1;
            en_dis(true);
            tbMAKH.Enabled = false;
        }
        private void btnDeleteKH_Click(object sender, EventArgs e)
        {
            DialogResult decision = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "", MessageBoxButtons.YesNo);
            if(decision == DialogResult.Yes)
            {
                if(khControl.XoaKhachHang(tbMAKH.Text))
                {
                    MessageBox.Show("Xóa thành công !");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại !");
                }
            }
            else
            {
               
            } // không làm gì
            fKHACHHANG_Load(sender, e);
        }
        private void btnSaveChangesKH_Click(object sender, EventArgs e)
        {
            DTO.KHACHHANG khachhang = taoDuLieuKhachHang(khDTO);
            if(choice == 0)  //thêm khách hàng
            {
                if(khControl.ThemKhachHang(khachhang))
                {
                    MessageBox.Show("Thêm thành công !");
                }
                else
                {
                    MessageBox.Show("Thêm thát bại !");
                }
            }
            else
            {
                if (khControl.UpdateKhachHang(khachhang))
                {

                    MessageBox.Show("Cập nhật thành công !");
                }
                else
                {
                    MessageBox.Show("Cập nhật thát bại !");
                }
            }
            fKHACHHANG_Load(sender, e);
            en_dis(false);
        }
        private void btnCancelChangeKH_Click(object sender, EventArgs e)
        {
            fKHACHHANG_Load(sender, e);
        }

        #endregion
       





    }
}
