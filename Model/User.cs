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
    public class User
    {
        [BsonElement("_id")]
        public ObjectId Id { get; set; }

        [BsonElement("firstName")]
        public string FirstName { get; set; }

        [BsonElement("lastName")]
        public string LastName { get; set; }
        public string FullName { get { return $"{FirstName} {LastName}"; } }
        
        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("hash")]
        public string Hash { get; set; }
        [BsonElement("salt")]
        public string Salt { get; set; }
                
        public string Password { get; set; }

        [BsonElement("accessLevel")]
        public AccessLevel AccessLevel { get; set; }    

        [BsonElement("branchAddress")]
        public BranchAddress BranchAddress { get; set; }
              
        
        public User(string firstName, string lastName, string email, string hash, string salt, AccessLevel accessLevel, BranchAddress branchAddress) //used to add user and login functionality
        {    
            FirstName = firstName;
            LastName = lastName;
            Email = email;            
            Hash = hash;
            Salt = salt;
            AccessLevel = accessLevel;
            BranchAddress = branchAddress;
            
        }        

        public User(ObjectId id, string firstName, string lastName, string email) //used to get "only required data" for User list in the UserManagement form.
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;            
        }

        //for password hashing
        public static string HashMethod(string Password, string Salt)
        {
            return ComputeHash(Encoding.UTF8.GetBytes(Password), Encoding.UTF8.GetBytes(Salt));
        }

        public static string ComputeHash(byte[] bytesToHash, byte[] salt)
        {
            var byteResult = new Rfc2898DeriveBytes(bytesToHash, salt, 10000);
            return Convert.ToBase64String(byteResult.GetBytes(24));
        }

        public static string GenerateSalt()
        {
            var bytes = new byte[128 / 8];
            var rng = new RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            return Convert.ToBase64String(bytes);
        }
    }
}
