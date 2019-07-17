using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Red7.Models
{
    public class PostRequestData
    {
        public Card[] Canvas { get; set; }
        public Player[] Players { get; set; }
    }
}
