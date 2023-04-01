using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPS
{
    public class PC
    {
        public Guid Id { get; set; }
        public string SerialNumber { get; set; }
        public string Model { get; set; }
        // model powinien być osobną tabelą
        public user AssignedTo { get; set; }
    }
}
