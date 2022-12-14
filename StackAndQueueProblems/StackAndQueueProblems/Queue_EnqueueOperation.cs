using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueueProblems
{
   public class Queue_EnqueueOperation
   {
        public Node Head;
        public void Enqueue(int data)
        {
            Node node = new Node(data);

            if (Head == null)
            {
                Head = node;
            }
            else
            {
                Node temp = Head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into queue",node.data);
        }

        public void display()
        {
            if (Head == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                while(Head != null)
                {
                    
                    Console.WriteLine(Head.data);
                    Head = Head.next;
                }
            }
        }
    }
}
