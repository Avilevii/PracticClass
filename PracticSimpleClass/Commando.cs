using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticSimpleClass
{
    internal class Commando
    {
        public string Name { get; set; }
        public string CodeName { get; set; }
        public string Status { get; set; }
        public IReadOnlyList <string> Tools { get; } = new List<string>{ "Hammer", "Chisel", "Rope", "Bag", "Canteen" };

        public Commando(string name, string codeName, string status) 
        {
            Name = name;
            CodeName = codeName;
            Status = status;
            

        }
        public void Walk()
        {
            Status = "Walk";
            Console.WriteLine($"The soldier {Name} is: {Status}");
        }
        public void Hide() 
        {
            Status = "Hide";
            Console.WriteLine($"The soldier {Name} is: {Status}");
        }
        public void Attack()
        {
            Console.WriteLine($"The Attack is:{CodeName}");
        }



    }
}
