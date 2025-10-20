using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Stack_Array_Implementation__C__
{
    public class Stack
    {
        int length;
        int top = 0;
        List<object> stackList = new List<object>();

        public Stack(int length)
        {
            this.length = length;

            for (int i = 0; i < length; i++)
            {
                stackList.Add(null);
            }
        }
        public void push(object item)
        {
            if (is_Full())
            {
                Console.WriteLine("The stack is full, no space to push");
            }
            else
            {
                stackList[top] = item;
                top += 1;
            }
        }

        public object pop()
        {
            if (is_Empty())
            {
                Console.WriteLine("The stack is empty, nothing to pop");
                return null;
            }
            else
            {
                var item = stackList[top - 1];
                top -= 1;
                return item;
            }
        }
        
        public bool is_Full()
        {
            return top == length;
        }

        public bool is_Empty()
        {
            return top == 0;
        }

        public object peek()
        {
            if (is_Empty())
            {
                Console.WriteLine("The stack is empty, nothing to peek at");
                return null;
            }
            else
            {
                return stackList[top - 1];
            }
        }
    }
}
