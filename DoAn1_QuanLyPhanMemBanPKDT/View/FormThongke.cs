using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn1_QuanLyPhanMemBanPKDT.DataAcsess;
using static DoAn1_QuanLyPhanMemBanPKDT.View.FormDonhang;

namespace DoAn1_QuanLyPhanMemBanPKDT.View
{
    
    public partial class FormThongke : Form
    {
        ThongkeDAL tk = new ThongkeDAL();
        public FormThongke()
        {
            InitializeComponent();
        }
        
        public void LoadDataGridView()
        {
            dtgrvHienThiListALLDH.DataSource = tk.GetAllDonHang();
        }
        public double TinhTong()
        {
            double tong = 0;
            foreach (DataGridViewRow row in dtgrvHienThiListALLDH.Rows)
            {
                double values = double.Parse(row.Cells[5].Value.ToString());
                tong = tong + values;
            }
            return tong;
        }
        private void FormThongke_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            //Chuyển sang tiền tệ
            double number = TinhTong();
            string formattedNumber = string.Format("{0:0,0.###}", number) + " VNĐ";
            formattedNumber = formattedNumber.TrimEnd('.', ',');
            lblDoanhThu.Text = formattedNumber;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.Text = "  Tìm kiếm";
                txtTimKiem.ForeColor = Color.DarkGray;
                LoadDataGridView();

            }
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "  Tìm kiếm")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if(txtTimKiem.Text != "  Tìm kiếm" || txtTimKiem.Text!="")
            {
                List<dynamic> TG = tk.Timkiem(txtTimKiem.Text);
                if(TG.Count > 0)
                {
                    dtgrvHienThiListALLDH.DataSource = TG;
                    
                }
                else
                {
                    MessageBox.Show("Không tìm thấy đơn hàng nào !", "Thông báo");
                }

            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa cần tìm !", "Thông báo");
            }
        }

        private void dtgrvHienThiListNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
       
        public class Chitiet1DH
        {
            static public DonHang dh;
            static public List<ObjectSP> listsp;
        }
        private void vbButton1_Click(object sender, EventArgs e)
        {
                FormChiTietDH a = new FormChiTietDH(Chitiet1DH.dh, Chitiet1DH.listsp);
                a.ShowDialog();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dtgrvHienThiListALLDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgrvHienThiListALLDH.SelectedRows.Count > 0)
            {
                // Lấy dòng đang được chọn
                DataGridViewRow selectedRow = dtgrvHienThiListALLDH.SelectedRows[0];

                // Kiểm tra xem có đủ số cột không
                if (selectedRow.Cells.Count > 1)
                {
                    btnXemchitiet.Visible = true;
                    // Lấy dữ liệu của cột thứ 2
                    string MaDH = selectedRow.Cells[0].Value.ToString();                    
                    Chitiet1DH.dh = tk.GetThongTin1Donhang(MaDH);                    
                    Chitiet1DH.listsp= tk.GetListSPmua(MaDH);



                }
            }
        }

        private void dtgrvHienThiListALLDH_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dtgrvHienThiListALLDH.CurrentCell= null;
        }

        private void vbButton1_Click_1(object sender, EventArgs e)
        {
            XuatExcel a = new XuatExcel();
            string[] listcoLuml = { "Mã ĐH", "Tên KH", "Địa chỉ", "Ngày mua", "Mã NV", "Tồng hóa đơn" };
            a.ExportToExcel(dtgrvHienThiListALLDH, "Danh sách tất cả đơn hàng tại quán", listcoLuml, "danhsachdonhang");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
    }
}
