using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructs
{
    public class Nodo <T>
    {
        public T value { get; set; }

        public Nodo(T value)
        {

            this.value = value;

        }


    }
}
