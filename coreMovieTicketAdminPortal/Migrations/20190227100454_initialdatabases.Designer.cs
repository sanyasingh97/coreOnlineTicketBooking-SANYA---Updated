﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using coreMovieTicketAdminPortal.Models;

namespace coreMovieTicketAdminPortal.Migrations
{
    [DbContext(typeof(MovieDbContext))]
    [Migration("20190227100454_initialdatabases")]
    partial class initialdatabases
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("coreMovieTicketAdminPortal.Models.Auditorium", b =>
                {
                    b.Property<int>("AuditoriumId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuditoriumDescription");

                    b.Property<string>("AuditoriumName");

                    b.Property<int>("Seats");

                    b.HasKey("AuditoriumId");

                    b.ToTable("Auditoriums");
                });

            modelBuilder.Entity("coreMovieTicketAdminPortal.Models.Booking", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuditoriumId");

                    b.Property<double>("BookingAmount");

                    b.Property<int>("LocationId");

                    b.Property<int?>("MovieId");

                    b.Property<int>("MultiplexId");

                    b.Property<int>("UserDetailId");

                    b.HasKey("BookingId");

                    b.HasIndex("AuditoriumId");

                    b.HasIndex("LocationId");

                    b.HasIndex("MovieId");

                    b.HasIndex("MultiplexId");

                    b.HasIndex("UserDetailId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("coreMovieTicketAdminPortal.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LocationName");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("coreMovieTicketAdminPortal.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MovieName");

                    b.HasKey("MovieId");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("coreMovieTicketAdminPortal.Models.MovieDetails", b =>
                {
                    b.Property<int>("MovieDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Casting");

                    b.Property<string>("Director");

                    b.Property<string>("MovieDuration");

                    b.Property<int>("MovieId");

                    b.Property<string>("MovieImage");

                    b.Property<string>("MovieType");

                    b.Property<double>("Price");

                    b.Property<string>("Producer");

                    b.HasKey("MovieDetailsId");

                    b.HasIndex("MovieId")
                        .IsUnique();

                    b.ToTable("MovieDetails");
                });

            modelBuilder.Entity("coreMovieTicketAdminPortal.Models.Multiplex", b =>
                {
                    b.Property<int>("MultiplexId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MultiplexDescription");

                    b.Property<string>("MultiplexName");

                    b.HasKey("MultiplexId");

                    b.ToTable("Multiplexes");
                });

            modelBuilder.Entity("coreMovieTicketAdminPortal.Models.UserDetail", b =>
                {
                    b.Property<int>("UserDetailId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContactNo");

                    b.Property<string>("Email");

                    b.Property<string>("Password");

                    b.Property<string>("UserName");

                    b.Property<string>("Usertype");

                    b.HasKey("UserDetailId");

                    b.ToTable("UserDetails");
                });

            modelBuilder.Entity("coreMovieTicketAdminPortal.Models.Booking", b =>
                {
                    b.HasOne("coreMovieTicketAdminPortal.Models.Auditorium", "Auditorium")
                        .WithMany("Bookings")
                        .HasForeignKey("AuditoriumId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("coreMovieTicketAdminPortal.Models.Location", "Location")
                        .WithMany("Bookings")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("coreMovieTicketAdminPortal.Models.Movie")
                        .WithMany("Bookings")
                        .HasForeignKey("MovieId");

                    b.HasOne("coreMovieTicketAdminPortal.Models.Multiplex", "Multiplex")
                        .WithMany("Bookings")
                        .HasForeignKey("MultiplexId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("coreMovieTicketAdminPortal.Models.UserDetail", "UserDetail")
                        .WithMany("Bookings")
                        .HasForeignKey("UserDetailId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("coreMovieTicketAdminPortal.Models.MovieDetails", b =>
                {
                    b.HasOne("coreMovieTicketAdminPortal.Models.Movie", "Movie")
                        .WithOne("MovieDetails")
                        .HasForeignKey("coreMovieTicketAdminPortal.Models.MovieDetails", "MovieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
