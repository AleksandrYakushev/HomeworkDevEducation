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
            Length = 0;
        }

        public DoublyLinkedList(int[] array)
        {
            if (array.Length == 0)
            {

                return;
            }

            Head = new Node(array[0]);
            Tail = Head;

            for (int i = 1; i < array.Length; i++)
            {
                Tail.Next = new Node(array[i]);
                Tail.Next.Prev = Tail;
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
            Node tmp = null;

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
                        tmp.Next = insertNode;
                    }

                    insertNode.Next = current;
                    Length++;
                    return;
                }

                tmp = current;
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
            if (Length == 0)
            {
                throw new Exception("The list is empty.");
            }

            if (Length == 1)
            {
                Head = null;
                Tail = null;
            }

            Head = Head.Next;
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

            Tail = Tail.Prev;
            Tail.Next = null;
            Length--;
        }

        public void RemoveAt(int index)
        {
            if ((index < 0) || (index > Length - 1) || (Head == null))
            {
                throw new IndexOutOfRangeException("Index out of List!");
            }

            else if (index == 0)
            {
                Head = Head.Next;
                Length--;
                return;
            }

            else if (index == Length - 1)
            {
                RemoveLast();
            }
            else
            {
                Node node = Head;

                for (int i = 1; i < index; i++)
                {
                    node = node.Next;
                }
                node.Next.Next.Prev = node;
                node.Next = node.Next.Next;
                Length--;
            }
        }

        public void RemoveAll(int val)
        {
            if (Head == null)
            {
                throw new Exception("The list is empty.");
            }

            Node current = Head;
            current.Prev = null;

            while (current != null)
            {
                if (current.Value == val)
                {
                    if (current != null)
                    {
                        current.Prev.Next = current.Next;
                        Length--;
                        if (current.Next == null)
                        {
                            Tail = current.Prev;
                        }
                    }
                    else
                    {
                        Head = current.Next;
                        Length--;
                    }
                }
                current.Prev = current;
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
                ListArray[i] = node.Value;
                node = node.Next;
                i++;
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

        public int Get(int index)
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
            Node tmp;
            Node preHead = Head;
            while (preHead.Next != null)
            {
                tmp = preHead.Next;
                preHead.Next = preHead.Next.Next;
                tmp.Next = Head;
                Head = tmp;
            }
            Tail = preHead;
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

        public void Sort()
        {
            if (Head == null)
            {
                return;
            }

            Node current = Head;
            Node currentNext;
            int tmp;

            while (current != null)
            {
                currentNext = current.Next;

                while (currentNext != null)
                {
                    if (current.Value > currentNext.Value)
                    {
                        tmp = currentNext.Value;
                        currentNext.Value = current.Value;
                        current.Value = tmp;
                    }

                    currentNext = currentNext.Next;
                }

                current = current.Next;
            }
        }

        public void SortDesc()  //- сортировка по убыванию
        {
            if (Head == null)
            {
                return;
            }

            Node current = Head;
            Node currentNext;
            int tmp;

            while (current != null)
            {
                currentNext = current.Next;
                while (currentNext != null)
                {
                    if (current.Value < currentNext.Value)
                    {
                        tmp = current.Value;
                        current.Value = currentNext.Value;
                        currentNext.Value = tmp;
                    }

                    currentNext = currentNext.Next;
                }
                current = current.Next;
            }
        }

        //public void Sort()
        //{
        //    Node a = Head;
        //    while (a != null)
        //    {
        //        if (a.Next == null)
        //        {
        //            return;
        //        }

        //        Node b = a.Next;

        //        if (a.Value > b.Value)
        //        {
        //            Node aPrev = a.Prev;
        //            Node bNext = b.Next;

        //            if (aPrev != null)
        //            {
        //                aPrev.Next = b;
        //            }

        //            b.Prev = aPrev;

        //            if (bNext != null)
        //            {
        //                bNext.Prev = a;
        //            }

        //            a.Next = bNext;
        //            b.Next = a;
        //            a.Prev = b;
        //        }
        //        else
        //        {
        //            a = a.Next;
        //        }
        //    }

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
