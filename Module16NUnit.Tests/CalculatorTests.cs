using NUnit.Framework;

namespace Module16NUnit.Tests
{
    [TestFixture]
    internal class CalculatorTests
    {
        [Test]
        public void Additional_MustReturnCorrectValue ()
        {
            Calculator calculator = new Calculator ();
            Assert.That (calculator.Additional(25, 35) ==60);
        }


        [Test]
        public void Subtraction_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Subtraction(100, 20) == 80);
        }

        [Test]
        public void Miltiplication_MustReturnCorrectValue()
        {
            Calculator calculator= new Calculator();
            Assert.That(calculator.Miltiplication(20, 5) == 100);
        }


        [Test]
        public void Division_MustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Division(100, 10) == 10);
        }
    }
}
