using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppQuanly
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox_TenTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel_DangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dangki = new DangKy();
            dangki.ShowDialog();
            
        }

        private void linkLabel_QuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhau quenMatKhau = new QuenMatKhau();
            quenMatKhau.ShowDialog();
            
        }
        Modify modify= new Modify();
        private void button_DangNhap_Click(object sender, EventArgs e)
        {
            string tentk=textBox_TenTaiKhoan.Text;
            string matkhau=textBox_MatKhau.Text;
            if(tentk.Trim() == "") { MessageBox.Show("Vui lòng nhập tài khoản !!"); }
            else if (matkhau.Trim() == "") { MessageBox.Show("Vui lòng nhập mật khẩu !!"); }
            else
            {
                string query = "Select * from TaiKhoan where TenTaiKhoan = '"+tentk+ "' and MatKhau = '"+matkhau+"'";
                if (modify.TaiKhoans(query).Count != 0)
                {
                    MessageBox.Show("Đăng nhập thành công !","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Home home = new Home();
                    home.ShowDialog();
                  
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void textBox_MatKhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
