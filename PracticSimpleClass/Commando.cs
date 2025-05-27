using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticSimpleClass
{
    internal class Commando
    {
        private string Name;
        public string CodeName { get; set; }
        public string Status { get; set; }
        public IReadOnlyList <string> Tools { get; } = new List<string>{ "Hammer", "Chisel", "Rope", "Bag", "Canteen" };

        public Commando(string name, string codname, string status)
        {
            Name = name;
            CodeName = codname;
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
        public string SayName(string commanderRank)
        {
            if (commanderRank == "GENERAL")

                return Name;
            else if (commanderRank == "COLONEL")
                return CodeName;
            else

                return "This is classified information";
        }



    }
}
