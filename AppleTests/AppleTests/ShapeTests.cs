using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppleTests
{
    [TestClass]
    public class ShapeTests
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }


        [TestMethod]
        public void ValidateShape()
        {
            TestContext.AddResultFile(@"data/badapple.png");
            Assert.Fail("Shape of the apple is bad");
        }
    }
}
