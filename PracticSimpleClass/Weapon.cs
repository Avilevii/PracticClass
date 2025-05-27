using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticSimpleClass
{
    internal class Weapon
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int NumBools { get; set; }

        public Weapon(string name, string manufacturer, int numBools) 
        {
            Name = name; 
            Manufacturer = manufacturer;
            NumBools = numBools;
        }
        public void Shoot()
        {
            if(NumBools > 0)
            {
                Console.WriteLine("Boom");
                NumBools -= 1;
            }
            else
            {
                Console.WriteLine("The ball is over ");
            }
        }

    }
}
