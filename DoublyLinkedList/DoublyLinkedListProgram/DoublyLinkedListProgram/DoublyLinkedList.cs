using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;

namespace DoublyLinkedListProgram
{
    internal class DoublyLinkedList
    {
        private Node? head;
        private Node? tail;

        public DoublyLinkedList()
        {
            this.head = null;
            this.tail = null;
        }

        public bool IsEmpty() => head is null;

        public void InsertAtLast(int data)
        {
            Node node = new(data);
            InsertNode(node);
        }

        private void InsertNode(Node node)
        {
            if (IsEmpty())
            {
                this.head = node;
            }
            else
            {
                this.tail!.next = node;
                node.previous = tail;
            }
            this.tail = node;
        }

        public void ShowForward()
        {
            Node? node = head;
            while (node is not null)
            {
                Console.Write(node.data + " --> ");
                node = node.next;
            }
            Console.WriteLine();
        }

        public void ShowBackward()
        {
            Node? node = tail;
            while (node is not null)
            {
                Console.Write(node.data + " --> ");
                node = node.previous;
            }
            Console.WriteLine();
        }
        private bool IsNotEmpty() => !IsEmpty();

        private void SwapeReference(Node node)
        {
            var temp = node.previous;
            node.previous = node.next;
            node.next = temp;
        }

        public DoublyLinkedList ImmutableBackward()
        {
            DoublyLinkedList list = new();
            if (IsNotEmpty())
            {
                Node? currentNode = this.tail;
                while (currentNode is not null)
                {
                    currentNode = currentNode.DeepCopy();
                    var prenode = currentNode.previous;
                    SwapeReference(currentNode);
                    list.InsertNode(currentNode);
                    currentNode = prenode;
                }
            }
            return list;
        }

        // Mutable backward
        public void Reverse()
        {
            if (IsNotEmpty())
            {
                Node? currentNode = this.tail;
                while (currentNode is not null)
                {
                    var prenode = currentNode.previous;
                    SwapeReference(currentNode);
                    currentNode = prenode;
                }
                var temp = tail;
                tail = head;
                head = temp;
            }
        }
    }
}
