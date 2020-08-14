using System;

namespace HomeWork3
{
    public class Homework3
    {
        //        Циклы
        //1. Пользователь вводит 2 числа. Сообщите, есть ли в написании двух чисел одинаковые цифры. Например, для пары 123 и 345, ответом будет являться “ДА”, а, для пары 500 и 999 - “НЕТ”. (на самом деле, это задание следовало перенести в раздел "Вложенные циклы")
        public void Block01Task01()
        {
            Console.WriteLine("Enter a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b");
            int b = Convert.ToInt32(Console.ReadLine());

            while (a > 0)
            {
                int currDigitA = a % 10;
                a /= 10;
                Console.WriteLine($"Now checking the digit {currDigitA}");

                int secondNumberB = b;

                while (secondNumberB > 0)
                {
                    int currDigitB = secondNumberB % 10;
                    secondNumberB /= 10;
                    Console.WriteLine($"Now checking the digit {currDigitB} number b");

                    if (currDigitA == currDigitB)
                    {
                        Console.WriteLine("Congratulations! The match was found!");
                        return;
                    }
                }

            }
        }

        //2. Пользователь вводит 1 число. Найти число, которое является зеркальным отображением последовательности цифр заданного числа, например, задано число 123, вывести 321.
        public void Block01Task02()
        {
            Console.WriteLine("Enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = 0;
            while (a > 0)
            {
                b = b * 10 + a % 10;
                a /= 10;
            }
            Console.Write("Mirrow number a is " + b);
        }

        //3. Написать программу, которая будет складывать, вычитать, умножать или делить два числа.Числа и знак операции вводятся пользователем.После выполнения вычисления программа не должна завершаться, а должна запрашивать новые данные для вычислений.Завершение программы должно выполняться при вводе символа '0' в качестве знака операции. Если пользователь вводит неверный знак (не '0', '+', '-', '*', '/'), то программа должна сообщать ему об ошибке и снова запрашивать знак операции.Также сообщать пользователю о невозможности деления на ноль, если он ввел 0 в качестве делителя.
        //Что должно получиться в результате? Я думаю, все представляют себе обычный калькулятор, где итог изначально равен 0. Вам предстоит реализовать нечто подобное - где вы вводите число, а затем - знак операции, потом снова число, потом снова знак операции... Естественно, стоит выводить в консоль промежуточные результаты вычислений.

        public void Block01Task03()
        {
            Console.WriteLine("Enter a first number ");
            int result = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                Console.WriteLine("Enter an operation(+, -, *, /)");
                string operation = Console.ReadLine();


                int number;
                switch (operation)
                {
                    case "0":
                        Console.WriteLine("End of the calculation");
                        return;
                    case "+":
                        Console.WriteLine("Enter next number");
                        number = Convert.ToInt32(Console.ReadLine());
                        result += number;
                        Console.WriteLine($"Result is: {result}");
                        break;
                    case "-":
                        Console.WriteLine("Enter next number");
                        number = Convert.ToInt32(Console.ReadLine());
                        result -= number;
                        Console.WriteLine($"Result is: {result}");
                        break;
                    case "*":
                        Console.WriteLine("Enter next number");
                        number = Convert.ToInt32(Console.ReadLine());
                        result *= number;
                        Console.WriteLine($"Result is: {result}");
                        break;
                    case "/":
                        Console.WriteLine("Enter next number");
                        number = Convert.ToInt32(Console.ReadLine());
                        if (number == 0)
                        {
                            Console.WriteLine("You can't divide by zero");
                        }
                        else
                        {
                            result /= number;
                            Console.WriteLine($"Result is: {result}");
                        }
                        break;
                    default:
                        Console.WriteLine("Error! You enter unknown action. Enter an action again");
                        break;
                }
            }

        }

        //Одномерные массивы
        //1. Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2. Если в массиве кол-во элементов нечётное (1 2 3 4 5), “средний” элемент оставить на своём месте: 4 5 3 1 2
        public void Block02Task01()
        {
            int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };



