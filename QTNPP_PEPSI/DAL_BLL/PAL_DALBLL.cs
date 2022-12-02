using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class PAL_DALBLL
    {
        QLNPP_PEPSI1DataContext QLNPP_PS = new QLNPP_PEPSI1DataContext();

        #region Load dữ liệu PAL
        public IQueryable load_PAL()
        {
            var pal = from p in QLNPP_PS.PALs select new { p.MAPAL, p.TENPAL };
            return pal;
        }

        public List<PAL> getPAL()
        {
            return QLNPP_PS.PALs.Select(k => k).ToList<PAL>();
        }

        #endregion

<<<<<<< HEAD
        #region Tìm kiếm PAL
        public IQueryable search_TenPAL(string ten)
        {
            return (from pal in QLNPP_PS.PALs.Where(p => p.TENPAL.Contains(ten))
                    select new
                    {
                        pal.MAPAL,
                        pal.TENPAL
                    });
        }

        #endregion

=======
>>>>>>> 7910f3a321947f813de7cc2c0787c6420c553f82
        #region Load dữ liệu PAL theo loại sản phẩm
        public IQueryable load_MAPAL()
        {
            var pal = from p in QLNPP_PS.PALs select new { p.MAPAL, p.TENPAL };
            return pal;
        }

        #endregion

        #region Thêm xóa sửa PAL
        public int them_PAL(string maPal, string tenPal)
        {
            PAL pal = new PAL { MAPAL = maPal, TENPAL = tenPal };
            try
            {
                QLNPP_PS.PALs.InsertOnSubmit(pal);
                QLNPP_PS.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int xoa_PAL(string maPal)
        {
            try
            {
                var pal = QLNPP_PS.PALs.Where(t => t.MAPAL == maPal).Single();

                QLNPP_PS.PALs.DeleteOnSubmit(pal);
                QLNPP_PS.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int sua_PAL(string maPal, string tenPal)
        {
            try
            {
                PAL pal = QLNPP_PS.PALs.Where(k => k.MAPAL == maPal).FirstOrDefault();
                pal.TENPAL = tenPal;

                QLNPP_PS.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;

            }
        }
        #endregion
    }
}
