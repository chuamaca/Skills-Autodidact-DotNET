using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjeccionDependencia
{
    public interface ITicketRepository
    {
        void saveTicket(Ticket ticket);
        List<Ticket> GetTickets();
        Ticket GetTicketById(int id);
        void UpdateTicket(Ticket updateTicket);
        void DeleteTicket(int id);

    }
}
