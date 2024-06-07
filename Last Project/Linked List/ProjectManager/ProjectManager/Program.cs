namespace ProjectManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            Node node = new Node(3,"Digikala",401121014,"Ali");
            linkedList.InsertAtLast(node);

            node = new Node(12, "Alibaba", 401121017, "Amir");
            linkedList.InsertAtLast(node);

            node = new Node(5, "Snap", 401121013, "Morteza");
            linkedList.InsertAtLast(node);

            node = new Node(7, "Tap30", 401121056, "Karim");
            linkedList.InsertAtLast(node);

            node = new Node(34, "Jobinja", 401121021, "Gholam");
            linkedList.InsertAtLast(node);

            linkedList.showAll();

            Console.WriteLine("Give me a student number to search for: ");
            int studentNumber = Convert.ToInt32(Console.ReadLine());
            node = linkedList.SearchByStudentNumber(studentNumber);
            linkedList.ShowNodeInfoByStudentNummber(node, studentNumber);

            Console.WriteLine("Give me another student number to search for: ");
            studentNumber = Convert.ToInt32(Console.ReadLine());
            node = linkedList.SearchByStudentNumber(studentNumber);
            linkedList.ShowNodeInfoByStudentNummber(node, studentNumber);

            Console.WriteLine("Give me a student number to change its info: ");
            studentNumber = Convert.ToInt32(Console.ReadLine());
            node = linkedList.ChangeProjectInfo(studentNumber);
            Console.WriteLine("The specifications of node after change: ");
            linkedList.ShowNodeInfo(node);

            Console.WriteLine("Check out the file to see all the changes. ");
            linkedList.WriteToFile();


        }
    }
}