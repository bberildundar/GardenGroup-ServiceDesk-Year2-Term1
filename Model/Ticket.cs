using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class Ticket
    {
        [BsonElement("_id")]
        public ObjectId Id { get; set; }

        [BsonElement("incident")]
        public Incident Incident { get; set; }

        [BsonElement("priority")]
        public Priority Priority { get; set; }

        [BsonElement("deadline")]
        public object Deadline { get; set; }

        [BsonElement("status")]
        public Status Status { get; set; }

        [BsonElement("resolvedBy")]
        public string Email { get; set; }

        public Ticket(Incident incident, Priority priority, object deadline, Status status, string email)
        {

            Incident = incident;
            Priority = priority;
            Deadline = deadline;
            Status = status;
            Email = email;
        }


        public Ticket(ObjectId id, Incident incident, Priority priority, object deadline, Status status, string email)

        {
            Id = id;
            Incident = incident;
            Priority = priority;
            Deadline = deadline;
            Status = status;
            Email = email;
        }

    }


}
