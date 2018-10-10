using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructs
{
    public class DubleNode<T> : ListNode<T>
    {
        public Nodo<T> PeviousNode { get; set; }

        public DubleNode(T value, int position) 
                                                : base(value, position)
        {
           

        }

    }
}
