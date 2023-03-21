using DSA.Library.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DSA.Tests
{
    public  class MylinkedListTests
    {
        [Fact]
        public void Validate_remove_middle_element()
        {
            MyLinkedList<int> list = new MyLinkedList<int>(); 
            list.AddLast   (12);
            list.AddLast(15);
            list.AddLast(10);
            list.AddLast(11);
            list.AddLast(5);
            list.AddLast(6);
            list.AddLast(2);
            list.AddLast(3);
            list.Remove(10);
            var actual=list.PrintList();
            Assert.Equal("12 15 11 5 6 2 3", actual.ToString());
        }

        [Fact]
        public void Validate_remove_head_element()
        {
            MyLinkedList<int> list = new MyLinkedList<int>();
            list.AddLast(12);
            list.AddLast(15);
            list.AddLast(10);
            list.AddLast(11);
            list.AddLast(5);
            list.AddLast(6);
            list.AddLast(2);
            list.AddLast(3);
            list.Remove(12);
            var actual = list.PrintList();
            Assert.Equal("15 10 11 5 6 2 3", actual.ToString());
        }
        [Fact]
        public void Validate_remove_not_existent_element()
        {
            MyLinkedList<int> list = new MyLinkedList<int>();
            list.AddLast(12);
            list.AddLast(15);
            list.AddLast(10);
            list.AddLast(11);
            list.AddLast(5);
            list.AddLast(6);
            list.AddLast(2);
            list.AddLast(3);
            list.Remove(45);
            var actual = list.PrintList();
            Assert.Equal("12 15 10 11 5 6 2 3", actual.ToString());
        }
    }
}
