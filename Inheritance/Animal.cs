using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Animal
    {
        public int legs { get; set; }
        public int eyes { get; set; }
        public int age { get; set; }
        public int height { get; set; }

        public void animalDetails()
        {
            Console.WriteLine($"legs: {legs}");
            Console.WriteLine($"eyes: {eyes}");
            Console.WriteLine($"age: {age}");
            Console.WriteLine($"height: {height}");
        }

    }
}
