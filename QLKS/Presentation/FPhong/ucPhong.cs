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
using QLKS.Presentation;

namespace QLKS.Presentation.FPhong
{
    public partial class ucPhong : UserControl
    {
        public ucPhong()
        {
            InitializeComponent();
        }
        private void ucPhong_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;

            LoadData();
        }
        private void LoadData()
        {
            PhongDAO dao = new PhongDAO();

            List<Phong> list = dao.GetAll();
            dgvPhong.DataSource = dao.GetAll();


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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmPhong_Add frm = new frmPhong_Add();
            frm.IsAdd = true;
            frm.ShowDialog();

            if (frm.Result)
            {
                LoadData();
            }
        }

        private void dgvPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmPhong_Add frm = new frmPhong_Add();
            frm.ID = int.Parse(dgvPhong.CurrentRow.Cells["MaPhong"].Value.ToString());
            frm.IsAdd = false;
            frm.ShowDialog();

            if (frm.Result)
            {
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvPhong.CurrentRow.Cells["MaPhong"].Value.ToString());

            PhongDAO dao = new PhongDAO();

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
