using QLKS.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS.Presentation
{
    public partial class frmDatPhong_KhachHang : Form
    {
        private int maKH_;
        public int MaKHs
        {
            get
            {
                return maKH_;
            }
        }

        private string hoTen_;
        public string HoTens
        {
            get
            {
                return hoTen_;
            }
        }

        public frmDatPhong_KhachHang()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            KhachHangDAO dao = new KhachHangDAO();

            dataGridView1.DataSource = dao.GetAll()
                .Select(t => new
                {
                    MaKH = t.MaKH,
                    TenKH = t.TenKH,
                    SDT = t.SDT,
                    CMT = t.CMT
                }).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                maKH_ = int.Parse(dataGridView1.CurrentRow.Cells["MaKH"].Value.ToString());
                hoTen_ = dataGridView1.CurrentRow.Cells["TenKH"].Value.ToString();
                this.Close();
            }
        }

        private void frmDatPhong_KhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
