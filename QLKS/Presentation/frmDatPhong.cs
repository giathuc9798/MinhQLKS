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

namespace QLKS.Presentation
{
    public partial class frmDatPhong : Form
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
        public frmDatPhong()
        {
            InitializeComponent();
        }

             private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmDatPhong_Load(object sender, EventArgs e)
        {

            if (!isAdd_)
            {
                var info = new DatPhongDAO().GetSingleByID(id_);
                txtMaDatPhong.Text = info.MaDatPhong.ToString();
                txtMaKH.Text = info.MaKH.ToString();
                txtMaPhong.Text = info.MaPhong.ToString();
                dtpNgayDen.Value = info.NgayDen.Value;
                dtpNgayDi.Value = info.NgayDi.Value;
                txtTinhTrang.Text = info.TinhTrang;
                txtThanhToan.Text = info.ThanhToan.ToString();
                txtChiPhiPhatSinh.Text = info.ChiPhiPhatSinh.ToString();

            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            DatPhongDAO dao = new DatPhongDAO();

            var info = InitInfo();

            if (isAdd_)
            {
                DatPhongDAO datPhongDAO = new DatPhongDAO();


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
        private DatPhong InitInfo()
        {
            DatPhong info = new DatPhong();
            info.MaDatPhong = int.Parse(txtMaDatPhong.Text.Trim());
            info.MaKH = int.Parse(txtMaKH.Text.Trim());
            info.MaPhong = int.Parse(txtMaPhong.Text.Trim());
            info.NgayDen = dtpNgayDen.Value;
            info.NgayDi = dtpNgayDi.Value;
            info.TinhTrang = txtTinhTrang.Text.Trim();
            info.ThanhToan = int.Parse(txtThanhToan.Text.Trim());
            info.ChiPhiPhatSinh = int.Parse(txtChiPhiPhatSinh.Text.Trim());
           
            return info;
        }

        private void txtMaKH_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void txtMaKH_Click(object sender, EventArgs e)
        {
            frmDatPhong_KhachHang frm = new frmDatPhong_KhachHang();
            frm.ShowDialog();
            txtMaKH.Text = frm.MaKHs.ToString();
            textBox1.Text = frm.HoTens;
        }

        private void cbbMaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
