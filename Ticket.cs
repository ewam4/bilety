using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilety
{
    class Ticket
    {
        public string Type { get; }
        public string Description { get; }

        public Ticket(string type, string description)
        {
            Type = type;
            Description = description;
        }
    }
}
