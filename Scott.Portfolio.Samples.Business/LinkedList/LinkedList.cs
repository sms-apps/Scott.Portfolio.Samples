using System.Text;

namespace Scott.Portfolio.Samples.Business.LinkedList
{
    public class LinkedList
    {
        public Node Head { get; set; }

        public LinkedList(Node head)
        {
            Head = head;
        }

        public void AddNode(object data)
        {
            var parent = GetLastNode();
            parent.Next = new Node(data);
        }

        public Node GetLastNode()
        {
            Node result = Head;
            Node current = Head;

            while (current != null)
            {
                if (current != null)
                {
                    result = current;
                }

                current = current.Next;
            }

            return result;
        }

        public int NodeCount()
        {
            int result = 0;

            Node current = Head;
            while (current != null)
            {
                result++;
                current = current.Next;
            }

            return result;
        }

        public string PrintAllNodes()
        {
            StringBuilder result = new StringBuilder();

            Node current = Head;
            while (current != null)
            {
                result.AppendLine(current.Data.ToString());
                current = current.Next;
            }

            return result.ToString();
        }
    }
}