namespace Models
{
    public class User : object
    {
        public User() : base()
        {
            CreateDateTime = new ComplexTypes.CustomDateTime();
        }

        public int Id { get; set; }

        public Models.ComplexTypes.CustomDateTime CreateDateTime { get; set; }

    }
}
