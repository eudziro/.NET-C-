using System;
using NUnit.Framework;
using Multiplication.Services;

    [TestFixture]
    public class Tests
    {
        [TestCase(2,3,-5)]
        [TestCase(3,3, 0)]
        [TestCase(4,5,-9)]
        [TestCase(-9,5,56)]
        public void Test1(int value1, int value2, int result)
        {
            Assert.That(result, Is.EqualTo(MultiplicationService.Multiplication(value1, value2)));
        }
        [TestCase(2,3,'m',6)]
        [TestCase(9,9,'m',81)]
        [TestCase(8,8,'m',64)]
        [TestCase(100,200,'d',0.5)]
        public void Test2(int value1, int value2, char val3, double result)
        {
            Assert.That(result, Is.EqualTo(MultiplicationService.Calculator(value1, value2, val3)));
        }
        [TestCase(new int[]{100, 40, 34, 57, 29, 72, 57, 88}, 59)]
        [TestCase(new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10}, 5)]
        public void TEST3(int[] array, int result)
        {
            Assert.That(result, Is.EqualTo(MultiplicationService.CalculateAverage(array)));
        }
        [TestCase(new int[]{100, 40, 34, 57, 29, 72, 57, 88}, 100)]
        public void TEST4(int[] array, int result)
        {
            Assert.That(result, Is.EqualTo(MultiplicationService.LinearSearch(array)));
        }
    }
