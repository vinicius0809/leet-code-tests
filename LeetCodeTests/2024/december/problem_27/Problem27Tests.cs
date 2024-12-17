using LeetCodeTests._2024.december.problem_1;

namespace LeetCodeTests
{
    [TestClass]
    public class Problem27Tests
    {
        [TestMethod]
        [DataRow(3, new int[] { 3, 2, 2, 3 }, 2)]
        [DataRow(2, new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 5)]
        public void Execute1(int target, int[] nums, int expected)
        {
            int result = new Problem27().RemoveElement(nums, target);
            Assert.AreEqual(expected, result);
        }
    }
}