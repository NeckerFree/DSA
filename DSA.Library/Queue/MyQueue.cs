using System.Data;
using System.Text;

namespace DSA.Library.Queue
{
    public class MyQueue<T>
    {
        private T?[] _collection;
        private int head;
        private int tail;
        private int _capacity;
        public bool IsEmpty { get; set; }


        public MyQueue(int capacity)
        {
            _capacity = capacity;
            _collection = new T[capacity];
            head = 0;
            tail = -1;
            IsEmpty = true;
        }



        public void Enqueue(T? element)
        {
            if (tail == _capacity - 1) { throw new Exception("The queue has reached its capacity"); }
            _collection[++tail] = element;
            IsEmpty = false;
        }

        public T? Dequeue()
        {
            if (IsEmpty) { throw new Exception("Queue is empty"); }
            var dequeue= _collection[head];
            for (int i = head; i < tail; i++)
            {
                _collection[i] = _collection[i+1];
            }
            _collection[tail] = default(T?);
            tail--;
            IsEmpty = (head == tail + 1);
            return dequeue;
        }

        public string Print()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = head; i <= tail; i++)
            {
                sb.AppendFormat("{0} ", _collection[i]);
            }
            return sb.ToString();
        }
    }
}
