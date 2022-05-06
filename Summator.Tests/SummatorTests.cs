using NUnit.Framework;

namespace Summator.Tests
{

    [TestFixture]
    public class SummatorTests
    {
        private Summator summator;

        [SetUp]
        public void SetUp()
        {
            summator = new Summator();
            System.Console.WriteLine("Test Started: " + System.DateTime.Now);
        }

        [Test]
        public void Test_Sum_TwoPossitiveNumbers()
        {
            long actual = summator.Sum(new int[] { 5, 7 });
            long expected = 12;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Sum_TwoNegativeNumbers()
        {
            long actual = summator.Sum(new int[] { -5, -7 });
            long expected = -12;

            Assert.That(actual == expected);

        }

        [Test]
        public void Test_Sum_Zero()
        {
            long actual = summator.Sum(new int[] { 0, 0 });
            long expected = 0;

            Assert.That(actual == expected);
        }

        [Test]
        public void Test_Sum_EmptyArray()
        {
            long actual = summator.Sum(new int[] { });
            long expected = 0;

            Assert.That(actual == expected);
        }

        [Test]
        public void Test_Sum_BigNumbers()
        {
            long actual = summator.Sum(new int[] { 2000000000, 2000000000 });
            long expected = 4000000000;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Average_Numbers()
        {
            int actual = Summator.Average(new int[] { 5, 10, 15 });
            int expected = 10;

            Assert.AreEqual(expected, actual);
        }

        [TearDown]
        public void TearDown()
        {
            summator = null;
            System.Console.WriteLine("Test ended: " + System.DateTime.Now);
        }

    }
}