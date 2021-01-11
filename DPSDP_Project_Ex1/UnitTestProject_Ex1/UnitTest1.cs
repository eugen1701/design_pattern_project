using Microsoft.VisualStudio.TestTools.UnitTesting;
using DPSDP_Project_Ex1;

namespace UnitTestProject_Ex1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Queue_Enqueuing_AddedData()
        {
            Queue<int> q = new Queue<int>();
            q.enqueue(3);

            int key = 3;

            Assert.AreEqual(key, q.dequeue().Key);
        }

        [TestMethod]
        public void Queue_AccessHead()
        {
            Queue<int> q = new Queue<int>();
            q.enqueue(3);
            q.enqueue(6);
            q.enqueue(2);

            int head = 3;

            Assert.AreEqual(head, q.Head.Key);
        }

        [TestMethod]
        public void Queue_AccessTail()
        {
            Queue<int> q = new Queue<int>();
            q.enqueue(3);
            q.enqueue(6);
            q.enqueue(2);

            int tail = 2;

            Assert.AreEqual(tail, q.Tail.Key);
        }
    }
}
