using NUnit.Framework;

namespace HomeWork1.Tests
{
    public class Homework1Test
    {
        [SetUp]
        public void Setup()
        {
        }

        //    [TestCase(15, 10, {10, 15})]
        //    public void ChangeA_BTest(double a, double b, double[] expected)
        //{
        //    Homework1 hw1 = new Homework1();
        //    double[] actual = hw1.ChangeA_B(a, b);  // 3. —читываем актуальное значение, которое возвращает этот метод.

        //    // assert
        //    Assert.AreEqual(expected, actual);
        //}

        [TestCase(2, 3, 3.605551275463989)]
        [TestCase(0, 0, 0)]
        public void HypotenuseTest(int a, int b, double expected)
        {
            Homework1 hw1 = new Homework1();
            double actual = hw1.Hypotenuse(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2, 3, 1)]
        [TestCase(4, 2, 3, 0.25)]
        [TestCase(-6, 13, -5, 3)]
        public void ValueX(double a, double b, double c, double expected)
        {
            Homework1 hw1 = new Homework1();
            double actual = hw1.ValueX(a, b, c);

            Assert.AreEqual(expected, actual);
        }
    }


}
