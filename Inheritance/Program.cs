using System;
using System.Collections.Specialized;

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

            Bird Zippy = new Bird()
            {
                Name = "Zippy",
                Legs = 2,
                Age = 5,
                Domesticated = false,
                Color = "red",
                Type = "cardinal",
                CanFly = true,
                Food = "insects"
            };

            Console.WriteLine($"{Zippy.Name} is a {Zippy.Type} with {Zippy.Legs} legs and is {Zippy.Age} years old. Can {Zippy.Name} be domesticated? {Zippy.Domesticated}! {Zippy.Name}'s feathers are {Zippy.Color} and he likes to eat {Zippy.Food}.");
            Console.WriteLine($"Of course it is {Zippy.CanFly} that {Zippy.Name} can fly.");

            Reptile Snek = new Reptile()
            {
                Name = "Snek",
                Legs = 0,
                Age = 5,
                Domesticated = false,
                Color = "red",
                Length = 5,
                Diet = "mice",
                Regenerative = true

            };
            Console.WriteLine($"{Snek.Name} is a corn snake that is {Snek.Age} years old and of course has {Snek.Legs} legs. With a length of {Snek.Length} feet this snake likes to eat {Snek.Diet}. His color is {Snek.Color}.");
            Console.WriteLine($"Is this snake domesticated? {Snek.Domesticated}");
            Console.WriteLine($"Is this snake regenerative? {Snek.Regenerative}");

/*Create an object of your Bird class
 *  give values to your members using the object of your Bird class
 *
 * Creatively display the class member values
 */

/*Create an object of your Reptile class
 *  give values to your members using the object of your Reptile class
 *
 * Creatively display the class member values
 */
        }
    }
}
