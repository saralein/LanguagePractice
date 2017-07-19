using NUnit.Framework;
using System;
using IsUniqueKata;

namespace IsUniqueTest
{
    [TestFixture()]
    public class Test
    {

        private IsUnique _str;

        [SetUp()]
        public void initializeIsUnique()
        {
            _str = new IsUnique();
        }

        [Test()]
        public void ReturnsFalseForEmptyString()
        {
            Assert.That(_str.HasUniqueCharacters(""), Is.EqualTo(false));
        }

        [Test()]
        public void ReturnsFalseForAllSameCharacter()
        {
            Assert.That(_str.HasUniqueCharacters("aaa"), Is.EqualTo(false));
        }

        [Test()]
        public void ReturnsTrueForAllUniqueCharacters()
        {
            Assert.That(_str.HasUniqueCharacters("abcdefghijkl"), Is.EqualTo(true));
        }

        [Test()]
        public void ReturnsFalseForMultipleSpaces()
        {
            Assert.That(_str.HasUniqueCharacters("a b c"), Is.EqualTo(false));
        }
    }
}
