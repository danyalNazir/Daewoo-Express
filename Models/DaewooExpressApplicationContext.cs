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

        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\6th Semester\\Enterprise Application Development\\Daewoo Web Application\\Daewoo Web Application\\DataBase\\DaewooExpressApplication.mdf;Integrated Security=True;Connect Timeout=30");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.ID).HasColumnName("ID");

                entity.Property(e => e.CNIC)
                    .HasMaxLength(15)
                    .HasColumnName("CNIC")
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

                entity.Property(e => e.ConfirmPassword)
                   .HasMaxLength(15)
                   .IsFixedLength();

                entity.Property(e => e.Number)
                    .HasMaxLength(11)
                    .HasColumnName("Phone_Number")
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
