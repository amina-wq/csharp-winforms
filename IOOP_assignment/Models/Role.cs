using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_assignment.Models
{
    public enum Role
    {
       Administrator,
       Manager,
       Chef,
       Customer   
    }

    internal class RoleUtility
    {
        public static string ToUUID(Role role)
        {
            switch (role)
            {
                case Role.Administrator:
                    return "2b1fa860-fabb-4d8e-850d-a4dfec450263";
                case Role.Manager:
                    return "c8b557ca-e21a-43a5-96bb-c86e25990d8d";
                case Role.Chef:
                    return "31f1e389-3856-4fa1-a29e-f3d9831c1b65";
                case Role.Customer:
                    return "f2c0795c-0aa5-489d-90f5-21a07d1deda9";
                default:
                    throw new ArgumentException("Invalid role");
            }
        }

        public static Role ToRole(string role)
        {
            switch (role)
            {
                case "2b1fa860-fabb-4d8e-850d-a4dfec450263":
                    return Role.Administrator;
                case "c8b557ca-e21a-43a5-96bb-c86e25990d8d":
                    return Role.Manager;
                case "31f1e389-3856-4fa1-a29e-f3d9831c1b65":
                    return Role.Chef;
                case "f2c0795c-0aa5-489d-90f5-21a07d1deda9":
                    return Role.Customer;
                default:
                    throw new ArgumentException("Invalid UUID");
            }
        }
    }

}
