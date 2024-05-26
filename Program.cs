using System;

namespace bilety
{
    class Program
    {
      
            static void Main(string[] args)
            {
                ITicketHandler techHandler = new TechnicalSupportHandler();
                ITicketHandler billingHandler = new BillingSupportHandler();
                ITicketHandler generalHandler = new GeneralSupportHandler();

                techHandler.SetNextHandler(billingHandler);
                billingHandler.SetNextHandler(generalHandler);

                Ticket ticket1 = new Ticket("technical", "Problem z systemem windows");
                Ticket ticket2 = new Ticket("billing", "Pytanie o fakture");
                Ticket ticket3 = new Ticket("general", "Nie działa komputer");

                techHandler.HandleRequest(ticket1);
                techHandler.HandleRequest(ticket2);
                techHandler.HandleRequest(ticket3);
            
        }
    }
}
