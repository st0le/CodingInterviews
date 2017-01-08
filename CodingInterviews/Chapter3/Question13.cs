using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingInterviews.Chapter3
{
    [TestClass]
    public class Question13
    {
        /*
         *  Question 13 - Please implement a function to print a list from its tail to head.          */
        public LLNode Reverse(LLNode head)
        {
            LLNode nhead = null, next = null;

            while (head != null)
            {
                next = head.Next;
                head.Next = nhead;
                nhead = head;
                head = next;
            }

            return nhead;
        }

        public string PrintReverse(LLNode head)
        {
            if (head != null)
            {
                return PrintReverse(head.Next) + " " + head.Data;
            }

            return string.Empty;
        }

        [TestMethod]
        public void TestMethod1()
        {
            LLNode head = LLNode.MakeList(1, 2, 3, 4);
            string reverse = PrintReverse(head);
            Assert.AreEqual("4 3 2 1", reverse.Trim());
        }

        [TestMethod]
        public void TestMethod2()
        {
            LLNode head = LLNode.MakeList(1, 2, 3, 4);
            LLNode reverse = Reverse(head);
            CollectionAssert.AreEqual(new int[] { 4, 3, 2, 1 }, reverse.ToArray());
        }
    }
}
