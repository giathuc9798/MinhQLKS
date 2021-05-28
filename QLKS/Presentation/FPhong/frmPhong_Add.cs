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

namespace QLKS.Presentation.FPhong
{

    public partial class frmPhong_Add : Form
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
        public frmPhong_Add()
        {
            InitializeComponent();
        }
        private void frmPhong_Add_Load(object sender, EventArgs e)
        {
            
            if (!isAdd_)
            {
                var info = new PhongDAO().GetSingleByID(id_);

                txtMaPhong.Text = info.MaPhong.ToString();
                txtSoPhong.Text = info.SoPhong;
                txtGiaPhong.Text = info.GiaPhong.ToString();
                txtLoaiPhong.Text = info.LoaiPhong;
                ckbTinhTrang.Checked = (bool)info.TinhTrang;
              
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

       
        private void btnSave_Click(object sender, EventArgs e)
        {
            PhongDAO dao = new PhongDAO();
            var info = InitInfo();

            if (isAdd_)
            {
                PhongDAO hocKiDAO = new PhongDAO();

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
        private Phong InitInfo()
        {
            Phong info = new Phong();
            info.MaPhong = int.Parse(txtMaPhong.Text.Trim());
            info.SoPhong = txtSoPhong.Text.Trim();
            info.GiaPhong = int.Parse(txtGiaPhong.Text.Trim());
            info.LoaiPhong = txtLoaiPhong.Text.Trim();
            info.TinhTrang = ckbTinhTrang.Checked;

            return info;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
