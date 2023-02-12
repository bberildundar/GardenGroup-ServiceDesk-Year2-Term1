using System;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;

namespace DAL
{
    public class BaseDAO
    {
        private MongoClient client;
        private IMongoDatabase database;

        public BaseDAO()
        {
            client = new MongoClient("mongodb+srv://user:wachtwoord123@nosqlcluster.grrzdwp.mongodb.net/?retryWrites=true&w=majority");
            database = client.GetDatabase("NoSQLProjectDatabase");

        }

        public IMongoDatabase GetDatabase()
        {
            return database;
        }

        // *** Achilleas Ballanos *** 686446 ***
        public void InsertRecord<T>(string table, T record)
        {
            var collection = database.GetCollection<T>(table);
            collection.InsertOne(record);
            
        }

        public List<BsonDocument> GetTicketsByFieldValue(string collectionName, string field, string value)
        {
            var collection = database.GetCollection<BsonDocument>(collectionName);
            var filter = Builders<BsonDocument>.Filter.Eq(field, value);
            var documents = collection.Find(filter).ToList();

            return documents;

        }
        // end

        //Roberta 677676 coded the below:

        protected List<BsonDocument> GetAll(string collectionName)
        {
            //using this to get all tickets/users
            var collection = database.GetCollection<BsonDocument>(collectionName);
            var filter = Builders<BsonDocument>.Filter.Empty;
            var Document = collection.Find(filter).ToList();
            return Document;
        }
        protected List<BsonDocument> GetSpecificDocumentList(string collectionName, string searchValue, string attribute)
        {
            try
            {
                var collection = database.GetCollection<BsonDocument>(collectionName);
                var filter = Builders<BsonDocument>.Filter.Eq(searchValue, attribute);
                var documents = collection.Find(filter).ToList();
                return documents;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<T> FindByQuery<T>(string table, FilterDefinition<T> filter)
        {
            var collection = database.GetCollection<T>(table);
            return collection.Find<T>(filter).ToList();
        }
        //End of Roberta's code


        // *** Achilleas Ballanos *** 686446 *** Additional functionality -> Sort tickets by field
        //
        public List<BsonDocument> GetSortedTickets(string collectionName, string field, int sort)
        {
            var collection = database.GetCollection<BsonDocument>(collectionName);

            BsonDocument pipelineSort = new BsonDocument {
            {
                "$sort",new BsonDocument{
                    {field,sort}
                }
            }
            };

            BsonDocument[] pipeline = new BsonDocument[] { pipelineSort };
            List<BsonDocument> sortedTickets = collection.Aggregate<BsonDocument>(pipeline).ToList();

            return sortedTickets;
        }
    }
}
