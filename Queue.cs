using System;
using System.Collections.Generic;
using System.Text;

namespace WeekTwoTask
{
    public class Queue<T>
    {
        public int count;
        public LinkedList<T> queue;

        public Queue()
        {
            queue = new LinkedList<T>();
            count = 0;
        }
        //Adds an item to the back of the queue
        public void Enqueue(T item)
        {
            queue.AddLast(item);
            count++;
        }
        // Removes and returns the item at the tail of the queue
        public T Dequeue()
        {
            if(queue.head == null)
            {
                throw new Exception("Queue is empty");
            }
            T item = queue.head.data;
            queue.RemoveFirstOccurence(item);
            count--;
            return item;
        }

        //Shows the number of items currently in the queue
        public int Size()
        {
            return count;
        }

        //Returns true if the queue is empty and false if it isn't
        public bool IsEmpty()
        {
            if (queue.head == null) return true;
            else return false;
        }
       
        //Prints the items in the queue
        public void PrintQueue()
        {
            queue.PrintList();
        }
    }
}
