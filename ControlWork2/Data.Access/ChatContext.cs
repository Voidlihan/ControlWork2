using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Microsoft.EntityFrameworkCore;
using ControlWork2.Models;

namespace ControlWork2
{
    public class ChatContext : DbContext
    {
        public ChatContext()
        {     
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Sms> SMS { get; set; }
        public DbSet<Chat> Chats { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=A-305-03;Database=controlwork2;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sms>().ToTable("Sms");
            modelBuilder.Entity<User>()
                .HasMany(x => x.SMS)
                .WithOne(x => x.User);
        }
    }
}