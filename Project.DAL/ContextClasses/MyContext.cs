using Project.ENTITIES.Models;
using Project.MAP.Options;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.ContextClasses
{
    public class MyContext:DbContext
    {
        public MyContext():base("MyConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new ClientMap());
            modelBuilder.Configurations.Add(new ClientProfileMap());
            modelBuilder.Configurations.Add(new IssueMap());
            modelBuilder.Configurations.Add(new OrderMap());
            modelBuilder.Configurations.Add(new SaloonMap());
            modelBuilder.Configurations.Add(new SaloonClientMap());
            modelBuilder.Configurations.Add(new StandIssueMap());
            modelBuilder.Configurations.Add(new StandMap());
        }

        public DbSet<Client> Clients  { get; set; }
        public DbSet<ClientProfile> ClientProfiles { get; set; }
        public DbSet<Issue> Issues  { get; set; }
        public DbSet<Order> Orders  { get; set; }
        public DbSet<Saloon> Saloons  { get; set; }
        public DbSet<SaloonClient> SaloonClients  { get; set; }
        public DbSet<Stand> Stands  { get; set; }
        public DbSet<StandIssue> StandIssues  { get; set; }
    }
}
