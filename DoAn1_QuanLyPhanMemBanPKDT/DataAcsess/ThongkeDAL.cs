using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1_QuanLyPhanMemBanPKDT.DataAcsess
{
   public  class ThongkeDAL
    {
        QLPKDTEntities2 db=new QLPKDTEntities2();
        public dynamic GetAllDonHang()
        {
                     
            var returnKQ = from dh in db.DonHang
                           join ctdh in db.ChiTietDonHang on dh.MaDH equals ctdh.MaDH
                           group new { dh, ctdh } by new { dh.MaDH, dh.TenKH, dh.DiaChi, dh.NgayMua, dh.MaNV } into g
                           select new
                           {
                                g.Key.MaDH,
                                g.Key.TenKH,
                                g.Key.DiaChi,
                                g.Key.NgayMua,
                                g.Key.MaNV,
                                tongtien = g.Sum(x=> x.ctdh.DonGia)
                           };

            return returnKQ.ToList();
        }
        public double SumDonGia()
        {
            return (double)db.ChiTietDonHang.Sum(ctdh => ctdh.DonGia);
        }
        public dynamic Timkiem(string keyword)
        {
            var listTK = GetAllDonHang();

            var searchResult = new List<dynamic>();

            foreach (var item in listTK)
            {
                if (item.TenKH.Contains(keyword)|| item.MaDH.Contains(keyword)) // Kiểm tra điều kiện tìm kiếm
                {
                    searchResult.Add(item);
                }
            }

            return searchResult.ToList();
        }
        public DonHang GetThongTin1Donhang(string MaDH )
        {
            DonHang DHTG = db.DonHang.FirstOrDefault(s => s.MaDH == MaDH);
            return DHTG;
        }
        
        public List<ObjectSP> GetListSPmua( string MaDH)
        {
            var Ketqua = from dhct in db.ChiTietDonHang
                         join sp in db.SanPham on dhct.MaSP equals sp.MaSP
                         where dhct.MaDH == MaDH
                         select new ObjectSP
                         {
                             MaSP=dhct.MaSP,
                             TenSP=sp.TenSP,
                             Soluong= (int)dhct.SoLuong,
                             Giaban= (double)sp.Giaban,
                             Thanhtien= (double)dhct.DonGia,

                         };
            return Ketqua.ToList();
        }






    }
}
