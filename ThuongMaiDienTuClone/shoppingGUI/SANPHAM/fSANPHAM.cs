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
using Controls;
namespace shoppingGUI.HANGHOA
{
    public partial class fSANPHAM : Form
    {
        int choice;
        SANPHAM_CONTROLS spControl = new SANPHAM_CONTROLS();
        SANPHAM spDTO = new SANPHAM();
        public fSANPHAM()
        {
            InitializeComponent();
            prePareControl();
           
        }

        #region methods
        void prePareControl()
        {
            cbLoaiSP.Items.Add("Lương thực thực phẩm");
            cbLoaiSP.Items.Add("Trang trí");
            cbLoaiSP.Items.Add("Nội thất");
            cbLoaiSP.Items.Add("Vật dụng gia đình");
            cbLoaiSP.Items.Add("Vật dụng vệ sinh");
            cbLoaiSP.Items.Add("Quần áo");
            cbLoaiSP.Items.Add("Thực phẩm chức năng");
            cbLoaiSP.Items.Add("Dụng cụ học tập");
        }
        void end_dis(bool e)
        {
            tbMASP.Enabled = e;
            tbTenSP.Enabled = e;
            cbLoaiSP.Enabled = e;
            tbGiaSP.Enabled = e;
            btnSaveChangesSP.Enabled = e;
            btnCancelChangeSP.Enabled = e;
            btnAddSP.Enabled = !e;
            btnUpdateSP.Enabled = !e;
            btnDeleteSP.Enabled = !e;
        }
        void prePareForm()
        {
            dgvDanhSachSP.DataSource = spControl.sanphamSelect();
        }
        void binding()
        {
            tbMASP.DataBindings.Clear();
            tbMASP.DataBindings.Add("Text", dgvDanhSachSP.DataSource, "MASP");
            tbTenSP.DataBindings.Clear();
            tbTenSP.DataBindings.Add("Text", dgvDanhSachSP.DataSource, "TENSP");
            tbGiaSP.DataBindings.Clear();
            tbGiaSP.DataBindings.Add("Text", dgvDanhSachSP.DataSource, "GIA");
            cbLoaiSP.DataBindings.Clear();
            cbLoaiSP.DataBindings.Add("Text", dgvDanhSachSP.DataSource, "LOAISANPHAM");
        }

        SANPHAM taoDuLieuSanPham(SANPHAM sp)
        {
            sp.MaSP = tbMASP.Text.Trim();
            sp.TenSP = tbTenSP.Text.Trim();
            sp.GiaSP = tbGiaSP.Text.Trim();
            sp.LoaiSanPham = cbLoaiSP.Text;
            return sp;
        }
        void clearcontrols()
        {
            tbMASP.Text = "";
            tbTenSP.Text = "";
            tbGiaSP.Text = "";
        }
            

        #endregion
        /****************************************************************/
        #region events
        private void fSANPHAM_Load(object sender, EventArgs e)
        {
            end_dis(false);
            prePareForm();
            binding();
        }

        private void btnAddSP_Click(object sender, EventArgs e)
        {
            choice = 0;
            end_dis(true);
            clearcontrols();
        }

        private void btnUpdateSP_Click(object sender, EventArgs e)
        {
            choice = 1;
            end_dis(true);
            tbMASP.Enabled = false;
        }

        private void btnDeleteSP_Click(object sender, EventArgs e)
        {
            DialogResult decicion = MessageBox.Show("Bạn có chắc chắn muốn xóa không ? ", "", MessageBoxButtons.YesNo);
            if (decicion == DialogResult.Yes)
            {
                if (spControl.deleteSP(tbMASP.Text))
                {
                    MessageBox.Show("Xóa thành công !");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại !");
                }
            }
            else { }
            fSANPHAM_Load(sender, e);
        }

        private void btnSaveChangesSP_Click(object sender, EventArgs e)
        {
            SANPHAM sp = taoDuLieuSanPham(spDTO);
            if (choice == 0) //thêm
            {
              
                    if (spControl.themSP(sp))
                    {
                        MessageBox.Show("Thêm thành công !");
                    }
                
                    else
                    {
                    MessageBox.Show("Thêm thất bại !");
                    }
            }
            else   // sửa
            {
              
                    if (spControl.updateSP(sp))
                    {
                        MessageBox.Show("Cập nhật thành công !");
                    }
                    else
                    { 
                
                      MessageBox.Show("Cập nhật thất bại !");
                    }
            }
            fSANPHAM_Load(sender, e);
        }
        
        private void btnCancelChangeSP_Click(object sender, EventArgs e)
        {
            end_dis(false);
            fSANPHAM_Load(sender, e);
        }


        #endregion

       
    }
}
