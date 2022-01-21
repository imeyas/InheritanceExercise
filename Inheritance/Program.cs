using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var newBird = new Bird()
            {
                Name = "Eagle",
                IsABird = true,
                HasWings = true,
                WingCount = 2,
            };

            Console.WriteLine($"The animal we are watching is an {newBird.Name}. This animal is a bird - true or false? {newBird.IsABird}." +
                $"That's correct! The eagle is a bird and has wings - true or false? {newBird.HasWings}." +
                $"You guys are so INTELLIGENT, right again! And who can tell me how many wings this eagle has? Naya answers:" +
                $"'the eagle has {newBird.WingCount} wings!'... BINNNNNNNOOOOOOO, great work team!!!");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var newReptile = new Reptile()
            {
                Name = "Sea turtle",
                ColdBlooded = true,
                LayEggsOnLand = true,
                FathersCreation = true,
            };

            Console.WriteLine($"\nThis next animal we are watching is a {newReptile.Name}. This animal is cold-blooded - true or false? {newReptile.ColdBlooded}." +
                $"That's correct! The sea turtle is a reptile that lays eggs on land - true or false? {newReptile.LayEggsOnLand}." +
                $"LET'S GOOOOOOO, right again! Here's a big one, sea turtles are also created by our FATHER God - true or false? Tobi answers:" +
                $"'I know, I know this one is {newReptile.FathersCreation}, duhhhhhhh everything was created by God, Mr. Barister!'" +
                $"You guys are geniouses, keep up the great work!!!");
        }
    }
}
