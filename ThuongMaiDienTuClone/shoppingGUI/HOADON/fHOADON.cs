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
using DTO;
using Controls;


namespace shoppingGUI.HOADON
{
    public partial class fHOADON : Form
    {
        #region controls
        KHACHHANG_CONTROLS khControls = new KHACHHANG_CONTROLS();
        SANPHAM_CONTROLS spControls = new SANPHAM_CONTROLS();
        HOADON_CONTROLS hdControls = new HOADON_CONTROLS();
        NHANVIEN_CONTROLS nvControls = new NHANVIEN_CONTROLS();
        CHITIETHOADON_CONTROLS cthdControls = new CHITIETHOADON_CONTROLS();
        #endregion
        #region DTO
        DTO.CHITIETHOADON cthdDTO = new DTO.CHITIETHOADON();
        DataTable dt = new DataTable();
        DTO.HOADON hdDTO = new DTO.HOADON();
        #endregion
        public fHOADON()
        {
            InitializeComponent();
            taoDatatableTam();
            
        }



        #region methods
        int ConvertStringtoInt(string text)
        {
            try
            {
                return Convert.ToInt32(text);
            }
            catch
            {
                return -1;
            }
        }
        int tinhTongGiaHD(DataTable cthd)
        {
            int tongGia = 0;
            for (int i = 0; i < cthd.Rows.Count; i++)
            {
                tongGia +=  ( int.Parse(cthd.Rows[i][3].ToString()) * int.Parse(cthd.Rows[i][4].ToString()) );
            }
            return tongGia;
        }
        void xoaDataSanPham(string maSP)
        {
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                if(maSP == dt.Rows[i][1].ToString())
                {
                    dt.Rows[i].Delete();
                    dgvDSHH.DataSource = dt;
                }
            }
        }
        void getDuLieuHD()
        {
            dgvDSHD.DataSource = hdControls.getDuLieuHoaDon();
           
        }
        void binding()
        {
            tbMAHD.DataBindings.Clear();
            tbMAHD.DataBindings.Add("Text", dgvDSHD.DataSource, "MAHD");
            dtpNgayHD.DataBindings.Clear();
            dtpNgayHD.DataBindings.Add("Text", dgvDSHD.DataSource, "NGHD");

            cbKHHD.DataBindings.Clear();
            cbKHHD.DataBindings.Add("Text", dgvDSHD.DataSource, "TENKH");

            cbNVHD.DataBindings.Clear();
            cbNVHD.DataBindings.Add("Text", dgvDSHD.DataSource, "TENNV");
        }
        void bindingCTHD()
        {
            
            cbSanPhaminHoaDon.DataBindings.Clear();
            cbSanPhaminHoaDon.DataBindings.Add("Text", dgvDSHH.DataSource, "TENSP");
            tbSLSPHD.DataBindings.Clear();
            tbSLSPHD.DataBindings.Add("Text", dgvDSHH.DataSource, "SOLUONG");
           
        }
        void end_dis(bool e)
        {
            tbMAHD.Enabled = e;
            cbKHHD.Enabled = e;
            cbNVHD.Enabled = e;
            dtpNgayHD.Enabled = e;
            btnSaveChanges.Enabled = e;
            btnCancelChanges.Enabled = e;
            btnAddHD.Enabled = !e;
            btnDeleteHD.Enabled = !e;
            cbSanPhaminHoaDon.Enabled = e;
            dgvDSHD.Enabled = !e;
            tbSLSPHD.Enabled = e;
            btnAddSPCTHD.Enabled = e;
            btnReduceSP.Enabled = e;
         
          
           
        }
        void prePareForm()
        {
            string stringQuerry = "SELECT GIA FROM SANPHAM WHERE MASP = N'"+ cbSanPhaminHoaDon.SelectedValue +"'";

            cbKHHD.DataSource = khControls.GetDuLieuKhachhang();
            cbKHHD.DisplayMember = "TENKH";
            cbKHHD.ValueMember = "MAKH";
           

            cbNVHD.DisplayMember = "TENNV";
            cbNVHD.ValueMember = "MANV";
            cbNVHD.DataSource = nvControls.GetDuLieuNhanVien();

            cbSanPhaminHoaDon.DisplayMember = "TENSP";
            cbSanPhaminHoaDon.ValueMember = "MASP";
            cbSanPhaminHoaDon.DataSource = spControls.sanphamSelect();
           
            

            tbTongGia.Enabled = false;
            
        }
        void clearControls()
        {
            cbSanPhaminHoaDon.SelectedIndex = 0;
            tbSLSPHD.Text = "";
            tbMAHD.Text = "";
            tbTongGia.Text = 0.ToString();
            dtpNgayHD.Value = DateTime.Now;
        }
        void taoDataTable()
        {
            DataTable dtSP = connectSQLDatabse.Instance.ExecuteSQL("SELECT GIA PRICE FROM SANPHAM WHERE MASP = N'" + cbSanPhaminHoaDon.SelectedValue + "'");
            int dr3;
            if (checkTrungMAHD(cbSanPhaminHoaDon.SelectedValue.ToString(),dt)) //có trùng
            {
                UpdateGiaCTHD(cbSanPhaminHoaDon.SelectedValue.ToString(), int.Parse(tbSLSPHD.Text));
            }
            else  // không trùng
            {
                DataRow dr = dt.NewRow();
                dr[0] = tbMAHD.Text.Trim();
                dr[1] = cbSanPhaminHoaDon.SelectedValue;
                dr[2] = cbSanPhaminHoaDon.Text;
                if( int.TryParse(tbSLSPHD.Text,out dr3) && ( int.Parse(tbSLSPHD.Text) >= 0))
                {
                    dr[3] = tbSLSPHD.Text;
                }
                else
                {
                    dr[3] = "Lỗi dữ liệu";
                }
                
                dr[4] = dtSP.Rows[0][0];
                dt.Rows.Add(dr);
                dgvDSHH.DataSource = dt;

            }





        }
        void UpdateGiaCTHD(string maSP,int sl )
        {
            for(int i = 0; i < dt.Rows.Count;i++)
            {
                if(dt.Rows[i][1].ToString() == maSP)
                {
                    int SL = int.Parse(dt.Rows[i][3].ToString());
                    dt.Rows[i][3] = SL + sl; 
                }
            }
        }
        void taoDatatableTam()
        {
            dt.Columns.Add("mahd");
            dt.Columns.Add("masp");
            dt.Columns.Add("tensp");
            dt.Columns.Add("soluong");
            dt.Columns.Add("gia");
        }
        bool checkTrungMAHD(string maSP,DataTable dt)
        {
            for(int i = 0; i < dt.Rows.Count;i++)
            {
                if(maSP == dt.Rows[i][1].ToString())
                {
                    return true;
                }
               
            }
            return false;
        }
        bool InsertDuLieuCTHD()
        {
            try
            {
                bool check = true;
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    if (cthdControls.addCTHD(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), int.Parse(dt.Rows[i][3].ToString())))
                    {

                    }
                    else
                    {
                        check = false;
                    }
                }
                return check;
            }
            catch
            {
                hdControls.xoaHD(tbMAHD.Text);
                getDuLieuHD();
                dt.Clear();
                return false;
            }
            
        }
        bool checkTrungMAHD(string maHD)
        {
            for (int i = 0; i < dt.Rows.Count;i++)
            {
                if(maHD == dt.Rows[i][0].ToString())
                {
                    return true;
                }
            }
            return false;
        }
        DTO.HOADON ganDuLieuHD(DTO.HOADON hd)
        {
            
            hd.MaHD = tbMAHD.Text.Trim();
            hd.MAKH = cbKHHD.SelectedValue.ToString();
            hd.MANV = cbNVHD.SelectedValue.ToString();
            hd.NgayHD = Convert.ToDateTime(dtpNgayHD.Text);
            return hd;

        }
        DTO.CHITIETHOADON gandulieuCTHD(DTO.CHITIETHOADON cthd)
        {
            cthd.MaHD1 = tbMAHD.Text.Trim();
            cthd.MaSP1 = cbSanPhaminHoaDon.SelectedValue.ToString().Trim();
            cthd.SoLuong =  ConvertStringtoInt(tbSLSPHD.Text.Trim());
            return cthd;
        }
           
        #endregion
            

        #region Events
        private void btnAddHD_Click(object sender, EventArgs e)
        {
            dt.Clear();           
            end_dis(true);
            clearControls();
            dtpNgayHD.Enabled = false;
        }
        private void fHOADON_Load(object sender, EventArgs e)
        {
            dtpNgayHD.Value = DateTime.Now;
            getDuLieuHD();
            end_dis(false);
            prePareForm();
            binding();
           
           
        }
        private void tbMAHD_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtt = new DataTable();
                dtt = cthdControls.getDuLieuCTHD(tbMAHD.Text.Trim()) ;
                dgvDSHH.DataSource = dtt;
                bindingCTHD();
                tbTongGia.Text = tinhTongGiaHD(cthdControls.getDuLieuCTHD(tbMAHD.Text.Trim())).ToString() + " VND";
            }
            catch
            {
               // dgvDSHD.DataSource = null;
            }
           
        }
        private void btnDeleteHD_Click(object sender, EventArgs e)
        {
            DialogResult decision = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này không ? ", "", MessageBoxButtons.YesNo);
            if (decision == DialogResult.Yes)
            {
                if ( hdControls.xoaHD(tbMAHD.Text))
                {
                    MessageBox.Show("Xóa hóa đơn thành công !");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại !");
                }
                fHOADON_Load(sender, e);
            }
            else { }
            
        }
        private void btnCancelChanges_Click(object sender, EventArgs e)
        {
            end_dis(false);
            fHOADON_Load(sender, e);
        }
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            end_dis(false);
            DTO.HOADON hoadon = ganDuLieuHD(hdDTO);
            DTO.CHITIETHOADON chiTietHoaDon = gandulieuCTHD(cthdDTO);
            if(hdControls.themHD(hoadon) && InsertDuLieuCTHD())
            {
                MessageBox.Show("Thêm hóa đơn thành công !");
            }
            else
            {
                MessageBox.Show("Thêm hóa đơn thất bại !");
            }
            fHOADON_Load(sender, e);
        }
        private void btnAddSPCTHD_Click(object sender, EventArgs e)
        {

            if(!string.IsNullOrEmpty(tbMAHD.Text))  // nếu null hoặc empty trả về 1 , nếu k thì trả về 0
            {
                try
                {


                    taoDataTable();
                    tbTongGia.Text = tinhTongGiaHD(dt).ToString() + " VND";

                }
                catch
                {
                    MessageBox.Show("Lỗi dữ liệu ! Vui lòng bỏ sản phẩm và nhập mới sản phẩm có số lượng lớn hơn 0 !");
                }
                
            }
            else
            {
                MessageBox.Show("mã hóa đơn không được để trống !");
                tbMAHD.Focus();
            }
        }
        private void btnReduceSP_Click(object sender, EventArgs e)
        {
            xoaDataSanPham(cbSanPhaminHoaDon.SelectedValue.ToString());
            tbTongGia.Text = tinhTongGiaHD(dt).ToString() + " VND";

        }


        #endregion






         










    }
}
