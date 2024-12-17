using LeetCodeTests._2024.december.problem_1;

namespace LeetCodeTests
{
    [TestClass]
    public class Problem9Tests
    {
        [TestMethod]
        [DataRow(121, true)]
        [DataRow(-121, false)]
        [DataRow(10, false)]
        [DataRow(11, true)]
        public void Execute1(int x, bool expected)
        {
            bool result = new Problem9().IsPalindrome(x);
            Assert.AreEqual(expected, result);
        }
    }
}