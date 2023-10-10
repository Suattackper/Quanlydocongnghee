using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn1_QuanLyPhanMemBanPKDT.DataAcsess;

namespace DoAn1_QuanLyPhanMemBanPKDT.Business
{
    public class SanPhamBUS
    {
        SanPhamDAL spdao=new SanPhamDAL();
        List<SanPham> lists;
        public List<SanPham> GetListSP()
        {
            lists= spdao.GetListSP();
            return lists;
        }
        public bool KiemTraKhoaNgoai(string sanPhamId)
        {
            return spdao.KiemTraKhoaNgoai(sanPhamId);
        }
        public bool AddSP(SanPham sp)
        {
            lists = spdao.GetListSP();
            if (lists.Find(s => s.MaSP == sp.MaSP) == null) 
            {
                spdao.Add(sp);
                return true;
            }
            return false;
        }
        public bool DeleteSP(string Masp)
        {
            lists = spdao.GetListSP();
            SanPham a = lists.Find(s => s.MaSP == Masp);
            if (a != null)
            {
                spdao.Delete(a);
                return true;
            }
            return false;
        }
        public bool ReplaceSP(SanPham newsp)
        {
            lists = spdao.GetListSP();
            if (lists.Find(s => s.MaSP == newsp.MaSP) != null)
            {
                spdao.Replace(newsp);
                return true;
            }
            return false;
        }
        public List<SanPham> Insert(string keyword)
        {            
            return spdao.InsertSP(keyword);
        }

    }
}
