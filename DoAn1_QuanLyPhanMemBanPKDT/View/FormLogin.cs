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
using DoAn1_QuanLyPhanMemBanPKDT.View;
using DoAn1_QuanLyPhanMemBanPKDT.Business;

namespace DoAn1_QuanLyPhanMemBanPKDT
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUserName.Padding= new Padding(10);
            txtPassWoud.Padding= new Padding(10);
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_BackColorChanged(object sender, EventArgs e)
        {
            
        }
        public class GetDataUser
        {
           static public string tentaikhoan;          
            static public string phanquyen;

        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            
                Application.Exit();
              
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormMenu a = new FormMenu();
            a.ShowDialog();

        }

        private void vbButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text == "" || txtPassWoud.Text == "")
                {
                    MessageBox.Show("Thông tin tài khoản hoặc mật khẩu không được để trống !");
                    

                }
                else
                {
                    TaiKhoanBUS ql=new TaiKhoanBUS();
                    TaiKhoan tg = ql.TimkiemTK(txtUserName.Text);
                    if(tg !=null)
                    {
                        if (tg.MatKhau == txtPassWoud.Text)
                        {
                            FormMenu a = new FormMenu();
                            GetDataUser.tentaikhoan = tg.TaiKhoan1;
                            GetDataUser.phanquyen = tg.PhanQuyen;
                            MessageBox.Show("Đăng nhập thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            this.Hide();
                            a.ShowDialog();
                            a.BringToFront();
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không chính xác hãy nhập lại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Hiện không có tài khoản nào giống như quý khách đã cung cấp !","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Question);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Bạn cần xem lại các thao tác vừa làm !");
            }
        }

        private void checkViewPassWord_CheckedChanged(object sender, EventArgs e)
        {
            if(checkViewPassWord.Checked)
            {
                txtPassWoud.PasswordChar='\0';
            }
           else
            {
                txtPassWoud.PasswordChar = '*';
            }
        }
    }
}
