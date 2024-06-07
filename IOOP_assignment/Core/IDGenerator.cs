using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_assignment.Core
{
    public class UserIdGenerator
    {
        private string connectionString;
        

        public UserIdGenerator(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public Guid GenerateNewUserId()
        {
            // Generate a new UUID (Guid) for the user ID
            return Guid.NewGuid();
        }

       
    }

    
    
}

