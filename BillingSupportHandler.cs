using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilety
{
    class BillingSupportHandler : ITicketHandler
    {
        private ITicketHandler _nextHandler;

        public void SetNextHandler(ITicketHandler handler)
        {
            _nextHandler = handler;
        }

        public void HandleRequest(Ticket ticket)
        {
            if (ticket.Type == "billing")
            {
                Console.WriteLine($"Handling billing ticket: {ticket.Description}");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(ticket);
            }
        }
    }
}
