using System;

namespace DoublyLinkedList
{
    class Node
    {
        public string Data
        {
            get;
            set;
        }
        public Node Next
        {
            get;
            set;
        }
        public Node Prev // previous: oncesi
        {
            get;
            set;
        }
        public Node(string data)
        {
            Data = data;
            Next = null;
            Prev = null;
        }
    }
}