using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Model
{
    [Serializable]
    public class Incident
    {
        [BsonElement("subject")]
        public string Subject { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }

        [BsonElement("dateTime")]
        public DateTime ReportedDate { get; set; }

        [BsonElement("reportedBy")]
        public string Email{ get; set; }

        public Incident(string subject, string description, DateTime reporteddate, string email)
        {
            Subject = subject;
            Description = description;
            ReportedDate = reporteddate;
            Email = email;
        }

        public Incident()
        {
        }

        // Roberta - 677676 coded the below:
        public static Incident Parse(BsonValue value)
        {
            Incident i = new Incident();
            i.Subject = value[0].ToString();
            i.Description = value[1].ToString();
            i.ReportedDate = (DateTime)value[2];
            i.Email = value[3].ToString();

            return i;
        }
    }
}
