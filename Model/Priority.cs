using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum Priority {ToBeDefined, Low, Medium, High}

    // parse priority value to string 
    public static class PriorityParse
    {
        public static string Parse(int priority)
        {
            switch (priority)
            {
                case 0:
                    return "To Be Defined";
                case 1:
                    return "Low";
                case 2:
                    return "Medium";
                case 3:
                    return "High";
                default:
                    break;
            }
            return null;
        }

        public static Priority Parse(string priority)
        {
            switch (priority.ToLower())
            {
                case "0":
                    return Priority.ToBeDefined;
                case "1":
                    return Priority.Low;
                case "2":
                    return Priority.Medium;
                case "3":
                    return Priority.High;
                case "tobedefined":
                    return Priority.ToBeDefined;
                case "low":
                    return Priority.Low;
                case "medium":
                    return Priority.Medium;
                case "high":
                    return Priority.High;
                default:
                    break;
            }
            return Priority.ToBeDefined;
        }
    }
    
}
