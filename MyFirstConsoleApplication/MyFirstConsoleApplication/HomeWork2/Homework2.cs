using System;
using System.Security.Cryptography.X509Certificates;

namespace HomeWork2
{
    public class Homework2
    {
        //Условия

        //1. Пользователь вводит 3 числа(A, B и С). Выведите в консоль решение(значения X) квадратного уравнения стандартного вида, где AX2+BX+C=0.   
        public void Block01Task01()
        {
            Console.WriteLine("ВВедите три числа: А, В, С, где А не равно нулю.");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double d = GetDiscriminant(a, b, c);
            double[] result = GetRoots(a, b, d);

            switch (result.Length)
            {
                case 0:
                    break;
                default:
                    break;
            }

        }

        public double GetDiscriminant(double a, double b, double c)
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }

        public double[] GetRoots(double a, double b, double discriminant)
        {
            if (discriminant < 0)
            {
                return new double[] { };
            }
            else if (discriminant == 0)
            {
                return new double[] { -b / 2 * a };
            }
            else
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                return new double[] { };
            }
        }

        //2. Пользователь вводит двузначное число.Выведите в консоль прописную запись этого числа. Например при вводе “25” в консоль будет выведено “двадцать пять”.
        public void Block01Task02()
        {
            Console.WriteLine("Введите двузначное число.");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a < 10 || a > 99)
            {
                Console.WriteLine("Введенное число не является двузначным.");
            }

            if (a > 9 && a < 20)
            {
                string translate;
                switch (a)
                {

                    case 10:
                        translate = "десять";
                        break;
                    case 11:
                        translate = "одиннадцать";
                        break;
                    case 12:
                        translate = "двенадцать";
                        break;
                    case 13:
                        translate = "тринадцать";
                        break;
                    case 14:
                        translate = "четырнадцать";
                        break;
                    case 15:
                        translate = "пятнадцать";
                        break;
                    case 16:
                        translate = "шестнадцать";
                        break;
                    case 17:
                        translate = "семнадцать";
                        break;
                    case 18:
                        translate = "восемнадцать";
                        break;
                    default:
                        translate = "девятнадцать";
                        break;

                }
                Console.WriteLine($"Буквенное представление числа: {translate}");
            }

            else if (a > 19 && a < 100)
            {
                int firstDigit = a / 10;
                int secondDigit = a % 10;

                string firstDigitString;
                string secondDigitString;

                switch (firstDigit)
                {
                    case 2:
                        firstDigitString = "двадцать";
                        break;
                    case 3:
                        firstDigitString = "тридцать";
                        break;
                    case 4:
                        firstDigitString = "сорок";
                        break;
                    case 5:
                        firstDigitString = "пятьдесят";
                        break;
                    case 6:
                        firstDigitString = "шестьдесят";
                        break;
                    case 7:
                        firstDigitString = "семьдесят";
                        break;
                    case 8:
                        firstDigitString = "восемьдесят";
                        break;
                    default:
                        firstDigitString = "девяносто";
                        break;

                }

                switch (secondDigit)
                {
                    case 1:
                        secondDigitString = "один";
                        break;
                    case 2:
                        secondDigitString = "два";
                        break;
                    case 3:
                        secondDigitString = "три";
                        break;
                    case 4:
                        secondDigitString = "четыре";
                        break;
                    case 5:
                        secondDigitString = "пять";
                        break;
                    case 6:
                        secondDigitString = "шесть";
                        break;
                    case 7:
                        secondDigitString = "семь";
                        break;
                    case 8:
                        secondDigitString = "восемь";
                        break;
                    default:
                        secondDigitString = "девять";
                        break;
                }
                Console.WriteLine($"Буквенное представление числа: {firstDigitString} {secondDigitString}");
            }

        }


        //3. Определение принадлежности точки кругу с центром в начале координат:
        //вводятся координаты (x; y) точки и радиус круга(r), определить, принадлежит ли данная точка кругу, если его центр находится в начале координат.
        //x и y - рандом от -15 до 15, r - рандом от -10 до 10
        public void Block01Task03()
        {
            Random rnd = new Random();
            int x = rnd.Next(-15, 15);
            int y = rnd.Next(-15, 15);
            int r = rnd.Next(-10, 10);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(r);


            if (r < 0)
            {
                Console.WriteLine("Радиус не может быть отрицательным.");
            }

            else if ((x * x) + (y * y) <= r * r)
            {
                Console.WriteLine("Точка принадлежит окружности");
            }
            else
            {
                Console.WriteLine("Точка находится за пределами окружности");
            }
        }
        //Циклы

        //1. Пользователь вводит 2 числа(A и B). Возвести число A в степень B.

        public void Block02Task01()
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            if (b == 0)
            {
                Console.WriteLine($"Результат равен {a}");
            }

            else if (b > 0)
            {

                double result = a;
                for (int i = 0; i < b - 1; i++)
                {
                    result *= a;
                }
                Console.WriteLine($"Результат равен {result}");
            }
            else /* (b < 0) */
            {
                double result = a;
                b = -b;
                for (double i = 0; i < b - 1; i++)
                {
                    result *= a;
                }
                Console.WriteLine($"Результат равен {1 / result}");
            }

            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //double result = Math.Pow(a, b);
            //Console.WriteLine(result);
        }

        //2. Пользователь вводит 1 число (A). Вывести все числа от 1 до 1000, которые делятся на A.

        public void Block02Task02()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int oneToThousand = 0;
            for (int i = 0; i <= 1000; i++)
            {
                if (oneToThousand % a == 0)
                {
                    Console.WriteLine(oneToThousand);
                }
                oneToThousand++;
            }


        }

        //3. Пользователь вводит число n. Докажите, что для множества натуральных чисел верно 1+2+...+n = n * (n + 1) / 2

        public void Block02Task03()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int res1 = n * (n + 1) / 2;
            int res2 = 0;
            for (int i = 1; i <= n; i++)
            {
                res2 += i;
            }
            if (res1 == res2)
            {
                Console.WriteLine("It works, res1 equals res2 =)");
            }
            else
            {
                Console.WriteLine("It doesn't work =(");
            }

        }

        //4. Пользователь вводит число n. Выведите N-ое число ряда Фибоначчи. В ряду Фибоначчи каждое следующее число является суммой двух предыдущих. Первое и второе считаются равными 1.

        public void Block02Task04()
        {
            Console.WriteLine("Введите натуральное число:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 2)
                Console.WriteLine($"{1}-ый и {2}-ой порядковые номера принадлежат числу 1 последовательности Фибоначчи");

            else if (n <= 0)
            {
                Console.WriteLine("Было бы лучше ввести натуральное число.");
            }

            else
            {
                int fibPrevious = 1;
                int fibCurrent = 1;
                int fibSum = 0;

                for (int i = 0; i < n - 2; i++)
                {
                    fibSum = fibPrevious + fibCurrent;
                    fibPrevious = fibCurrent;
                    fibCurrent = fibSum;
                }
                Console.WriteLine($"Порядковый номер {n} принадлежит числу {fibSum} последовательности Фибоначчи");
            }
        }

        //5. Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A.
        public void Block02Task05()
        {
            Console.WriteLine("Please, enter a number:");
            int a = Convert.ToInt32(Console.ReadLine());
            int greatestDivider = a - 1;

            while (a % greatestDivider != 0)
            {
                greatestDivider -= 1;
            }
            Console.WriteLine($"The greatest divider number {a} is {greatestDivider}");

            //My first not laconic solution:
            //Console.WriteLine("Please, enter a number:");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int greatestDivider = 0;
            //while (a % 5 == 0)
            //{
            //    greatestDivider = a / 5;
            //    break;
            //}

            //while (a % 3 == 0)
            //{
            //    greatestDivider = a / 3;
            //    break;
            //}

            //while (a % 2 == 0)
            //{
            //    greatestDivider = a / 2;
            //    break;
            //}

            //while ((a % 2 != 0) &&
            //                         (a % 3 != 0) &&
            //                                            (a % 5 != 0))
            //{
            //    greatestDivider = a / a;
            //    break;
            //}
            //Console.WriteLine($"The greatest divider number {a} is {greatestDivider}");
        }

        //Массивы
        //Задан массив из 20 элементов.
        //1. Заполните массив случайными числами (рандом от -100 до 100).
        public void Block03Task01_02_03_04_05()
        {
            Random rnd = new Random();
            int[] arr = new int[20];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-100, 100);
            }

            //2. Найдите наибольший элемент этого массива и его индекс.

            Console.WriteLine($"All elements of the array:");
            int maxValue = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (maxValue < arr[i])
                {
                    maxValue = arr[i];
                }
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine($"\nLargest element in the array: \n{maxValue}");

            //3. Посчитайте сумму элементов этого массива с нечетными индексами.

            int sumOddIndex = 0;
            for (int i = 1; i < arr.Length; i += 2)
            {
                sumOddIndex += arr[i];
            }
            Console.WriteLine($"\nSum of odd elements on index: \n{sumOddIndex}");

            //4. Найдите в массиве те элементы, значение которых меньше среднего арифметического, взятого от всех элементов массива.

            double sumElements = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sumElements += arr[i];
            }

            double average = sumElements / arr.Length;
            Console.WriteLine("\nElements, whose value is less than arithmetic mean:");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < average)
                {
                    Console.WriteLine(arr[i]);
                }
            }

            //5. Сделайте реверс массива (расположите элементы массива в обратном порядке - последний становится первым, предпоследний - вторым, и т.д.)

            for (int i = 0; i < arr.Length / 2; i++)
            {
                int j = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = j;
            }

            Console.WriteLine("\nArray reverse:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}
