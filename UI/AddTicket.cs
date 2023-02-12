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
using MongoDB.Bson;

namespace UI
{
    public partial class AddTicket : Form
    {
        TicketService TicketService;
        bool newIncident;
        UserService UserService;
        Ticket ticket;
        User user;
        //coded by Cody unless otherwise specified.
        public AddTicket(User user)
        {
            InitializeComponent();
            newIncident = true;
            TicketService = new TicketService();
            UserService = new UserService();
            InitializeForm(user);
            ticket = null;
        }
        public AddTicket(Ticket ticket,User user)
        {
            InitializeComponent();
            newIncident = false;
            this.ticket = ticket;
            TicketService = new TicketService();
            UserService = new UserService();
            InitializeForm(user);
        }

        private void btnConfirmTicket_Click(object sender, EventArgs e)
        {
            try
            {
                CheckBoxes();
                if (newIncident)
                {
                    Incident incident = new Incident(txtIncidentSubject.Text, txtDescription.Text, DateTime.Now, txtEmail.Text);
                    ticket = new Ticket(incident, PriorityParse.Parse(cbPriority.SelectedItem.ToString()), dateTimePickerDeadline.Value, Status.Open, null);
                    TicketService.AddTicketToDatabase("Ticket", ticket);
                }
                else if (!newIncident && ticket.Status == Status.Open)
                {
                    ticket.Status = StatusParse.Parse(cbStatus.SelectedItem.ToString());
                    ticket.Email = cbResolvedBy.SelectedItem.ToString();
                    TicketService.UpdateTicket(ticket);
                }
                else if (!newIncident && ticket.Status == Status.HasToBeOpened)
                {
                    ticket.Status = Status.Open;
                    ticket.Priority = PriorityParse.Parse(cbPriority.SelectedItem.ToString());
                    ticket.Deadline = dateTimePickerDeadline.Value;
                    TicketService.UpdateTicket(ticket);
                }
                else if (!newIncident && ticket.Status != Status.Open)
                {
                    ticket.Email = cbResolvedBy.SelectedText;
                    ticket.Status = StatusParse.Parse(cbStatus.SelectedItem.ToString());
                    ticket.Email = cbResolvedBy.SelectedItem.ToString();
                    TicketService.UpdateTicket(ticket);
                }
                else
                {
                    ticket.Status = StatusParse.Parse(cbStatus.SelectedItem.ToString());
                    ticket.Priority = PriorityParse.Parse(cbPriority.SelectedItem.ToString());
                    ticket.Deadline = dateTimePickerDeadline.Value;
                    ticket.Email = cbResolvedBy.SelectedItem.ToString();
                    TicketService.UpdateTicket(ticket);
                }
                OpenDashboardAndClose();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }



        public void InitializeForm(User user)
        {
            this.user = user;
            if (newIncident == false && ticket.Status == Status.Open)
            {
                SetupForm();
                dateTimePickerDeadline.Value = (DateTime)ticket.Deadline;
                dateTimePickerDeadline.Enabled = false;
                cbPriority.Text = ticket.Priority.ToString();
                cbPriority.Enabled = false;
                cbStatus.Enabled = true;
                btnConfirmTicket.Text = "CLOSE TICKET";
                cbResolvedBy.Enabled = true;
                lblResolvedBy.Enabled = true;
            }
            else if (!newIncident && ticket.Status == Status.HasToBeOpened)
            {
                SetupForm();
            }
            else if(!newIncident && ticket.Status != Status.Open) //if editing a closed ticket - coded by Myrthe
            {
                SetupForm();
                dateTimePickerDeadline.Value = (DateTime)ticket.Deadline;
                dateTimePickerDeadline.Enabled = false;
                cbStatus.Enabled = true;
                cbPriority.Text = ticket.Priority.ToString();
                cbPriority.Enabled = false;
                cbStatus.Text = ticket.Status.ToString();
                cbResolvedBy.Text = ticket.Email;
                btnConfirmTicket.Text = "SAVE CHANGES";
                cbResolvedBy.Enabled = true;
                lblResolvedBy.Enabled = true;
                if (ticket.Status == Status.Resolved || ticket.Status == Status.EscalatedToManagement)
                {
                    cbResolvedBy.SelectedItem = ticket.Email;
                }
            }
            else if (newIncident == false)
            {
                SetupForm();
            }
            else if (newIncident)
            {
                cbStatus.Enabled = false;
                cbResolvedBy.Enabled = false;
                SetupComboBoxes();
            }
        }

        private void SetupForm()
        {
            dateTimePickerDeadline.Value = DateTime.Now;

            cbResolvedBy.Enabled = false;
            cbResolvedBy.Visible = true;
            lblResolvedBy.Enabled = false;
            lblResolvedBy.Visible = true;
            cbStatus.Enabled = false;
            SetupComboBoxes();
            txtIncidentSubject.Text = ticket.Incident.Subject;
            txtDescription.Text = ticket.Incident.Description;
            txtEmail.Text = ticket.Incident.Email;
            txtIncidentSubject.Enabled = false;
            txtEmail.Enabled = false;
            txtDescription.Enabled = false;

        }

        private void SetupComboBoxes()
        {
            cbPriority.Items.Add("Low");
            cbPriority.Items.Add("Medium");
            cbPriority.Items.Add("High");
            foreach (User u in UserService.GetUsersByAccessLevel("accessLevel", AccessLevel.Admin))
                cbResolvedBy.Items.Add(u.Email);
            foreach (string name in Enum.GetNames(typeof(Status)))
                cbStatus.Items.Add(name);
            cbStatus.Items.Remove("HasToBeOpened");
        }

        public void CheckBoxes()
        {
            if (txtDescription.Text.Equals(""))
                throw new Exception("Please enter a incident description.");
            if (txtEmail.Text.Equals(""))
                throw new Exception("Please enter the email of the reporter.");
            if (txtIncidentSubject.Text.Equals(""))
                throw new Exception("Please enter the incident subject.");
            if (cbPriority.SelectedItem == null)
                throw new Exception("Please enter a priority.");
            if (dateTimePickerDeadline.Value == DateTime.Now)
                throw new Exception("Please pick a date that isn't today.");
            if (!newIncident && ticket.Status == Status.Open && cbResolvedBy.SelectedItem.ToString().Equals(""))
                throw new Exception("Please enter the email of the person who resolved the incident.");
            if (!newIncident && cbStatus.SelectedItem == null && ticket.Status != Status.HasToBeOpened)
                throw new Exception("Pick a status of the ticket.");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OpenDashboardAndClose();
        }
        private void OpenDashboardAndClose()
        {
            Dashboard dashboard = new Dashboard(user);
            dashboard.Show();
            Hide();
        }
    }
}
