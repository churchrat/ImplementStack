using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementStack
{
    public class Stack
    {
        public static int count = 0;
        private List<int> element = new List<int>();
        public Stack()
        {

        }
        public void Push(int item)
        {
            element.Add(item);
            count++;
        }
        public int Pop()
        {
            int temp = element[element.Count - 1];
            element.Remove(element[element.Count - 1]);
            return temp;

        }
        public int Peek()
        {
            return element[element[element.Count - 1]];
        }
    }
}
