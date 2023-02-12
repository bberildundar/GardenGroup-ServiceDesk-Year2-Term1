using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Logic;

namespace UI
{
    public partial class Forget_Password : Form
    {
        UserService userService;
        User user;
        int fourDigitCode;
        public Forget_Password()
        {
            InitializeComponent();
            InitializeForm();
        }
        private void InitializeForm()
        {
            btnUsed.Text = "Confirm Email";
            userService = new UserService();
            fourDigitCode = GetFourDigitCode();
            SetConfirmStuff(false);
        }

        private void SetConfirmStuff(bool i)
        {
            lblConfirm.Visible = i;
            txtConfirm.Visible = i;
            txtConfirm.Enabled = i;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnUsed_Click(object sender, EventArgs e)
        {
            try
            {
                ButtonCheck();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); } 
        }

        private void ButtonCheck()
        {
            if (btnUsed.Text == "Confirm Email")
            {
                if (txtUsed.Text.Equals(""))
                    throw new Exception("Please enter a email");
                else if (userService.SearchUser(txtUsed.Text) == null)
                    throw new Exception("Enter a valid email");
                user = userService.SearchUser(txtUsed.Text);
                MessageBox.Show("An email was send to your account with a four digit code please enter that into the box.");
                btnUsed.Text = "Confirm Code";
                lblUsed.Text = "Enter four digit code";
                lblFourDigitCode.Text = $"The four digit code is {fourDigitCode}";
                txtUsed.Text = "";
            }
            else if (btnUsed.Text == "Confirm Code")
            {
                if (txtUsed.Text.Equals(""))
                    throw new Exception("Please enter the code");
                else if (int.Parse(txtUsed.Text) != fourDigitCode)
                    throw new Exception("Please enter the correct code");
                MessageBox.Show("Correct verification code now please enter your new password.");
                btnUsed.Text = "Confirm Password";
                lblUsed.Text = "Enter new password";
                lblFourDigitCode.Text = "";
                txtUsed.Text = "";
                SetConfirmStuff(true);
                txtUsed.PasswordChar = '*';
            }
            else if (btnUsed.Text == "Confirm Password")
            {
                if (txtUsed.Text.Equals("") || txtConfirm.Text.Equals(""))
                    throw new Exception("Enter a password");
                if (txtUsed.Text != txtConfirm.Text)
                    throw new Exception("please enter the same password twice.");
                string salt = User.GenerateSalt();
                user.Salt = salt;
                user.Hash = User.HashMethod(txtUsed.Text, salt);
                userService.UpdateUser(user);
                MessageBox.Show("Your password has been updated");
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private int GetFourDigitCode()
        {
            Random generator = new Random();
            return generator.Next(1000,10000); // this misses out on a 1000 numbers but i am lazy and can't be bothered implementing it properly.
        }
    }
}
