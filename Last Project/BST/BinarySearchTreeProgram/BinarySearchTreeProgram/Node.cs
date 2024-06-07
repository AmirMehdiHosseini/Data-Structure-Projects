using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeProgram
{
    internal class Node
    {
        private string bookName;
        private int bookNumber;
        internal Node? left;
        internal Node? right;

        public int GetBookNumber() => bookNumber;
        public string GetBookName() => bookName;
        public Node(string bookName, int bookNumber)
        {
            this.bookName = bookName;
            this.bookNumber = bookNumber;
        }
    }
}
