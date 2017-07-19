using NUnit.Framework;
using FindOddCubesKata;

namespace FindOddCubesTest
{
    [TestFixture]
    public class Test
    {

        private FindOddCubes _foc;

        [SetUp]
        public void InitFindOddCubes()
        {
            _foc = new FindOddCubes();
        }

        [Test]
        public void ItReturnsZeroForEmptyArray()
        {
            Assert.That(_foc.OddCubeSum(new int[] { }), Is.EqualTo(0));
        }

        [Test]
        public void ItReturnsZeroForAllEvenNumbers()
        {
            Assert.That(_foc.OddCubeSum(new [] { 2, 4, 6 }), Is.EqualTo(0));
        }

        [Test]
        public void ItReturnsCubeForOddNumber()
        {
            Assert.That(_foc.OddCubeSum((new [] { 2, 3, 4 })), Is.EqualTo(27));
        }

        [Test]
        public void ItPassesTestsFromCodeWars()
        {
            Assert.That(_foc.OddCubeSum(new [] { -5, -5, 5, 5 }), Is.EqualTo(0));
            Assert.That(_foc.OddCubeSum(new [] { 1, 2, 3, 4 }), Is.EqualTo(28));
            Assert.That(_foc.OddCubeSum(new [] { -3, -2, 2, 3 }), Is.EqualTo(0));
        }
    }
}
