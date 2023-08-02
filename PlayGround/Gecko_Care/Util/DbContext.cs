using System.Data;
using System.Data.SqlClient;

namespace Gecko_Care.Util
{
	public class DbContext 
	{
		private readonly IConfiguration _config;

		public DbContext(IConfiguration config)
		{
			_config = config;
		}

		public IDbConnection GetConnection(string conn = "GeckoCareDb")
		{
			return new SqlConnection(_config.GetConnectionString(conn));
		}
	}
}
