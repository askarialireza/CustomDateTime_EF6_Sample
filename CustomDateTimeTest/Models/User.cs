namespace Models
{
    public class User : object
    {

        #region Configuration

        internal class Configuration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Models.User>
        {
            public Configuration() : base()
            {
                // For Showing " CreateDateTime " instead of " CreateDateTime_DateTime " in DB Tables Columns

                Property(current => current.CreateDateTime.DateTime)
                    .HasColumnName(nameof(Models.User.CreateDateTime));
            }
        }

        #endregion /Configuration

        public User() : base()
        {
            CreateDateTime = new ComplexTypes.CustomDateTime();
        }

        public int Id { get; set; }

        public Models.ComplexTypes.CustomDateTime CreateDateTime { get; set; }

    }
}
