using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzery.Core
{
    public class ConfigurableStrategy : ICalculateFizzBuzz
    {
        private readonly IList<ExecutionRule> _rules;

        public ConfigurableStrategy(IList<ExecutionRule> rules)
        {
            _rules = rules;
        }


        public string Execute(long numberToCalculate)
        {
            var match = _rules.Where(r => r.IsDivisibleBy(numberToCalculate))
                .OrderByDescending(r => r.DivisibleBy.Count())
                .FirstOrDefault();

            return (match != null) ? match.ReturnString : string.Format("{0}", numberToCalculate);
        }
    }
}
