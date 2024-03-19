using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Practice
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        Modify modify = new Modify();   
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tentk = txtUsername.Text;
            string matkhau = txtPassword.Text;

            if (tentk.Trim() == "") { MessageBox.Show("Vui lòng nhập tài khoản"); }
            else if (matkhau.Trim() == "") { MessageBox.Show("Vui lòng nhập mật khẩu");}
            else
            {
                string query = "select * from TaiKhoan where UserName = '"+tentk+"' and PassWord = '"+matkhau+"'";
                if (modify.TaiKhoans(query).Count != 0)
                {
                    Form1 f = new Form1();
                    f.Show();
                    this.Hide();
                    f.LogOut += F_LogOut;
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //Form1 f = new Form1();
            //f.Show();
            //this.Hide();
            //f.LogOut += F_LogOut;
        }

        private void F_LogOut(object sender, EventArgs e)
        {
            (sender as Form1).isExit = false;
            (sender as Form1).Close();
            this.Show();
        }

        private void llbResetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetPassword resetPassword = new ResetPassword();
            resetPassword.ShowDialog();
        }

        private void llbSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
