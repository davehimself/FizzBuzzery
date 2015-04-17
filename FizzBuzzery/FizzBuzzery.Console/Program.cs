using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzery.Core;

namespace FizzBuzzery
{
    class Program
    {
        public static void Main(string[] args)
        {
            var fizzBuzz = new FizzBuzz(new DefaultStrategy());

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(fizzBuzz.CalculateFizzBuzz(i));
            }

            Console.ReadLine();
        }
    }
}
