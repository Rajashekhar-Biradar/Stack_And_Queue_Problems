using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueueProblems
{
    public class StackPushOperation
    {
        public Node top;
        public void push(int data)
        {
            Node node = new Node(data);
            if (top == null)
            {
                node.next = null;
            }
            else
            {
               node.next = top;
            }
            top = node;
        }

        public void display()
        {
            if (top == null)
            {
                Console.WriteLine("stack is empty");
            }
           while(top != null)
            {
                Console.Write("|"+top.data+"|");
                top = top.next;
            }
        }
    }
    
}
