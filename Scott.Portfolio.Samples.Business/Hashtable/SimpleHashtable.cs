using System.Collections;
using System.Collections.Generic;

namespace Scott.Portfolio.Samples.Business.Hashtable
{
    public class SimpleHashtable : ICollection<Node>
    {
        private List<Node> Table { get; set; }

        public SimpleHashtable()
        {
            Table = new List<Node>();
        }

        public int Count { get { return Table.Count; } }

        public bool IsReadOnly { get { return false; } }

        public Node this[int index]
        {
            get { return Table[index]; }
            set { Table[index] = value; }
        }

        public void Add(object key, object value)
        {
            Table.Add(new Node(key, value));
        }

        public void Add(Node item)
        {
            Table.Add(item);
        }

        public void Clear()
        {
            Table.Clear();
        }

        public bool Contains(Node item)
        {
            return Table.Contains(item);
        }

        public void CopyTo(Node[] array, int arrayIndex)
        {
            array.SetValue(Table[arrayIndex], 0);
        }

        public bool Remove(Node item)
        {
            return Table.Remove(item);
        }

        public IEnumerator<Node> GetEnumerator()
        {
            return Table.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Table.GetEnumerator();
        }
    }
}