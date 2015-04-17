using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzery.Core
{
    public class DefaultStrategy : ICalculateFizzBuzz
    {
        public string Execute(long numberToCalculate)
        {
            if (numberToCalculate % 3 == 0 && numberToCalculate % 5 == 0)
            {
                return "FizzBuzz";
            }

            if (numberToCalculate % 3 == 0)
            {
                return "Fizz";

            }

            if (numberToCalculate % 5 == 0)
            {
                return "Buzz";
            }

            return string.Format("{0}", numberToCalculate);
        }
    }
}
