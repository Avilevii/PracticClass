using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticSimpleClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Commando c = new Commando("Avi", "Levi", "Hide");
            Weapon w = new Weapon("Glook", "Austria", 13);
            w.Shoot();
            Console.WriteLine(w.NumBools);
        }
    }
}
