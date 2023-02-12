using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model; 


namespace Logic
{
    public class UserService
    {
        UserDao userDb;        

        public UserService()
        {
            userDb = new UserDao();
        }

        //getting the USER LIST from Dao class.
        public List<User> GetListOfUsers()
        {
            return userDb.GetUserListFromDatabase();
        }

        //sending new user details to Dao class.
        public void AddUser(User user)
        {
            userDb.AddUserToDatabase(user);
        }

        //search specific user from db with their email address
        public User SearchUser(string email)
        {
            return userDb.FindUserByEmail(email);
        }        

        public User GetSpecificUser(string email, string attribute)
        {
            //return userDb.GetSpecificUser(email, attribute);
            return null;
        }
        public void UpdateUser(User user)
        {
            userDb.UpdateUser(user);
        }
        public List<User> GetUsersByAccessLevel(string attribute, AccessLevel accessLevel)
        {
            return userDb.GetUsersByAccessLevel(attribute, accessLevel);
        }
    }
}
