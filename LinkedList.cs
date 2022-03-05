using System;
using System.Collections.Generic;
using System.Text;

namespace WeekTwoTask
{
    public class LinkedList<T>
    {
       public LinkedListNode<T> head;
       public LinkedListNode<T> tail;
        int count;
        public LinkedList()
        {
            head = null;
            count = 0;
        }

        //ADDS Node to front 
        public void AddFirst(T item)
        {
            if(head == null)
            {
                LinkedListNode<T> data = new LinkedListNode<T>(item);
                head = tail = data;
                head.next = tail;
            }
            LinkedListNode<T> node = new LinkedListNode<T>(item)
            {
                next = head
            };
            head = node;
        }

        // ADDS Node to Tail and returns the size
        public int AddLast(T item)
        {
            LinkedListNode<T> data = new LinkedListNode<T>(item);
            if (head == null)
            {
                
                tail = head = data;
                //tail.next = data;
            }
            else
            {
                //LinkedListNode<T> node = new LinkedListNode<T>(item);
                head.next = data;
                tail = data;
                //tail=node;
            }
                count++;
            return count;
        }


        //Removes the first occurrence of an item in the linked list ,
        //returns TRUE if said item is found and removes it or returns FALSE otherwise.

        public bool RemoveFirstOccurence(T item)
        {
            if(head == null)
            {
                return false;
            }
            if (head.data.Equals(item))
            {
                head= head.next;
                return true;
            }
            LinkedListNode<T> current = head;
            while (current.next != null)
            {
                if (current.next.data.Equals(item))
                {
                    current.next = current.next.next;
                    return true;
                }
                current = current.next;
            }
            return false;

        }
        //Checks for a specified item in the linked list
        public bool Check(T item)
        {
            int position = 1;
            LinkedListNode<T> node = head;
            while (node != null)
            {
                if (node.data.Equals(item))
                    break;
                position++;
                node = node.next;
            }
            if(node == null)
            {
                    return false;
            }else   return true;
        }


        //Returns the index of an item or -1 of not found
        public int Index(T item)
        {
            int index = -1;
            LinkedListNode<T> current = head;
            while (current != null)
            {
                if (current.data.Equals(item))
                {
                    index++;
                    return index;
                }
                index++;
                current = current.next;
            }
           return index;
        }

        // To Print out the data
        public void PrintList()
        {
            LinkedListNode<T> print = head;
            while(print != null)
            {
                Console.WriteLine(print.data);
                print = print.next;
            }
        }      
    }

}
