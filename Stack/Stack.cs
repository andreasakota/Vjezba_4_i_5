using SingleList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{

    class Stack
    {
        private List list; 
        
        public Stack()
        {
            list = new List();
        }

        public bool IsEmpty()
        {
            return list.IsEmpty();
        }

        public void Push(object data)
        {
            list.InsertFront(data); 
        }

        public object Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            return list.RemoveFront(); 
        }

        public void Display()
        {
            list.Display();
        }
    }

}
