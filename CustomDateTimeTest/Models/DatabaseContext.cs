
namespace Models
{
    public class DatabaseContext : System.Data.Entity.DbContext
    {
        public DatabaseContext() : base()
        {
        }

        public System.Data.Entity.DbSet<Models.User> Users { get; set; }
    }
}
