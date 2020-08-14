using NUnit.Framework;
using HomeWork2;

namespace HomeWork2.Tests
{
    public class Homework2Test
    {
        [SetUp]
        
        [Test]
        public void GetDiscriminant_a2_b8_c1_Result56()
        {
            //arrange

            double a = 1, b = 2, c = 1; // 1. ѕоготавливаем наши тестовые данные 
            double expected = 0;        // 2. ѕодготовили результат выполнени€ (ожидаемое значение). —юда мы кладем результат того, что должны получить если метод работает правильно. “о, на что мы надеемс€).

            // expected actual - общеприн€тые названи€.

            // act (взаимодействие / позвать метод, передать туда наши a, b, c параметры и поучить какой то результат).

            Homework2 hw2 = new Homework2();
            double actual = hw2.GetDiscriminant(a, b, c);  // 3. —читываем актуальное значение, которое возвращает этот метод.

            // assert (нам нужно сравнить что то значение, которое мы получили в actual совпадает с тем что мы ожидали увидеть). 
            Assert.AreEqual(expected, actual);
        }
        
            [TestCase(1, 2, 1, 0)]
            [TestCase(2, 8, 1, 56)]
            [TestCase(2, 0, -1, 8)]
            [TestCase(3, 0, 1, -12)]
            public void GetDiscriminantTest(double a, double b, double c, double expected)
        {
            //arrange
            //(все тестовые данные и резултат выполнени€ перенели в параметры метода)


            // act 

            Homework2 hw2 = new Homework2();
            double actual = hw2.GetDiscriminant(a, b, c);  // 3. —читываем актуальное значение, которое возвращает этот метод.

            // assert
            Assert.AreEqual(expected, actual);
        }
        
    }
}