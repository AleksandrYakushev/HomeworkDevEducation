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

            double a = 1, b = 2, c = 1; // 1. ������������� ���� �������� ������ 
            double expected = 0;        // 2. ����������� ��������� ���������� (��������� ��������). ���� �� ������ ��������� ����, ��� ������ �������� ���� ����� �������� ���������. ��, �� ��� �� ��������).

            // expected actual - ������������ ��������.

            // act (�������������� / ������� �����, �������� ���� ���� a, b, c ��������� � ������� ����� �� ���������).

            Homework2 hw2 = new Homework2();
            double actual = hw2.GetDiscriminant(a, b, c);  // 3. ��������� ���������� ��������, ������� ���������� ���� �����.

            // assert (��� ����� �������� ��� �� ��������, ������� �� �������� � actual ��������� � ��� ��� �� ������� �������). 
            Assert.AreEqual(expected, actual);
        }
        
            [TestCase(1, 2, 1, 0)]
            [TestCase(2, 8, 1, 56)]
            [TestCase(2, 0, -1, 8)]
            [TestCase(3, 0, 1, -12)]
            public void GetDiscriminantTest(double a, double b, double c, double expected)
        {
            //arrange
            //(��� �������� ������ � �������� ���������� �������� � ��������� ������)


            // act 

            Homework2 hw2 = new Homework2();
            double actual = hw2.GetDiscriminant(a, b, c);  // 3. ��������� ���������� ��������, ������� ���������� ���� �����.

            // assert
            Assert.AreEqual(expected, actual);
        }
        
    }
}