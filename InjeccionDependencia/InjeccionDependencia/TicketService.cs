using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjeccionDependencia
{
    class TicketService
    {
        private readonly ITicketRepository _ticketRepository;

        public TicketService(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        private void PrintTicket(Ticket ticket)
        {
            Console.WriteLine("Id " + ticket.Id);
            Console.WriteLine("Name " + ticket.Name);
            Console.WriteLine("IssuedAt " + ticket.IssuedAt);
            Console.WriteLine("TicketNumber " + ticket.TicketNumber);
        }


        public string GenerateTicket(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("El campo nombre no puede ser Nulo o Vacio", nameof(name));

            Random rnd = new Random();
            int ticketNumber = rnd.Next(1000, 9999);
            int ticketID = rnd.Next(10000, 99999);
            DateTime dateTime = DateTime.Now;

            Ticket newticket = new Ticket();
            newticket.Id = ticketID;
            newticket.Name = name;
            newticket.IssuedAt = dateTime;
            newticket.TicketNumber = ticketNumber;

            try
            {
                _ticketRepository.saveTicket(newticket);
                PrintTicket(newticket);
                return "Ticket se Guardo correctamente";
            }
            catch (InvalidOperationException ex)
            {

                return ex.Message;
            }
        }

        public string GetTicket(int id)
        {
            try
            {
                Ticket getTicket= _ticketRepository.GetTicketById(id);
                if (getTicket == null)
                    throw new InvalidOperationException("Ticket no Existe");

                PrintTicket(getTicket);
                return "Realizado";

            }
            catch (Exception ex )
            {

                throw new InvalidOperationException("Fallo la Busqueda de Ticket", ex);
            }
        }

        public string UpdateTicket(Ticket updateTicket)
        {
            try
            {
                _ticketRepository.UpdateTicket(updateTicket);
                return "Ticket a sido Actualizado correctamente";
            }
            catch (InvalidOperationException ex)
            {

                return ex.Message;
            }

        }


        public string DeleteTicket(int id)
        {
            try
            {
                _ticketRepository.DeleteTicket(id);
                return "Ticket a sido Eliminado correctamente";
            }
            catch (InvalidOperationException ex)
            {

                return ex.Message;
            }

        }






    }
}
