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
using System.Security.Policy;

namespace UI //coded by Betül Beril Dündar - 691136
{
    public partial class AddUser : Form
    {        
        UserService userService;
        User user;

        public AddUser(User user) //this will be used when roles are activated
        {            
            InitializeComponent();
            this.user = user;
            userService = new UserService();               
            ResetForm();
        }

        private void btnConfirmUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtboxFirstName.Text)|| string.IsNullOrEmpty(txtboxLastName.Text)|| string.IsNullOrEmpty(txtboxEmail.Text)|| string.IsNullOrEmpty(txtPhoneNumber.Text)|| string.IsNullOrEmpty(txtBoxPassword.Text)|| string.IsNullOrEmpty(txtBoxPasswordAgain.Text))
                //checks if the all text boxes are filled in or not.
                {
                    MessageBox.Show("Please fill in all the fields.");
                    return;
                }
                string email = txtboxEmail.Text;
                IsValidEmail(email);
                if (!IsValidEmail(email))
                {
                    MessageBox.Show("Please enter a valid e-mail address.");
                    return;
                }
                if (txtBoxPassword.Text != txtBoxPasswordAgain.Text) //checks the passwords
                {
                    MessageBox.Show("Entered passwords do not match.");                    
                    return;
                }

                User user = userService.SearchUser(email); 
                if (user == null)//checks if the email is already in the database
                {
                    AddingUser();
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("This email is already in use.");
                }                 
            }
            catch(Exception ex)
            {
                MessageBox.Show("The user could not be added. Please try again. " + ex.Message);
            }
        }

        private void AddingUser()
        {
            try
            {
                string password = txtBoxPassword.Text;
                string newSalt = User.GenerateSalt();
                string hashedPassword = User.HashMethod(password, newSalt); //hashing the new user's password
                string firstName = txtboxFirstName.Text;
                string lastName = txtboxLastName.Text;
                string email = txtboxEmail.Text;
                string phoneNumber = txtPhoneNumber.Text;
                string branch = cboxBranch.Text;
                string access = cBoxAccessLevel.Text;

                AccessLevel accessLevel = AccessLevelConverter.ConvertToAccessLevel(access);

                BranchAddress branchAddress = new BranchAddress();
                branchAddress = branchAddress.ConvertToBranchAddress(branch);

                User user = new User(firstName, lastName, email, hashedPassword, newSalt, accessLevel, branchAddress);

                userService.AddUser(user); //adding user                

                MessageBox.Show("The new user has been successfully added.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("The user could not be added. Please try again. " + ex.Message);
            }
        }      

        private void ResetForm()
        {
            try
            {
                txtboxFirstName.Clear();
                txtboxLastName.Clear();
                txtboxEmail.Clear();
                txtBoxPassword.Clear();
                txtBoxPasswordAgain.Clear();
                txtPhoneNumber.Clear();
                cboxBranch.SelectedIndex = 0;
                cBoxAccessLevel.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }            
        }

        static bool IsValidEmail(string email) //checks if the email is a valid mail
        {
            try
            {
                var address = new System.Net.Mail.MailAddress(email);
                return address.Address == email;
            }
            catch
            {
                return false;
            }
        }        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            UserManagement userManagementForm = new UserManagement(user);
            this.Hide();
            userManagementForm.ShowDialog();
        }

        private void btnDashboardIAddUserForm_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(user);
            this.Hide();
            dashboard.Show();
        }

        private void btnIncidentManagementInTicketAddUserForm_Click(object sender, EventArgs e)
        {
            Ticket_Overview ticketOverview = new Ticket_Overview(user);
            this.Hide();
            ticketOverview.Show();
        }

        private void btnUserManagementInAddUserForm_Click(object sender, EventArgs e)
        {
            UserManagement userManagement = new UserManagement(user);
            this.Hide();
            userManagement.Show();
        }
    }
}
