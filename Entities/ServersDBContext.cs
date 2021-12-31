using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerBrowser.Entities
{
    public class ServersDBContext : DbContext
    {
        private string _connectionString = "Server=DESKTOP-SREB1B5\\SQLEXPRESS;Database=ServersDB;User Id=sa;Password=123456789;Trusted_Connection=False";
        public DbSet<Servers> ServerList { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Servers>().Property(r => r.Name)
                .IsRequired().HasMaxLength(30);
            modelBuilder.Entity<Servers>().Property(r => r.Ip)
                .IsRequired();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
