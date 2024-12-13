using SingleList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
  
    class Queue
    {
        private List list; 

        public Queue()
        {
            list = new List();
        }

        public bool IsEmpty()
        {
            return list.IsEmpty();
        }

        public void Enqueue(object data)
        {
            list.InsertEnd(data); 
        }

        public object Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty.");
            }
            return list.RemoveFront(); 
        }

        public void Display()
        {
            list.Display();
        }
    }


}
