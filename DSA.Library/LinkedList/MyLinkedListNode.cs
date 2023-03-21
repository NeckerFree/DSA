namespace DSA.Library.LinkedList
{
    public class MyLinkedListNode<T>
    {
        public T? Data { get; }

        public MyLinkedListNode<T>? Next { get; set; }

        public MyLinkedListNode(T data)
        {
            Data = data;
            Next = null;
        }
    }
}