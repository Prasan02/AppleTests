using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppleTests
{
    [TestClass]
    public class SizeTests
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }


        [TestMethod]
        public void ValidateSize()
        {
            Assert.IsTrue(true == true);
        }
    }
}
