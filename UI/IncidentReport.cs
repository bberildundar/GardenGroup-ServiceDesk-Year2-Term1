using Logic;
using Model;
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

namespace UI
{
    // *** Achilleas Ballanos *** 686446 *** 
    public partial class IncidentReport : Form
    {
        private Dashboard dashboard;
        private User user;
        private Ticket ticket;
        private TicketService ticketService;
        private Incident incident;
        private string collectionName;


        public IncidentReport(User user)
        {
            InitializeComponent();
            this.user = user;
            ticketService = new TicketService();
            dashboard = new Dashboard(user);
            lblMessage.Visible = false;
            btnIncidentManagement.Enabled = false;


            // name of the ticket collection in the database
            collectionName = "Ticket";

            // display the name of the person who's logged in
            lblUserName.Text = user.FirstName;

            if (TextBoxesChecked())
            {
                btnCancel.Enabled = false;
                btnReportIncident.Enabled = false;
            }

        }

        private void btnReportIncident_Click(object sender, EventArgs e)
        {
            try
            { // get the incident details from the user and create an incident object
                string subject = txtSubject.Text;
                string description = txtDescription.Text;
                DateTime reportedDate = DateTime.Now;

                incident = new Incident(subject, description, reportedDate, user.Email);

                // add incident to a new ticket
                ticket = CreateTicketWithIncident(incident);

                // create a ticket with the information about the incident
                AddTicketToDatabase(collectionName, ticket);

                // display a mesage to notify the user for the successfull insertion
                // and reset text boxes
                _ = DisplayMessageAsync();
                ResetTextBoxes();

                UpdateDashboardTicketView();
            }
            catch (Exception exception) { MessageBox.Show("Failed to log the incident! Try again: " + exception.Message); }
            
        }

        // method to update the ticket list in the dashboard after a new incident is reported (ticket created)
        public void UpdateDashboardTicketView()
        {
            dashboard.DisplayPersonalizedTickets();
            dashboard.ResetChart();
            List<Ticket> tickets = dashboard.PersonalizedTickets();
            dashboard.LoadChart(tickets);

        }

        public void ResetTextBoxes()
        {
            txtSubject.Text = "";
            txtDescription.Text = "";
        }

        public bool TextBoxesChecked()
        {
            if (txtSubject.Text != "" && txtDescription.Text != "")
            {
                return true;
            }
            return false;
        }

        // create a ticket with an embedded incident object
        private Ticket CreateTicketWithIncident(Incident incident)
        {
            return ticketService.CreateTicketWithIncident(incident);

        }

        // method to store a ticket into the database
        private void AddTicketToDatabase(string table, Ticket ticket)
        {
            ticketService.AddTicketToDatabase(table, ticket);
        }

        public async Task DisplayMessageAsync()
        {
            lblMessage.Visible = true;
            await Task.Delay(3000);
            lblMessage.Visible = false;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetTextBoxes();
        }
    }
}
