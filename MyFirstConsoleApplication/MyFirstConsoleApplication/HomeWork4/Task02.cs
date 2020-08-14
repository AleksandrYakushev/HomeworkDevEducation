using System;

namespace HomeWork4
{
    public class Task02
    {
        // Реализовать сортировку одномерного массива по возрастанию, используя метод сортировки выбором.
        public void SortArray()
        {
            Helper helper = new Helper();
            int[] array = new int[] { 7, 3, 1, 5, 3, 6, 8, 9 };
            array = Sort(array);
            helper.Print("Sort array:");
            helper.Print(array);
        }
        public int[] Sort(int[] array)
        {
            int min;
            int tmp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                tmp = array[i];
                array[i] = array[min];
                array[min] = tmp;
            }
            return array;
        }
    }
}
