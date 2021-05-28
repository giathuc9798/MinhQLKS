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

namespace QLKS.Presentation
{
    public partial class ucListDatPhong : UserControl
    {
        public ucListDatPhong()
        {
            InitializeComponent();
        }

        private void ucListDatPhong_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;

            LoadData();
        }
        private void LoadData()
        {
            DatPhongDAO dao = new DatPhongDAO();

            List<DatPhong> list = dao.GetAll();
            dgvListDatPhong.DataSource = dao.GetAll();


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
            frmDatPhong frm = new frmDatPhong();
            frm.IsAdd = true;
            frm.ShowDialog();

            if (frm.Result)
            {
                LoadData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmDatPhong frm = new frmDatPhong();
            frm.ID = int.Parse(dgvListDatPhong.CurrentRow.Cells["MaDatPhong"].Value.ToString());
            frm.IsAdd = false;
            frm.ShowDialog();

            if (frm.Result)
            {
                LoadData();
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvListDatPhong.CurrentRow.Cells["MaDatPhong"].Value.ToString());

            DatPhongDAO dao = new DatPhongDAO();

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
