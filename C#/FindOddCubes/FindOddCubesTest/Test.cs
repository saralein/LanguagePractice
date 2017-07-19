using NUnit.Framework;
using FindOddCubesKata;

namespace FindOddCubesTest
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void ItReturnsZeroForEmptyArray()
        {
            var x = new FindOddCubes();
            var actual = x.OddCubeSum(new int[] { });
            Assert.That(actual, Is.EqualTo(0));
        }

        [Test()]
        public void ItReturnsZeroForAllEvenNumbers()
        {
            var x = new FindOddCubes();
            var actual = x.OddCubeSum(new int[] { 2, 4, 6 });
            Assert.That(actual, Is.EqualTo(0));
        }

        [Test()]
        public void ItReturnsCubeForOddNumber()
        {
            var x = new FindOddCubes();
            var actual = x.OddCubeSum((new int[] { 2, 3, 4 }));
            Assert.That(actual, Is.EqualTo(27));
        }

        [Test()]
        public void ItPassesTestsFromCodeWars()
        {
            var x = new FindOddCubes();

            Assert.That(x.OddCubeSum(new int[] { -5, -5, 5, 5 }), Is.EqualTo(0));
            Assert.That(x.OddCubeSum(new int[] { 1, 2, 3, 4 }), Is.EqualTo(28));
            Assert.That(x.OddCubeSum(new int[] { -3, -2, 2, 3 }), Is.EqualTo(0));
        }
    }
}
