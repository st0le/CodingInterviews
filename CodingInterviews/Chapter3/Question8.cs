using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingInterviews.Chapter3
{
    [TestClass]
    public class Question8
    {
        /*
         Question 8 - In a 2-D matrix, every row is increasingly sorted from left to right, and every column is
        increasingly sorted from top to bottom. Please implement a function to check whether a number is in such a
        matrix or not. For example, all rows and columns are increasingly sorted in the following matrix. It returns true if it
        tries to find number 7, but it returns false if it tries to find number 5.
        1 2 8 9
        2 4 9 12
        4 7 10 13
        6 8 11 15
        */

        public bool find(int[][] mat, int key)
        {
            int rows = mat.Length, cols = mat[0].Length;
            int i = 0, j = cols - 1;

            while (i < rows && j >= 0)
            {
                if (mat[i][j] == key)
                {
                    return true;
                }
                else if (mat[i][j] < key)
                {
                    i++;
                }
                else
                {
                    j--;
                }
            }

            return false;
        }

        [TestMethod]
        public void TestMethod1()
        {
            int[][] mat = new int[][]
            {
                new int[] {1,2,8,9},
                new int[] {2,4,9,12},
                new int[] {4,7,10,13},
                new int[] {6,8,11,15},
            };
            Assert.IsTrue(find(mat, 11));
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[][] mat = new int[][]
            {
                new int[] {1,2,8,9},
                new int[] {2,4,9,12},
                new int[] {4,7,10,13},
                new int[] {6,8,11,15},
            };
            Assert.IsFalse(find(mat, 0));
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[][] mat = new int[][]
            {
                new int[] {1,2,8,9},
                new int[] {2,4,9,12},
                new int[] {4,7,10,13},
                new int[] {6,8,11,15},
            };
            Assert.IsFalse(find(mat, 20));
        }
    }
}