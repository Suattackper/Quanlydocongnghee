using DoAn1_QuanLyPhanMemBanPKDT.DataAcsess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1_QuanLyPhanMemBanPKDT.Business
{
    public class NCCBUS
    {
       NhacungcapDAL NhaCCDAO=new NhacungcapDAL();
        List<NhaCC> List;
        public List<NhaCC> GetList()
        {
            List = NhaCCDAO.list();
            return List;
        }
        public bool KiemTraKhoaNgoai(string maNCC)
        {
            return NhaCCDAO.KiemTraKhoaNgoai(maNCC);
        }
        public void Add(NhaCC ncc)
        {
            List = NhaCCDAO.list();
            if (List.Find(p=>p.MaNCC==ncc.MaNCC)==null) 
            {
                NhaCCDAO.Add(ncc);
                
            }
            
        }
        public bool Detele(NhaCC ncc)
        {
            List = NhaCCDAO.list();
            if (List.Find(p=>p.MaNCC==ncc.MaNCC)!=null) 
            {
                NhaCCDAO.Delete(ncc);
                return true;
               
            }
            return false;
           
        }
        
        public void Replace(NhaCC ncc )
        {
            List = NhaCCDAO.list();
            if (List.Find(p=>p.MaNCC==ncc.MaNCC)!=null)
            {
                NhaCCDAO.Replace(ncc);
               
            }
          
        }
      
    }
}
