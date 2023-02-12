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
using System.Collections;

namespace UI //coded by Betül Beril Dündar - 691136 (additional functionality)
{
    public partial class ArchivingTickets : Form
    {        
        UserService userService;
        TicketService ticketService;
        ArchiveTicketService archiveTicketService;
        User user;

        public ArchivingTickets(User user) 
        {
            InitializeComponent();
            this.user = user;
            userService = new UserService();
            ticketService = new TicketService(); 
            archiveTicketService = new ArchiveTicketService();
        }

        private void btnArchiveAll_Click(object sender, EventArgs e)
        {       
            try
            {    
                List<Ticket> closedTickets = GetClosedTickets();
                if (closedTickets.Count == 0) // checks if there are any closed tickets to be archived
                {
                    MessageBox.Show("No closeed tickets found to be archived.");
                    return;
                }

                foreach (Ticket ticket in closedTickets)
                {
                    archiveTicketService.ArchiveTicket(ticket);
                    ticketService.DeleteTicketFromTicketCollection(ticket);
                }

                MessageBox.Show("Closed tickets have been successfully archived.");
                CloseArchivingForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while archiving tickets. Please try again. " + ex.Message);
            }

        }

        public List<Ticket> GetClosedTickets() //gets list of tickets which have the status of closed
        {
            List<Ticket> ticketList = ticketService.GetListOfTickets();

            List<Ticket> closedTickets = new List<Ticket>();

            foreach (Ticket item in ticketList)
            {
                if (item.Status == Status.ClosedUnresolved
                    || item.Status == Status.Resolved)
                {
                    closedTickets.Add(item);
                }
            }

            return closedTickets;
        }

        private void btnArchiveBefore_Click(object sender, EventArgs e)
        {
            try
            {
                List<Ticket> ticketsBeforeDate = GetTicketsWithSpecificDate();
                if (ticketsBeforeDate.Count == 0) //checks if there are any tickets before the date
                {
                    MessageBox.Show("No ticket found to be archived.");
                    return;
                }
;

                foreach (Ticket ticket in ticketsBeforeDate)
                {
                    archiveTicketService.ArchiveTicket(ticket);
                    ticketService.DeleteTicketFromTicketCollection(ticket);
                }

                MessageBox.Show("Tickets before specified date have been successfully archived.");
                CloseArchivingForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while archiving tickets. Please try again. " + ex.Message);
            }
        }


        public List<Ticket> GetTicketsWithSpecificDate() //gets the list of tickets before the date
        {
            DateTime specificDate = datePickerArchiveTickets.Value.Date;

            List<Ticket> ticketList = ticketService.GetListOfTickets();

            List<Ticket> ticketsBeforeDate = new List<Ticket>();

            foreach (Ticket item in ticketList)
            {
                if (item.Incident.ReportedDate < specificDate) //selects the tickets before the date
                {
                    ticketsBeforeDate.Add(item);
                }
            }

            return ticketsBeforeDate;
        }

        public void CloseArchivingForm()
        {
            try
            {
                Ticket_Overview ticket_OverviewForm = new Ticket_Overview(user);
                this.Hide();
                ticket_OverviewForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem while loading Ticket Overview Form. " + ex.Message);
            }

        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            try
            {
                Ticket_Overview ticket_OverviewForm = new Ticket_Overview(user);
                this.Hide();
                ticket_OverviewForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem while loading Ticket Overview Form. " + ex.Message);
            }
        }
    }
}
