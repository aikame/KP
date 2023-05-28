using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using KP.BD.Models;

namespace KP.BD
{
    public class DataContext : DbContext
    {
        public DbSet<UserModel> User => Set<UserModel>();
        public DbSet<RequestModel> Request => Set<RequestModel>();
        public DbSet<EventModel> Event => Set<EventModel>();
        public DbSet<CompetitorModel> CompetitorModel => Set<CompetitorModel>();

        public DataContext(string ConnectionString) : base(ConnectionString) 
        {

        }
    }
}
