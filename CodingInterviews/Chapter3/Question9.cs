using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingInterviews.Chapter3
{
    [TestClass]
    public class Question9
    {
        /*
         * Question 9 - Please implement a function to replace each blank in a string with “%20”. For instance, it
         * outputs “We%20are%20happy.” if the input is “We are happy.”.
         */

        public char[] ReplaceBlanks(char[] arr)
        {
            int newLen = 0, oldLen = 0;
            for (int i = 0; arr[i] != 0; i++, oldLen++)
            {
                if (arr[i] == ' ')
                {
                    newLen += 3;
                }
                else
                {
                    newLen++;
                }
            }
            for (int i = oldLen - 1, j = newLen - 1; i >= 0; i--)
            {
                if (arr[i] == ' ')
                {
                    arr[j--] = '0';
                    arr[j--] = '2';
                    arr[j--] = '%';
                }
                else
                {

                    arr[j--] = arr[i];
                }
            }

            return arr;
        }

        [TestMethod]
        public void TestMethod1()
        {
            char[] arr = new char[30];
            string s = "We are happy.";
            for (int i = 0; i < s.Length; i++)
                arr[i] = s[i];

            arr = ReplaceBlanks(arr);
            string res = new string(arr);
            Assert.IsTrue(res.StartsWith("We%20are%20happy."));
        }
    }
}
