using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKS.DAO;
using QLKS.Model;

namespace QLKS.Presentation.FKhachHang
{
    public partial class frmKhachHang_Add : Form
    {
        private bool isAdd_ = false;
        public bool IsAdd
        {
            set
            {
                isAdd_ = value;
            }
        }

        private int id_;
        public int ID
        {
            set
            {
                id_ = value;
            }
        }

        private bool result_ = false;
        public bool Result
        {
            get
            {
                return result_;
            }
        }
        private void frmKhachHang_Add_Load(object sender, EventArgs e)
        {
            txtMaKH.Enabled = false;

            if (!isAdd_)
            {
                var info = new KhachHangDAO().GetSingleByID(id_);
                txtMaKH.Text = info.MaKH.ToString();
                txtTenKhachHang.Text = info.TenKH;
                dtpNgaySinh.Text = info.NgaySinh.ToString();
                ckbGioiTinh.Checked = (bool)info.GioiTinh;
                txtCMT.Text = info.CMT;
                txtSDT.Text = info.SDT;
                txtNgheNghiep.Text = info.NgheNghiep;
                txtQuocTich.Text = info.QuocTich;
                              
            }
        }
        public frmKhachHang_Add()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            KhachHangDAO dao = new KhachHangDAO();

            var info = InitInfo();

            if (isAdd_)
            {
                KhachHangDAO hocKiDAO = new KhachHangDAO();
               
                if (dao.Add(info))
                {
                    MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    result_ = true;
                }
                else
                {
                    MessageBox.Show("Thêm mới thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (dao.Edit(info))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    result_ = true;
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (result_)
            {
                this.Close();
            }
        }
        private KhachHang InitInfo()
        {
            KhachHang info = new KhachHang();
            info.MaKH = int.Parse(txtMaKH.Text.Trim());
            info.TenKH = txtTenKhachHang.Text.Trim();
            info.NgaySinh = dtpNgaySinh.Value;
            info.GioiTinh = ckbGioiTinh.Checked;
            info.CMT = txtCMT.Text.Trim();
            info.SDT = txtSDT.Text.ToString().Trim();
            info.NgheNghiep = txtNgheNghiep.Text.Trim();
            info.QuocTich = txtQuocTich.Text.Trim();
            

            return info;
        }

        private void txtNgheNghiep_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCMT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenKhachHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuocTich_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
