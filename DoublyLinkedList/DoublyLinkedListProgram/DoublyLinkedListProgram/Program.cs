using System.Xml.Linq;
using System.Xml;

namespace DoublyLinkedListProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList list = new DoublyLinkedList();
            list.InsertAtLast(0); 
            list.InsertAtLast(1); 
            list.InsertAtLast(2); 
            list.InsertAtLast(3); 
            list.InsertAtLast(4);
            list.ShowForward();
            list.ShowBackward();

            DoublyLinkedList backwardList = list.ImmutableBackward();
            backwardList.ShowForward();
            backwardList.ShowBackward();

            list.Reverse();
            list.ShowForward();
            list.ShowBackward();
        }
    }
}