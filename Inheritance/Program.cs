using System;

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
             var swan= NewBird
             * Creatively display the class member values 
             */
            var swan = new Bird();
            swan.CanFly = false;
                swan.Lifespan = 6;
            swan.Origin = "Florida";
            swan.CanSwim = true;
            swan.Food = "fish and plants";
            swan.Name = "Swan";

            Console.WriteLine($"My favorite bird is a {swan.Name}. It's from {swan.Origin}  and it eats \n{swan.Food}. A {swan.Name} can live up to {swan.Lifespan} years!");
            Console.WriteLine($"If you ask me if a {swan.Name} can fly, the answer is {swan.CanFly} but a {swan.Name} \ncan very much swim! Which is {swan.CanSwim}");
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var lizard = new Reptile();
            lizard.TailLength = 6;
            lizard.Color = "bright green and chocolate brown";
            lizard.Food = "plants and flies";
            lizard.IsPoisonous = false;
            lizard.LifeSpan = 12;
            lizard.Name = "Lizard";

            Console.WriteLine($"Name:{lizard.Name}\nTail Length:{lizard.TailLength} inches\nColor:{lizard.Color}\nFood:{lizard.Food}\nIs Poisonous:{lizard.IsPoisonous}\nLifespan:{lizard.LifeSpan}");
        }
    }
}
