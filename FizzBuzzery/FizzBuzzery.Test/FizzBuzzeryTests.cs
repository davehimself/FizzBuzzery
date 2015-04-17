using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzery.Core;
using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzzery.Test
{
    [TestFixture]
    public class FizzBuzzeryTests
    {
        [Test]
        public void CanExecuteDefaultStrategy()
        {
            var fizzBuzz = new FizzBuzz(new DefaultStrategy());

            fizzBuzz.CalculateFizzBuzz(3).Should().Be("Fizz");
            fizzBuzz.CalculateFizzBuzz(5).Should().Be("Buzz");
            fizzBuzz.CalculateFizzBuzz(15).Should().Be("FizzBuzz");
        }

        [Test]
        public void CanExecuteConfigurableStrategy()
        {
            var strategy = new ConfigurableStrategy(new List<ExecutionRule>()
            {
                new ExecutionRule(3, "Fizz"),
                new ExecutionRule(5, "Buzz"),
                new ExecutionRule(new List<long>() { 3, 5 }, "FizzBuzz")
            });

            var fizzBuzz = new FizzBuzz(strategy);

            fizzBuzz.CalculateFizzBuzz(3).Should().Be("Fizz");
            fizzBuzz.CalculateFizzBuzz(5).Should().Be("Buzz");
            fizzBuzz.CalculateFizzBuzz(15).Should().Be("FizzBuzz");
        }
    }
}
