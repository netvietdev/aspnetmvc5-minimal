using Dapper;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Rabbit.Business.DbTest
{
    public class SimpleDbRunnerService : ISimpleRunnerService
    {
        public string Run()
        {
            var nbItems = CountItemsFromDb();

            return string.Format("{0} found {1} items from database at {2}",
                typeof(SimpleDbRunnerService).Name,
                nbItems,
                DateTime.Now);
        }

        private static int CountItemsFromDb()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultDb"].ConnectionString;
            const string sql = "UPDATE [Item] SET [UpdatedAt] = GETDATE()";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                return connection.Execute(sql);
            }
        }
    }
}