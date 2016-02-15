namespace Scott.Portfolio.Samples.Business.LinkedList
{
    public class Node
    {
        public Node Next { get; set; }
        public object Data { get; set; }

        public Node(object data)
        {
            Data = data;
        }

        public Node(Node next, object data)
        {
            Next = next;
            Data = data;
        }
    }
}