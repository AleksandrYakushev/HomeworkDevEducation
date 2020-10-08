using NUnit.Framework;

namespace HomeWork5.Tests
{
    public class ArrayListTest
    {
        [TestCase(new[] { 1, 4, 6, 4 }, 13, new[] { 13, 1, 4, 6, 4 })]
        [TestCase(new[] { 0, 4, 6, 4 }, 0, new[] { 0, 0, 4, 6, 4 })]
        public void AddFirstTest(int[] sourceArray, int val, int[] expected)
        {
            ArrayList array = new ArrayList(sourceArray);
            array.AddFirst(val);
            int[] actual = array.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 1, 4, 6, 4 }, 13, new[] { 1, 4, 6, 4, 13 })]
        [TestCase(new[] { 7, 4, 6, 0 }, 0, new[] { 7, 4, 6, 0, 0 })]
        public void AddLastTest(int[] sourceArray, int val, int[] expected)
        {
            ArrayList array = new ArrayList(sourceArray);
            array.AddLast(val);
            int[] actual = array.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 1, 2, 3, 4 }, 1, 7, new int[] { 1, 7, 2, 3, 4 })]
        public void AddAtTest(int[] sourceArray, int idx, int val, int[] expected)
        {
            ArrayList array = new ArrayList(sourceArray);
            array.AddAt(idx, val);
            int[] actual = array.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 1, 2, 3, 4 }, new[] { 17, 24, 1 }, new int[] { 17, 24, 1, 1, 2, 3, 4 })]
        [TestCase(new[] { 1, 2, 3, 4 }, new[] { 0 }, new int[] { 0, 1, 2, 3, 4 })]
        public void AddFirstArrTest(int[] sourceArray, int[] arr, int[] expected)
        {
            ArrayList array = new ArrayList(sourceArray);
            array.AddFirst(arr);
            int[] actual = array.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 1, 2, 3, 4 }, new[] { 17, 24, 1 }, new int[] { 1, 2, 3, 4, 17, 24, 1 })]
        [TestCase(new[] { 1, 2, 3, 4 }, new[] { 0 }, new int[] { 1, 2, 3, 4, 0 })]
        public void AddLastArrTest(int[] sourceArray, int[] arr, int[] expected)
        {
            ArrayList array = new ArrayList(sourceArray);
            array.AddLast(arr);
            int[] actual = array.ToArray();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new[] { 1, 2, 3, 4 }, 2, new[] { 17, 24, 1 }, new int[] { 1, 2, 17, 24, 1, 3, 4 })]
        [TestCase(new[] { 1, 2, 3, 4 }, 3, new[] { 0 }, new int[] { 1, 2, 3, 0, 4 })]
        public void AddAtArrTest(int[] sourceArray, int idx, int[] arr, int[] expected)
        {
            ArrayList array = new ArrayList(sourceArray);
            array.AddAt(idx, arr);
            int[] actual = array.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(17, 17)]
        [TestCase(0, 0)]
        public void GetSizeTest(int realLength, int expected)
        {
            ArrayList array = new ArrayList();
            array.GetSize();
            int actual = realLength;
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 17, 17, 16, 17 }, 2, 17, new[] { 17, 17, 17, 17 })]
        [TestCase(new[] { 17, 17, 17, 17 }, 1, 0, new[] { 17, 0, 17, 17 })]
        public void SetTest(int[] sourceArray, int idx, int val, int[] expected)
        {
            ArrayList array = new ArrayList(sourceArray);
            array.Set(idx, val);
            int[] actual = array.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 3, 5, 16, 19 }, new[] { 5, 16, 19 })]
        [TestCase(new[] { 42, 34, 81, 56 }, new[] { 34, 81, 56 })]
        public void RemoveFirstTest(int[] sourceArray, int[] expected)
        {
            ArrayList array = new ArrayList(sourceArray);
            array.RemoveAt(0);
            int[] actual = array.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 3, 5, 16, 19 }, new[] { 3, 5, 16 })]
        [TestCase(new[] { 42, 34, 81, 56 }, new[] { 42, 34, 81 })]
        public void RemoveLastTest(int[] sourceArray, int[] expected)
        {
            ArrayList array = new ArrayList(sourceArray);
            array.RemoveAt(sourceArray.Length-1);
            int[] actual = array.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 3, 5, 16, 19 }, 2, new[] { 3, 5, 19 })]
        [TestCase(new[] { 42, 34, 81, 56 }, 1, new[] { 42, 81, 56 })]
        public void RemoveAtTest(int[] sourceArray, int idx, int[] expected)
        {
            ArrayList array = new ArrayList(sourceArray);
            array.RemoveAt(idx);
            int[] actual = array.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 3, 5, 16, 19 }, 16, true)]
        [TestCase(new[] { 42, 34, 81, 56 }, 95, false)]
        public void ContainsTest(int[] sourceArray, int val, bool expected)
        {
            ArrayList array = new ArrayList(sourceArray);
            bool actual = array.Contains(val);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 31, 5, 16, 4, 3, 17, 4, 3 }, 3, 4)]
        [TestCase(new[] { 31, 5, 16, 4, 3, 17, 4, 3 }, 16, 2)]
        [TestCase(new[] { 31, 5, 16, 4, 3, 17, 4, 3 }, 45, -1)]
        public void IndexOfTest(int[] sourceArray, int val, int expected)
        // - вернёт индекс первого найденного элемента,
        //равного val(или -1, если элементов с таким значением в списке нет)
        {
            ArrayList array = new ArrayList(sourceArray);
            int actual = array.IndexOf(val);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8 })]
        [TestCase(new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 }, new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 })]
        //[TestCase(new[] { }, new[] { })]
        public void ToArrayTest(int[] sourceArray, int[] expected) 
        // - вернёт хранимые данные в виде массива
        {
            ArrayList array = new ArrayList(sourceArray);
            int[] actual = array.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 1)]
        [TestCase(new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 }, 9)]
        public void GetFirstTest(int[] sourceArray, int expected)
        // - вернёт значение первого элемента списка
        {
            ArrayList array = new ArrayList(sourceArray);
            int actual = array.GetFirst();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 8)]
        [TestCase(new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 }, 1)]
        public void GetLastTest(int[] sourceArray, int expected)
        // - вернёт значение первого элемента списка
        {
            ArrayList array = new ArrayList(sourceArray);
            int actual = array.GetLast();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 7, 8)]
        [TestCase(new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 }, 3, 6)]
        public void GetTest(int[] sourceArray, int idx, int expected)
        // - вернёт значение первого элемента списка
        {
            ArrayList array = new ArrayList(sourceArray);
            int actual = array.Get(idx);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8 }, new[] { 8, 7, 6, 5, 4, 3, 2, 1 })]
        [TestCase(new[] { 0 }, new[] { 0 })]
        public void ReverseTest(int[] sourceArray, int[] expected)  
        // - изменение порядка элементов списка на обратный
        {
            ArrayList array = new ArrayList(sourceArray);
            array.Reverse();
            int[] actual = array.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 31, 5, 16, 4, 3, 17, 4, 3 }, 31)]
        [TestCase(new[] { 0, 0, -1, -1 }, 0)]
        public void MaxTest(int[] sourceArray, int expected) 
        // - поиск значения максимального элемента
        {
            ArrayList array = new ArrayList(sourceArray);
            int actual = array.Max();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 31, 5, 16, 4, 3, 17, 4, 3 }, 3)]
        [TestCase(new[] { 0, 0, -1, -1 }, -1)]
        public void MinTest(int[] sourceArray, int expected)
        // - поиск значения миниимального элемента
        {
            ArrayList array = new ArrayList(sourceArray);
            int actual = array.Min();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 7)]
        [TestCase(new[] { 0, 0, -1, -1 }, 0)]
        [TestCase(new[] { 0 }, 0)]
        public void IndexOfMaxTest(int[] sourceArray, int expected)
        // - поиск индекса максимального элемента
        {
            ArrayList array = new ArrayList(sourceArray);
            int actual = array.IndexOfMax();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 0)]
        [TestCase(new[] { 0, 0, -1, -1 }, 2)]
        [TestCase(new[] { 0 }, 0)]
        public void IndexOfMinTest(int[] sourceArray, int expected)
        // - поиск индекса минимального элемента
        {
            ArrayList array = new ArrayList(sourceArray);
            int actual = array.IndexOfMin();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { -1, -7, -1, 1, 12, 4, 4, 0 }, new[] { -7, -1, -1, 0, 1, 4, 4, 12 })]
        [TestCase(new[] { 0 }, new[] { 0 })]
        [TestCase(new[] { 1, 5, 3, 9, 43, 2, 7, -8 }, new[] { -8, 1, 2, 3, 5, 7, 9, 43 })]
        public void SortTest(int[] sourceArray, int[] expected)
        //- сортировка по возрастанию
        {
            ArrayList array = new ArrayList(sourceArray);
            array.Sort();
            int[] actual = array.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { -1, -7, -1, 1, 12, 4, 4, 0 }, new[] { 12, 4, 4, 1, 0, -1, -1, -7 })]
        [TestCase(new[] { 0 }, new[] { 0 })]
        [TestCase(new[] { 1, 5, 3, 9, 43, 2, 7, -8 }, new[] { 43, 9, 7 , 5, 3, 2, 1, -8 })]
        public void SortDeskTest(int[] sourceArray, int[] expected)
        //- сортировка по убыванию
        {
            ArrayList array = new ArrayList(sourceArray);
            array.SortDesc();
            int[] actual = array.ToArray();
            Assert.AreEqual(expected, actual);
        }
    }
}