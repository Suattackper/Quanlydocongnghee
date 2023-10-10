using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn1_QuanLyPhanMemBanPKDT.DataAcsess;

namespace DoAn1_QuanLyPhanMemBanPKDT.Business
{
    public class KhoHangBUS
    {
        KhoHangDAL kho = new KhoHangDAL();
        List<KhoHang> listSP ;
        public List<KhoHang> GetAllSP()
        {
            listSP = kho.GetDataKhoHang();
            return listSP;
        }
        public bool AddSanPham(KhoHang sp)
        {
            listSP = kho.GetDataKhoHang();
            if(listSP.Find(p=>p.MaSP==sp.MaSP) == null)
            {
                kho.AddSP(sp);
                return true;
            }
            return false;
        }
        public bool DeleteSanPham(string MaSP)
        {
            listSP = kho.GetDataKhoHang();
            KhoHang TG = listSP.Find(p => p.MaSP == MaSP);
            if (TG != null)
            {
                kho.DeleteSP(TG);
                return true;
            }
            return false;
        }
        public bool UpdateKhoHang(KhoHang sp)
        {

            listSP = kho.GetDataKhoHang();
            if (listSP.Find(p => p.MaSP == sp.MaSP) != null)
            {
                kho.UpdateSP(sp);
                return true;
            }
            return false;
        }
        public bool GiamSoLuongQL(string MaSP, int x)
        {
            KhoHang spp=listSP.Find(s=>s.MaSP== MaSP);
            if(spp!= null&&spp.Soluong>=x)
            {
                kho.GiamSoLuong(spp, x);
                return true;
            }
            return false;
            

        }
        public bool TangSoLuongQL(string MaSP, int x)
        {
            KhoHang spp = listSP.Find(s => s.MaSP == MaSP);
            if (spp != null )
            {
                kho.TangSoLuong(spp, x);
                return true;
            }
            return false;


        }

    }
}
