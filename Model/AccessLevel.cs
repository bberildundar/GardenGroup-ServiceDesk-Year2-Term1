using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum AccessLevel { Basic,Admin} //access level of the user basic is for regular GG employees, Admin is for service desk
    public static class AccessLevelConverter
    {
        public static AccessLevel ConvertToAccessLevel(string accessLevel)
        {
            switch (accessLevel)
            {
                case "Basic":
                    return AccessLevel.Basic;
                case "Admin":
                    return AccessLevel.Admin;               
                default:
                    break;
            }
            return AccessLevel.Basic;
        }
    }

}