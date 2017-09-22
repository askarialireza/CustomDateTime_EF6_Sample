using System.Linq;

namespace CustomDateTimeTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Models.DatabaseContext oDatabaseContext = null;

            try
            {
                oDatabaseContext = new Models.DatabaseContext();

                for (int i = 0; i < 5; i++)
                {

                    Models.User oUser = new Models.User();

                    oUser.Id = 1001;
                    oUser.CreateDateTime.DateTime = System.DateTime.Now;

                    oDatabaseContext.Users.Add(oUser);
                }

                oDatabaseContext.SaveChanges();

                System.DateTime fromDateTime =
                    new System.DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, hour: 20, minute: 40, second: 0);

                System.DateTime toDateTime =
                    new System.DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, hour: 20, minute: 34, second: 0);

                var varList = oDatabaseContext.Users
                    .Where(current => current.CreateDateTime.DateTime >= fromDateTime)
                    //.Where(current => current.CreateDateTime.DateTime <= toDateTime)
                    .ToList();

                foreach (Models.User user in varList)
                {
                    System.Console.WriteLine();

                    System.Console.WriteLine(
                        string.Format("{0} -- {1}/{2}/{3} {4}:{5}:{6}", user.CreateDateTime.DateTime,
                        user.CreateDateTime.PersianDate.Year, user.CreateDateTime.PersianDate.Month, user.CreateDateTime.PersianDate.Day,
                        user.CreateDateTime.PersianDate.Hour, user.CreateDateTime.PersianDate.Minute, user.CreateDateTime.PersianDate.Second));

                    System.Console.WriteLine();
                }

            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            finally
            {
                if (oDatabaseContext != null)
                {
                    oDatabaseContext.Dispose();
                    oDatabaseContext = null;
                }
            }

            System.Console.ReadLine();
        }
    }
}
