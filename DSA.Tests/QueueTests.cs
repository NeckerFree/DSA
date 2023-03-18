using DSA.Library.Queue;

namespace DSA.Tests
{
    public class QueueTests
    {

        [Fact]
        public void ValidateQueueResult()
        {
            MyQueue<string> queue = new MyQueue<string>(10);
            queue.Enqueue("One");
            queue.Enqueue("Two");
            queue.Enqueue("Three");
            queue.Enqueue("Four");
            queue.Dequeue();
            queue.Enqueue("Five");
            queue.Enqueue("Six");
            queue.Enqueue("Seven");
            queue.Enqueue("Eight");
            queue.Enqueue("Nine");
            queue.Enqueue("Ten");
            queue.Enqueue("Eleven");
            //queue.Enqueue("Twelve");
            queue.Dequeue();
            string actual = queue.Print();
            Assert.Equal("Three Four Five Six Seven Eight Nine Ten Eleven ", actual);
        }

        [Fact]
        public void ValidateQueueResultInteger()
        {
            MyQueue<int?> queue = new MyQueue<int?>(10);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Dequeue();
            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.Enqueue(9);
            queue.Enqueue(10);
            queue.Enqueue(11);
            //queue.Enqueue("Twelve");
            queue.Dequeue();
            string actual = queue.Print();
            Assert.Equal("3 4 5 6 7 8 9 10 11 ", actual);
        }
    }
}
