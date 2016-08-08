using System;
using AugChallenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AugChallengeTest
{
    [TestClass]
    public class checkElementsTests
    {
        [TestMethod]
        public void ShouldReturnSuccess()
        {
            var prgm = new Program();

            var st = prgm.CheckSumOfElements(new[] { 10, 20, 5, 18, 30, 5 });
            Assert.AreEqual(@"TEST PASSED", st);
        }

        [TestMethod]
        public void ShouldReturnFail()
        {
            var prgm = new Program();

            var returnstmt = prgm.CheckSumOfElements(new[] { 4, 2, 3 });
            Assert.AreEqual("Test Failed", returnstmt);
        }
    }
}
