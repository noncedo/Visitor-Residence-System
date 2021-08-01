using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Security : User
    {
        public int SecurityId { get; set; }
        public string StaffNumber { get; set; }
        public string SecurityFirstName { get; set; }
        public string SecurityLastName { get; set; }
        public string SecurityPassword { get; set; }
    }
}
