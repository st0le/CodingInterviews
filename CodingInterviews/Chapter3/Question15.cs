using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingInterviews.Chapter3
{
    [TestClass]
    public class Question15
    {
        /*
         * Question 15 Please implement a function to merge two sorted lists into a single sorted list. 
         */
        public LLNode Merge(LLNode A, LLNode B)
        {
            LLNode nhead = null, last = null;

            while (A != null && B != null)
            {
                LLNode next = null, cur;
                if (A.Data < B.Data)
                {
                    next = A.Next;
                    A.Next = null;
                    cur = A;
                    A = next;

                }
                else
                {
                    next = B.Next;
                    B.Next = null;
                    cur = B;
                    B = next;
                }

                if (nhead == null)
                {
                    nhead = last = cur;
                }
                else
                {
                    last.Next = cur;
                    last = cur;
                }
            }

            last.Next = A != null ? A : B; ;
            return nhead;
        }

        public LLNode MergeRecurse(LLNode A,LLNode B)
        {
            if (A == null) return B;
            if (B == null) return A;
            
            if(A.Data < B.Data)
            {
                A.Next = Merge(A.Next, B);
                return A;
            }else
            {
                B.Next = Merge(A, B.Next);
                return B;
            }
        }

        [TestMethod]
        public void TestMethod1()
        {
            LLNode A = LLNode.MakeList(1, 3, 5, 7);
            LLNode B = LLNode.MakeList(2, 4, 6, 8);
            LLNode C = Merge(A, B);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, C.ToArray());

        }

        [TestMethod]
        public void TestMethod2()
        {
            LLNode A = LLNode.MakeList(1, 3, 5, 7);
            LLNode B = LLNode.MakeList(2, 4, 6, 8);
            LLNode C = MergeRecurse(A, B);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, C.ToArray());

        }
    }
}
