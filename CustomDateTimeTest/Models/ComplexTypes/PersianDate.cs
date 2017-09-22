
namespace Models.ComplexTypes
{
    public class PersianDate : System.ComponentModel.DataAnnotations.Schema.ComplexTypeAttribute
    {
        public PersianDate() : base()
        {
            Year = 0;
            Month = 0;
            Day = 0;
            Hour = 0;
            Minute = 0;
            Second = 0;
            Milisecond = 0;
        }

        public int Year { get; set; }

        public int Month { get; set; }

        public int Day { get; set; }

        public int Hour { get; set; }

        public int Minute { get; set; }

        public int Second { get; set; }

        public int Milisecond { get; set; }
    }
}
