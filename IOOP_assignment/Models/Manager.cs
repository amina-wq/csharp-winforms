using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_assignment.Models
{
    internal class Manager : User
    {
        public Manager(string userID, string userName, string email, string password) : base(userID, userName, email, password, Role.Manager)
        {
        }
        
       
    }
    internal class SqlConnect
    {
        private String _connectionString;

        public SqlConnect()
        {
            this._connectionString = ("Data Source=DESKTOP-UIM3V3L;Initial Catalog=ioop;Integrated Security=True;Encrypt=True");
          
        }
    }

    


}
