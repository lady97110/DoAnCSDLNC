using DoAnCSDLNC.Classes;
using DoAnCSDLNC.Models;
using DoAnCSDLNC.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCSDLNC.Views.UserManagment
{
    public partial class FLogin : Form
    {
        private UserModel userModel;
        private DataTable selectedUser;
        public FLogin()
        {
            InitializeComponent();
            userModel = new UserModel();
            selectedUser = new DataTable();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (tbxUserName.Text.Trim() == "")
            {
                MessageBox.Show("Phải nhập tên người sử dụng.");
                tbxUserName.Focus();
                return;
            }
            if (tbxPassword.Text == "")
            {
                MessageBox.Show("Phải nhập mật khẩu.");
                tbxPassword.Focus();
                return;
            }
            if (tbxPassword.Text.Contains(" "))
            {
                MessageBox.Show("Mật khẩu không chứa dấu cách.");
                tbxPassword.Focus();
                return;
            }
            User user = new User();
            user.UserName = tbxUserName.Text;
            Byte[] tmpSource = ASCIIEncoding.ASCII.GetBytes(tbxPassword.Text);
            user.Password = BitConverter.ToString(new MD5CryptoServiceProvider().ComputeHash(tmpSource)).Replace("-", "");
           
            selectedUser = userModel.getUser(user);
            if(selectedUser.Rows.Count == 1)
            {
                GlobalVarialbe.isLogin = true;
                GlobalVarialbe.selectedUser.UserId = int.Parse(selectedUser.Rows[0][0].ToString());
                GlobalVarialbe.selectedUser.UserName = selectedUser.Rows[0][1].ToString();
                GlobalVarialbe.selectedUser.Password = selectedUser.Rows[0][2].ToString();
                GlobalVarialbe.selectedUser.UserType = int.Parse(selectedUser.Rows[0][3].ToString());
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản không đúng hoặc không tồn tại.");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new FRegister().Show();
            this.Close();
        }
    }
}
