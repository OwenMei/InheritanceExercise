using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public int eggSize { get; set; }
        public bool nocturnal { get; set; }
        public int numScales { get; set;}
        public bool aquatic { get; set; }

        public void reptileDetails()
        {
            Console.WriteLine($"egg size: {eggSize}");
            Console.WriteLine($"nocturnal: {nocturnal}");
            Console.WriteLine($"number of scales: {numScales}");
            Console.WriteLine($"aquatic: {aquatic}");
        }
    }
}
