using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12
{
    interface ITireCar
    {
        public int Diameter { get; set; }
        public int Width { get; set; }
        public int Profile { get; set; }
        public string Season { get; set; }
    }
}
