using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Scott.Portfolio.Samples.Business.Hashtable.Tests
{
    [TestClass()]
    public class SimpleHashtableTests
    {
        [TestMethod()]
        public void SimpleHashtableTest()
        {
            var sht = new SimpleHashtable();
            Assert.IsNotNull(sht);
            Assert.IsInstanceOfType(sht, typeof(SimpleHashtable));
        }

        [TestMethod()]
        public void AddWithKeyAndValueTest()
        {
            var sht = new SimpleHashtable();
            sht.Add(1, "value for 1");
            Assert.IsTrue(sht.Count == 1);
            Assert.IsInstanceOfType(sht[0], typeof(Node));
        }

        [TestMethod()]
        public void AddWithObjectTest()
        {
            var sht = new SimpleHashtable();
            var node = new Node(1, "value for 1");
            sht.Add(node);
            Assert.IsTrue(sht.Count == 1);
            Assert.IsInstanceOfType(sht[0], typeof(Node));
        }

        [TestMethod()]
        public void ClearTest()
        {
            var sht = new SimpleHashtable();
            var node = new Node(1, "value for 1");
            sht.Add(node);
            Assert.IsTrue(sht.Count == 1);
            Assert.IsInstanceOfType(sht[0], typeof(Node));

            sht.Clear();
            Assert.IsTrue(sht.Count == 0);
        }

        [TestMethod()]
        public void ContainsTest()
        {
            var sht = new SimpleHashtable();
            var node = new Node(1, "value for 1");
            sht.Add(node);

            Assert.IsTrue(sht.Contains(node));
        }

        [TestMethod()]
        public void CopyToTest()
        {
            var sht = new SimpleHashtable();
            var node = new Node(1, "value for 1");
            sht.Add(node);

            Node[] array = new Node[1];
            sht.CopyTo(array, 0);
            Assert.IsNotNull(array);
            Assert.IsInstanceOfType(array[0], typeof(Node));
        }

        [TestMethod()]
        public void RemoveTest()
        {
            var sht = new SimpleHashtable();
            var node = new Node(1, "value for 1");
            sht.Add(node);
            Assert.IsTrue(sht.Count == 1);
            Assert.IsInstanceOfType(sht[0], typeof(Node));

            sht.Remove(node);
            Assert.IsTrue(sht.Count == 0);
        }

        [TestMethod()]
        public void GetEnumeratorTest()
        {
            var sht = new SimpleHashtable();
            var node = new Node(1, "value for 1");
            sht.Add(node);
            var enumerator = sht.GetEnumerator();
            Assert.IsInstanceOfType(enumerator, typeof(IEnumerator<Node>));
        }
    }
}