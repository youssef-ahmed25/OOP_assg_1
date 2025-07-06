using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_assg_1.Enum
{
    internal class season
    {

        public string name { get; set; }
        public void display()
        {
            Console.WriteLine($"Season:{name}");

        }
    }
}
