using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKS.Model;

namespace QLKS.DAO
{
    public class DatPhongDAO : BaseDAO
    {
        public List<DatPhong> GetAll()
        {
            return db_.DatPhongs.ToList();
        }

        public DatPhong GetSingleByID(int maDatPhong)
        {
            return db_.DatPhongs.Where(t => t.MaDatPhong == maDatPhong).FirstOrDefault();
        }

        public List<DatPhong> GetByKeyword(string keyword)
        {
            return db_.DatPhongs.Where(t => t.MaDatPhong.ToString().Contains(keyword)).ToList();
        }

        public bool Add(DatPhong datPhong)
        {
            try
            {
                db_.DatPhongs.Add(datPhong);

                db_.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            return true;
        }

        public bool Edit(DatPhong datPhong)
        {
            try
            {
                var ef = GetSingleByID(datPhong.MaDatPhong);

                if (ef != null)
                {
                    ef.MaKH = datPhong.MaKH;
                    ef.MaPhong = datPhong.MaPhong;
                    ef.NgayDen = datPhong.NgayDen;
                    ef.NgayDi = datPhong.NgayDi;
                    ef.TinhTrang = datPhong.TinhTrang;
                    ef.ThanhToan = datPhong.ThanhToan;
                    ef.ChiPhiPhatSinh = datPhong.ChiPhiPhatSinh;

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

        public bool Delete(int MaDatPhong)
        {
            try
            {
                var ef = GetSingleByID(MaDatPhong);

                if (ef != null)
                {
                    db_.DatPhongs.Remove(ef);
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
