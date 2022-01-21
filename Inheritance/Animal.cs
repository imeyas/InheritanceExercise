using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    // Create a class Animal
    // give this class 4 members that all Animals have in common
    public class Animal
    {
        public Animal()
        {

        }

        public bool Alive { get; set; }
        public string Name { get; set; }
        public bool FathersCreation { get; set; }
        public bool EatsFood { get; set; }

    }
}
