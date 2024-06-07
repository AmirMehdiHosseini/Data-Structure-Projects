using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySpecifications
{
    internal class Node
    {
        private string name;
        private int number;
        private int countOfStudents;
        private int cityNumber;
        internal Node next;

        public string GetName() => name;
        public int GetNumber() => number;
        public int GetCountOfStudents() => countOfStudents;
        public int GetCityNumber() => cityNumber;


        public void SetName( string name) => this.name = name;
        public void SetNumber(int number) => this.number = number;
        public void SetCountOfStudents(int countOfStudents) => this.countOfStudents = countOfStudents;
        public void SetCityNumber(int cityNumber) => this.cityNumber = cityNumber;

        public Node(string name, int number, int countOfStudents, int cityNumber)
        {
            this.name = name;   
            this.number = number;
            this.countOfStudents = countOfStudents;
            this.cityNumber = cityNumber;
        }
        public Node DeepCopy()
        {
            Node node = (Node)this.MemberwiseClone();
            return node;
        }
    }
}
