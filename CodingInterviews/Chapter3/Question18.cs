using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using System.Collections.Generic;

namespace CodingInterviews.Chapter3
{
    [TestClass]
    public class Question18
    {

        private BTNode Find(BTNode root, int key)
        {
            if (root != null)
            {
                if (root.Data == key) return root;
                else
                {
                    BTNode find = Find(root.Left, key);
                    if (find != null)
                        return find;

                    find = Find(root.Right, key);
                    if (find != null)
                        return find;
                }
            }

            return null;
        }

        public BTNode NextInorder(BTNode node)
        {
            if (node == null) return null;
            BTNode next = null;
            if (node.Right != null)
            {
                next = node.Right;
                while (next.Left != null) next = next.Left;
            }
            else
            {
                next = node.Parent;
                while (next != null && next.Right == node)
                {
                    node = next;
                    next = next.Parent;
                }
            }
            return next;
        }

        [TestMethod]
        public void TestMethod1()
        {
            BTNode root = BTNode.MakeBinaryTree(0, 1, 2, 3, 4, 5, 6);
            //               0
            //           1        2
            //       3      4  5     6
            BTNode find = Find(root, 0);
            BTNode next = NextInorder(find);
            Assert.AreEqual(5, next.Data);
        }
    }
}
