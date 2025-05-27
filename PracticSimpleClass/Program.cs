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
            Commando s = new SeaCommando("Yossy", "Madar", "Attack");
            Commando a = new AirCommando("Aaron", "Madar", "Walk");
            Commando c = new Commando("Avi", "Levi", "Hide");
            Commando[] commandos = new Commando[] { s, a, c };

            foreach (var command in commandos)
            {
                command.Attack();
            }

            Weapon w = new Weapon("Glook", "Austria", 13);
            Console.WriteLine(c.CodeName);
            c.CodeName = "gurviz";
            Console.WriteLine(c.SayName("GENERAL"));
            Console.WriteLine(c.SayName("COLONEL"));
        }
    }
}
