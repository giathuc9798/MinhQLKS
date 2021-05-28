using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKS.Presentation;

namespace QLKS
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void AddScreen(Control control)
        {
            pnMain.Controls.Clear();
            pnMain.Controls.Add(control);
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            AddScreen(new Presentation.FPhong.ucPhong());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddScreen(new Presentation.FKhachHang.ucKhachHang());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmDatPhong frm = new frmDatPhong();
            frm.ShowDialog();
            
        }

        private void btnListDatPhong_Click(object sender, EventArgs e)
        {
            AddScreen(new Presentation.ucListDatPhong());
        }
    }
}
