using HomeWork5;
using HomeWork6;
using HomeWork7;
using System;
using System.Collections.Generic;
using System.Diagnostics;



namespace MyFirstConsoleApplication
{
    class Program
    { 

        static void Main(string[] args)
        {
            int[] array = new int[] { 6, 5, 4, 3, 2, 1, 0 };
            ArrayList arrayList = new ArrayList(new int[] { 6, 5, 4, 3, 2, 1, 0 });
            arrayList.GetSize();
            int a = array[3];
            int b = arrayList[3];
            LinkedList list = new LinkedList(new int[] { 6, 5, 4, 3, 2, 1, 0 });

            int c = list[3];
            Console.WriteLine(c);
        }
    }
}
