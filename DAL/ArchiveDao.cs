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
    //coded by Betül Beril Dündar - 691136 - Additional Functionality - Archiving Tickets 
    //DAO class for Archive Collection

    public class ArchiveDao : BaseDAO
    {
        private IMongoDatabase db;
        const string CollectionName = "TicketArchive";

        public ArchiveDao()
        {
            db = GetDatabase();
        }

        //adding artchived tickets to the Archive db collection.
        public void AddTicketToArchiveCollection<T>(T ticket)
        {
            InsertRecord(CollectionName, ticket);
        }        
    }
}
