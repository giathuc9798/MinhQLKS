using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DAO
{
    public class BaseDAO
    {
        protected Model.DB_QuanLyKhachSanEntities5 db_;
         public BaseDAO()
        {
            db_ = new Model.DB_QuanLyKhachSanEntities5();
        }
    }
}
