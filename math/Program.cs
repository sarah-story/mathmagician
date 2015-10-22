using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathmagician
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What would you like for me to do?");
            string Operation = Console.ReadLine();
            Console.WriteLine("How many should I print?");
            string Number = Console.ReadLine();
            Console.WriteLine("Cool, I'm going to print {0} {1} numbers.", Number, Operation);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
