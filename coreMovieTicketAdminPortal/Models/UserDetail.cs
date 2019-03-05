using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreMovieTicketAdminPortal.Models
{
    public class UserDetail
    {
        public int UserDetailId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int ContactNo { get; set; }

        public string UserName { get; set; }
        public string Usertype { get; set; }
        public List<Booking> Bookings { get; set; }
    }
}
