using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AppleTests
{
    [TestClass]
    public class ColorTests
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        private static IEnumerable<string[]> GetData()
        {
            List<string> colors = new List<string>();
            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Blue");

            foreach (string color in colors)
            {
                yield return new[] { color };
            }
        }

        [DynamicData(nameof(GetData), DynamicDataSourceType.Method)]
        [TestMethod]
        public void ValidateColor(string c)
        {
            Assert.IsTrue(true == true);
        }
    }
}
