using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_assignment.Models
{
    internal class Manager : User
    {
        public Manager(string userID, string userName, string email, string password) : base(userID, userName, email, password, Role.Manager)
        {
        }


    }
}
