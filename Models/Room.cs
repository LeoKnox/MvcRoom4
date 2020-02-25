using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcRoom.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }

        ICollection<Door> Doors { get; set; }
    }
}
