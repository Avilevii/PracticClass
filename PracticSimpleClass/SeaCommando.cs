using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticSimpleClass
{
    internal class SeaCommando:Commando
    {
        public SeaCommando(string name, string codname, string status) : base(name, codname, status)
        {

        }

        public void Swim()
        {
            Console.WriteLine(CodeName);
        }
        public override void Attack()
        {
            Console.WriteLine("Sea commando soldier attacks");
        }
    }
}
