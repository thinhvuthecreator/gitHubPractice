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

namespace shoppingGUI.NHANVIEN
{
    public partial class fNHANVIEN : Form
    {
        DTO.NHANVIEN nhanvienDTO = new DTO.NHANVIEN();
        NHANVIEN_CONTROLS nv = new NHANVIEN_CONTROLS();
        int flag;

        public fNHANVIEN()
        {
            InitializeComponent();
            prePareControl();
        }
          
           

        #region methods

        void prePareControl()
        {
            cbGioiTinhNV.Items.Add("Nam");
            cbGioiTinhNV.Items.Add("Nữ");

        }
        void getListNV()
        {
           
            dgvDanhSachNV.DataSource = nv.GetDuLieuNhanVien();
        }
        void binding()
        {
            tbMANV.DataBindings.Clear();
            tbMANV.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "MANV");

            tbTenNV.DataBindings.Clear();
            tbTenNV.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "TENNV");

            tbSDTNV.DataBindings.Clear();
            tbSDTNV.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "SDTNV");

            dtpNGSINHNV.DataBindings.Clear();
            dtpNGSINHNV.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "NGSINHNV");

            cbGioiTinhNV.DataBindings.Clear();
            cbGioiTinhNV.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "GIOITINHNV");

        }
        void en_dis(bool e)
        {
            tbMANV.Enabled = e;
            tbTenNV.Enabled = e;
            tbSDTNV.Enabled = e;
            dtpNGSINHNV.Enabled = e;
            cbGioiTinhNV.Enabled = e;
            btnSaveChangesNV.Enabled = e;
            btnCancelChangeNV.Enabled = e;
            btnAddNV.Enabled = !e;
            btnDeleteNV.Enabled = !e;
            btnUpdateNV.Enabled = !e;
        }
        void clearControls()
        {
            tbMANV.Text = "";
            tbTenNV.Text = "";
            tbSDTNV.Text = "";
            dtpNGSINHNV.Text = "";
        }
        int ConvertSDTNV(string text)
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
        DTO.NHANVIEN taoDuLieuNhanVien(DTO.NHANVIEN nhanvien)
        {

            nhanvien.MaNV = tbMANV.Text.Trim() ;
            nhanvien.TenNV = tbTenNV.Text.Trim();
            nhanvien.SoDienThoaiNV = tbSDTNV.Text;
            nhanvien.GioiTinhNV = cbGioiTinhNV.Text.Trim();
            nhanvien.NgSinhNV = DateTime.Parse(dtpNGSINHNV.Text);
            return nhanvien;
        }       

       
        #endregion

        /*******************************************************************************************************/

        #region event
        private void btnAddNV_Click(object sender, EventArgs e)
        {
            flag = 0;
            en_dis(true);
            clearControls();
           
        }           //ổn

        private void btnSaveChangesNV_Click(object sender, EventArgs e)
        {
            DTO.NHANVIEN nvDTO = taoDuLieuNhanVien(nhanvienDTO);    // nhân viên mới mang các dữ liệu nhập vào trên GUI
            en_dis(false);
            if (flag == 0) // thêm nhân viên này vào
            {
                if(nv.ThemNhanVien( nvDTO))
                {
                    MessageBox.Show("Thêm thành công !");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại !");
                    
                }
            }
            else   // sửa nhân viên đang hiển thị trên GUI
            {
                if(nv.UpdateNhanVien(nvDTO))
                {
                    MessageBox.Show("Cập nhật thành công !");
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại !");
                    
                }
            }
            fNHANVIEN_Load(sender, e);
        }       //ổn

        private void btnCancelChangeNV_Click(object sender, EventArgs e)
        {
           fNHANVIEN_Load(sender, e); // gọi event load() để reset lại nếu không muốn save changes
            en_dis(false);
        }        // xong

        private void btnUpdateNV_Click(object sender, EventArgs e)
        {
            flag = 1;
            en_dis(true);
            tbMANV.Enabled = false;
            
   
        }             //ổn
                
        private void btnDeleteNV_Click(object sender, EventArgs e)
        {
            DialogResult decision = MessageBox.Show("Bạn có chắc chắn muốn xóa không ? ","Cảnh báo", MessageBoxButtons.YesNo);
            if (decision == DialogResult.Yes)
            {
               if( nv.XoaNhanVien(tbMANV.Text))
                {
                    MessageBox.Show("Xóa thành công !");
                    fNHANVIEN_Load(sender, e);
                }
               else
                {
                    MessageBox.Show("Xóa thất bại !");
                }
            }
            else
            {

            }
           
        }           // ổn
        private void fNHANVIEN_Load(object sender, EventArgs e)
        {
            en_dis(false);
            getListNV();
            binding();
        }

        #endregion










    }

}
