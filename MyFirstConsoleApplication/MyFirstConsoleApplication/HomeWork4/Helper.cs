using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork4
{
    public class Helper
    {
        public int EnterTheNumber(string s)
        {
            Console.WriteLine(s);
            int a = Convert.ToInt32(Console.ReadLine());
            return a;
        }
        public void Print(int number)
        {
            Console.WriteLine(number);
        }
        public void Print(String s)
        {
            Console.WriteLine(s);
        }

        public void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
