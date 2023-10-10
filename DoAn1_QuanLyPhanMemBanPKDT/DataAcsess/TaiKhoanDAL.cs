using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1_QuanLyPhanMemBanPKDT.DataAcsess
{
    public class TaiKhoanDAL
    {
        QLPKDTEntities2 db = new QLPKDTEntities2();
        public void AddTaiKhoan(TaiKhoan taiKhoan)
        {
            db.TaiKhoan.Add(taiKhoan);
            db.SaveChanges();
        }
        
        public void DeleteTaiKhoan(TaiKhoan taiKhoan)
        {
            db.TaiKhoan.Remove(taiKhoan);
            db.SaveChanges();
        }
        public void Doimatkhau(TaiKhoan taiKhoan, string mknew)
        {
            taiKhoan.MatKhau = mknew;
            db.SaveChanges();
        }
        public TaiKhoan TimkiemTK(string tentk)
        {
            return db.TaiKhoan.FirstOrDefault(s=>s.TaiKhoan1== tentk);
        }

    }
}
