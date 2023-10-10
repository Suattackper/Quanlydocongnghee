using DoAn1_QuanLyPhanMemBanPKDT.DataAcsess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1_QuanLyPhanMemBanPKDT.Business
{
    public class TaiKhoanBUS
    {
        TaiKhoanDAL account = new TaiKhoanDAL();
        public bool AddTaiKhoan(TaiKhoan taiKhoan)
        {
            if(account.TimkiemTK(taiKhoan.TaiKhoan1)==null)
            {
                account.AddTaiKhoan(taiKhoan); 
                return true;
            }
            return false;
        }
        public bool DeleteTaiKhoan(string taiKhoan)
        {
            if (account.TimkiemTK(taiKhoan) != null)
            {                
                account.DeleteTaiKhoan(account.TimkiemTK(taiKhoan));
                return true;
            }
            return false;
        }
        public bool Doimatkhau(TaiKhoan taiKhoan, string mknew)
        {
            if (account.TimkiemTK(taiKhoan.TaiKhoan1) != null)
            {
                account.Doimatkhau(taiKhoan, mknew);
                return true;
            }
            return false;
        }
        public bool KiemTraTKMK(string Tentk, string mk)
        {
            TaiKhoan tg = account.TimkiemTK(Tentk);
            if (tg!=null)
            { 
                if(tg.MatKhau==mk)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
        public TaiKhoan TimkiemTK(string tentk)
        {
            return account.TimkiemTK(tentk);
        }

    }
}
