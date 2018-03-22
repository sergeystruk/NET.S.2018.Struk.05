using System;
using System.Security.Cryptography.X509Certificates;
using GreatestCommonDivisor;
using NUnit.Framework;

namespace GreatestCommonDivesor.Tests
{
    public class AlgorithmTests
    {
        [TestCase(15, 9, ExpectedResult = 3)]
        public int EuclidAlgorithm_OverloadedTest(int a, int b) => Algorithm.EuclidAlgorithm(a, b);
        [TestCase(28, 56, 658, ExpectedResult = 14)]
        public int EuclidAlgorithm_OverloadedTest(int a, int b, int c) => Algorithm.EuclidAlgorithm(a, b, c);
        [TestCase(30, 120, 60, 180, 10, ExpectedResult = 10)]
        public int EuclidAlgorithm_OverloadedTest(params int[] array) => Algorithm.EuclidAlgorithm(array);

        [Test]
        public void EuclidAlgorithm_TestWithNegative() =>
            Assert.Throws<ArgumentNullException>(() => Algorithm.EuclidAlgorithm(-5, 0));
    }
}
