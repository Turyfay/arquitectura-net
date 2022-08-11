using System;
using System.Collections.Generic;
using System.Text;
using devd.Ecommerce.Transersal.Common;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace devd.Ecommerce.Infraestructura.Data
{
    public class ConnectionFactory : IConnectionFactory
    {
        private readonly IConfiguration _configuration;

        public ConnectionFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection dbConnection
        {
            get {
                var sqlconnection = new SqlConnection();
                if (sqlconnection == null) return null;

                sqlconnection.ConnectionString = _configuration.GetConnectionString("default");
                sqlconnection.Open();
                return sqlconnection;

            }
        }
    }
}
