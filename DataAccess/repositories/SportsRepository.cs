namespace DataAccess
{
    public class SportsRepository
    {
        public SportsRepository()
        {
            ConnectionString = SportsDbConnectionString.ConnectionString;
        }

        public static string ConnectionString { get; private set; }
    }
}
