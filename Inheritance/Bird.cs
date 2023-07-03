using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public bool flies { get; set; }
        public int numFeather { get; set; }
        public int beakSize { get; set; }
        public int wingSpan { get; set; }

        public void birdDetails()
        {
            Console.WriteLine($"flies: {flies}");
            Console.WriteLine($"number of feathers: {numFeather}");
            Console.WriteLine($"beakSize: {beakSize}");
            Console.WriteLine($"wingSpan: {wingSpan}");
        }
    }
}
