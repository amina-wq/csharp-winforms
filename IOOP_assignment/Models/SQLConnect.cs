using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_assignment.Models
{
    internal class SQLConnect
    {
        private string connectionString;

        public SQLConnect()
        {
            this.connectionString = "Data Source=localhost;Initial Catalog=ioop;Integrated Security=True;TrustServerCertificate=True";
        }

        public SQLConnect(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
