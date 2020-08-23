using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motivs.Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print Natural \n");
            NaturalNumbers naturals = new NaturalNumbers(20);
            naturals.Print();

            Console.WriteLine("Print Fibonacci \n");
            FibonacciNumbers fibs = new FibonacciNumbers(233);
            fibs.Print();

            Console.Read();
        }
    }
}
