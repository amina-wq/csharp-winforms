using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_assignment.Models
{
    internal class Chef : User
    {
        public Chef(Guid userID, string userName, string email, string password) : base(userID, userName, email, password, Role.Chef)
        {
        }
    }
}
