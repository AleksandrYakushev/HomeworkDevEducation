using NUnit.Framework;
using System;


namespace HomeWork4.Tests
{
    public class Homework4Test
    {
        [SetUp]
        public void Setup()
        {
        }

        // Task01

        [TestCase(40, 75, 5)]
        [TestCase(20, 4, 4)]
        [TestCase(0, 1, 1)]
        [TestCase(1, 0, 1)]
        [TestCase(0, 0, 0)]
        [TestCase(-33, 11, 11)]
        [TestCase(1000, -10, 10)]
        public void FindingGreatestDevisorTest(int a, int b, int expected)
        {
            Task01 task01 = new Task01();
            int actual = task01.FindingGreatestDevisor(a, b);
            Assert.AreEqual(expected, actual);
        }

        // Task02

        [TestCase(new[] {1, 7, 4 }, new int[] { 1, 4, 7})]
        [TestCase(new[] { 1, 2, 3, 2, 5, 0 }, new int[] { 0, 1, 2, 2, 3, 5 })]
        [TestCase(new[] { 0, 0, 4, 0, 1, 4 }, new int[] { 0, 0, 0, 1, 4, 4 })]
        [TestCase(new[] { -17, -25, 1, -4, 0, -100 }, new int[] { -100, -25, -17, -4, 0, 1 })]
        public void SortTest(int[] sourceArray, int[] expected)
        {
            Task02 task02 = new Task02();
            int[] actual = task02.Sort(sourceArray);
            Assert.AreEqual(expected, actual);
        }

        // Task03

        [TestCase(0, 0, 0, 0)]
        [TestCase(1, 2, 3, 247)]
        [TestCase(3, 7, -5, 0)]
        [TestCase(-3, -7, -5, 0)]
        [TestCase(4, 8, 23, 1582)]
        [TestCase(6, 3, 0, 222)]

        public void CaloriesAcquiredTest(int grass, int seaweed, int crocodile, int expected)
        {
            Task03 task03 = new Task03();
            int actual = task03.CaloriesAcquired(grass, seaweed, crocodile);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0, 0, 0, 0)]
        [TestCase(-1, -2, -3, -4, 0)]
        [TestCase(1, 2, 3, 4, 1264)]
        [TestCase(18, 56, 0, 0, 26568)]
        
        public void CaloriesBurnTest(int hideAndSeek, int catchUp, int dotaGame, int chess, int expected)
        {
            Task03 task03 = new Task03();
            int actual = task03.CaloriesBurned(hideAndSeek, catchUp, dotaGame, chess);
            Assert.AreEqual(expected, actual);
        }
    }
}