using NUnit.Framework;
using System;
using IsUniqueKata;

namespace IsUniqueTest
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void ReturnsFalseForEmptyString()
        {
            var str = new IsUnique();
            Assert.That(str.HasUniqueCharacters(""), Is.EqualTo(false));
        }

        [Test()]
        public void ReturnsFalseForAllSameCharacter()
        {
            var str = new IsUnique();
            Assert.That(str.HasUniqueCharacters("aaa"), Is.EqualTo(false));
        }

        [Test()]
        public void ReturnsTrueForAllUniqueCharacters()
        {
            var str = new IsUnique();
            Assert.That(str.HasUniqueCharacters("abcdefghijkl"), Is.EqualTo(true));
        }

        [Test()]
        public void ReturnsFalseForMultipleSpaces()
        {
            var str = new IsUnique();
            Assert.That(str.HasUniqueCharacters("a b c"), Is.EqualTo(false));
        }
    }
}
