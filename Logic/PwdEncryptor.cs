using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Logic;
using Model;

namespace Logic
{
    public class PwdEncryptor
    {
        public string Encrypt(string pwd)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(pwd);
            SHA256Managed sHA256Managed = new SHA256Managed();
            byte[] hash = sHA256Managed.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }

        public bool CompareHashToPassword(User user, string password)
        {
            UserService userService = new UserService();
            string userPassword = userService.GetPassword(user);
            string hashedPassword = Encrypt(password);
            return hashedPassword == userPassword;
        }

    }
}