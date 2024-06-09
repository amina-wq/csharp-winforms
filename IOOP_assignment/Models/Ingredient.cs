using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_assignment.Models
{
    public partial class Ingredient
    {
        public Guid IngredientID { get; set; }
        public string IngredientName { get; set; }
        public decimal Quantity { get; set; }
        public string IngredientDetails { get; set; }
    }
}
