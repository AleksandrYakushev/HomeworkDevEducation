using System;

namespace HomeWork7
{
    public class Node
    {
        public int Value { get; set; }
        public Node Prev { get; set; }
        public Node Next { get; set; }

        public Node(int val)
        {
            Value = val;
        }
    }
}