using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreMovieTicketAdminPortal.Models
{
    public class Auditorium
    {
        public int AuditoriumId { get; set; }
        public string AuditoriumName { get; set; }
        public string AuditoriumDescription { get; set; }
        public int Seats { get; set; }
        public List<Booking> Bookings { get; set; }

    }
}
