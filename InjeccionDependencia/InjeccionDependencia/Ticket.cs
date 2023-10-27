using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjeccionDependencia
{
    public class Ticket
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int TicketNumber { get; set; }
        public DateTime IssuedAt { get; set; }
    }
}
