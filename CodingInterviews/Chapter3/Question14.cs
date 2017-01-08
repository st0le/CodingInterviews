using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingInterviews.Chapter3
{
    [TestClass]
    public class Question14
    {

        public LLNode Sort(LLNode head)
        {
            LLNode nhead = null, next;
            while (head != null)
            {
                next = head.Next;
                head.Next = null;
                nhead = Insert(nhead, head);
                head = next;
            }
            return nhead;
        }

        private LLNode Insert(LLNode start, LLNode node)
        {
            if(start == null)
            {
                return node;
            }

            if (node.Data < start.Data)
            {
                node.Next = start;
                return node;
            }
            else
            {
                LLNode cur = start;
                while (cur.Next != null && cur.Data < node.Data)
                {
                    cur = cur.Next;
                }

                node.Next = cur.Next;
                cur.Next = node;
            }
            return start;

        }

        [TestMethod]
        public void TestMethod1()
        {
            LLNode head = LLNode.MakeList(5, 4, 3, 2, 1);
            LLNode sorted = Sort(head);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, sorted.ToArray());
        }
    }
}
