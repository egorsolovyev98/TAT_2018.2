using NUnit.Framework;
using System;

namespace task_DEV3.Tests
{
    [TestFixture]
    public class RadixConverterTests
    {
        [Test]
        [TestCase(128, 16, "80")]
        [TestCase(-23, 2, "-10111")]
        [TestCase(0, 9, "0")]
        [TestCase(int.MaxValue, 36, "zik0zj")]
        [TestCase(int.MinValue, 13, "-282ba4aab")]
        public void ToNewRadix_PositiveTest(int value, int newRadix, string expected)
        {
            string actual = value.ToNewRadix(newRadix);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        [TestCase(-221, 37)]
        [TestCase(873, 1)]
        [TestCase(int.MinValue, 0)]
        public void ToNewRadix_ArgumentExceptionTest(int value, int newRadix)
        {
            value.ToNewRadix(newRadix);
        }
    }
}