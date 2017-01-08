using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingInterviews.Chapter3
{
    [TestClass]
    public class Question11
    {
        /*
         * Question 11 How do you implement a function to match regular expressions with ‘.’ and ‘*’ in patterns? The
            character ‘.’ in a pattern matches a single character, and ‘*’ matches zero or any number of characters preceding
            it. Matching means that a string fully matches the pattern where all characters in a string match the whole pattern.
            For example, the string “aaa” matches the pattern “a.a” and the pattern “ab*ac*a”. However, it does not match
            the pattern “aa.a” nor “ab*a”.
         */

        public bool Match(string hay, string needle)
        {
            return Match(hay.ToCharArray(), 0, needle.ToCharArray(), 0);
        }

        private bool Match(char[] hay, int i, char[] needle, int j)
        {
            if (j == needle.Length)
                return i == hay.Length;

            if (i == hay.Length) return false;

            if (j + 1 < needle.Length && needle[j + 1] == '*')
            {
                if (hay[i] == needle[j] || needle[j] == '.')
                {
                    return Match(hay, i + 1, needle, j + 2)
                        || Match(hay, i + 1, needle, j)
                        || Match(hay, i, needle, j + 2);
                }
                else
                {
                    return Match(hay, i, needle, j + 2);
                }
            }
            else
            {
                return (hay[i] == needle[j] || needle[j] == '.') && Match(hay, i + 1, needle, j + 1);
            }
        }

        [TestMethod]
        public void TestCase1()
        {
            Assert.IsTrue(Match("aaa", "a.a"));
            Assert.IsTrue(Match("aaa", "ab*ac*a"));
            Assert.IsTrue(Match("aaa", "a*"));
            Assert.IsTrue(Match("aaa", "a*a"));
        }
    }
}