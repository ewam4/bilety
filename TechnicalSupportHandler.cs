using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilety
{
    class TechnicalSupportHandler : ITicketHandler
    {
        private ITicketHandler _nextHandler;

        public void SetNextHandler(ITicketHandler handler)
        {
            _nextHandler = handler;
        }

        public void HandleRequest(Ticket ticket)
        {
            if (ticket.Type == "technical")
            {
                Console.WriteLine($"Handling technical ticket: {ticket.Description}");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(ticket);
            }
        }
    }
}
