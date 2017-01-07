using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingInterviews.Chapter3
{
    /// <summary>
    /// Summary description for Question7
    /// </summary>
    [TestClass]
    public class Question7
    {

        /**
         * Question 7 In a 2-D matrix, every row is increasingly sorted from left to right, and the last number in each
            row is not greater than the first number of the next row. A sample matrix follows. Please implement a function to
            check whether a number is in such a matrix or not. It returns true if it tries to find the number 7 in the sample
            matrix, but it returns false if it tries to find the number 12.

            1 3 5
            7 9 11
            13 15 17
         */

        public bool find(int[][] mat, int key)
        {
            int rows = mat.Length;
            int cols = mat[0].Length;

            int i = 0, j = rows * cols - 1;
            while (i <= j)
            {
                int mid = (i + j) / 2;
                int x = mid / cols, y = mid % cols;

                if (mat[x][y] == key)
                {
                    return true;
                }
                else if (mat[x][y] < key)
                {
                    i = mid + 1;
                }
                else
                {
                    j = mid - 1;
                }
            }
            return false;
        }

        [TestMethod]
        public void TestMethod1()
        {
            int[][] mat = new int[][]
            {
                new int[] {1,3,5},
                new int[] {7,9,11},
                new int[] {13,15,17},
            };

            Assert.IsTrue(find(mat, 7));
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[][] mat = new int[][]
            {
                new int[] {1,3,5},
                new int[] {7,9,11},
                new int[] {13,15,17},
            };

            Assert.IsFalse(find(mat, 0));
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[][] mat = new int[][]
            {
                new int[] {1,3,5},
                new int[] {7,9,11},
                new int[] {13,15,17},
            };

            Assert.IsFalse(find(mat, 100));
        }
    }
}
