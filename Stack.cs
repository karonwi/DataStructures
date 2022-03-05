using System;
using System.Collections.Generic;
using System.Text;

namespace WeekTwoTask
{

    public class Stack<T>
    {
        int count;
        public LinkedList<T> stack;

        public Stack()
        {
            stack = new LinkedList<T>();
            count = 0;
        }

        //Returns the last item added to the stack
        public T Peek()
        {
            if(stack.head == null)
            {
                throw new Exception("Stack is Empty");
            }
            return stack.head.data;
        }

        //Removes and returns the last item added to the stack
        public T Pop()
        {
          

            var firstNode = stack.head;
            LinkedListNode<T> prevNode = null;
            while(firstNode != null)
            {
                prevNode = firstNode;
            firstNode = firstNode.next;

            }
                firstNode.next = null;
            prevNode.next = firstNode;
            return firstNode.data;

            
        }

        //Adds an item to the top of the stack
        public void Push(T item)
        {
            stack.AddLast(item);
            count++;
        }
        public bool IsEmpty()
        {
            if (stack.head== null) return true;
            else return false;
        }

        //Shows the number of elements currently in the stack
        public int Size()
        {

            return count; 
        }

        //Prints the items in the stack
        public void PrintStack()
        {
            stack.PrintList();
        }
    }
}
