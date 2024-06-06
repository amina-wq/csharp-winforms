using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_assignment.Models
{
    internal class Order
    {
        public Guid OrderID { get; set; }
        public Customer Customer { get; set; }
        public DateTime DateTime { get; set; }
        public List<MenuItem> MenuItems { get; set; }
        public string OrderStatus { get; set; }
    }
}
