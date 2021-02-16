using NUnit.Framework;

namespace Weekly228.First
{
    public class FirstSolutionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void First_LeetCodeCases()
        {
            var sol = new Solution();
            var res = sol.MinOperations("0100");
            Assert.AreEqual(1, res);
            res = sol.MinOperations("10");
            Assert.AreEqual(0, res);
            res = sol.MinOperations("1111");
            Assert.AreEqual(2, res);
        }
    }
}
