using Single_List;
using System;

namespace SingleList
{
    public class List
    {
        private Node head; 
        private Node tail; 

        
        public List()
        {
            head = null;
            tail = null;
        }

 
        public bool IsEmpty()
        {
            return head == null;
        }

       
        public void InsertFront(object data)
        {
            Node newNode = new Node(data);
            if (IsEmpty())
            {
                head = tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head = newNode;
            }
        }

        public void InsertEnd(object data)
        {
            Node newNode = new Node(data);
            if (IsEmpty())
            {
                head = tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
            }
        }


        public object RemoveFront()
        {
            if (IsEmpty())
            {
                throw new Exception("The list is empty");
            }

            object removedData = head.Element;
            if (head == tail)
            {
                head = tail = null;
            }
            else
            {
                head = head.Next;
            }
            return removedData;
        }


        public object RemoveEnd()
        {
            if (IsEmpty())
            {
                throw new Exception("The list is empty");
            }

            object removedData = tail.Element;
            if (head == tail)
            {
                head = tail = null;
            }
            else
            {
                Node current = head;
                while (current.Next != tail)
                {
                    current = current.Next;
                }
                current.Next = null;
                tail = current;
            }
            return removedData;
        }


        public void Display()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.Element);
                current = current.Next;
            }
        }
    }
}
