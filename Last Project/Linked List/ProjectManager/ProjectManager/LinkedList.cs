using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProjectManager
{
    internal class LinkedList
    {
        private Node? head;

        public LinkedList() {
            head = null;
        }

        private bool IsEmpty() => head is null;

        private Node LastNode()
        {
            Node node = head;
            while(node.next is not null)
            {
                node = node.next;
            }
            return node;
        }
        public void InsertAtLast(Node node)
        {
            if (IsEmpty())
            {
                head = node;
            } 
            else
            {
                Node lastNode = LastNode();
                lastNode.next = node;
            }
        }
        public void showAll()
        {
            Node node = head;
            while(node is not null)
            {
                Console.WriteLine("Project Number: " + node.GetProjectNumber());
                Console.WriteLine("Project Name: " + node.GetProjectName());
                Console.WriteLine("Student Number: " + node.GetStudentNumber()); 
                Console.WriteLine("Student Name: " + node.GetStudentName() + "\n");
                node = node.next;
            }
        }
        public Node SearchByStudentNumber(int studentNumber)
        {
            Node node = head;
            while(node is not null) {
                if (node.GetStudentNumber() == studentNumber)
                    break; 
                node = node.next;
            }
            if(node is not null)
            {
                return node;
            }
            else { return null; }
        }
        public Node ChangeProjectInfo(int studentNumber)
        {
            Node node = SearchByStudentNumber(studentNumber);
            if (node is not null)
            {
                Console.WriteLine("Do you like to change project number:(yes / no) ");
                string result =  Console.ReadLine();
                if (result is "yes" or "Yes") {
                    Console.WriteLine("Give me the new project number: ");
                    node.SetProjectNumber ( Convert.ToInt32( Console.ReadLine() ) );
                }

                Console.WriteLine("Do you like to change project name:(yes / no) ");
                result = Console.ReadLine();
                if (result is "yes" or "Yes")
                {
                    Console.WriteLine("Give me the new project name: ");
                    node.SetProjectName(Console.ReadLine());
                }

                Console.WriteLine("Do you like to change student number:(yes / no) ");
                result = Console.ReadLine();
                if (result is "yes" or "Yes")
                {
                    Console.WriteLine("Give me the new student number: ");
                    node.SetStudentNumber(Convert.ToInt32(Console.ReadLine()));
                }

                Console.WriteLine("Do you like to change student name:(yes / no) ");
                result = Console.ReadLine();
                if (result is "yes" or "Yes")
                {
                    Console.WriteLine("Give me the new student name: ");
                    node.SetStudentName(Console.ReadLine());
                }
            }
            return node;
        }
        
        public void ShowNodeInfoByStudentNummber(Node node, int studentNumber)
        {
            if (node is not null)
            {
                Console.WriteLine($"The Student number {studentNumber} was found:");
                Console.WriteLine("Project Number: " + node.GetProjectNumber());
                Console.WriteLine("Project Name: " + node.GetProjectName());
                Console.WriteLine("Student Number: " + node.GetStudentNumber());
                Console.WriteLine("Student Name: " + node.GetStudentName() + "\n");
            }
            else
            {
                Console.WriteLine($"The Student number {studentNumber} was not found.");
            }
        }

        public void ShowNodeInfo(Node node)
        {
            if (node is not null)
            {
                Console.WriteLine("Project Number: " + node.GetProjectNumber());
                Console.WriteLine("Project Name: " + node.GetProjectName());
                Console.WriteLine("Student Number: " + node.GetStudentNumber());
                Console.WriteLine("Student Name: " + node.GetStudentName() + "\n");
            }
            else
            {
                Console.WriteLine("The node was not found in the list.");
            }
        }

        public void WriteToFile()
        {
            Node node = head;
            using (StreamWriter w = File.AppendText("myFile.txt"))
            {
            while (node is not null)
            {
                
                w.WriteLine("Project Number: " + node.GetProjectNumber() + "\n" +
                                "Project Name: " + node.GetProjectName() + "\n" +
                                "Student Number: " + node.GetStudentNumber() + "\n" +
                                "Student Name: " + node.GetStudentName() + "\n\n"
                                );
                node = node.next;
            }
                
            }
        }
    }
}
