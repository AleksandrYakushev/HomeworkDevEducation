using System;

namespace HomeWork5
{
    public class ArrayList
    {
        private int size = 10;
        private int[] _array;
        private int _realLength = 0;

        public ArrayList()
        {
            _array = new int[size];
        }

        public ArrayList(int[] array)
        {
            _array = new int[array.Length + 5];
            for (int i = 0; i < array.Length; i++)
            {
                _array[i] = array[i];
            }
            _realLength = array.Length;
        }

        public void AddFirst(int val)
        {
            AddAt(0, val);
        }

        public void AddLast(int val)
        {
            AddAt(_realLength, val);
        }

        public void AddAt(int idx, int val)
        {
            if (idx < 0 || idx > _realLength)
            {
                throw new Exception("Out of array size!");
            }

            if (_realLength == size - 1)
            {
                size = EnlargeArraySize(size);
                _array = CopyArrayUp();
            }

            for (int i = _realLength; i >= idx; i--)
            {
                _array[i + 1] = _array[i];
            }

            _array[idx] = val;
            _realLength++;
        }

        public void AddFirst(int[] arr)
        {
            AddAt(0, arr);
        }

        public void AddLast(int[] arr)
        {
            AddAt(_realLength, arr);
        }

        public void AddAt(int idx, int[] arr)
        {
            if (idx < 0 || idx > _realLength)
            {
                throw new Exception("Out of array size!");
            }

            if (size - _realLength < arr.Length)
            {
                size += arr.Length;

                _array = CopyArrayUp();
            }

            for (int i = _realLength; i >= idx; i--)
            {
                _array[i + arr.Length] = _array[i];
            }

            for (int i = 0; i < arr.Length; i++)
            {
                _array[idx + i] = arr[i];
            }

            _realLength += arr.Length;
        }

        public int GetSize() //GetSize() - узнать кол-во элементов в списке
        {
            return _array.Length;
        }

        public void Set(int idx, int val)  //Set(int idx, int val) - поменять значение элемента с указанным индексом
        {
            if (idx < 0 || idx >= _realLength)
            {
                throw new Exception("Out of array size!");
            }

            _array[idx] = val;
        }

        public void RemoveFirst() //RemoveFirst() - удаление первого элемента
        {
            RemoveAt(0);
        }

        public void RemoveLast() //RemoveLast() - удаление последнего элемента
        {
            RemoveAt(_realLength - 1);
        }

        public void RemoveAt(int idx)
        {
            if (idx < 0 || idx >= _realLength)
            {
                throw new Exception("Out of array size!");
            }

            for (int i = idx; i < _realLength; i++)
            {
                _array[i] = _array[i + 1];
            }
            _array[_realLength - 1] = 0;
            _realLength--;

            if (_realLength == size / 2)
            {
                size = LessArraySize(size);
                _array = CopyArrayDown();
            }
        }

        public void RemoveAll(int val) //удалить все элементы, равные val
        {
            for (int i = 0; i < _realLength; i++)
            {
                if (_array[i] == val)
                {
                    RemoveAt(i);
                    _realLength--;
                }
            }
        }

        public bool Contains(int val)  // - проверка, есть ли элемент в списке
        {
            for (int i = 0; i < _realLength; i++)
            {
                if (_array[i] == val)
                {
                    return true;
                }
            }
            return false;
        }

        public int IndexOf(int val) // - вернёт индекс первого найденного элемента, равного val(или -1, если элементов с таким значением в списке нет)
        {
            for (int i = 0; i < _realLength; i++)
            {
                if (_array[i] == val)
                {
                    return i;
                }

            }
            return -1;
        }

        public int[] ToArray() // - вернёт хранимые данные в виде массива
        {
            int[] newArray = new int[_realLength];
            for (int i = 0; i < _realLength; i++)
            {
                newArray[i] = _array[i];
            }
            return newArray;
        }

        public int GetFirst() // - вернёт значение первого элемента списка
        {
            return Get(0);
        }

        public int GetLast() // - вернёт значение последнего элемента списка
        {
            return Get(_realLength - 1);
        }

        public int Get(int idx) // - вернёт значение элемента списка c указанным индексом
        {
            if (idx < 0 || idx >= _realLength)
            {
                throw new Exception("Out of array size!");
            }

            for (int i = 0; i < _realLength; i++)
            {
                if (i == idx)
                {
                    return _array[i];
                }
            }
            return -1;
        }

        public void Reverse()  // - изменение порядка элементов списка на обратный
        {
            for (int i = 0; i < _realLength / 2; i++)
            {
                int tmp = _array[i];
                _array[i] = _array[_realLength - i - 1];
                _array[_realLength - i - 1] = tmp;
            }
        }

        public int Max() // - поиск значения максимального элемента
        {
            int max = _array[0];
            for (int i = 0; i < _realLength; i++)
            {
                if (_array[i] > max)
                {
                    max = _array[i];
                }
            }
            return max;
        }

        public int Min() // - поиск значения минимального элемента
        {
            int min = _array[0];
            for (int i = 0; i < _realLength; i++)
            {
                if (_array[i] < min)
                {
                    min = _array[i];
                }
            }
            return min;
        }

        public int IndexOfMax()  //- поиск индекса максимального элемента
        {
            for (int i = 0; i < _realLength; i++)
            {
                if (_array[i] == Max())
                {
                    return i;
                }
            }
            return -1;
        }

        public int IndexOfMin() //- поиск индекс минимального элемента
        {
            for (int i = 0; i < _realLength; i++)
            {
                if (_array[i] == Min())
                {
                    return i;
                }
            }
            return -1;
        }

        public void Sort() //- сортировка по возрастанию
        {
            int min;
            int tmp;
            for (int i = 0; i < _realLength - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < _realLength; j++)
                {
                    if (_array[j] < _array[min])
                    {
                        min = j;
                    }
                }
                tmp = _array[i];
                _array[i] = _array[min];
                _array[min] = tmp;
            }
        }

        public void SortDesc()  //- сортировка по убыванию
        {
            int tmp;
            int max;
            for (int i = 0; i < _realLength - 1; i++)
            {
                max = i;
                for (int j = i + 1; j < _realLength; j++)
                {
                    if (_array[j] > _array[max])
                    {
                        max = j;
                    }
                }
                tmp = _array[i];
                _array[i] = _array[max];
                _array[max] = tmp;
            }
        }

        public void PrintArray()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                Console.Write(_array[i] + " ");
            }
            Console.WriteLine();
        }

        private int[] CopyArrayUp()
        {
            int[] newArray = new int[size];

            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }

            return newArray;
        }

        private int[] CopyArrayDown()
        {
            int[] newArray = new int[size];
            for (int i = 0; i < _realLength; i++)
            {
                newArray[i] = _array[i];
            }

            return newArray;
        }

        private int EnlargeArraySize(int size)
        {
            return size * 3 / 2 + 1;
        }

        private int LessArraySize(int size)
        {
            return size / 4 * 3 + 1;
        }
    }
}

