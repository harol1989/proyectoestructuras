using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructs
{
    public class ListNode<T> : Nodo<T>
    {
        public int position { get; set; }

        public ListNode<T>  Next { get; set; }


        public ListNode(T value, int position): base(value)
        {
            this.position = position;

        }

    }
}
