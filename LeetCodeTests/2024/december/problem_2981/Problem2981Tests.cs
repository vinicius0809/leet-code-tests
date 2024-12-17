namespace LeetCodeTests
{
    [TestClass]
    public class Problem2981Tests
    {
        [TestMethod]
        [DataRow("aaaa", 2)]
        [DataRow("abcdef", -1)]
        [DataRow("abcaba", 1)]
        [DataRow("ttttt", 3)]
        [DataRow("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", 48)]
        [DataRow("azzyyyyyyy", 5)]
        public void Execute1(string input, int expectedOutput)
        {
            Assert.AreEqual(expectedOutput, new Problem2981().MaximumLength(input));
        }
    }
}