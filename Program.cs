using System;

namespace WeekTwoTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            //linkedList.AddLast("karonwi");
            //linkedList.AddLast("chisom like last checks");
            linkedList.AddLast("ebelle lkes last checks");
            //linkedList.AddLast("karonwi");
            //linkedList.PrintList();

            //linkedList.RemoveFirstOccurence("karonwi");
            //linkedList.RemoveFirstOccurence("chisom like last checks");
            //linkedList.RemoveFirstOccurence("ebelle lkes last checks");
           // linkedList.RemoveFirstOccurence("karonwi");
            //linkedList.PrintList();

            //linkedList.RemoveFirstOccurence("karonwi");
            //Console.WriteLine(linkedList.Index("karonwi"));
            //linkedList.Index("Iyin");

            Stack<string> stack = new Stack<string>();
            //stack.Push("Kay");
            //stack.Push("ola");
            //stack.Push("oyin");
            ////stack.Pop();
            //Console.WriteLine(stack.Size());
            //stack.PrintStack();
            //stack.Peek();
            //stack.Pop();
            //stack.Size();

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Ola");
            queue.Enqueue("oyin");
            Console.WriteLine(queue.Size());
            //queue.Size();
            //queue.IsEmpty();

        }
    }
}