            for (int i = 0; i < arr.Length / 2; i++)
            {
                int replaceIndex = Convert.ToInt32(Math.Ceiling(arr.Length / 2.0)) + i;
                int tmp = arr[i];
                arr[i] = arr[replaceIndex];
                arr[replaceIndex] = tmp;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        //2. В массиве найти сумму элементов, находящихся между минимальным и максимальным элементами.Сами минимальный и максимальный элементы в сумму не включать.
        public void Block02Task02()
        {
            int[] arr = { 4, 3, 6, 5, 7, 6 };
            int maxValue = Int32.MinValue; // макс эл-т массива
            int minValue = Int32.MaxValue; //минимальный эл-т массива
            int indexMin = arr[0]; // индекс максимального и минимального эл та массива
            int indexMax = arr[0];
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxValue)
                {
                    maxValue = arr[i];
                    indexMax = i;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < minValue)
                {
                    minValue = arr[i];
                    indexMin = i;
                }
            }
            if (indexMin < indexMax)
            {
                for (int i = indexMin + 1; i < indexMax; i++)
                {
                    sum += arr[i];
                }
            }
            else
            {
                for (int i = indexMax - 1; i < indexMin; i--)
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine($"Sum all elements of the array between min and max index of the array: {sum}");
        }

        //Вложенные циклы
        //1. Посчитать, сколько раз встречается определенная цифра в введенной последовательности чисел.Количество вводимых чисел и цифра, которую необходимо посчитать, задаются вводом с клавиатуры.
        public void Block03Task01()
        {
            Console.WriteLine("Enter a number of numbers");
            int numberNumber = Convert.ToInt32(Console.ReadLine());
            int numberLastDigit;
            Console.WriteLine("Enter a digit");
            int digit = Convert.ToInt32(Console.ReadLine());
            int counterNumbers = 0; // для красоты
            int counter = 0;

            for (int i = 0; i < numberNumber; i++)
            {
                counterNumbers++;
                Console.WriteLine("Enter a number {0}", counterNumbers);
                int number = Convert.ToInt32(Console.ReadLine());
                while (number > 0)
                {
                    numberLastDigit = number % 10;
                    if (digit == numberLastDigit)
                    {
                        counter++;
                    }
                    number /= 10;
                }
            }
            Console.WriteLine("The digit: {0} met {1} time(s) in this sequence of numbers.", digit, counter);
        }

        //2. Вывести на экран "прямоугольник", образованный из двух видов символов.Контур прямоугольника должен состоять из одного символа, а в "заливка" - из другого. Размеры прямоугольника, а также используемые символы задаются вводом с клавиатуры.
        //Например: http://joxi.ru/zAN943Ni63e3e2

        public void Block03Task02()
        {
            int i, j;

            for (i = 0; i < 20; i++)
            {
                Console.Write("*");
                if (i == 0 || i == 19)
                {
                    for (j = 0; j < 18; j++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    for (j = 0; j < 17; j++)
                    {
                        Console.Write("0");
                    }
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

        //Двумерные массивы
        //Пользователь вводит размеры массива (переменные rows и cols)

        public void Block04Task01_02_03()
        {
            int rows = Convert.ToInt32(Console.ReadLine());
            int cols = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[rows, cols];

            //1. Заполнить массив случайными числами(рандом от -200 до 200)

            Random rnd = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(-200, 200);
                }
            }

            //2. Вывести полученный массив массив в консоль(так, чтобы получились ровные столбцы)

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //3. Найти количество элементов массива, которые больше своих левого, правого, верхнего и нижнего соседа одновременно.
            //   Вывести эти элементы в консоль в формате[i, j] = x(вместо i - индекс строки, вместо j - индекс столбца, вместо х - значение элемента массива)


            int counterLargeElements = 0;
            for (int i = 1; i < rows - 1; i++)
            {
                for (int j = 1; j < cols - 1; j++)
                {
                    if (array[i, j] > array[i, j - 1] &&
                        array[i, j] > array[i, j + 1] &&
                        array[i, j] > array[i - 1, j] &&
                        array[i, j] > array[i + 1, j])
                    {
                        counterLargeElements++;
                        Console.WriteLine("[{0}, {1}] = {2} \n", i, j, array[i, j]);
                    }
                }
            }
            Console.WriteLine("Number of elements: {0}. \t", counterLargeElements);
        }
    }
}
