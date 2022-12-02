using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class BacLuong_DALBLL
    {
        QLNPP_PEPSI1DataContext QLNPP_PS = new QLNPP_PEPSI1DataContext();

        #region Load dữ liệu bậc lương
        public IQueryable load_BacLuong()
        {
            var bacl = from bl in QLNPP_PS.BACLUONGs select bl;
            return bacl;
        }

        public List<BACLUONG> getBacLuong()
        {
            return QLNPP_PS.BACLUONGs.Select(k => k).ToList<BACLUONG>();
        }

        #endregion

        #region Load dữ liệu CT bậc lương
        public IQueryable load_CTBacLuong(string mabl)
        {
            return (from ctbl in QLNPP_PS.CHITIETBACLUONGs
                    join nv in QLNPP_PS.NHANVIENs on ctbl.MANV equals nv.MANV
                    where ctbl.MABAC == mabl
                    select new { ctbl.MABAC, ctbl.MANV, ctbl.TUNGAY, ctbl.DENNGAY });
        }

        #endregion

        #region Thêm xóa sửa bậc lương
        public int insert_Bac(string maBac, string tenBac, double heSo, string maNV, string tuNgay, string denNgay)
        {
            BACLUONG bac = new BACLUONG { MABAC = maBac, TENBAC = tenBac, HESO = heSo };
            CHITIETBACLUONG ct = new CHITIETBACLUONG { MABAC = maBac, MANV = maNV, TUNGAY = Convert.ToDateTime(tuNgay), DENNGAY = Convert.ToDateTime(denNgay) };
            try
            {
                QLNPP_PS.BACLUONGs.InsertOnSubmit(bac);
                QLNPP_PS.CHITIETBACLUONGs.InsertOnSubmit(ct);
                QLNPP_PS.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int delete_Bac(string maBac)
        {
            try
            {
                var bac = QLNPP_PS.BACLUONGs.Where(t => t.MABAC == maBac).Single();

                QLNPP_PS.BACLUONGs.DeleteOnSubmit(bac);
                QLNPP_PS.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        #endregion

        #region Thêm xóa sửa CT bậc lương

        public int insert_CTBac(string maBac, string maNV, DateTime tuNgay, DateTime denNgay)
        {
            CHITIETBACLUONG ctbac = new CHITIETBACLUONG { MABAC = maBac, MANV = maNV, TUNGAY = tuNgay, DENNGAY = denNgay };
            try
            {
                QLNPP_PS.CHITIETBACLUONGs.InsertOnSubmit(ctbac);
                QLNPP_PS.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public bool insertQuanHuyen(string maQH, string maTT, string tenQH)
        {
            try
            {
                QUANHUYEN quanhuyen = new QUANHUYEN();
                quanhuyen.MAQUANHUYEN = maQH;
                quanhuyen.MATINHTHANH = maTT;
                quanhuyen.TENQUANHUYEN = tenQH;
                QLNPP_PS.QUANHUYENs.InsertOnSubmit(quanhuyen);
                QLNPP_PS.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int delete_CTBac(string maBac, string maNV)
        {
            try
            {
                var ctbac = QLNPP_PS.CHITIETBACLUONGs.Where(t => t.MABAC == maBac && t.MANV == maNV).Single();

                QLNPP_PS.CHITIETBACLUONGs.DeleteOnSubmit(ctbac);
                QLNPP_PS.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int update_CTBL(string maBac, string maNV, DateTime tuNgay, DateTime denNgay)
        {
            try
            {
                CHITIETBACLUONG ctbac = QLNPP_PS.CHITIETBACLUONGs.Where(t => t.MABAC == maBac & t.MANV == maNV).FirstOrDefault();
                ctbac.TUNGAY = tuNgay;
                ctbac.DENNGAY = denNgay;

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
