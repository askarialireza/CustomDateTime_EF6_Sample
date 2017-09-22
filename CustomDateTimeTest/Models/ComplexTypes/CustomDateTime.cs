
namespace Models.ComplexTypes
{
    public class CustomDateTime : System.ComponentModel.DataAnnotations.Schema.ComplexTypeAttribute
    {
        public CustomDateTime() : base()
        {
            PersianDate = new PersianDate();
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

                System.Globalization.PersianCalendar oPersianCalendar =
                    new System.Globalization.PersianCalendar();

                PersianDate.Year = oPersianCalendar.GetYear(_dateTime);

                PersianDate.Month = oPersianCalendar.GetMonth(_dateTime);

                PersianDate.Day = oPersianCalendar.GetDayOfMonth(_dateTime);

                PersianDate.Hour = _dateTime.Hour;

                PersianDate.Minute = _dateTime.Minute;

                PersianDate.Second = _dateTime.Second;

                PersianDate.Milisecond = _dateTime.Millisecond;
            }
        }

        public Models.ComplexTypes.PersianDate PersianDate { get; }

    }
}
