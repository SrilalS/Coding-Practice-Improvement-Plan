using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Distinct_Subsequences
{
    [TestClass]
    class DistinctSubsequencesTest
    {
        [TestMethod]
        public void TestOne()
        {
            string Sequence = "rabbbit";
            string SubSequence = "rabbit";

            int TestAns = DistinctSubsequences.GetSubSequences(Sequence, SubSequence);
            Assert.AreEqual(3, TestAns);
        }

        [TestMethod]
        public void TestTwo()
        {
            string Sequence = "babgbag";
            string SubSequence = "bag";

            int TestAns = DistinctSubsequences.GetSubSequences(Sequence, SubSequence);
            Assert.AreEqual(5, TestAns);
        }
    }
}
