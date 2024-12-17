using LeetCodeTests._2024.december.problem_1;

namespace LeetCodeTests
{
    [TestClass]
    public class Problem28Tests
    {
        [TestMethod]
        [DataRow("sadbutsad", "sad", 0)]
        [DataRow("leetcode", "leeto", -1)]
        [DataRow("a", "a", 0)]
        [DataRow("abc", "c", 2)]
        public void Execute1(string haystack, string needle, int expected)
        {
            int result = new Problem28().StrStr(haystack, needle);
            Assert.AreEqual(expected, result);
        }
    }
}