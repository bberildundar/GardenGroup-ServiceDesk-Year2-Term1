using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    public enum Status { HasToBeOpened, Open, Resolved, ClosedUnresolved ,EscalatedToManagement }


    public static class StatusParse
    {
        public static string Parse(Status status)
        {
            switch (status)
            {
                case Status.HasToBeOpened:
                    return "Has To Be Opened";
                case Status.Open:
                    return "Open";
                case Status.Resolved:
                    return "Resolved";
                case Status.ClosedUnresolved:
                    return "Closed Unresolved";
                case Status.EscalatedToManagement:
                    return "Escalated To Management";
                default:
                    break;
            }
            return null;
        }

        //Roberta - 677676 coded the below
        public static Status Parse(string status)
        {
            switch (status.ToLower())
            {
                case "Has To Be Opened":
                    return Status.HasToBeOpened;
                case "open":
                    return Status.Open;
                case "resolved":
                    return Status.Resolved;
                case "closedunresolved":
                    return Status.ClosedUnresolved;
                case "escalatedtomanagement":
                    return Status.EscalatedToManagement;
                case "closed unresolved":
                    return Status.ClosedUnresolved;
                case "escalated to management":
                    return Status.EscalatedToManagement;
                default:
                    break;
            }
            return Status.HasToBeOpened;
        }
    }
}
