
using System.Data.Entity;

namespace Models
{
    public class DatabaseContext : System.Data.Entity.DbContext
    {
        public DatabaseContext() : base()
        {
        }

        public System.Data.Entity.DbSet<Models.User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new Models.User.Configuration());
        }
    }
}
