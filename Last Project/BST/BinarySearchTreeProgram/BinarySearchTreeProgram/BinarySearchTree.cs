using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeProgram
{
    internal class BinarySearchTree
    {
        private Node? root;


        public void Insert(string bookName, int bookNumber)
        {
            root = InsertRecursive(root, bookName, bookNumber);
        }
        private Node InsertRecursive(Node root, string bookName, int bookNumber)
        {
            if (root is null)
            {
                root = new Node(bookName, bookNumber);
            }
            else if (root.GetBookNumber() > bookNumber)
            {
                root.left = InsertRecursive(root.left, bookName, bookNumber);
            }
            else if (root.GetBookNumber() < bookNumber)
            {
                root.right = InsertRecursive(root.right, bookName, bookNumber);
            }
            return root;
        }

        public void InOrder()
        {
            InOrderRecursive(root);
        }

        private void InOrderRecursive(Node root)
        {
            if (root is not null)
            {
                InOrderRecursive(root.left);
                Console.WriteLine(root.GetBookNumber() + " " + root.GetBookName());
                InOrderRecursive(root.right);
            }
        }
        public void readFromFile(string fileName)
        {
            using (TextReader reader = File.OpenText(fileName))
            {
                int count = int.Parse(reader.ReadLine());
                string[] info;
                string text;
                int bookNumber;
                for (int i = 0; i < count; i++) 
                { 
                    text = reader.ReadLine();
                    info = text.Split(' ');
                    bookNumber = int.Parse(info[0]);
                    Insert(info[1], bookNumber);
                }
            }
        }
    }
}
