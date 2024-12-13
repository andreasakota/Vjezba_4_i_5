using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_List
{
    public class Node
    {
        public object Element { get; private set; }
        public Node Next { get; set; }

        public Node(object element) 
        {
            Element = element;
            Next = null;
        }
    }
}
