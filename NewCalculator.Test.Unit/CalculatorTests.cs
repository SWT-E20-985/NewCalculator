using NUnit.Framework;

namespace NewCalculator.Test.Unit
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new Calculator();
        }

        [TestCase(2.2, 2.8, 5)]
        [TestCase(0, 2.8, 2.8)]
        public void Add_TwoPositives_CorrectResult(double addend1, double addend2, double expected)
        {
            Assert.That(_uut.Add(addend1, addend2), Is.EqualTo(expected));
        }
    }
}