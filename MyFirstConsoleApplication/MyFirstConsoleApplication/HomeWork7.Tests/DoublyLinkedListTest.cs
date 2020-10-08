using NUnit.Framework;
using System;

namespace HomeWork7.Tests
{
    public class DoublyLinkedListTestTest
    {
        DoublyLinkedList list;

        [SetUp]
        public void Setup()
        {
            list = new DoublyLinkedList();
        }

        [TestCase(10, new int[] { 10, 0, 1, 2, 3 })]
        [TestCase(0, new int[] { 0, 0, 1, 2, 3 })]
        [TestCase(-1, new int[] { -1, 0, 1, 2, 3 })]
        [TestCase(56, new int[] { 56, 0, 1, 2, 3 })]
        public void AddFirstTest(int val, int[] expected)
        {
            list = new DoublyLinkedList(new int[] { 0, 1, 2, 3 });
            list.AddFirst(val);
            int[] actual = list.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, new int[] { 0 })]
        [TestCase(10, new int[] { 10 })]
        public void AddFirstEmptyTest(int val, int[] expected)
        {
            list.AddFirst(val);
            int[] actual = list.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new[] { 0, 1, 2, 3, 1 })]
        [TestCase(0, new[] { 0, 1, 2, 3, 0 })]
        [TestCase(-1, new[] { 0, 1, 2, 3, -1 })]
        [TestCase(56, new[] { 0, 1, 2, 3, 56 })]
        public void AddLastTest(int val, int[] expected)
        {
            list = new DoublyLinkedList(new int[] { 0, 1, 2, 3 });
            list.AddLast(val);
            int[] actual = list.ToArray();
             Assert.AreEqual(expected, actual);
        }

        [TestCase(56, new[] { 56 })]
        [TestCase(56, new[] { 56 })]
        public void AddLastEmptyTest(int val, int[] expected)
        {
            list.AddFirst(val);
            int[] actual = list.ToArray();
            Assert.AreEqual(expected, actual);
        }


        [TestCase(0, 8, new[] { 8, 0, 1, 2, 3 })]
        [TestCase(1, 8, new[] { 0, 8, 1, 2, 3 })]
        [TestCase(2, 8, new[] { 0, 1, 8, 2, 3 })]
        [TestCase(3, 8, new[] { 0, 1, 2, 8, 3 })]
        [TestCase(4, 8, new int[] { })]
        [TestCase(5, 8, new int[] { })]
        [TestCase(-1, 8, new int[] { })]
        public void AddAtTest(int idx, int val, int[] expected)
        {
            int[] array = new int[] { 0, 1, 2, 3 };
            list = new DoublyLinkedList(array);
            if (idx < 0 || idx > array.Length - 1)
            {
                Assert.Throws<Exception>(() => list.AddAt(idx, val));
            }
            else
            {
                list.AddAt(idx, val);
                int[] actual = list.ToArray();
                Assert.AreEqual(expected, actual);
            }
        }

        [TestCase(new[] { 17, 24, 1 }, new int[] { 17, 24, 1 })]
        [TestCase(new[] { 0 }, new int[] { 0 })]
        public void AddFirstArrTest(int[] arr, int[] expected)
        {
            list.AddFirst(arr);
            int[] actual = list.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 17, 24, 1 }, new int[] { 17, 24, 1 })]
        [TestCase(new[] { 0 }, new int[] { 0 })]
        public void AddLastArrTest(int[] arr, int[] expected)
        {
            list.AddLast(arr);
            int[] actual = list.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, new[] { 8, 9, 10 }, new int[] { 8, 9, 10, 0, 1, 2, 3 })]
        [TestCase(1, new[] { 8, 9, 10 }, new int[] { 0, 8, 9, 10, 1, 2, 3 })]
        [TestCase(2, new[] { 8, 9, 10 }, new int[] { 0, 1, 8, 9, 10, 2, 3 })]
        [TestCase(3, new[] { 8, 9, 10 }, new int[] { 0, 1, 2, 8, 9, 10, 3 })]
        [TestCase(4, new[] { 8, 9, 10 }, new int[] { })]
        [TestCase(-1, new[] { 8, 9, 10 }, new int[] { })]
        public void AddAtArrTest(int idx, int[] arr, int[] expected)
        {
            int[] array = new int[] { 0, 1, 2, 3 };
            list = new DoublyLinkedList(array);
            if (idx < 0 || idx > array.Length - 1)
            {
                Assert.Throws<IndexOutOfRangeException>(() => list.AddAt(idx, arr));
            }
            else
            {
                list = new DoublyLinkedList(new int[] { 0, 1, 2, 3 });
                list.AddAt(idx, arr);
                int[] actual = list.ToArray();
                Assert.AreEqual(expected, actual);
            }
        }

        [TestCase(4, 4)]
        [TestCase(0, 0)]
        public void GetSizeTest(int realLength, int expected)
        {
            list.GetSize();
            int actual = realLength;
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 555, new int[] { 555, 1, 2, 3 })]
        [TestCase(3, 555, new int[] { 0, 1, 2, 555 })]
        public void SetTest(int idx, int val, int[] expected)
        {
            list = new DoublyLinkedList(new int[] { 0, 1, 2, 3 });
            if (idx < 0 || idx > 3)
            {
                Assert.Throws<IndexOutOfRangeException>(() => list.Set(idx, val));
            }
            else
            {
                list.Set(idx, val);
                int[] actual = list.ToArray();
                Assert.AreEqual(expected, actual);
            }
        }

        [TestCase(new int [] { 1, 2, 3 })]
        public void RemoveFirstTest(int[] expected)
        {
            list = new DoublyLinkedList(new int[] { 0, 1, 2, 3 });
            list.RemoveFirst();
            int[] actual = list.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase("The list is empty.")]
        public void RemoveFirstEmptyTest(string expected)
        {
            try
            {
                list.RemoveFirst();
                Assert.Fail("Should have exception here.");
            }
            catch (Exception e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }

        [TestCase(new int [] { })]
        public void RemoveLastTestLength1(int[] expected)
        {
            list = new DoublyLinkedList(new int[] { 1 });
            list.RemoveLast();
            int[] actual = list.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 })]
        public void RemoveLastTest(int[] expected)
        {
            list = new DoublyLinkedList(new int[] { 1, 2, 3, 4 });
            list.RemoveLast();
            int[] actual = list.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase("The list is empty.")]
        public void RemoveLastEmptyTest(string expected)
        {
            try
            {
                list.RemoveLast();
                Assert.Fail("Should have exception here.");
            }
            catch (Exception e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }

        [TestCase(0, new[] { 1, 2, 3 })]
        [TestCase(1, new[] { 0, 2, 3 })]
        [TestCase(2, new[] { 0, 1, 3 })]
        [TestCase(3, new int[] { 0, 1, 2 })]
        [TestCase(-1, new int [] { })]
        [TestCase(-4, new int [] { })]
        public void RemoveAtTest(int idx, int[] expected)
        {
            list = new DoublyLinkedList(new int[] { 0, 1, 2, 3 });
            if (idx < 0 || idx > 3)
            {
                Assert.Throws<IndexOutOfRangeException>(() => list.RemoveAt(idx));
            }
            else
            {
                list.RemoveAt(idx);
                int[] actual = list.ToArray();
                Assert.AreEqual(expected, actual);
            }
        }

        [TestCase(2, new[] { 0, 1, 3, 5, 7 })]
        public void RemoveAllTest(int val, int[] expected)
        {
            list = new DoublyLinkedList(new int[] { 0, 1, 2, 3, 2, 5, 2, 7 });
            list.RemoveAll(val);
            int[] actual = list.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, "The list is empty.")]
        public void RemoveAllEmptyTest(int val, string expected)
        {
            try
            {
                list.RemoveAll(val);
                Assert.Fail("Should have exception here.");
            }
            catch (Exception e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }

        [TestCase(3, true)]
        [TestCase(5, false)]
        public void ContainsTest(int val, bool expected)
        {
            list = new DoublyLinkedList(new int[] { 0, 1, 2, 3 });
            bool actual = list.Contains(val);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 4)]
        [TestCase(2, 1)]
        [TestCase(0, 0)]
        [TestCase(9, -1)]
        public void IndexOfTest(int val, int expected)
        {
            list = new DoublyLinkedList(new int[] { 0, 2, 3, 2, 1, 5 });
            int actual = list.IndexOf(val);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8 })]
        public void ToArrayTest(int[] expected)
        {
            list = new DoublyLinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });
            int[] actual = list.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(8)]
        public void GetFirstTest(int expected)
        {
            list = new DoublyLinkedList(new int[] { 8, 2, 3, 4 });
            int actual = list.GetFirst();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(4)]
        public void GetLastTest(int expected)
        // - вернёт значение первого элемента списка
        {
            list = new DoublyLinkedList(new int[] { 8, 2, 3, 4 });
            int actual = list.GetLast();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 3)]
        [TestCase(0, 8)]
        [TestCase(7, 1)]
        public void GetTest(int idx, int expected)
        {
            list = new DoublyLinkedList(new int[] { 8, 7, 6, 5, 4, 3, 2, 1 });
            int actual = list.Get(idx);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 8, 7, 6, 5, 4, 3, 2, 1 })]
        public void ReverseTest(int[] expected)
        {
            list = new DoublyLinkedList(new[] { 1, 2, 3, 4, 5, 6, 7, 8 });
            list.Reverse();
            int[] actual = list.ToArray();
            Assert.AreEqual(expected, actual);
        }


        [TestCase(8)]
        public void MaxTest(int expected)
        {
            list = new DoublyLinkedList(new[] { 1, 2, 3, 8, 5, 6, 7 });
            int actual = list.Max();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-3)]
        public void MinTest(int expected)
        {
            list = new DoublyLinkedList(new[] { 1, 2, 3, -3, 5, 6, 7 });
            int actual = list.Min();
            Assert.AreEqual(expected, actual);
        }


        [TestCase(3)]
        public void IndexOfMaxTest(int expected)
        {
            list = new DoublyLinkedList(new[] { 1, 2, 3, 8, 5, 6, 7 });
            int actual = list.IndexOfMax();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(4)]
        public void IndexOfMinTest(int expected)
        {
            list = new DoublyLinkedList(new[] { 1, 2, 3, 4, 0, 6, 7 });
            int actual = list.IndexOfMin();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { -1, -7, -1, 1, 12, 4, 4, 0 }, new[] { -7, -1, -1, 0, 1, 4, 4, 12 })]
        [TestCase(new[] { 1, 5, 3, 9, 43, 2, 7, -8 }, new[] { -8, 1, 2, 3, 5, 7, 9, 43 })]
        [TestCase(new[] { 0 }, new[] { 0 })]
        public void SortTest(int[] sourceArray, int[] expected)
        //- сортировка по возрастанию
        {
            list = new DoublyLinkedList(sourceArray);
            list.Sort();
            int[] actual = list.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { -1, -7, -1, 1, 12, 4, 4, 0 }, new[] { -7, -1, -1, 0, 1, 4, 4, 12 })]
        [TestCase(new[] { 1, 5, 3, 9, 43, 2, 7, -8 }, new[] { -8, 1, 2, 3, 5, 7, 9, 43 })]
        [TestCase(new[] { 0 }, new[] { 0 })]
        public void SortDeskTest(int[] sourceArray, int[] expected)
        //- сортировка по убыванию
        {
            list = new DoublyLinkedList(sourceArray);
            list.Sort();
            int[] actual = list.ToArray();
            Assert.AreEqual(expected, actual);
        }
    }

}
