
namespace Models.ComplexTypes
{
    public class CustomDateTime : System.ComponentModel.DataAnnotations.Schema.ComplexTypeAttribute
    {
        public CustomDateTime() : base()
        {
        }

        private System.DateTime _dateTime;

        public System.DateTime DateTime
        {
            get
            {
                return (_dateTime);
            }
            set
            {
                _dateTime = value;

                PersianDate = new FarsiLibrary.Utils.PersianDate(_dateTime);
            }
        }

        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public FarsiLibrary.Utils.PersianDate PersianDate { get; set; }

    }
}
