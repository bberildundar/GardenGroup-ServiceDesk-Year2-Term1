using Model;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Net.Sockets;

namespace DAL
{
    public class UserDao : BaseDAO
    {
        private IMongoDatabase db;
        const string CollectionName = "User";

        public UserDao()
        {
            db = GetDatabase();

        }

        // start of Betül Beril Dündar 691136's code      
        public List<User> GetUserListFromDatabase() //getting the USER LIST for the User Management from the MongoDB database
        {
            List<User> users = new List<User>();
            var doc = GetAll(CollectionName);

            foreach (var item in doc)
            {
                ObjectId id = (ObjectId)item["_id"];
                string firstName = item["firstName"].ToString();
                string lastName = item["lastName"].ToString();                
                string email = item["email"].ToString();

                User user = new User(id, firstName, lastName, email);                
                users.Add(user);
            }
            return users;
        }
        
        public void AddUserToDatabase<T>(T user) //adding new user as new record to the mongodb database
        {
            InsertRecord(CollectionName, user);
        }
        
        public User FindUserByEmail(string email) //finding specific user with their email 
        {
            var filter = Builders<User>.Filter.Eq("email", email);
            List<User> users = FindByQuery<User>(CollectionName, filter);

            return users.Count > 0 ? users[0] : null;
        }
        // end of Betül Beril's code
        //
        //
        //

        public List<User> GetUsersByAccessLevel(string attribute,AccessLevel accessLevel )
        {
            var collection = db.GetCollection<BsonDocument>("User");
            var filter = Builders<BsonDocument>.Filter.Eq(attribute, accessLevel);
            var documents = collection.Find(filter).ToList();
            List<User> users = new List<User>();
            foreach (var item in documents)
            {
                ObjectId id = (ObjectId)item["_id"];
                string firstName = item["firstName"].ToString();
                string lastName = item["lastName"].ToString();
                string email = item["email"].ToString();

                User user = new User(id, firstName, lastName, email);
                users.Add(user);
            }
            return users;
        }       

        public List<BsonDocument> GetSpecificUser(string email, string attribute)
        {
            var collection = db.GetCollection<BsonDocument>("User");
            var filter = Builders<BsonDocument>.Filter.Eq(attribute, email);
            var documents = collection.Find(filter).ToList();

            var user1 = documents[0];
          //  User loggedinuser = new User(user1[1].ToString(), user1[2].ToString(), user1[6].ToString(), Enum.Parse(AccessLevel, user1[4].ToString()), (BranchAddress)user1[5], user1[3].ToString()); TODO : fix this.

            return documents;

        }
        public void UpdateUser(User user)
        {
            var collection = db.GetCollection<BsonDocument>("User");
            var filter = Builders<BsonDocument>.Filter.Eq("_id", user.Id);
            var list = GetUserUpdateDefinitions(user);
            foreach (var item in list)
            {
                collection.UpdateOne(filter, item);
            }
        }
        //updates all the info of a ticket.
        private List<UpdateDefinition<BsonDocument>> GetUserUpdateDefinitions(User user)
        {
            var list = new List<UpdateDefinition<BsonDocument>>();
            list.Add(Builders<BsonDocument>.Update.Set("firstName", user.FirstName));
            list.Add(Builders<BsonDocument>.Update.Set("lastName", user.LastName));
            list.Add(Builders<BsonDocument>.Update.Set("email", user.Email));
            list.Add(Builders<BsonDocument>.Update.Set("accessLevel", user.AccessLevel));
            list.Add(Builders<BsonDocument>.Update.Set("hash", user.Hash));
            list.Add(Builders<BsonDocument>.Update.Set("salt", user.Salt));
            list.Add(Builders<BsonDocument>.Update.Set("branchAddress", user.BranchAddress));
            return list;
        }
    }
}