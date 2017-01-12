using System.Data.Entity;
using ATH.TestTaskPlatform.Backend.Domain.Models;

namespace ATH.TestTaskPlatform.Backend.DataAccess.DataContexts
{
    public class DataContext : DbContext
    {
        public DataContext() : base(nameof(DataContext))
        {
            Database.SetInitializer<DataContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(typeof(DataContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Scope> Scopes { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Task> Tasks { get; set; }
    }
}
