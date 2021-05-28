using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKS.DAO;
using QLKS.Model;

namespace QLKS.Presentation.FKhachHang
{
    public partial class ucKhachHang : UserControl
    {
        public ucKhachHang()
        {
            InitializeComponent();
        }
        private void ucKhachHang_Load(object sender, EventArgs e)
        {

            this.Dock = DockStyle.Fill;

            LoadData();
        }
        private void LoadData()
        {
           KhachHangDAO dao = new KhachHangDAO();

            List<KhachHang> list = dao.GetAll();
            dgvKhachHang.DataSource = dao.GetAll();


            if (list.Count > 0)
            {
                EnableButton(true, true, true);
            }
            else
            {
                EnableButton(true, false, false);
            }


        }
        private void EnableButton(bool isAdd, bool isEdit, bool isDelete)
        {
            btnAdd.Enabled = isAdd;
            btnEdit.Enabled = isEdit;
            btnDelete.Enabled = isDelete;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmKhachHang_Add frm = new frmKhachHang_Add();
            frm.IsAdd = true;
            frm.ShowDialog();
            if (frm.Result)
            {
                LoadData();
            }
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvKhachHang_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            frmKhachHang_Add frm = new frmKhachHang_Add();
            frm.ID = int.Parse(dgvKhachHang.CurrentRow.Cells["MaKH"].Value.ToString());
            frm.IsAdd = false;
            frm.ShowDialog();

            if (frm.Result)
            {
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvKhachHang.CurrentRow.Cells["MaKH"].Value.ToString());

            KhachHangDAO dao = new KhachHangDAO();

            if (dao.Delete(id))
            {
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
