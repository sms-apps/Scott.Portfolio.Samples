using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Scott.Portfolio.Samples.Business.LinkedList.Tests
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void LinkedListTest()
        {
            var headNode = new Node("Head");
            var list = new LinkedList(headNode);

            Assert.IsNotNull(list);
            Assert.IsInstanceOfType(list, typeof(LinkedList));

            list = new LinkedList(null);
            Assert.IsNotNull(list);
            Assert.IsInstanceOfType(list, typeof(LinkedList));
        }

        [TestMethod]
        public void GetLastNodeTest()
        {
            var list = new LinkedList(new Node("Head"));
            list.AddNode("Sub Node 1");
            list.AddNode("Sub Node 2");

            var lastNode = list.GetLastNode();
            Assert.IsNotNull(lastNode);
            Assert.IsInstanceOfType(lastNode, typeof(Node));
            Assert.IsTrue(lastNode.Data.Equals("Sub Node 2"));
        }

        [TestMethod]
        public void PrintAllNodesTest()
        {
            var list = new LinkedList(new Node("Head"));
            list.AddNode("Sub Node 1");
            list.AddNode("Sub Node 2");

            Assert.IsTrue(list.PrintAllNodes().Equals("Head\r\nSub Node 1\r\nSub Node 2\r\n"));
        }

        [TestMethod]
        public void AddNodeTest()
        {
            var list = new LinkedList(new Node("Head"));
            list.AddNode("Sub Node 1");

            Assert.IsTrue(list.NodeCount().Equals(2));
        }

        [TestMethod]
        public void NodeCountTest()
        {
            var list = new LinkedList(new Node("Head"));
            list.AddNode("Sub Node 1");
            list.AddNode("Sub Node 2");
            Assert.IsTrue(list.NodeCount().Equals(3));
        }
    }
}