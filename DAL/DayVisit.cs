using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DayVisit:Visitor
    {
        public string DayVisitId { get; set; }
        public string StudentId { get; set; }
        public string Tenant { get; set; }
        public string Visitor { get; set; }
        public string Security { get; set; }
        public string SecurityId { get; set; }
        public string Room { get; set; }
        public string Description { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string IdentifierType { get; set; }
    }
}
