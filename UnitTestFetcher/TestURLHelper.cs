using BilibiliVideoFetcher.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestFetcher
{
    [TestClass]
    public class TestURLHelper
    {
        [TestMethod]
        public void TestConvertToThunder()
        {
            var url = UrlHelper.ConvertToThunder("http://tool.lu/test.zip");
            Assert.AreEqual(url, "thunder://QUFodHRwOi8vdG9vbC5sdS90ZXN0LnppcFpa");

            url = UrlHelper.ConvertToThunder("http://tool.lu/test2.zip");
            Assert.AreEqual(url, "thunder://QUFodHRwOi8vdG9vbC5sdS90ZXN0Mi56aXBaWg==");
        }
    }
}
