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
    public partial class FRegister : Form
    {
        private UserModel userModel;
        public FRegister()
        {
            InitializeComponent();
            userModel = new UserModel();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(tbxUserName.Text.Trim() == "")
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
            if(tbxPassword.Text.Contains(" "))
            {
                MessageBox.Show("Mật khẩu không chứa dấu cách.");
                tbxPassword.Focus();
                return;
            }
            if (tbxConfirmedPassword.Text== "")
            {
                MessageBox.Show("Phải nhập tên người sử dụng.");
                tbxPassword.Focus();
                tbxConfirmedPassword.Clear();
                return;
            }
            User user = new User(1,tbxUserName.Text.Trim(), BitConverter.ToString(new MD5CryptoServiceProvider().ComputeHash(ASCIIEncoding.ASCII.GetBytes(tbxPassword.Text))).Replace("-", ""), 1);
            if (GlobalVarialbe.selectedUser.UserType != -1)
            {
                user.UserType = GlobalVarialbe.selectedUser.UserType;
            }
            DataTable selectedUser = userModel.getUserByName(user);
            if(selectedUser.Rows.Count >= 1)
            {
                MessageBox.Show("Tên tài khoản đã tồn tại.");
                return;
            }
            else
            {
                userModel.insertUser(user);
                MessageBox.Show("Tạo tài khoản thành công, mời đăng nhập!");
                btnCancel_Click(sender, e);
            }
            //if (GlobalVarialbe.selectedUser.UserType != -1)
            //{
              
            //    this.Close();
            //}
            //else
            //{
            //    btnCancel_Click(sender, e);
            //}
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            new FLogin().Show();
        }
    }
}
