using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLL_LAB01
{
    public class LinkedList
    {
        public int Count { get; private set; }
        public Node Head { get; private set; }
        public Node Tail { get; private set; }

        public void AddFirst(string value)
        {
            var node = new Node(value);
            if (Head == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.Next = Head;
                Head = node;
            }
            Count++;
        }

        public void AddLast(string value)
        {
            var node = new Node(value);
            if (Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.Next = node;
                Tail = node;
            }
            Count++;
        }

        public void RemoveFirst()
        {
            if (Head == null) return;

            Head = Head.Next;
            Count--;
        }

        public void RemoveLast()
        {
            if (Tail == null) return;

            if (Head == Tail)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                var current = Head;
                while (current.Next != Tail)
                    current = current.Next;

                current.Next = null;
                Tail = current;
            }
            Count--;
        }

        public string GetValue(int index)
        {
            if (index < 0 || index >= Count) return null;

            var current = Head;
            for (int i = 0; i < index; i++)
                current = current.Next;

            return current.Value;
        }

        public class Node
        {
            public string Value { get; set; }
            public Node Next { get; set; }

            public Node(string value)
            {
                Value = value;
                Next = null;
            }
        }
    }
}




       

