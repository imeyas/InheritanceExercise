using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {
        // Create a class Reptile
        // give this class 4 members that are specific to Reptile
        // Set this class to inherit from your Animal Class

        public Reptile()
        {

        }

        public string Name { get; set; }
        public bool ColdBlooded { get; set; }
        public bool LayEggsOnLand { get; set; }
        public bool FathersCreation { get; set; }
    }
}
