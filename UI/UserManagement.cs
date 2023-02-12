using Logic;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace UI //coded by Betül Beril Dündar - 691136
{
    public partial class UserManagement : Form
    {
        UserService userService;
        TicketService ticketService;
        User user;

        public UserManagement(User user) 
        {
            InitializeComponent();
            userService = new UserService();
            ticketService = new TicketService();
            this.user = user;
            LoadUserList();
        }

        private void LoadUserList()
        {
            try
            {
                listViewUserManagement.Items.Clear();
                List<User> userList = userService.GetListOfUsers();

                foreach (User user in userList) //getting the details of the list
                {
                    ListViewItem list = new ListViewItem(user.Id.ToString());                     
                    list.SubItems.Add(user.Email);
                    list.SubItems.Add(user.FirstName);
                    list.SubItems.Add(user.LastName);
                    list.SubItems.Add(CalculateTicketCounts(user.Email).ToString());
                    
                    list.Tag = user;
                    listViewUserManagement.Items.Add(list);
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddNewUserInUserManagementForm_Click(object sender, EventArgs e)
        {
            try
            {
                AddUser addUserForm = new AddUser(user);
                this.Hide();
                addUserForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public int CalculateTicketCounts(string email) //calculating the number of tickets the user has created 
        {
            int output = 0;

            List<string> allReporterEmails = new List<string>();
            List<Ticket> ticketsList = ticketService.GetListOfTickets();

            foreach (Ticket ticket in ticketsList)
            {
                allReporterEmails.Add(ticket.Incident.Email);
            }

            foreach (string reporterMail in allReporterEmails)
            {
                if (email == reporterMail)
                {
                    output++;
                }
            }
            return output;
        }

        private void btnDashboardInUserManagementForm_Click(object sender, EventArgs e)
        {
            Dashboard form = new Dashboard(user);
            form.Show();
            this.Hide();
        }

        private void btnIncidentManagementInUserManagementForm_Click(object sender, EventArgs e)
        {            
            Ticket_Overview form = new Ticket_Overview(user);
            form.Show();
            this.Hide();
        }
    }
}
