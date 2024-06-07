using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListProgram 
{
    internal class Node 
    {
        internal int data;
        internal Node next;
        internal Node previous;

        public Node(int data)
        {
            this.next = this.previous = null;
            this.data = data;
        }

        public Node DeepCopy()
        {
            Node node = (Node)this.MemberwiseClone();
            return node;
        }
    }
}
