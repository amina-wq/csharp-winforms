using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_assignment.Models
{
    public partial class MenuItem
    {
        public Guid ItemID { get; set; }
        public string ItemName { get; set; }
        public Category ItemCategory { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public decimal Price { get; set; }

    }
}
