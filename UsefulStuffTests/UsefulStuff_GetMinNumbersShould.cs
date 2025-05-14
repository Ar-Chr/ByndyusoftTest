using NUnit.Framework;
using ByndyusoftTest;

namespace UsefulStuffTests
{
    [TestFixture]
    public class UsefulStuff_GetMinNumbersShould
    {
        [Test]
        public void ThrowArgumentException_When_InputLengthLessThanMinCount()
        {
            var numbers = new int[0];
            Assert.Throws(typeof(ArgumentException), () => UsefulStuff.GetMinNumbers(numbers, 1));
        }

        [Test]
        public void ThrowArgumentException_When_MinCountIsNegative()
        {
            var numbers = new int[0];
            Assert.Throws(typeof(ArgumentException), () => UsefulStuff.GetMinNumbers(numbers, -1));
        }

        [Test]
        public void ThrowNullReferenceException_When_InputIsNull()
        {
            int[]? numbers = null;
            Assert.Throws(typeof(NullReferenceException), () => UsefulStuff.GetMinNumbers(numbers, 1));
        }

        [Test]
        public void ReturnCorrectNumbers_When_MinCountIs1()
        {
            var numbers = new int[] { 8, -16 };
            var minNumbers = UsefulStuff.GetMinNumbers(numbers, 1);
            CollectionAssert.AreEquivalent(minNumbers, new[] { -16 });
        }

        [Test]
        public void ReturnCorrectNumbers_When_InputIsCorrect()
        {
            var numbers = new int[] { 4, 0, 3, 19, 492, -10, 1 };
            var minNumbers = UsefulStuff.GetMinNumbers(numbers, 2);
            CollectionAssert.AreEquivalent(minNumbers, new[] { -10, 0 });
        }

        [Test]
        public void ReturnCorrectNumbers_When_InputLengthEqualsMinCount()
        {
            var numbers = new int[] { 4, 0, 3 };
            var minNumbers = UsefulStuff.GetMinNumbers(numbers, numbers.Length);
            CollectionAssert.AreEquivalent(minNumbers, numbers);
        }

        [Test]
        public void ReturnCorrectNumbers_When_InputLengthIsMaxArrayLength()
        {
            var numbers = new int[int.MaxValue / 2];
            numbers[0] = int.MinValue;
            var minNumbers = UsefulStuff.GetMinNumbers(numbers, 1);
            CollectionAssert.AreEquivalent(minNumbers, new[] { numbers[0] });
        }
    }
}