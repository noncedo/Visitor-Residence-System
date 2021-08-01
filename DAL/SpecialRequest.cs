using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SpecialRequest
    {
        public int StudentId { get; set; }
        public string VisitorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string SpecialRequests { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
