using LINQ_Computers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Computers
{
    internal class Computer
    {
        public int Num { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public int Freq { get; set; }
        public int Ram { get; set; }
        public int VolHD { get; set; }
        public int VolVideo { get; set; }
        public int Summa { get; set; }
        public int Quantity { get; set; }
    }
}

//new Computer() { Num = 1, Name = "Bb", Type = 11, Freq = 3, Ram = 32, VolHD = 4, VolVideo = 2, Summa = 100, Quantity = 30 },