using System;

namespace HomeWork7
{
    public class DoublyLinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        private int Length { get; set; }

        public DoublyLinkedList()
        {
        }

        public DoublyLinkedList(int[] array)
        {
            if (array.Length == Length)
            {
                Head = null;
                Tail = null;
                return;
            }

            Head = new Node(array[0]);
            Tail = Head;

            for (int i = 1; i < array.Length; i++)
            {
                Tail.Next = new Node(array[i]);
                Tail = Tail.Next;
            }
            Length = array.Length;
        }

        public void AddFirst(int val)
        {
            Length++;
            Node node = new Node(val);

            if (Head == null)
            {
                Head = node;
                Tail = node;
                return;
            }

            node.Next = Head;
            Head.Prev = node;
            Head = node;   
        }

        public void AddFirst(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                AddFirst(arr[arr.Length - 1 - i]);
            }
        }

        public void AddLast(int val)
        {
            Length++;
            Node node = new Node(val);

            if (Tail == null)
            {
                Head = node;
                Tail = node;
                return;
            }

            Tail.Next = node;
            node.Prev = Tail;
            Tail = node;
        }

        public void AddLast(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                AddLast(arr[i]);
            }
        }

        public void AddAt(int index, int val)
        {
            if (index > Length - 1 || index < 0)
            {
                throw new Exception("Index out of List!");
            }

            int count = 0;
            Node current = Head;
            Node previous = null;

            while (current != null)
            {
                if (index == count)
                {
                    Node insertNode = new Node(val);
                    if (current == Head)
                    {
                        Head = insertNode;
                    }
                    else
                    {
                        previous.Next = insertNode;
                    }

                    insertNode.Next = current;
                    Length++;
                    break;
                }

                previous = current;
                current = current.Next;
                count++;
            }
        }

        public void AddAt(int index, int[] arr)
        {
            if ((index > Length - 1 || index < 0) && index != 0)
            {
                throw new IndexOutOfRangeException("Index out of List!");
            }

            int counter = 0;
            Node currentNode = Head;
            while (counter == index && index != 0)
            {
                currentNode = currentNode.Next;
                counter++;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                AddAt(index, arr[i]);
                index++;
            }

        }


        public int GetSize()
        {
            return Length;
        }

        public void Set(int index, int val)
        {
            if (index < 0 || index > Length - 1)
            {
                throw new IndexOutOfRangeException("Index out of List!");
            }

            int counter = 0;
            Node addIndexNode = Head;

            while (addIndexNode != null)
            {
                if (index == counter)
                {
                    addIndexNode.Value = val;
                    return;
                }
                addIndexNode = addIndexNode.Next;
                counter++;
            }
        }

        public void RemoveFirst() //RemoveFirst() - удаление первого элемента
        {
            if (Head == null)
            {
                throw new Exception("The list is empty.");
            }

            if (Length == 1)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Head = Head.Next;
            }
            Length--;
        }

        public void RemoveLast() //RemoveLast() - удаление последнего элемента
        {
            if (Head == null)
            {
                throw new Exception("The list is empty.");
            }

            if (Length == 1)
            {
                Head = null;
                Tail = null;
                Length--;
                return;
            }
            Node node = Head;
            Node previous = null;
            while (node.Next != null)
            {
                previous = node;
                node = node.Next;
            }
            previous.Next = null;
            Length--;
        }

        public void RemoveAt(int index)
        {
            if ((index < 0) || (index > Length - 1) || (Head == null))
            {
                throw new IndexOutOfRangeException("Index out of List!");
            }

            if (index == 0)
            {
                Head = Head.Next;
                Length--;
                return;
            }

            int counter = 0;
            Node currentNode = Head;
            Node previousNode = null;
            while (currentNode != null)
            {
                if (index == counter)
                {
                    previousNode.Next = currentNode.Next;
                    Length--;
                }
                previousNode = currentNode;
                currentNode = currentNode.Next;
                counter++;
            }
        }

        public void RemoveAll(int val)
        {
            if (Head == null)
            {
                throw new Exception("The list is empty.");
            }

            Node current = Head;
            Node previous = null;

            while (current != null)
            {
                if (current.Value == val)
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        Length--;
                        if (current.Next == null)
                        {
                            Tail = previous;
                        }
                    }
                    else
                    {
                        Head = current.Next;
                        Length--;
                    }
                }
                previous = current;
                current = current.Next;
            }
            Tail = current;
        }

        public bool Contains(int val)
        {
            Node foundNode = Head;
            while (foundNode != null)
            {
                if (foundNode.Value == val)
                {
                    return true;
                }
                foundNode = foundNode.Next;
            }
            return false;
        }

        public int IndexOf(int val) // - вернёт индекс первого найденного элемента, равного val(или -1, если элементов с таким значением в списке нет)
        {
            int counter = 0;
            Node foundIndexNode = Head;

            while (foundIndexNode != null)
            {
                if (foundIndexNode.Value == val)
                {
                    return counter;
                }
                foundIndexNode = foundIndexNode.Next;
                counter++;
            }
            return -1;
        }

        public int[] ToArray()
        {
            int[] ListArray = new int[Length];
            Node node = Head;
            int i = 0;
            while (node != null)
            {
                ListArray[i++] = node.Value;
                node = node.Next;
            }

            return ListArray;
        }

        public int GetFirst()
        {
            return Head.Value;
        }

        public int GetLast()
        {
            return Tail.Value;
        }

        public int Get(int index) // - вернёт значение элемента списка c указанным индексом
        {
            if (index < 0 || index > Length - 1)
            {
                throw new IndexOutOfRangeException("Index out of List!");
            }
            int counter = 0;
            Node node = Head;
            while (node != null)
            {
                if (index == counter)
                {
                    return node.Value;
                }
                node = node.Next;
                counter++;
            }
            return 0;
        }

        public void Reverse()
        {
            Node tmp1;
            Node tmp2 = null;
            Node current = Head;
            Tail = Head;

            while (current != null)
            {
                tmp1 = current.Next;
                current.Next = tmp2;
                tmp2 = current;
                current = tmp1;
            }
            Head = tmp2;
        }

        public int Max() // - поиск значения максимального элемента
        {
            if (Head == null)
            {
                throw new Exception("The list is empty.");
            }
            int max = Head.Value;
            Node current = Head;
            while (current != null)
            {
                if (current.Value > max)
                {
                    max = current.Value;
                }
                current = current.Next;
            }
            return max;
        }

        public int Min()
        {
            if (Head == null)
            {
                throw new Exception("The list is empty.");
            }

            int min = Head.Value;
            Node current = Head;

            while (current != null)
            {
                if (current.Value < min)
                {
                    min = current.Value;
                }
                current = current.Next;
            }
            return min;
        }

        public int IndexOfMax()
        {
            if (Head == null)
            {
                throw new Exception("The list is empty.");
            }

            Node current = Head;
            int max = Max();
            int counter = 0;

            while ((current != null) && (current.Value != max))
            {
                current = current.Next;
                counter++;
            }
            return counter;
        }

        public int IndexOfMin()
        {
            if (Head == null)
            {
                throw new Exception("The list is empty.");
            }
            Node current = Head;
            int min = Min();
            int counter = 0;

            while (current != null && current.Value != min)
            {
                current = current.Next;
                counter++;
            }
            return counter;
        }

        //public void Sort()
        //{
        //    Node current = Head;
        //    int counter = 0;
        //    int min;
        //    int tmp;
        //    while (current != null)
        //    {
        //        for (int i = 0; i < counter; i++)
        //        {
        //            min = i;
        //            for (int j = i + 1; j < counter - 1; j++)
        //            {
        //                if (current.Value < )
        //        }
        //            current = current.Next;
        //            counter++;
        //        }
        //    }

        //}

        //public void SortDesc()  //- сортировка по убыванию
        //{
        //    for (int i = 1; i < _realLength; i++)
        //    {
        //        for (int j = 1; j < _realLength; j++)
        //        {
        //            int tmp;
        //            if (_array[j] > _array[j - 1])
        //            {
        //                tmp = _array[j - 1];
        //                _array[j - 1] = _array[j];
        //                _array[j] = tmp;
        //            }
        //        }
        //    }
        //}

        public void PrintList()
        {
            Node node = Head;
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }


    }
}
