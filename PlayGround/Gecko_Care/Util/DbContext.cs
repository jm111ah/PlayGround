using System.Data;
using System.Data.SqlClient;

namespace Gecko_Care.Util
{
	public class DbConnectoin 
	{
		private readonly IConfiguration _config;

		public DbConnectoin(IConfiguration config)
		{
			_config = config;
		}

		public IDbConnection GetConnection(string conn = "GeckoCareDb")
		{
			return new SqlConnection(_config.GetConnectionString(conn));
		}
	}
}
