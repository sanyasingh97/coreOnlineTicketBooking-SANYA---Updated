using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreMovieTicketAdminPortal.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int UserDetailId { get; set; }
        public int LocationId { get; set; }
        public int MultiplexId { get; set; }
        public int AuditoriumId { get; set; }

        public double BookingAmount { get; set; }
        public UserDetail UserDetail { get; set; }
        public Location Location { get; set; }

        public Multiplex Multiplex { get; set; }

        public Auditorium Auditorium{ get; set; }

    }
}
