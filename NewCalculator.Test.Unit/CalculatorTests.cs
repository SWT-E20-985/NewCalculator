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

        [Test]
        public void Add_TwoPositives_CorrectResult()
        {
            Assert.That(_uut.Add(2.2, 2.8), Is.EqualTo(5));
        }
    }
}