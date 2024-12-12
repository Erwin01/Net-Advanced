using Demo.Arquitecture.Transversal.Common;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Demo.Arquitecture.Infraestructure.Data
{
    public class ConnectionFactory : IConnectionFactory
    {
        private readonly IConfiguration _configuration;

        public ConnectionFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection GetConnection
        {
            get
            {
                var sqlConnection = new SqlConnection();

                if (sqlConnection == null)
                {
                    return null;
                }
                else
                {
                    sqlConnection.ConnectionString = _configuration.GetConnectionString(Constant.SqlStringConnection);
                    sqlConnection.Open();

                    return sqlConnection;
                }
            }
        }
    }
}
