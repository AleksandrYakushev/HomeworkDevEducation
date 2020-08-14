using System;

namespace HomeWork4
{
    public class Task01
    {
        // Пользователь вводит 2 числа. Найти их наибольший общий делитель используя алгоритм Евклида.
        public void FindingGreatestDevisor()
        {
            Helper helper = new Helper();
            int number1 = helper.EnterTheNumber("Enter the first number:");
            int number2 = helper.EnterTheNumber("Enter the second number:");
            int result = FindingGreatestDevisor(number1, number2);
            helper.Print("The Greatest Devisior is:");
            helper.Print(result);
        }
        public int FindingGreatestDevisor(int a, int b)

        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            while ((a != 0) && (b != 0))
            {
                if (a > b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
            }
            return a + b;
        }
    }
}
