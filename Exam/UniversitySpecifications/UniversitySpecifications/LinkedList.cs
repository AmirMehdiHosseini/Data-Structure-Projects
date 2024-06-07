using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySpecifications
{
    internal class LinkedList
    {
        private Node? head;
        private int countOfUniversities;
        public Node findLastNode()
        {
            Node node = head;
            while (node.next is not null)
            {
                node = node.next;
            }
            return node; 
        }

        public void showAllNodes()
        {
            Node node = head;
            while (node is not null)
            {
                Console.WriteLine(node.GetName()  + " " + node.GetNumber() + " " + node.GetCountOfStudents() + " " + node.GetCityNumber());
                node = node.next;
            }
        }



        private void InsertNode(Node node)
        {
            node = node.DeepCopy();
            node.next = null;
            if (head is null)
            {
                head = node;
            }
            else
            {
                Node lastNode = findLastNode();
                lastNode.next = node;
            }
        }

        public void readFromFile(string fileName)
        {
            using (TextReader reader = File.OpenText(fileName))
            {
                countOfUniversities = int.Parse(reader.ReadLine());
                string[] info;
                string text;
                int bookNumber;
                Node node;
                for (int i = 0; i < countOfUniversities; i++)
                {
                    text = reader.ReadLine();
                    info = text.Split(' ');
                    node = new Node(info[0], int.Parse(info[1]), int.Parse(info[2]), int.Parse(info[3]));
                    InsertNode(node);
                }
            }
        }

        public static LinkedList ConcatenateNodes(LinkedList firstList, LinkedList secondList) 
        {
            LinkedList  concatenatedList = new LinkedList();
            var node = firstList.head;
            concatenatedList.InsertNode(node);
            node = secondList.head;
            concatenatedList.InsertNode(node);
            concatenatedList.countOfUniversities += 2;
            for (int i = 1; i< firstList.countOfUniversities; i++)
            {
                node = firstList.findIndex(i );
                concatenatedList.InsertNode(node);
                node = secondList.findIndex(i);
                concatenatedList.InsertNode(node);
                concatenatedList.countOfUniversities += 2;
            }
            return concatenatedList;
        }
        
        private Node findIndex(int index) {
            Node node = head;
            for (int i = 0; i < index; i++)
                node = node.next;
            return node;
        }
    }
}
