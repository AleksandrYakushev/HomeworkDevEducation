using System;


namespace HomeWork1
{
    public class Homework1
    {
        // Переменные алгоритмы
        // 1. Пользователь вводит 2 числа (a и b). Поменяйте содержимое переменных a и b местами.

        public void Block01Task01()
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            SwapNumbers(a, b);
        }
        public double[] SwapNumbers(double a, double b)
        {
            double c;
            c = b;
            b = a;
            a = c;

            return new double[] { a + b};
        }

        //  2.Найти длину гипотенузы(по двум введенным пользователем катетам вычислить длину гипотенузы.) 

        public void Block01Task02()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Hypotenuse(a, b);
        }
        public double Hypotenuse(int a, int b)
        { 
            double c = Math.Sqrt(a * a + b * b);
            Console.WriteLine(c);
            return c;
        }

        //3.Пользователь вводит 3 числа(A, B и С).Выведите в консоль решение(значение X) линейного уравнения стандартного вида, где A* X+B = C

        public void Block01Task03()
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            ValueX(a, b, c);
        }

        public double ValueX(double a, double b, double c)
        {
            double x = (c - b) / a;
            Console.WriteLine(x);
            return x;
        }

        public void Block02Task01()
        {
            /*
             Условия
            1.Пользователь вводит 2 числа(A и B).Если A > B, подсчитать A+B, если A = B, подсчитать A* B, если A < B, подсчитать A-B
            */

            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            if (a > b)
                Console.WriteLine(a + b);
            else if (a == b)
                Console.WriteLine(a * b);
            else
                Console.WriteLine(a - b);
        }
        public void Block02Task02()
        {

            /*
            2.Вводятся два целых числа.Проверить, делится ли первое на второе.Вывести на экран сообщение об этом, а также остаток(если он есть) и частное(в любом случае).
    (рандом от - 100 до 100)
           */

            Random rnd = new Random();
            int a = rnd.Next(-100, 100);
            int b = rnd.Next(-100, 100);
            Console.WriteLine(a + " " + b);
            int d = a % b;
            int c = a / b;

            if (d == 0)
            {
                Console.WriteLine("Первое число делится на второе число");
                Console.WriteLine("Частное" + " " + c);
            }

            else
            {
                Console.WriteLine("Первое число не делится на второе число");
                Console.WriteLine("Остаток" + " " + d);
                Console.WriteLine("Частное" + " " + c);
            }
        }

        public void Block02Task03()
        {
            /* 3.Определить, какой четверти принадлежит точка с координатами(x, y).
    x и y - рандом от - 10 до 10 */

            Random rnd = new Random();
            int x = rnd.Next(-10, 10);
            int y = rnd.Next(-10, 10);
            Console.WriteLine(x);
            Console.WriteLine(y);

            if (x > 0 && y > 0)
                Console.WriteLine(1);
            else if (x < 0 && y > 0)
                Console.WriteLine(2);
            else if (x < 0 && y < 0)
                Console.WriteLine(3);
            else if (x > 0 && y < 0)
                Console.WriteLine(4);
            else
                Console.WriteLine("Точка находится на оси координат");
        }

        public void Print(String print)
        {
            Console.WriteLine(print);
        }
    }
}
