namespace MyFirstConsoleApplication
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    namespace JointProjectArrayList
    {
        public class ArrayList
        {
            private int[] _array;
            private int _realLength = 0;

            public ArrayList()
            {
                _array = new int[0];
                // _currentIndex = 0;
            }

            public ArrayList(int[] array)
            {
                _array = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    _array[i] = array[i];
                    _realLength = array.Length;
                }
            }

            public int[] Array { get; set; }
            //public int CurrentIndex { get; set; }
            private int[] AppendArrayByNum(int num) // appending in the end
            {
                int[] arr = new int[_array.Length + num];
                for (int i = 0; i < _array.Length; i++)
                {
                    arr[i] = _array[i];
                }
                _array = arr;
                return _array;
            }
            private int[] AppendArrayByNumAtFront(int num)      // на длину массива или для инта на 1
            {
                int[] arr = new int[_array.Length + num];
                int n = 0;
                for (int i = num; i < _array.Length + num; i++)
                {
                    arr[i] = _array[n];
                    n++;
                }
                _array = arr;
                return _array;
            }
            private int[] AppendArrayAtIndex(int index, int value)
            {
                int[] arr = new int[_array.Length + 1];
                for (int i = 0; i < index; i++)
                {
                    arr[i] = _array[i];
                }
                for (int i = index + 1; i < _array.Length + 1; i++)
                {
                    arr[i] = _array[i - 1];
                }
                arr[index] = value;
                _array = arr;
                return _array;
            }
            private int[] AppendArrayAtIndexforArray(int index, int[] values)
            {
                int[] arr = new int[_array.Length + values.Length];
                for (int i = 0; i < index; i++)
                {
                    arr[i] = _array[i];
                }
                int n = index;
                for (int i = index + values.Length; i < _array.Length + values.Length; i++)
                {
                    arr[i] = _array[n];
                    n++;
                }
                int m = 0;
                for (int i = index; i < index + values.Length; i++)
                {
                    arr[i] = values[m];
                    m++;
                }
                _array = arr;
                return _array;
            }
            public int[] AddLast(int value)
            {
                int[] arr = AppendArrayByNum(1);
                arr[arr.Length - 1] = value;
                _array = arr;
                return _array;
            }
            public int[] AddLast(int[] values)
            {
                int[] arr = AppendArrayByNum(values.Length);
                int n = 0;
                for (int i = arr.Length - values.Length; i < arr.Length; i++)
                {
                    arr[i] = values[n];
                    n++;
                }
                _array = arr;
                return _array;
            }
            public int[] AddFirst(int value)
            {
                int[] arr = AppendArrayByNumAtFront(1);
                arr[0] = value;
                _array = arr;
                return _array;
            }
            public int[] AddFirst(int[] values)
            {
                int[] arr = AppendArrayByNumAtFront(values.Length);
                for (int i = 0; i < values.Length; i++)
                {
                    arr[i] = values[i];
                }
                _array = arr;
                return _array;
            }
            public int[] AddAt(int index, int value)
            {
                AppendArrayAtIndex(index, value);
                return _array;
            }
            public int[] AddAt(int index, int[] values)
            {
                AppendArrayAtIndexforArray(index, values);
                return _array;
            }
            public int[] RemoveLast()
            {
                int[] arr = new int[_array.Length - 1];
                for (int i = 0; i < _array.Length - 1; i++)
                {
                    arr[i] = _array[i];
                }
                _array = arr;
                return _array;
            }
            public int[] RemoveFirst()
            {
                int[] arr = new int[_array.Length - 1];
                for (int i = 0; i < _array.Length - 1; i++)
                {
                    arr[i] = _array[i + 1];
                }
                _array = arr;
                return _array;
            }
            public int[] RemoveAt(int index)
            {
                int[] arr = new int[_array.Length - 1];
                for (int i = 0; i < index; i++)
                {
                    arr[i] = _array[i];
                }
                for (int i = index; i < arr.Length; i++)
                {
                    arr[i] = _array[i + 1];
                }
                _array = arr;
                return _array;
            }
            public int[] RemoveAll(int value)
            {
                while (IndexOf(value) != -1)
                {
                    RemoveAt(IndexOf(value));
                }
                return _array;
            }
            public bool Contains(int value)
            {
                for (int i = 0; i < _array.Length; i++)
                {
                    if (_array[i] == value) return true;
                }
                return false;

            }
            public int IndexOf(int value)
            {
                int index = -1; // такого значения нет в списке
                for (int i = 0; i < _array.Length; i++)
                {
                    if (_array[i] == value) return i;
                }
                return index;
            }
            public int[] Set(int index, int value)
            {
                _array[index] = value;
                return _array;
            }
            public void PrintArray()
            {
                for (int i = 0; i < _array.Length; i++)
                {
                    Console.Write(" " + _array[i]);
                }
                Console.WriteLine("");
            }
            public int Min()
            {
                return GetElement(IndexOfMin());
            }
            public int Max()
            {
                return GetElement(IndexOfMax());
            }
            public int IndexOfMin()
            {
                int min = _array[0];
                int minIndex = 0;
                for (int i = 1; i < _array.Length; i++)
                {
                    if (_array[i] < min)
                    {
                        min = _array[i];
                        minIndex = i;
                    }
                }
                return minIndex;
            }
            public int IndexOfMax()
            {
                int max = _array[0];
                int maxIndex = 0;
                for (int i = 1; i < _array.Length; i++)
                {
                    if (_array[i] > max)
                    {
                        max = _array[i];
                        maxIndex = i;
                    }
                }
                return maxIndex;
            }
            public int GetLast()
            {
                return GetElement(_array.Length - 1);
            }
            public int GetFirst()
            {
                return GetElement(0);
            }
            public int Get(int n)
            {
                return GetElement(n);
            }
            public int[] Reverse()
            {
                int temp;
                for (int i = 0; i < (_array.Length / 2); i++)
                {
                    temp = _array[i];
                    _array[i] = _array[_array.Length - i - 1];
                    _array[_array.Length - i - 1] = temp;
                }
                return _array;
            }
            public int[] Sort()
            {
                for (int i = 0; i < _array.Length - 1; i++)
                {
                    int min = i;
                    for (int j = i + 1; j < _array.Length; j++)
                    {
                        if (_array[j] < _array[min])   //поиск минимального числа
                        {
                            min = j;
                        }
                    }
                    int temp = _array[min];   // замена элементов местами
                    _array[min] = _array[i];
                    _array[i] = temp;
                }
                return _array;
            }
            public int[] SortDesc()
            {
                for (int i = 1; i < _array.Length; i++)
                {
                    for (int j = 0; j < _array.Length - 1; j++)
                    {
                        if (_array[j] < _array[j + 1])   //поиск минимального числа
                        {
                            int temp = _array[j];   // замена элементов местами
                            _array[j] = _array[j + 1];
                            _array[j + 1] = temp;
                        }
                    }
                }
                return _array;
            }
            public int GetSize()
            {
                return _array.Length;
            }
            private int GetElement(int n)
            {
                return _array[n];
            }
            public int[] ToArray()
            {
                return _array;
            }
        }
    }
}
