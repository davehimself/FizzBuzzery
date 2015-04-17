using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzery.Core
{
    public class ExecutionRule
    {
        public ExecutionRule(long divisibleBy, string returnString)
        {
            DivisibleBy = new List<long>() { divisibleBy };
            ReturnString = returnString;
        }

        public ExecutionRule(IEnumerable<long> divisibleBy, string returnString)
        {
            DivisibleBy = divisibleBy;
            ReturnString = returnString;
        }

        public IEnumerable<long> DivisibleBy { get; set; } 

        public string ReturnString { get; set; }

        public bool IsDivisibleBy(long numberToTest)
        {
            return DivisibleBy.All(x => numberToTest % x == 0);
        }
    }
}
