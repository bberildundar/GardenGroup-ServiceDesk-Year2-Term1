using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using MongoDB.Bson;

namespace Logic //coded by Betül Beril Dündar - 691136 - for additional functionality.
{
    public class ArchiveTicketService
    {        
        ArchiveDao archiveDao;

        public ArchiveTicketService()
        {
            archiveDao = new ArchiveDao();
        }

        public void ArchiveTicket(Ticket ticket)
        {
            archiveDao.AddTicketToArchiveCollection(ticket);
        }

    }
}
