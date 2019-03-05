using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreMovieTicketAdminPortal.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string MovieDescription { get; set; }
        public List<Booking> Bookings { get; set; }

        public MovieDetail MovieDetail { get; set; }

    }
}
