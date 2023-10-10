using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn1_QuanLyPhanMemBanPKDT.DataAcsess;

namespace DoAn1_QuanLyPhanMemBanPKDT.Business
{
    public class DonHangBUS
    {
        DonHangDAL dataDH=new DonHangDAL();
        
        List<DonHang> listDH;
        public bool KiemTraKhoaNgoai(string maDH)
        {
            return dataDH.KiemTraKhoaNgoai(maDH);
        }

        public bool AddDH(DonHang dh)
        {
            listDH = dataDH.GetDonHangs();
            if (listDH.Find(s => s.MaDH == dh.MaDH) == null)
            {
                dataDH.AddDH(dh);
                return true;
            }
            return false;

        }
        public void AddChiTietDH(ChiTietDonHang ctdh) 
        {
            dataDH.AddCTDH(ctdh);
        }
        public bool DeleteDH(string Madh)
        {
           DonHang tg = dataDH.GetThongTin1Donhang(Madh);
           if (tg!= null) 
            {
                dataDH.DeleteDH(tg);
                return true;
            }
            return false;
        }
        public bool DeleteCTDH(string Madh)
        {
            if(getALLCTDH(Madh).Count>0)
            {
                dataDH.DeleteCTDH(Madh);
                return true;
            }
            return false;
        }
        public List<ObjectSP> getALLCTDH(string MaDH)
        {
            return dataDH.GetListSPmua(MaDH);
        }
         
    }
}
