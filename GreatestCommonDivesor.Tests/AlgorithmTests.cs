using System;
using GreatestCommonDivisor;
using NUnit.Framework;

namespace GreatestCommonDivesor.Tests
{
    public class AlgorithmTests
    {
        [TestCase(15, 9, ExpectedResult = 3)]
        public int EuclidAlgorithm_OverloadedTest(int a, int b) => Algorithm.EuclidAlgorithm(a, b);
        [TestCase(0, 0, ExpectedResult = 0)]
        public int EuclidAlgorithm_OverloadedTestWithNulls(int a, int b) => Algorithm.EuclidAlgorithm(a, b);
        [TestCase(28, 56, 658, ExpectedResult = 14)]
        public int EuclidAlgorithm_OverloadedTest(int a, int b, int c) => Algorithm.EuclidAlgorithm(a, b, c);
        [TestCase(0, 0, 658, ExpectedResult = 658)]
        public int EuclidAlgorithm_OverloadedTestWithNulls(int a, int b, int c) => Algorithm.EuclidAlgorithm(a, b, c);
        [TestCase(30, 120, 60, 180, 10, ExpectedResult = 10)]
        public int EuclidAlgorithm_OverloadedTest(params int[] array) => Algorithm.EuclidAlgorithm(array);
        [TestCase(0,0,0,0,30,ExpectedResult = 30)]
        public int EuclidAlgorithm_OverloadedTestWithNulls(params int[] array) => Algorithm.EuclidAlgorithm(array);

        [TestCase(15, 9, ExpectedResult = 3)]
        public int SteinAlgorithm_OverloadedTest(int a, int b) => Algorithm.SteinAlgorithm(a, b);
        [TestCase(0, 0, ExpectedResult = 0)]
        public int SteinAlgorithm_OverloadedTestWithNulls(int a, int b) => Algorithm.SteinAlgorithm(a, b);
        [TestCase(28, 56, 658, ExpectedResult = 14)]
        public int SteinAlgorithm_OverloadedTest(int a, int b, int c) => Algorithm.SteinAlgorithm(a, b, c);
        [TestCase(0, 0, 658, ExpectedResult = 658)]
        public int SteinAlgorithm_OverloadedTestWithNulls(int a, int b, int c) => Algorithm.SteinAlgorithm(a, b, c);
        [TestCase(30, 120, 60, 180, 10, ExpectedResult = 10)]
        public int SteinAlgorithm_OverloadedTest(params int[] array) => Algorithm.SteinAlgorithm(array);
        [TestCase(0, 0, 0, 0, 30, ExpectedResult = 30)]
        public int SteinAlgorithm_OverloadedTestWithNulls(params int[] array) => Algorithm.SteinAlgorithm(array);
    }
}
