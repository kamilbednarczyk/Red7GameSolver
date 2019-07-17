using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Red7.Models
{
    public class Card
    {
        public long Number { get; set; }
        public Colors Color { get; set; }
    }

    public enum Colors
    {
        VIOLET,
        INDIGO,
        BLUE,
        GREEN,
        YELLOW,
        ORANGE,
        RED
    }
}
