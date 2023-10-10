using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn1_QuanLyPhanMemBanPKDT.DataAcsess;

namespace DoAn1_QuanLyPhanMemBanPKDT.DataAcsess
{
    public class SanPhamDAL
    {
        QLPKDTEntities2 db = new QLPKDTEntities2();
        public List<SanPham> GetListSP()
        {
            return db.SanPham.ToList<SanPham>();
        }
        public bool KiemTraKhoaNgoai(string sanPhamId)
        {
            bool KetQua = db.KhoHang.Any(o => o.MaSP == sanPhamId)|| db.ChiTietDonHang.Any(o => o.MaSP == sanPhamId);
            return KetQua;
        }
        public void Add(SanPham sp)
        {
            db.SanPham.Add(sp);
            db.SaveChanges();
        }
        public void Delete(SanPham sp)
        {
            db.SanPham.Remove(sp);
            db.SaveChanges();
        }
        public void Replace(SanPham spnew)
        {
            SanPham spOld = db.SanPham.FirstOrDefault(s => s.MaSP == spnew.MaSP);
            if (spOld != null)
            {
                spOld.MaSP = spnew.MaSP;
                spOld.MaNCC = spnew.MaNCC;
                spOld.TenSP = spnew.TenSP;
                spOld.TheLoai = spnew.TheLoai;
                spOld.HangSP = spnew.HangSP;
                spOld.XuatXu = spnew.XuatXu;
                spOld.Giaban = spnew.Giaban;
                db.SaveChanges();
            }
        }
        public List<SanPham> InsertSP(string Keyword)
        {
            List<SanPham> Inserts = db.SanPham.Where(s => s.MaSP.Contains(Keyword) || s.MaNCC.Contains(Keyword) || s.TenSP.Contains(Keyword) || s.XuatXu.Contains(Keyword) || s.HangSP.Contains(Keyword) || s.Giaban.ToString().Contains(Keyword)).ToList();
            return Inserts;
        }

    }
}
