using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PracticSimpleClass
{
    internal class AirCommando:Commando
    {
        public AirCommando(string name, string codname, string status):
            base(name, codname, status)
        {
        }

        public void Parachute()
        {
            Console.WriteLine($"{CodeName} is parachuting from the sky!");
        }
        public override void Attack()
        {
            Console.WriteLine("Air Force commando soldier attacks");
        }

    }
}
