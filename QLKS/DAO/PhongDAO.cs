using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKS.Model;

namespace QLKS.DAO
{
    public class PhongDAO : BaseDAO
    {       
        public List<Phong> GetAll()
        {
            return db_.Phongs.ToList();
        }

        public Phong GetSingleByID(int maPhong)
        {
            return db_.Phongs.Where(t => t.MaPhong == maPhong).FirstOrDefault();
        }

        public List<Phong> GetByKeyword(string keyword)
        {
            return db_.Phongs.Where(t => t.MaPhong.ToString().Contains(keyword)).ToList();
        }

        public bool Add(Phong Phong)
        {
            try
            {
                db_.Phongs.Add(Phong);

                db_.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            return true;
        }

        public bool Edit(Phong phong)
        {
            try
            {
                var ef = GetSingleByID(phong.MaPhong);

                if (ef != null)
                {

                    ef.SoPhong = phong.SoPhong;
                    ef.GiaPhong = phong.GiaPhong;
                    ef.LoaiPhong = phong.LoaiPhong;
                    ef.TinhTrang = phong.TinhTrang;
                  
                    db_.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Đối tượng không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            return true;
        }

        public bool Delete(int maPhong)
        {
            try
            {
                var ef = GetSingleByID(maPhong);

                if (ef != null)
                {
                    db_.Phongs.Remove(ef);
                    db_.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            return true;
        }
    }
}
