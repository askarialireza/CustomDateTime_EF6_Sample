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
                    new System.DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, hour: 0, minute: 0, second: 0);

                System.DateTime toDateTime =
                    new System.DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, hour: 23, minute: 59, second: 59);

                var varList = oDatabaseContext.Users
                    //.Where(current => current.CreateDateTime.DateTime >= fromDateTime)
                    //.Where(current => current.CreateDateTime.DateTime <= toDateTime)
                    .ToList();

                foreach (Models.User user in varList)
                {
                    System.Console.WriteLine();

                    System.Console.WriteLine(user.CreateDateTime.DateTime.ToString() + " ||| " + user.CreateDateTime.PersianDate.ToString());

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
