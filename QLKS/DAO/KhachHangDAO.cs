using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKS.Model;

namespace QLKS.DAO
{
    public class KhachHangDAO : BaseDAO
    {
        public List<KhachHang> GetAll()
        {
            return db_.KhachHangs.ToList();
        }

        public KhachHang GetSingleByID(int maKH)
        {
            return db_.KhachHangs.Where(t => t.MaKH == maKH).FirstOrDefault();
        }

        public List<KhachHang> GetByKeyword(string keyword)
        {
            return db_.KhachHangs.Where(t => t.MaKH.ToString().Contains(keyword)).ToList();
        }

        public bool Add(KhachHang khachhang)
        {
            try
            {
                db_.KhachHangs.Add(khachhang);

                db_.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            return true;
        }

        public bool Edit(KhachHang khachhang)
        {
            try
            {
                var ef = GetSingleByID(khachhang.MaKH);

                if (ef != null)
                {
                                       
                    ef.TenKH = khachhang.TenKH;
                    ef.NgaySinh = khachhang.NgaySinh;
                    ef.GioiTinh = khachhang.GioiTinh;
                    ef.CMT = khachhang.CMT;
                    ef.SDT = khachhang.SDT;
                    ef.NgheNghiep = khachhang.NgheNghiep;
                    ef.QuocTich = khachhang.QuocTich;

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

        public bool Delete(int MaKH)
        {
            try
            {
                var ef = GetSingleByID(MaKH);

                if (ef != null)
                {
                    db_.KhachHangs.Remove(ef);
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
