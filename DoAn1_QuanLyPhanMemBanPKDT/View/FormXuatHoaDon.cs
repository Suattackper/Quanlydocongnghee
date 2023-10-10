using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1_QuanLyPhanMemBanPKDT.View
{
    public partial class FormXuatHoaDon : Form
    {
        public FormXuatHoaDon()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FormXuatHoaDon_Load(object sender, EventArgs e)
        {
            double tong = 0;
            var ttnv = FormDonhang.Inhoadon.dh;
            var listsps = FormDonhang.Inhoadon.listsp;
            lblMaHD.Text = ttnv.MaDH.ToString();
            lblMaNV.Text = ttnv.MaNV.ToString();
            lblTenKH.Text = ttnv.TenKH.ToString();
            lblSDTKH.Text = ttnv.SDTKH.ToString();
            lblDiachi.Text=ttnv.DiaChi.ToString();
            lblNgaymua.Text=ttnv.NgayMua.ToString();
           foreach(var i in listsps)
            {
                dtgrvHienThiListSPChon.Rows.Add(i.MaSP,i.TenSP,i.Soluong,i.Giaban,i.Thanhtien);
                tong = tong + i.Thanhtien;
                
            }
            string epkieuTiente = tong.ToString("#,##0")+" VNĐ";
            lblTongtien.Text= epkieuTiente;
            lblPhaitra.Text= epkieuTiente;

        }


        private void dtgrvHienThiListSPChon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgrvHienThiListSPChon_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dtgrvHienThiListSPChon.CurrentCell = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
