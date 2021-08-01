using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SleepOver:Visitor
    {
        public string SleepOverId { get; set; }
        public string StudentId { get; set; }
        public string Tenant { get; set; }
        public string Visitor { get; set; }
        public string Room { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string IdentityType { get; set; }
        public bool Approved { get; set; }
        public bool SignOut { get; set; }
    }
}
