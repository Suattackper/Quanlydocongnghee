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
using DoAn1_QuanLyPhanMemBanPKDT.Business;
using static System.Net.Mime.MediaTypeNames;
using System.Data.Entity.Infrastructure;

namespace DoAn1_QuanLyPhanMemBanPKDT.View
{
    public partial class FormNhanVien : Form
    { 
        
        NhanVienBUS ql=new NhanVienBUS();
        NhanVienDAL nv=new NhanVienDAL();
        TaiKhoanBUS qltk = new TaiKhoanBUS();
        List<NhanVien> listNV;
     
        public FormNhanVien()
        {
            InitializeComponent();
        }
        public dynamic GetListNV()
        {
            listNV=ql.GetListNV().ToList();
            var ListNVNew = listNV.Select(p => new { p.MaNV, p.TenNV, p.SDT, p.QueQuan, p.Email }).ToList();
            return ListNVNew;

        }
        public void LoadDataGridView()
        {
            dtgrvHienThiListNV.DataSource=GetListNV();
        }
        public bool CheckTextBox()
        {
            if(txtMaNV.Text!=""&&txtName.Text!=""&&txtSDT.Text != "" &&txtQueQuan.Text != "" &&txtEmail.Text != "" &&txtTaiKhoan.Text != "" &&txtMatKhau.Text != "" )
            {
                return true;
            }
            return false;
        }
        public bool CheckTextBox2()
        {
            if (txtMaNV.Text != "" && txtName.Text != "" && txtSDT.Text != "" && txtQueQuan.Text != "" && txtEmail.Text != "")
            {
                return true;
            }
            return false;
        }
        public NhanVien ObjectNV()
        {
            NhanVien nv = new NhanVien();
            if (CheckTextBox())
            {
                nv.MaNV = txtMaNV.Text;
                nv.TenNV = txtName.Text;
                nv.SDT = txtSDT.Text;
                nv.QueQuan = txtQueQuan.Text;
                nv.Email = txtEmail.Text;
                nv.Tentk= txtTaiKhoan.Text;
                return nv;

            }
            else
            {
                nv = null;
                return nv;
            }
            
        }
        public NhanVien ObjectNV2() 
        {
            NhanVien nv = new NhanVien();
            if (CheckTextBox2())
            {
                nv.MaNV = txtMaNV.Text;
                nv.TenNV = txtName.Text;
                nv.SDT = txtSDT.Text;
                nv.QueQuan = txtQueQuan.Text;
                nv.Email = txtEmail.Text;
                nv.Tentk = txtTaiKhoan.Text;
                return nv;

            }
            else
            {
                nv = null;
                return nv;
            }

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }


        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "    Tìm kiếm")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
            }
        }

        

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            txtName.Text = "";
            txtSDT.Text = "";
            txtQueQuan.Text="";
            txtEmail.Text = "";
            txtTaiKhoan.Text="";
            txtMatKhau.Text = "";
            txtMaNV.Focus();
            LoadDataGridView();
        }

        private void btnAddNV_Click(object sender, EventArgs e)
        {
          

                if (ObjectNV() != null)
                {
                    if (listNV.Find(s => s.MaNV == ObjectNV().MaNV) == null)
                    {
                        TaiKhoan tgxx = qltk.TimkiemTK(txtTaiKhoan.Text);
                        if (tgxx == null)
                        {
                            TaiKhoan tg = new TaiKhoan();                        
                            tg.TaiKhoan1 = txtTaiKhoan.Text;
                            tg.MatKhau= txtMatKhau.Text;
                            tg.PhanQuyen = "Nhân Viên";
                            qltk.AddTaiKhoan(tg);
                            ql.AddNV(ObjectNV());                        
                            listNV.Add(ObjectNV());
                            LoadDataGridView();
                            MessageBox.Show("Thêm nhân viên thành công !");
                        }
                        else
                        {
                            MessageBox.Show("Tên tài khoản này đã tồn tại hãy nhập lại !");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã nhân viên này đã tồn tại hãy nhập lại !");
                    }

                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ các trường dữ liệu của một nhân viên !");
                }
           


        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                
                    int SoluongNV = nv.InsertNV(txtTimKiem.Text).Count;
                    if (SoluongNV > 0)
                    {
                        var list = nv.InsertNV(txtTimKiem.Text).ToList();
                        dtgrvHienThiListNV.DataSource = list.Select(x => new { x.MaNV, x.TenNV, x.SDT, x.QueQuan, x.Email }).ToList();
                        MessageBox.Show("Tìm kiếm thành công");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nhân viên nào");
                    }
                
               
            }
            catch
            {
                MessageBox.Show("Có lỗi khi tìm kiếm ! ");
            }
        }

        private void btnDeleteNV_Click(object sender, EventArgs e)
        {
            
                NhanVien tg = new NhanVien();
                tg = listNV.Find(s => s.MaNV == txtMaNV.Text);
                if (tg != null)
                {
                    string Tentkx = ql.GetTentk(txtMaNV.Text);
                    if (!ql.KiemTraKhoaNgoai(txtMaNV.Text))
                    {
                        listNV.Remove(tg);
                        ql.DeteleNV(tg);
                        qltk.DeleteTaiKhoan(Tentkx);
                        MessageBox.Show("Xóa thành công nhân viên này");
                        LoadDataGridView();
                        
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa một nhân viên có liên kết khóa ngoại đến bảng khác !: ", "Thông báo");
                    }                   
                   
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên này");
                }
            
            
        }

        private void btnReplaceNV_Click(object sender, EventArgs e)
        {
            try { 
                if (ObjectNV2() != null)
                {
                    if (listNV.Find(s => s.MaNV == ObjectNV2().MaNV) != null)
                    {
                            ql.Replace(ObjectNV2());
                            listNV.Remove(ObjectNV2());
                            listNV.Add(ObjectNV2());
                            MessageBox.Show("Sửa thành công !");
                            LoadDataGridView();
                      
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nhân viên cần sửa!");
                    }

                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ các trường dữ liệu của một nhân viên !");
                }
            }
            catch { MessageBox.Show("Có lỗi khi thực hiện chức năng này !" ); }


        }

        private void dtgrvHienThiListNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaNV.Text = dtgrvHienThiListNV.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = dtgrvHienThiListNV.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSDT.Text = dtgrvHienThiListNV.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtQueQuan.Text = dtgrvHienThiListNV.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtEmail.Text = dtgrvHienThiListNV.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Có lỗi khi thực hiện chức năng này !");
            }
        }

        private void FormNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.Text = "    Tìm kiếm";
                txtTimKiem.ForeColor = Color.DarkGray;
               
            }
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            XuatExcel xuatExcel = new XuatExcel();
            string[]tieudecolumn= { "Mã NV", "Tên Nhân Viên", "SĐT", "Quê Quán", "Email" };
            xuatExcel.ExportToExcel(dtgrvHienThiListNV,"Danh Sách Nhân Viên",tieudecolumn,"danhsachnhanvien.xlsx");
        }

        private void dtgrvHienThiListNV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dtgrvHienThiListNV.CurrentCell= null;
        }
    }
    
}
