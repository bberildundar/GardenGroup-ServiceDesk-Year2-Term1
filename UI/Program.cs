using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Logic;

namespace UI
{
    internal static class Program
    {
        //Project setup done by Cody

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());

            //Application.Run(new AddTicket());
            //TicketService ticketService = new TicketService();
            //Application.Run(new AddTicket(ticketService.GetListOfTickets()[12]));
            //Application.Run(new Ticket_Overview());
            //Application.Run(new UserManagement());
            //Application.Run(new AddUser());
        }
    }
}
