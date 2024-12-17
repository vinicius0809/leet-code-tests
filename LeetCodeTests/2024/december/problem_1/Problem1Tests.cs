using LeetCodeTests._2024.december.problem_1;

namespace LeetCodeTests
{
    [TestClass]
    public class Problem1Tests
    {
        [TestMethod]
        [DataRow(9, new int[] { 2, 7, 11, 15 }, new int[] { 0, 1 })]
        [DataRow(6, new int[] { 3, 2, 4 }, new int[] { 1, 2 })]
        [DataRow(6, new int[] { 3, 3 }, new int[] { 0, 1 })]
        public void Execute1(int target, int[] nums, int[] expected)
        {
            int[] result = new Problem1().TwoSum(nums, target);
            Assert.AreEqual(expected.Length, result.Length);
            Assert.IsTrue(expected.Contains(result[0]));
            Assert.IsTrue(expected.Contains(result[1]));
        }
    }
}