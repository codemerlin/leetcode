using NUnit.Framework;

namespace Weekly228.Second
{
    public class SecondSolutionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Second_LeetCodeCases()
        {
            var sol = new Solution();
            var res = sol.CountHomogenous("abbcccaa");
            Assert.AreEqual(13, res);
            res = sol.CountHomogenous("xy");
            Assert.AreEqual(2, res);
            res = sol.CountHomogenous("zzzzz");
            Assert.AreEqual(15, res);
        }
    }
}
