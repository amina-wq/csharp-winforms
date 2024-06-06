using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_assignment.Models
{
    internal class Reservation
    {
        public Guid ReservationID { get; set; }
        public Customer Customer { get; set; }
        public DateTime ReservationDateTime { get; set; }
        public string ReservationType { get; set; }
        public string ReservationDetails { get; set; }
    }
}
