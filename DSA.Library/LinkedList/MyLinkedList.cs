using System;
using System.Collections;
using System.Text;
using System.Xml.Linq;

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
            bool removed = false;
            if (Head is null)
            {
                return false;
            }
            var tempNode = Head;
            if (tempNode.Data is null)
            {
                return removed;
            }
            if (tempNode.Data.Equals(data))
            {
                Head = tempNode.Next;
                return true;
            }
            var previousNode = Head;
            while (tempNode is not null)
            {
                if (tempNode.Data is not null)
                {
                    if (tempNode.Data.Equals(data))
                    {
                        previousNode.Next = tempNode.Next;
                        return true;
                    }
                    previousNode = tempNode;
                    tempNode = tempNode.Next;
  
                }
            }
           return removed;
        }

        public MyLinkedListNode<T> AddLast(T value)
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

        public string PrintList()
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (Head == null)
            {
                return stringBuilder.ToString();
            }
            var tempNode = Head;
            while (tempNode.Next is not null)
            {
                stringBuilder.AppendFormat("{0} ", tempNode.Data);
                tempNode = tempNode.Next;
            }
            stringBuilder.AppendFormat("{0} ", tempNode.Data);
            return stringBuilder.ToString();
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
