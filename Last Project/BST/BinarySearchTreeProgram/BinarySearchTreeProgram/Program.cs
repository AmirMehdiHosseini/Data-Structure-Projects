namespace BinarySearchTreeProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.readFromFile("D:\\Education\\3\\Data Structure\\Project\\Last Project\\BST\\BinarySearchTreeProgram\\Data.txt");
            bst.InOrder();
        }
    }
}