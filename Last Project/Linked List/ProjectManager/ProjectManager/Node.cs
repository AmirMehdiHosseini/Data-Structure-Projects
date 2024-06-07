using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager
{
    internal class Node
    {
        private int projectNumber;
        private string projectName;
        private int studentNumber;
        private string studentName;
        internal Node? next;

        public int GetProjectNumber () => projectNumber; 
        public int GetStudentNumber () => studentNumber;
        public string GetProjectName () => projectName;
        public string GetStudentName () => studentName;
        public void SetProjectNumber(int projectNumber) => this.projectNumber = projectNumber;
        public void SetStudentNumber(int studentNumber) => this.studentNumber = studentNumber;
        public void SetProjectName(string projectName) => this.projectName = projectName;
        public void SetStudentName(string studentName) => this.studentName = studentName;

        public Node(int projectNumber, string projectName, int studentNumber, string studentName)
        {
            this.projectNumber = projectNumber;
            this.projectName = projectName;
            this.studentNumber = studentNumber;
            this.studentName = studentName;
        }

    }
}
