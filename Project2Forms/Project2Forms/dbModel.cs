using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Project2Forms
{
    public class dataContext : DbContext
    {
        public DbSet<dbEntry> appInfo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={staticInfo.database()}");
        }
    }

    public class dbEntry
    {
        public int dbEntryID { get; set; }
        public string subName { get; set; }
        public DateTime dueDate { get; set; }
        public double amount { get; set; }
    }
}