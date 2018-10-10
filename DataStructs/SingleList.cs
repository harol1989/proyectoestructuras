using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructs
{
    public class SingleList<T>
    {
        public ListNode<T> Head { get; set; }


        public ListNode<T> Current { get; set; }


        private int _Count;
        

        public int Count
        {
            get
            {
                return this._Count;

            }


        }

        // la lista esta vacia

        public void AddNode(T value)
        {

            if (this.Count == 0)
            {
                ListNode<T> newnode = new ListNode<T>(value, 0);
                this.Head = newnode;
                this.Current = newnode;
                this._Count++;

            }
            else
            {
                int newPosition = this.Current.position + 1;
                ListNode<T> newnode = new ListNode<T>(value, newPosition);
                newnode.Next = this.Current.Next;
                this.Current.Next = newnode;
                this.Current = newnode;
                this._Count++;

                // falta incrementar la posicion del siguiente

            }



        }
        public void ImprimirLista()
        {
            if (this.Count >= 0)
            {
                this.Current = this.Head;
                while (this.Current != null)
                {
                    Console.Write(this.Current.value + " ");
                    this.Current = this.Current.Next;
                }



            }
        }

       

        public void AddNodefinal(T value)
        {

            if (this.Current == null)
            {
                ListNode<T> newnode = new ListNode<T>(value, 0);
                this.Head = newnode;
                this.Current = newnode;
                this._Count++;

            }
            else
            {
                int newPosition = this.Current.position + 1;
                ListNode<T> newnode = new ListNode<T>(value, newPosition);
                newnode.Next = this.Current.Next;
                this.Current.Next = newnode;
                this.Current = newnode;
                this._Count++;
                

                // falta incrementar la posicion del siguiente

            }



        }



        public void AddNodeinicial(T value)
        {

            if (this.Current == null)
            {
                
                ListNode<T> newnode = new ListNode<T>(value, 0);
                this.Head = newnode;
                this.Current = newnode;
                this._Count++;

            }
            else
            {
                this.Current = Head;
                int newPosition = this.Current.position +1;
                ListNode<T> newnode = new ListNode<T>(value, newPosition);
                newnode.Next = this.Head.Next;
                this.Head = newnode;
                this.Head = newnode;
                this._Count++;


                // falta incrementar la posicion del siguiente

            }



        }

    }
}
