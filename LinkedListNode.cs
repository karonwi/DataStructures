using System;
//using System.Collections.Generic;
using System.Text;

namespace WeekTwoTask
{

    // A LinkedListNode 
    public class LinkedListNode<T>
    {
        public T data;
        public LinkedListNode<T> next;

        public LinkedListNode(T data)
        {
            this.data = data;
            next = null;
        }
    }


}
