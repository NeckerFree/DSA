using System;
using System.Collections;

namespace DSA.Library.LinkedList
{
    public class MyLinkedList<T> //: IEnumerable<T>, ICollection<T>
    {
        private MyLinkedListNode<T>? Head { get; set; }
        public int Count { get; set; }
        //LinkedList l = new LinkedList<int>();
        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T data)
        {
            var firstLinkedListNode=new MyLinkedListNode<T>(data);
            firstLinkedListNode.Next = Head;
            Head = firstLinkedListNode;
            Count++;
            
       }

        public void Clear()
        {
            Head = null;
            Count = 0;
        }

        public bool Contains(T data)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T data)
        {
            throw new NotImplementedException();
        }

        internal MyLinkedListNode<T> AddLast(T value)
        {
            MyLinkedListNode<T> newNode= new MyLinkedListNode<T>(value);
            Count++;
            if (Head == null)
            {
                Head= newNode;  
                return newNode;
            }
            var tempNode = Head;
            while (tempNode.Next is not null)
            {
                tempNode = tempNode.Next;
            }
            tempNode.Next = newNode;    
            return newNode ;
        }

        internal T? GetElementByIndex(int index)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            var tempElement = Head;

            for (var i = 0; tempElement is not null && i < index; i++)
            {
                tempElement = tempElement.Next;
            }

            if (tempElement is null)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            return tempElement.Data;
        }

    }
}
