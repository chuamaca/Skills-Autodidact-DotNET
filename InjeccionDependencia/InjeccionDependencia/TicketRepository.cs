using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjeccionDependencia
{
    public class TicketRepository : ITicketRepository
    {

        private List<Ticket> tickets = new List<Ticket>();

        public void saveTicket(Ticket ticket)
        {
            tickets.Add(ticket);
        }

        public List<Ticket> GetTickets() { return tickets; }

        public Ticket GetTicketById(int id)
        {
            return tickets.Find(x => x.Id == id);
        }
        public void UpdateTicket(Ticket upTicket)
        {
            int index = tickets.FindIndex(x => x.Id == upTicket.Id);
            if (index != -1)
                tickets[index] = upTicket;
        }

        public void DeleteTicket(int id)
        {
            int index = tickets.FindIndex(y => y.Id == id);
            if (index != -1)
                tickets.RemoveAt(index);
            else
                throw new InvalidOperationException("Id Ticket No Encontrado");
        }
    }
}
