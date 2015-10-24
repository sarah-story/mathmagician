using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathmagician
{
    public class Ouput<T> where T : NaturalNumbers, new()
    {
        public void CheckInput()
        {
            Console.WriteLine("How many?");
            Console.Write("> ");
            string response_length = Console.ReadLine();
            int length;
            bool parsed = int.TryParse(response_length, out length);
            if (parsed)
            {
                T nats = new T();
                Console.WriteLine(nats.ToString(nats.GetSequence(length)));
            }
            else
            {
                Console.WriteLine("Whoops!");
            }
        } 
    }
}
