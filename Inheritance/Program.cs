using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird ostrich = new Bird();
            ostrich.flies = false;
            ostrich.numFeather = 300;
            ostrich.beakSize = 8;
            ostrich.wingSpan = 7;
            ostrich.age = 3;
            ostrich.eyes = 2;
            ostrich.height = 5;
            ostrich.legs = 2;

            ostrich.birdDetails();
            ostrich.animalDetails();
            Console.WriteLine();

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile crocodile = new Reptile();
            crocodile.nocturnal = false;
            crocodile.aquatic = true;
            crocodile.eggSize = 5;
            crocodile.numScales = 500;
            crocodile.age = 2;
            crocodile.eyes = 2;
            crocodile.height = 1;
            crocodile.legs = 4;

            crocodile.reptileDetails();
            crocodile.animalDetails(); 
        }
    }
}


/* Codewars solution:
 
        public class God
        {
          public static Human[] Create()
          {
            Man adam = new Man();
            Woman eve = new Woman();
            return (new Human[] {adam, eve});
          }
        }
        public class Human
        {
  
        }

        public class Woman : Human
        {
  
        }

        public class Man : Human
        {
  
        }
 
 */