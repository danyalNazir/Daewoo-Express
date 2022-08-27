using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Daewoo_Web_Application.Models
{
    public partial class DaewooExpressApplicationContext : DbContext
    {
        public DaewooExpressApplicationContext()
        {
        }

        public DaewooExpressApplicationContext(DbContextOptions<DaewooExpressApplicationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Booking> Bookings { get; set; } = null!;
        public virtual DbSet<BookingSchedule> BookingSchedules { get; set; } = null!;
        public virtual DbSet<Seat> Seats { get; set; } = null!;
        public virtual DbSet<Terminal> Terminals { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\6th Semester\\Enterprise Application Development\\Daewoo Web Application\\Daewoo Web Application\\DataBase\\DaewooExpressApplication.mdf;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BookingNumber).HasColumnType("text");

                entity.Property(e => e.BookingScheduleId).HasColumnName("BookingScheduleID");

                entity.Property(e => e.Date).HasColumnType("text");

                entity.Property(e => e.SeatId).HasColumnName("SeatID");

                entity.Property(e => e.Time).HasColumnType("text");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.BookingSchedule)
                    .WithMany(p => p.Bookings)
                    .HasForeignKey(d => d.BookingScheduleId)
                    .HasConstraintName("FK_Bookings_To_Schedules");

                entity.HasOne(d => d.Seat)
                    .WithMany(p => p.Bookings)
                    .HasForeignKey(d => d.SeatId)
                    .HasConstraintName("FK_Bookings_To_Seats");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Bookings)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Bookings_To_Users");
            });

            modelBuilder.Entity<BookingSchedule>(entity =>
            {
                entity.Property(e => e.ID).HasColumnName("ID");

                entity.Property(e => e.Arrival)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Class)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Departure)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Destination)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Origin)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Status)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.SeatsLeft).HasColumnName("SeatsLeft");

                entity.Property(e => e.TotalSeats).HasColumnName("TotalSeats");

                entity.Property(e => e.Price).HasColumnName("Price");

            });

            modelBuilder.Entity<Seat>(entity =>
            {
                entity.Property(e => e.ID).HasColumnName("ID");

                entity.Property(e => e.SeatNo).HasColumnName("SeatNO");

                entity.Property(e => e.Status).HasColumnType("text");
            });

            modelBuilder.Entity<Terminal>(entity =>
            {
                entity.Property(e => e.ID).HasColumnName("ID");

                entity.Property(e => e.Address).HasColumnType("text");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Phone)
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.TerminalImage).HasColumnType("text");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.ID).HasColumnName("ID");

                entity.Property(e => e.CNIC)
                    .HasMaxLength(15)
                    .HasColumnName("CNIC")
                    .IsFixedLength();

                entity.Property(e => e.ConfirmPassword)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Password)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Number)
                    .HasMaxLength(11)
                    .HasColumnName("Phone_Number")
                    .IsFixedLength();

                entity.Property(e => e.ProfilePicture).HasColumnType("text");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
