using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueueProblems
{
    public class StackPOpAndPeakOperation
    {
         Node top;
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
            while (top != null)
            {
                Console.Write("|" + top.data + "|");
                top = top.next;
            }
        }

        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            Console.WriteLine("{0} removed from the satck",top.data);
            top = top.next;
        }

        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("stack is empty");
            }
            Console.WriteLine("{0} is on the top of the Satck",this.top.data);
        }
        
        public void TillEmpty()
        {
           
            while (this.top != null)
            {             
                Peek();
                Console.WriteLine();
                Pop();
                Console.WriteLine();
            }
           
        }
    }
}
