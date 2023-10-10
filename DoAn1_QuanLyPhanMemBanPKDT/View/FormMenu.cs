using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn1_QuanLyPhanMemBanPKDT.View;
using DoAn1_QuanLyPhanMemBanPKDT.DataAcsess;

namespace DoAn1_QuanLyPhanMemBanPKDT.View
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
           

        }
        static string GetTimeNow()
        {
            DateTime date = DateTime.Now; // Lấy thời điểm hiện tại

            string dayOfWeek = date.ToString("dddd"); // Lấy thứ trong tuần
            string dayOfMonth = date.Day.ToString(); // Lấy ngày trong tháng
            string month = date.Month.ToString(); // Lấy tên của tháng
            string year = date.Year.ToString(); // Lấy năm

            return $"{dayOfWeek}, ngày {dayOfMonth}/{month}/{year}";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private Form formNow;
        private void LoadForm(Form formnew)
        {
            if (formNow != null)
            {
                formNow.Close();
            }
            formNow = formnew;
            formnew.TopLevel = false;
            formnew.FormBorderStyle= FormBorderStyle.None;
            formnew.Dock = DockStyle.Fill;
            panelBody.Controls.Add(formnew);
            panelBody.Tag = formnew;
            formnew.BringToFront();
            formnew.Show();
        }
        private void FormMenu_Load(object sender, EventArgs e)
        {

            this.Height = 900;
            this.Width = 1620;
            lblUserName.Text = FormLogin.GetDataUser.tentaikhoan;
            lblPhanQuyen.Text = FormLogin.GetDataUser.phanquyen;
            //Gettime
            lblDateTime.Text = GetTimeNow();
            if (lblPhanQuyen.Text == "Nhân Viên") 
            {
                btnNhanvien.Visible = false;
                btnThongke.Visible= false;
            }
            ButtonNow = btnTrangchu;
            ButtonNow.ForeColor = Color.DarkGreen;
            
            
        }

        

        private void btnLogout_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất tài khoản không  ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                FormLogin a=new FormLogin();
                a.ShowDialog();
            }
        }

        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {     
                Application.Exit();            
        }
        private Button ButtonNow;
       
      
        private void ActiveColor(Button ButtonNew)
        {
            if(ButtonNow!=null)
            {
                ButtonNow.ForeColor = Color.White;
                ButtonNow = ButtonNew;
                ButtonNew.ForeColor = Color.DarkGreen;

            }
        }    
        
        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            panelBody.Controls.Clear();
            
            ActiveColor(btnTrangchu);
        }

        private void lblDateTime_Click(object sender, EventArgs e)
        {

        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            FormSanPham a=new FormSanPham();
            LoadForm(a);
            ActiveColor(btnSanPham);
        }
       

        private void btnNhacc_Click(object sender, EventArgs e)
        {
            FormNhaCC a = new FormNhaCC();
            LoadForm(a);
            ActiveColor(btnNhacc);
        }

        private void btnAddDH_Click(object sender, EventArgs e)
        {
            FormDonhang a = new FormDonhang();
            LoadForm(a);
            ActiveColor(btnAddDH);
        }

        private void btnKhohang_Click(object sender, EventArgs e)
        {
            FormKhoHang a = new FormKhoHang();
            LoadForm(a);
            ActiveColor(btnKhohang);
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            FormNhanVien a = new FormNhanVien();
            LoadForm(a);
            ActiveColor(btnNhanvien);
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            FormThongke a = new FormThongke();
            LoadForm(a);
            ActiveColor(btnThongke);
        }

        private void panelBody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblPhanQuyen_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
