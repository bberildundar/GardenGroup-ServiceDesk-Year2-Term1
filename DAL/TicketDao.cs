using Model;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL
{
    public class TicketDao : BaseDAO
    {
        private IMongoDatabase db;

        public TicketDao()
        {
            db = GetDatabase();

        }

        //Roberta - 677676 conding this below:
        //retrive all tickets
        public List<Ticket> GetListOfTickets()
        {
            List<Ticket> tickets = new List<Ticket>();
            var document = GetAll("Ticket");

            foreach (var info in document)
            {
                ObjectId id = (ObjectId)info["_id"];
                Incident incident = Incident.Parse(info["incident"]);
                Priority priority = PriorityParse.Parse(info["priority"].ToString());
                DateTime deadline = (DateTime)info["deadline"];
                Status status = StatusParse.Parse(info["status"].ToString());
                string email = info["resolvedBy"].ToString();
                Ticket t = new Ticket(id, incident, priority, deadline, status, email);
                tickets.Add(t);
            }

            return tickets;

        }
        
        public List<Ticket> GetListOfTicketsFiltered(string field, string filter)
        {
            List<Ticket> tickets = new List<Ticket>();
            var document = GetSpecificDocumentList("Ticket", field, filter);

            foreach (var info in document)
            {
                ObjectId id = (ObjectId)info["_id"];
                Incident incident = Incident.Parse(info["incident"]);
                Priority priority = PriorityParse.Parse(info["priority"].ToString());
                DateTime deadline = (DateTime)info["deadline"];
                Status status = StatusParse.Parse(info["status"].ToString());
                string email = info["resolvedBy"].ToString();
                Ticket t = new Ticket(id, incident, priority, deadline, status, email);
                tickets.Add(t);
            }

            return tickets;
        }
        //End of Roberta's code
        //CK code

        //updates an already existing ticket with more info so the ones which only have incidents.
        public void UpdateTicket(Ticket ticket)
        {
            var collection = db.GetCollection<BsonDocument>("Ticket");
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ticket.Id);
            var list = GetTicketUpdateDefinitions(ticket);
            foreach (var item in list)
            {
                collection.UpdateOne(filter, item);
            }
        }
        //updates all the info of a ticket.
        private List<UpdateDefinition<BsonDocument>> GetTicketUpdateDefinitions(Ticket ticket)
        {
            var list = new List<UpdateDefinition<BsonDocument>>();
            list.Add(Builders<BsonDocument>.Update.Set("incident", ticket.Incident));
            list.Add(Builders<BsonDocument>.Update.Set("priority", (int)ticket.Priority));
            list.Add(Builders<BsonDocument>.Update.Set("deadline", ticket.Deadline));
            list.Add(Builders<BsonDocument>.Update.Set("status", StatusParse.Parse((Status)(int)ticket.Status)));
            list.Add(Builders<BsonDocument>.Update.Set("resolvedBy", ticket.Email));
            return list;
        }

        // *** Achilleas Ballanos *** 686446 *** 
        //
        // insert a ticket into the Ticket collection in the database
        public void AddTicketToDatabase(string collectionName, Ticket ticket)
        {
            InsertRecord(collectionName, ticket);
            UpdateTicket(ticket);
        }
        

        public List<Ticket> GetTicketsByUserEmail(string collectioName, string field, string userEmail)
        {
            var userTickets = GetTicketsByFieldValue(collectioName, field, userEmail);

            List<Ticket> tickets = new List<Ticket>();

            foreach (var ticket in userTickets)
            {
                ObjectId id = (ObjectId)ticket["_id"];
                Incident incident = Incident.Parse(ticket["incident"]);
                Priority priority = (Priority)(int)ticket["priority"];
                object deadline = ticket["deadline"];
                Status status = StatusParse.Parse((string)ticket["status"]);
                string email = ticket["resolvedBy"].ToString();
                Ticket t = new Ticket(id, incident, priority, deadline, status, email);
                tickets.Add(t);
            }
            return tickets;
        }

        // *** Achilleas Ballanos *** 686446 *** Additional functionality -> Sort tickets by field
        //
        public List<Ticket> GetTicketsSortedByField(string collectioName, string field, int sort)
        {

            List<BsonDocument> sortedTickets = GetSortedTickets(collectioName, field, sort);
            List<Ticket> tickets = new List<Ticket>();

            foreach (var ticket in sortedTickets)
            {
                ObjectId id = (ObjectId)ticket["_id"];
                Incident incident = Incident.Parse(ticket["incident"]);
                Priority priority = (Priority)(int)ticket["priority"];
                object  deadline = ticket["deadline"];
                Status status = StatusParse.Parse((string)ticket["status"]);
                string email = ticket["resolvedBy"].ToString();

                Ticket t = new Ticket(id, incident, priority, deadline, status, email);
                tickets.Add(t);
            }
            return tickets;

        }
        //End of Achilleas' code
        //

        // *** Betül Beril Dündar - 691136 - Additional functionality -> Archive Tickets
        //
        public void DeleteTicketFromTicketCollection(Ticket ticket)
        {
            var collection = db.GetCollection<BsonDocument>("Ticket");
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ticket.Id);

            collection.DeleteOne(filter);
        }
        //End of Betül Beril's code
    }
}