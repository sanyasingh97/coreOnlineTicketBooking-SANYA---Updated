using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coreMovieTicketAdminPortal.Models;

namespace coreMovieTicketAdminPortal.Models
{
    public class MovieDbContext : DbContext
    {
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieDetail> MovieDetails { get; set; }
        public DbSet<Multiplex> Multiplexes { get; set; }
        public DbSet<Auditorium> Auditoriums { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlServer("Data Source=TRD-507;Initial Catalog=ProjectDatabase;Integrated Security=true");


        }

    }

}