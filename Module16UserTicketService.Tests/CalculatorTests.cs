using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Module16UserTicketService.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void MultiplicationMustReturnNotNullValue()
        {
            var calculator = new Calculator();

            Xunit.Assert.Equal(8, calculator.Multiplication(2, 4));
        }
        

        [Test]
        public void AddAlwaysReturnsExpectedValue()
        {
            var calculatorTest = new Calculator();
            NUnit.Framework.Assert.That(calculatorTest.Add(10, 220), Is.EqualTo(230));
        }
    }
}
