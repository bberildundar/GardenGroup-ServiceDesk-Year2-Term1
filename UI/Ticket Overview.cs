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

namespace UI
{
    //This was coded by Roberta Paracchini - 677676
    public partial class Ticket_Overview : Form
    {
        //the two list below are global because I use them in txtEmailToFilter_TextChanged
        //Roberta
        private List<Ticket> listOfIncidents;
        private List<Ticket> listOfTickets;
        private TicketService ticketService = new TicketService();
        private User user;
        public Ticket_Overview(User user)
        {
            InitializeComponent();

            listOfIncidents = ticketService.GetListOfTicketsFiltered("status", "Has To Be Opened");
            listOfTickets = ticketService.GetListOfTicketsFiltered("status", "Open");
            DisplayIncidents();
            DisplayTickets();
            btnManageTicketInTicketOverview.Enabled = false;
            //each time the form is loaded tickets will be checked and might be escalated to management
            EscalateTicketsToManagementBasedOnTiming();
            this.user = user;
        }

        //load all incidents "hasToBeOpened" regardless of the staff
        private void DisplayIncidents()
        {
            try
            {
                listviewIncidentsOverview.Items.Clear();
                listviewIncidentsOverview.View = View.Details;
                foreach (Ticket i in listOfIncidents)
                {
                    string[] items = { i.Incident.Subject, i.Incident.Email, i.Incident.ReportedDate.ToString(), i.Status.ToString() };
                    ListViewItem li = new ListViewItem(items);
                    this.listviewIncidentsOverview.Items.Add(li);
                    li.Tag = i;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DisplayTickets()
        {
            try
            {
                listviewTicketOverview.Items.Clear();
                listviewTicketOverview.View = View.Details;
                foreach (Ticket i in listOfTickets)
                {
                    string[] items = { i.Incident.Subject, i.Incident.Email, i.Deadline.ToString(), i.Status.ToString(), i.Priority.ToString() };
                    ListViewItem li = new ListViewItem(items);
                    this.listviewTicketOverview.Items.Add(li);
                    li.Tag = i;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        //open Dashboard form
        private void btnDashboardInTicketOverviewForm_Click(object sender, EventArgs e)
        {
            Dashboard form = new Dashboard(user);
            form.Show();
            this.Close();
        }


        //open UserManagement form
        private void btnUserManagementInTicketOverviewForm_Click(object sender, EventArgs e)
        {
            UserManagement form = new UserManagement(user);
            form.Show();
            this.Close();
        }

        private void listviewIncidentsOverview_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listviewIncidentsOverview.SelectedItems.Count == 0)
            {
                return;
            }
            //change button text
            btnCreateTicketInTicketOverview.Text = "CONVERT TO TICKET";
        }

        private void btnCreateTicketInTicketOverview_Click(object sender, EventArgs e)
        {
            AddTicket addTicket = new AddTicket(user);
            //Send the incident to convert to ticket to the AddTicketForm
            if (listviewIncidentsOverview.SelectedItems.Count != 0)
            {
                addTicket = new AddTicket((Ticket)listviewIncidentsOverview.SelectedItems[0].Tag, user);
            }
            addTicket.Show();
            this.Hide();
        }

        private void btnManageTicketInTicketOverview_Click(object sender, EventArgs e)
        {
            //get select ticket and open form to resolve it
            AddTicket manageTicket = new AddTicket(user);
            //Send the incident to convert to ticket to the AddTicketForm
            if (listviewTicketOverview.SelectedItems.Count != 0)
            {
                manageTicket = new AddTicket((Ticket)listviewTicketOverview.SelectedItems[0].Tag, user);
            }
            manageTicket.Show();
            this.Hide();
        }

        private void listviewTicketOverview_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Enable the manage ticket if something is selected
            if (listviewTicketOverview.SelectedItems.Count != 0)
                btnManageTicketInTicketOverview.Enabled = true;
            else
                return;
        }

        private void SortIncidentsAndTIcketsByEmail()
        {
            string emailToSort = txtEmailToFilter.Text;
            listOfIncidents = ticketService.GetListOfTicketsFiltered("incident.reportedBy", emailToSort);
            listOfTickets = ticketService.GetListOfTicketsFiltered("resolvedBy", emailToSort);

            //if textbox clear then reload all tickets/incident
            if (txtEmailToFilter.Text.Equals(""))
            {
                listOfIncidents = ticketService.GetListOfTicketsFiltered("status", "Has To Be Opened");
                listOfTickets = ticketService.GetListOfTicketsFiltered("status", "Open");
            }
            DisplayIncidents();
            DisplayTickets();
        }

        private void txtEmailToFilter_TextChanged(object sender, EventArgs e)
        {
            SortIncidentsAndTIcketsByEmail();
        }

        private void txtEmailToFilter_OnClick(object sender, EventArgs e)
        {
            txtEmailToFilter.Clear();
        }

        //additional functionality by Roberta 677676

        private void EscalateTicketsToManagementBasedOnTiming()
        {
            //if a ticket has been reported and not closed for over 21 days status will change to escalated to Management
            //and only if priority is high or medium, low priority tickets will simply be "Closed Unresolved"
            int dayToEscalateTicket = 21;
            foreach (Ticket ticket in listOfTickets)
            {
                TimeSpan differenceBetweenNowAndTickedOpened = DateTime.Now - ticket.Incident.ReportedDate;
                if (differenceBetweenNowAndTickedOpened.TotalDays >= dayToEscalateTicket)
                {
                    if (ticket.Priority == Priority.Low)
                    {
                        ticket.Status = Status.ClosedUnresolved;
                    }
                    else
                    {
                        ticket.Status = Status.EscalatedToManagement;
                    }
                    ticketService.UpdateTicket(ticket);
                }
            }
        }

        //additional functionality by Betül Beril Dündar 691136 - Archiving Tickets Button (opens archive ticket form)
        private void btnArchivingInTicketOverviewForm_Click(object sender, EventArgs e)
        {
            ArchivingTickets form = new ArchivingTickets(user);
            form.Show();
            this.Hide();
        }
    }
}
