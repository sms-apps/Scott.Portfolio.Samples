namespace Scott.Portfolio.Samples.Business.Hashtable
{
    public class Node
    {
        public object Key { get; set; }
        public object Value { get; set; }

        public Node(object key, object value)
        {
            Key = key;
            Value = value;
        }
    }
}