namespace LeetCodeTests
{
    [TestClass]
    public class TechnicalInterviewTests
    {
        [TestMethod]
        [DataRow(4, new int[] { 25, 64, 9, 4, 100 }, 29)]
        [DataRow(7, new int[] { 54, 6, 34, 66, 63, 52, 39, 62, 46, 75, 28, 65, 18, 37, 18, 13, 33, 69, 19, 40, 13, 10, 43, 61, 72 }, 618)]
        public void Execute1(int k, int[]arr, int expected)
        {
            Assert.AreEqual(expected, new TechnicalInterview().PickGifts(arr, k));
        }
    }
}