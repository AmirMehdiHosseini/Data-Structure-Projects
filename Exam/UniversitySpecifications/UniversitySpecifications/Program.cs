namespace UniversitySpecifications
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList firstProvinceList = new LinkedList();
            LinkedList secondProvinceList = new LinkedList();
            firstProvinceList.readFromFile("D:\\Education\\3\\Data Structure\\Project\\Emtehan payani\\UniversitySpecifications\\Data1.txt");
            secondProvinceList.readFromFile("D:\\Education\\3\\Data Structure\\Project\\Emtehan payani\\UniversitySpecifications\\Data2.txt");
            firstProvinceList.showAllNodes();
            secondProvinceList.showAllNodes();

            LinkedList concatenatedList = LinkedList.ConcatenateNodes(firstProvinceList, secondProvinceList);
            concatenatedList.showAllNodes();
        }
    }
}