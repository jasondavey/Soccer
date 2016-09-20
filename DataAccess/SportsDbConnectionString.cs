using System.Configuration;

namespace DataAccess
{
    public static class SportsDbConnectionString
    {
        public static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["Soccer"].ConnectionString;
    }
}
