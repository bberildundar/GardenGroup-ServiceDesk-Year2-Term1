using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using MongoDB.Bson;

namespace Logic
{
    public class TicketService
    {
        private TicketDao TicketDao; 
        private Ticket ticket;
        
        public TicketService()
        {
            TicketDao = new TicketDao();
        }

        // *** Achilleas Ballanos *** 686446 *** 
        public Ticket CreateTicketWithIncident(Incident incident)
        {
            return ticket = new Ticket(incident, Priority.ToBeDefined, new DateTime(), Status.HasToBeOpened, null);
        }

        public void AddTicketToDatabase(string collectionName, Ticket ticket)
        {
            TicketDao.AddTicketToDatabase(collectionName, ticket);
        }

        public List<Ticket> GetTicketsByUserEmail(string collectioName, string field, string userEmail)
        {
            return TicketDao.GetTicketsByUserEmail(collectioName, field, userEmail);
        }
        //end

        //Below coded by Roberta - 677676
        public List<Ticket> GetListOfTicketsFiltered(string field, string filter)
        {
            return TicketDao.GetListOfTicketsFiltered(field, filter);
        }

        public List<Ticket> GetListOfTickets()
        {
            return TicketDao.GetListOfTickets();
        }
        public void UpdateTicket(Ticket ticket)
        {
            TicketDao.UpdateTicket(ticket);
        }


        //end of Roberta's code
        //
        //

        // Betül Beril Dündar - 691136 - Additional functionality (Archiving tickets)
        public void DeleteTicketFromTicketCollection(Ticket ticket)
        {
            TicketDao.DeleteTicketFromTicketCollection(ticket); //deletes ticket because they are archived
        }
        //end of Betül Beril's code



        // *** Achilleas Ballanos *** 686446 *** Additional functionality -> Sort tickets by priority
        //
        public List<Ticket> GetTicketsSortedByField(string collectioName, string field, int sort)
        {
            return TicketDao.GetTicketsSortedByField(collectioName, field, sort);
        }
    }
}
