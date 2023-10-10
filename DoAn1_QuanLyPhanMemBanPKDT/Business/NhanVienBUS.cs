using DoAn1_QuanLyPhanMemBanPKDT.DataAcsess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1_QuanLyPhanMemBanPKDT.Business
{
    public class NhanVienBUS
    {
       NhanVienDAL NhanVienDAO=new NhanVienDAL();
        List<NhanVien> ListNV;
        public List<NhanVien> GetListNV()
        {
            ListNV = NhanVienDAO.list();
            return ListNV;
        }
        public string GetTentk(string MaNV)
        {
            return NhanVienDAO.GetNhanVien(MaNV);
        }
        public bool KiemTraKhoaNgoai(string maNV)
        {
         
            return NhanVienDAO.KiemTraKhoaNgoai(maNV);
        }
        public void AddNV(NhanVien nv)
        {
            ListNV = NhanVienDAO.list();
            if (ListNV.Find(p=>p.MaNV==nv.MaNV)==null) 
            {
                NhanVienDAO.AddNV(nv);
                
            }
            
        }
        public void DeteleNV(NhanVien nv)
        {
            ListNV = NhanVienDAO.list();
            if (ListNV.Find(p=>p.MaNV==nv.MaNV)!=null) 
            {
                NhanVienDAO.DeleteNV(nv);
               
            }
           
        }
        
        public void Replace(NhanVien nv)
        {
            ListNV = NhanVienDAO.list();
            if (ListNV.Find(p=>p.MaNV==nv.MaNV)!=null)
            {
                NhanVienDAO.Replace(nv);
               
            }
          
        }
      
    }
}
