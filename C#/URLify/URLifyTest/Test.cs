using NUnit.Framework;
using System;
using URLifyKata;

namespace URLifyTest
{
    [TestFixture]
    public class Test
    {
        private URLify _str;

        [SetUp]
        public void InitURLify()
        {
            _str = new URLify();
        }

        [Test]
        public void ReturnsEmptyStringForNoTrueLength ()
        {
            Assert.That(_str.ConvertStringToURL(" ", 0), Is.EqualTo(""));
        }

        [Test]
        public void ReplacesOneSpaceWithChars ()
        {
            Assert.That(_str.ConvertStringToURL(" ", 1), Is.EqualTo("%20"));
        }

        [Test]
        public void ReplacesSpaceInStringWithTrail ()
        {
            Assert.That(_str.ConvertStringToURL("Mr John Smith    ", 13), Is.EqualTo("Mr%20John%20Smith"));
        }

        [Test]
        public void RelacesSpaceInStringOfTrueLength ()
        {
            Assert.That(_str.ConvertStringToURL("Mr John Smith", 13), Is.EqualTo("Mr%20John%20Smith"));
        }
    }
}
