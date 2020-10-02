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
            // Act og Assert i samme kodelinje
            Assert.That(_uut.Add(addend1, addend2), Is.EqualTo(expected));
        }

        [TestCase(2.2, 2.8, 5)]
        [TestCase(0, 2.8, 2.8)]
        public void Add_TwoPositives_AccumulatorCorrect(double addend1, double addend2, double expected)
        {
            // Act
            _uut.Add(addend1, addend2);
            // Assert
            Assert.That(_uut.Accumulator, Is.EqualTo(expected));
        }

        [TestCase(5, 12)]
        public void Add_SingleParameter_CorrectResult(double newaddend, double expected)
        {
            // Arrange - set accumulator to known value 7
            _uut.Add(3, 4);
            // Act + assert
            Assert.That(_uut.Add(newaddend), Is.EqualTo(expected));
        }


    }
}