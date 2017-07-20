using NUnit.Framework;
using CheckPermutationKata;

namespace CheckPermutationTest
{
    [TestFixture]
    public class Test
    {
        
        private CheckPermutation _perms;

	    [SetUp]
	    public void InitCheckPermutation()
	    {
            _perms = new CheckPermutation();
	    }

        [Test]
        public void ItReturnsFalseForEmptyString()
        {
            Assert.That(_perms.ArePermutations("", ""), Is.EqualTo(false));
        }

        [Test]
        public void ItReturnsFalseForDiffLenghts()
        {
            Assert.That(_perms.ArePermutations("aa", "aaa"), Is.EqualTo(false));
        }

        [Test]
        public void ItReturnsFalseForDifferentStrings()
        {
            Assert.That(_perms.ArePermutations("cat", "acts"), Is.EqualTo(false));
        }

        [Test]
        public void ItReturnsTrueForPermutation() {
            Assert.That(_perms.ArePermutations("cheese", "heecse"), Is.EqualTo(true));
        }
    }
}
