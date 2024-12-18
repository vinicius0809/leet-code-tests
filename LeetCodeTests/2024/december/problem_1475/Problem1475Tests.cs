namespace LeetCodeTests
{
    [TestClass]
    public class Problem1475Tests
    {
        [TestMethod]
        [DataRow(new int[] { 8, 4, 6, 2, 3 }, new int[] { 4, 2, 4, 2, 3 })]
        [DataRow(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 1, 2, 3, 4, 5, 6 })]
        [DataRow(new int[] { 10, 1, 1, 6 }, new int[] { 9, 0, 1, 6 })]
        [DataRow(new int[] { 8,7,4,2,8,1,7,7,10,1 }, new int[] {1,3,2,1,7,0,0,6,9,1 })]
        public void Execute1(int[] input, int[] expectedOutput)
        {
            int[] result = new Problem1475().FinalPrices(input);
            for (int i = 0; i < expectedOutput.Length; i++)
            {
                Assert.AreEqual(expectedOutput[i], result[i]);
            }
        }
    }
}