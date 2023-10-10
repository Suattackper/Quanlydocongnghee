using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn1_QuanLyPhanMemBanPKDT.DataAcsess;

namespace DoAn1_QuanLyPhanMemBanPKDT.DataAcsess
{
    public class NhacungcapDAL
    {
        QLPKDTEntities2 db = new QLPKDTEntities2();
        public List<NhaCC> list()
        {
            return db.NhaCC.ToList<NhaCC>();
        }
        public bool KiemTraKhoaNgoai(string maNCC)
        {
            bool KetQua = db.SanPham.Any(o => o.MaNCC == maNCC) ;
            return KetQua;
        }
        public void Add(NhaCC nv)
        {

            db.NhaCC.Add(nv);
            db.SaveChanges();

        }
        public void Delete(NhaCC nv)
        {

            db.NhaCC.Remove(nv);
            db.SaveChanges();

        }
        public void Replace(NhaCC NhaCCNew)
        {
            NhaCC nccTG = db.NhaCC.FirstOrDefault(p => p.MaNCC == NhaCCNew.MaNCC);
            if (nccTG != null)
            {
                nccTG.MaNCC=NhaCCNew.MaNCC;
                nccTG.TenNCC=NhaCCNew.TenNCC;
                nccTG.SDTLH=NhaCCNew.SDTLH;
                nccTG.Email=NhaCCNew.Email;
                db.SaveChanges();
            }
        }
        public List<NhaCC> InsertNhaCC(string Keyword)
        {
            List<NhaCC> listTG = db.NhaCC.Where(s => s.MaNCC.Contains(Keyword) || s.TenNCC.Contains(Keyword) || s.Email.Contains(Keyword) || s.SDTLH.Contains(Keyword)).ToList();
            return listTG;
        }
    }
}
