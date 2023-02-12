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
using System.Windows.Forms.DataVisualization.Charting;

namespace UI
{
    public partial class Dashboard : Form
    {
        private User user;
        private TicketService ticketService = new TicketService();
        private IncidentReport incidentReport;
        List<Ticket> listOfTickets;
        List<Ticket> personalizedTickets;

        public Dashboard(User user)
        {
            InitializeComponent();
            this.user = user;

            // show dashboard for the logged in user and according to the his access level
            if (user.AccessLevel == AccessLevel.Admin)
            {
                listOfTickets = ticketService.GetListOfTickets();
                DisplayIncidents(listOfTickets);
                LoadChart(listOfTickets);
                btnEditTicket.Enabled = false;
            }
            else
            {
                btnDashboardInDashboardForm.Enabled = false;
                btnUserManagementInDashBoardForm.Visible = false;
                btnEditTicket.Visible = false;

                DisplayPersonalizedTickets();
                personalizedTickets = PersonalizedTickets();
                LoadChart(personalizedTickets);

            }
        }

        // *** Achilleas Ballanos *** 686446 *** 
        //
        // get tickets created by the user (regular employee)
        public List<Ticket> PersonalizedTickets()
        {
            List<Ticket> personalizedTickets = ticketService.GetTicketsByUserEmail("Ticket", "incident.reportedBy", user.Email);
            return personalizedTickets;
        }

        // display the tickets of the user (regular employee) in the list-view
        public void DisplayPersonalizedTickets()
        {
            listOfTickets = PersonalizedTickets();

            try
            {
                listViewTicketsByUser.Items.Clear();
                listViewTicketsByUser.View = View.Details;

                foreach (Ticket i in listOfTickets)
                {
                    string[] items = { i.Incident.Subject, i.Incident.Description, i.Incident.ReportedDate.ToString(), i.Status.ToString(), i.Priority.ToString() };
                    ListViewItem li = new ListViewItem(items);
                    this.listViewTicketsByUser.Items.Add(li);
                    li.Tag = i;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // combo box used to implement the sorting of tickets
        private void sortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sortBox.Text == "By priority")
            {
                DisplayTicketsSortedByPriority();
            }

            if (sortBox.Text == "Undo")
            {
                DisplayIncidents(listOfTickets);
            }
        }
        // end

        // *** Achilleas Ballanos *** 686446 *** Additional functionality -> Sort tickets by priority
        //  
        // method to display the sorted tickets for the logged in user and according to his access level 
        public void DisplayTicketsSortedByPriority()
        {
            try
            {
                listViewTicketsByUser.Items.Clear();
                listViewTicketsByUser.View = View.Details;

                List<Ticket> sortedTickets = new List<Ticket>();

                if (user.AccessLevel == AccessLevel.Admin)
                {
                    sortedTickets = ticketService.GetTicketsSortedByField("Ticket", "priority", -1);
                }
                else
                {
                    sortedTickets = GetSortedTicketsForEmployee();
                }

                foreach (Ticket i in sortedTickets)
                {
                    string[] tickets = {i.Incident.Subject, i.Incident.Description, i.Incident.ReportedDate.ToString(), i.Status.ToString(), i.Priority.ToString() };

                    ListViewItem li = new ListViewItem(tickets);
                    listViewTicketsByUser.Items.Add(li);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // get the sorted by priority tickets for the regular employee who's currently logged in
        public List<Ticket> GetSortedTicketsForEmployee()
        {
            List<Ticket> sortedTickets = ticketService.GetTicketsSortedByField("Ticket", "priority", -1);
            List<Ticket> list = new List<Ticket>();

            foreach (Ticket i in sortedTickets)
            {
                if (i.Incident.Email == user.Email)
                {
                    list.Add(i);
                }
            }

            return list;
        }

        // clear the chart to update it after a new incident is reported (ticket created)
        public void ResetChart()
        {
            foreach (var series in chartTickets.Series)
            {
                series.Points.Clear();
            }
        }

        // Roebrta 677676 coding the below
        private void DisplayIncidents(List<Ticket> listOfIncidents)
        {
            try
            {
                listViewTicketsByUser.Items.Clear();
                listViewTicketsByUser.View = View.Details;
                foreach (Ticket i in listOfIncidents)
                {
                    string[] items = { i.Incident.Subject, i.Incident.Description, i.Incident.ReportedDate.ToString(), i.Status.ToString(), i.Priority.ToString() };
                    ListViewItem li = new ListViewItem(items);
                    this.listViewTicketsByUser.Items.Add(li);
                    li.Tag = i;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //End of Roberta's code
        //
 

        // Betül Beril Dündar 691136:
        public void LoadChart(List<Ticket> tickets)
        {
            int hasToBeOpenedTicketNumber = 0;
            int openTicketNumber = 0;
            int resolvedTicketNumber = 0;
            int closedUnresolvedTicketNumber = 0;
            int escalatedToManagementTicketNumber = 0;

            foreach (Ticket ticket in tickets)
            {
                if (ticket.Status == Model.Status.HasToBeOpened)
                {
                    hasToBeOpenedTicketNumber++;
                }
                else if (ticket.Status == Model.Status.Open)
                {
                    openTicketNumber++;
                }
                else if (ticket.Status == Model.Status.Resolved)
                {
                    resolvedTicketNumber++;
                }
                else if (ticket.Status == Model.Status.ClosedUnresolved)
                {
                    closedUnresolvedTicketNumber++;
                }
                else if (ticket.Status == Model.Status.EscalatedToManagement)
                {
                    escalatedToManagementTicketNumber++;
                }
            }

            chartTickets.Titles.Add("Tickets Chart"); //adding the values to the chart
            chartTickets.Series["Series1"].IsValueShownAsLabel = true;
            chartTickets.Series["Series1"].Points.AddXY("Has To Be Opened", $"{hasToBeOpenedTicketNumber}");
            chartTickets.Series["Series1"].Points.AddXY("Open", $"{openTicketNumber}");
            chartTickets.Series["Series1"].Points.AddXY("Resolved", $"{resolvedTicketNumber}");
            chartTickets.Series["Series1"].Points.AddXY("Closed", $"{closedUnresolvedTicketNumber}");
            chartTickets.Series["Series1"].Points.AddXY("Escalated", $"{escalatedToManagementTicketNumber}");
        }
        // end of Betül Beril's code

        private void btnIncidentManagementInDashboardForm_Click(object sender, EventArgs e)
        {
            if (user.AccessLevel == AccessLevel.Admin)
            {
                Ticket_Overview form = new Ticket_Overview(user);
                form.Show();
            }
            else
            {
                incidentReport = new IncidentReport(user);
                incidentReport.Show();
                    
            }

            this.Hide();
        }

        private void btnUserManagementInDashBoardForm_Click(object sender, EventArgs e)
        {
            UserManagement form = new UserManagement(user);
            this.Hide();
            form.Show();
;
        }
        

        //start of myrthe's code
        private void listViewTicketsByUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewTicketsByUser.SelectedItems.Count != 0){
                btnEditTicket.Enabled = true;
            }

        }

        private void btnEditTicket_Click(object sender, EventArgs e)
        {
            AddTicket addTicket = new AddTicket((Ticket)listViewTicketsByUser.SelectedItems[0].Tag, user);
            addTicket.Show();
            this.Hide();
        }

       
        //end of myrthe's code - some additions made in AddTicket
    }
}

