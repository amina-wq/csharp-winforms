using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_assignment.Models
{
    public class Feedback
    {
        public Guid FeedbackID { get; set; }
        public Customer Customer { get; set; }
        public string FeedbackMessage { get; set; }
        public DateTime FeedbackDateTime { get; set; }
    }
}
