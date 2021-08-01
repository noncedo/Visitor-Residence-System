using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StudentRoom
    {
        public int StudentRoomId { get; set; }
        public int RoomId { get; set; }
        public int StudentId { get; set; }
        public int FlatId { get; set; }
        public int VillageId { get; set; }
    }
}
