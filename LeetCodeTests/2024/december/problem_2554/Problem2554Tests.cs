namespace LeetCodeTests
{
    [TestClass]
    public class Problem2554Tests
    {
        [TestMethod]
        [DataRow(new int[] { 1, 6, 5 }, 5, 6, 2)]
        [DataRow(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 8, 1, 0)]
        [DataRow(new int[] { 11 }, 7, 50, 7)]
        public void Execute(int[] banned, int n, int maxSum, int expectedOutput)
        {
            Assert.AreEqual(expectedOutput, Problem2554.Run(banned, n, maxSum));
        }
    }
}