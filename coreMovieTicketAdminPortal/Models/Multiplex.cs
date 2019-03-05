
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreMovieTicketAdminPortal.Models
{
    public class Multiplex
    {
        public int MultiplexId { get; set; }

        public string MultiplexName { get; set; }
        public string MultiplexDescription { get; set; }
        public List<Booking> Bookings { get; set; }
    }
}
