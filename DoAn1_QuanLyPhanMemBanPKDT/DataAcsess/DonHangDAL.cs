using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1_QuanLyPhanMemBanPKDT.DataAcsess
{
    public class DonHangDAL
    {
        QLPKDTEntities2 db=new QLPKDTEntities2();
        public List<DonHang> GetDonHangs ()
        {
            return db.DonHang.ToList<DonHang>();
        }
        public bool KiemTraKhoaNgoai(string maDH)
        {
            bool KetQua = db.ChiTietDonHang.Any(o => o.MaDH == maDH);
            return KetQua;
        }
        public DonHang GetThongTin1Donhang(string MaDH)
        {
            DonHang DHTG = db.DonHang.FirstOrDefault(s => s.MaDH == MaDH);
            return DHTG;
        }

        public void AddDH(DonHang dh)
        {
            db.DonHang.Add(dh);
            db.SaveChanges();
        }
        public void DeleteDH(DonHang dh)
        {            
            db.DonHang.Remove(dh);
            db.SaveChanges();
        }
        
        //Thao tác với Chitietdonhang
        public void AddCTDH(ChiTietDonHang dh)
        {
            db.ChiTietDonHang.Add(dh);
            db.SaveChanges();
        }
        public void DeleteCTDH(string Madh)
        {
            var ctdhList = db.ChiTietDonHang.Where(ctdh => ctdh.MaDH == Madh).ToList();
            db.ChiTietDonHang.RemoveRange(ctdhList);
            db.SaveChanges();
        }
        public List<ObjectSP> GetListSPmua(string MaDH)
        {
            var Ketqua = from dhct in db.ChiTietDonHang
                         join sp in db.SanPham on dhct.MaSP equals sp.MaSP
                         where dhct.MaDH == MaDH
                         select new ObjectSP
                         {
                             MaSP = dhct.MaSP,
                             TenSP = sp.TenSP,
                             Soluong = (int)dhct.SoLuong,
                             Giaban = (double)sp.Giaban,
                             Thanhtien = (double)dhct.DonGia,

                         };
            return Ketqua.ToList();
        }


    }
}
