using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzery.Core
{
    public class FizzBuzz
    {
        private readonly ICalculateFizzBuzz _strategy;

        public FizzBuzz(ICalculateFizzBuzz strategy)
        {
            _strategy = strategy;
        }

        public string CalculateFizzBuzz(long numberToCalculate)
        {
            return _strategy.Execute(numberToCalculate);
        }
    }
}
