using NUnit.Framework;
using ByndyusoftTest;

namespace UsefulStuffTests
{
    [TestFixture]
    public class UsefulStuff_GetTwoMinNumbersSumShould
    {
        [Test]
        public void ReturnCorrectSum_When_InputIsCorrect()
        {
            var numbers = new[] { -1, 30, -2 };
            Assert.That(UsefulStuff.GetMinTwoNumbersSum(numbers) == -3);
        }

        [Test]
        public void ReturnCorrectSum_When_NumbersAreMaxValue()
        {
            var numbers = new[] { int.MaxValue, int.MaxValue };
            Assert.That(UsefulStuff.GetMinTwoNumbersSum(numbers) == (long)int.MaxValue + int.MaxValue);
        }

        [Test]
        public void ReturnCorrectSum_When_NumbersAreMinValue()
        {
            var numbers = new[] { int.MinValue, int.MinValue };
            Assert.That(UsefulStuff.GetMinTwoNumbersSum(numbers) == (long)int.MinValue + int.MinValue);
        }
    }
}
