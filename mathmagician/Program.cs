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
            Console.WriteLine("What do you want me to do? (Natural Numbers, Even Numbers, Odd Numbers, Fibonacci Numbers, or Prime Numbers)");
            Console.Write("> ");
            string input = Console.ReadLine();
            if (input.ToLower().Equals("natural numbers"))
            {
                Ouput<NaturalNumbers> nats = new Ouput<NaturalNumbers>();
                nats.CheckInput();
            }
            else if (input.ToLower().Equals("even numbers"))
            {
                Ouput<EvenNumbers> even = new Ouput<EvenNumbers>();
                even.CheckInput();
            }
            else if (input.ToLower().Equals("odd numbers"))
            {
                Ouput<OddNumbers> odd = new Ouput<OddNumbers>();
                odd.CheckInput();
            }
            else if (input.ToLower().Equals("fibonacci numbers"))
            {
                Ouput<FibonacciNumbers> fib = new Ouput<FibonacciNumbers>();
                fib.CheckInput();
            }
            else if (input.ToLower().Equals("prime numbers"))
            {
                Ouput<PrimeNumbers> prime = new Ouput<PrimeNumbers>();
                prime.CheckInput();
            }
            else
            {
                Console.WriteLine("Nope! Do better next time.");
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(); 
        }
    }
}
