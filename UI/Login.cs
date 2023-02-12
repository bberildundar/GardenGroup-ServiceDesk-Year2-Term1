using Model;
using System;
using Logic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Login : Form
    {
        private User user;


        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

            UserService userservice = new UserService();
            if (Usernametxtbx.Text == "" || Passwordtxtbx.Text == "")
            {
                LoginErrorLbl.Text = "Please Fill in Username and Password";
            }
            else // bool to check if user exists and is valid
            {
                user = userservice.SearchUser(Usernametxtbx.Text);
                string hashedPassword = User.HashMethod(Passwordtxtbx.Text, user.Salt);

                if (user.Email == Usernametxtbx.Text && user.Hash == hashedPassword)
                {
                    Dashboard dashboard = new Dashboard(user);
                    dashboard.Show();
                    this.Hide();
                    
                }
                else
                {
                    LoginErrorLbl.Text = "Wrong Username or Password";
                }
            }


        }
        private void Forgotlinklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forget_Password forget_Password = new Forget_Password();
            forget_Password.Show();
            this.Hide();
        }
    } 
}
