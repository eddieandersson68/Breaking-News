using Breaking_News;
using Moq;
using NUnit.Framework;
using System;

namespace Breaking_News_NUnitTests
{
    [TestFixture]
    public class IWebCalculatorTests
    {
        // Test works
        [Test]
        public void IWebCalculatorTests_Check_If_WebColl_Is_Null()
        {
            IWebCalculator wcalc = new WebHandler();
            IWebCollector wcoll = new WebHandler();
            string t = "test";
            var result = wcalc.CalculateNumberOfHits(wcoll, t);
            Assert.AreEqual(-1, result);
        }

        // Test works
        [Test]
        public void IWebCalculatorTests_ValidUrl()
        {
            IWebCollector wc = new WebHandler();
            string url = "https://www.aftonbladet.se";
            wc.GetHTMLFromUrl(url);
            Assert.IsTrue(url.Contains("https://"));
        }

        // Test works
        [Test]
        public void IWebCalculator_TestNullObjectHtml()
        {
            IWebCalculator wcalc = new WebHandler();
            IWebCollector wecoll = new WebHandler();
            wecoll.HtmlCode = null;
            string t = "test";
            var results = wcalc.CalculateNumberOfHits(wecoll, t);
            Assert.AreEqual(-1, results);
        }
        // Test works
        [Test]
        public void IWebCalculatorTests_Check_If_Html_String_Is_Empty()
        {
            IWebCalculator wcalc = new WebHandler();
            IWebCollector wecoll = new WebHandler();
            wecoll.HtmlCode = string.Empty;
            string t = "test";
            var results = wcalc.CalculateNumberOfHits(wecoll, t);
            Assert.AreEqual(-1, results);
        }

        // Test works
        [Test]
        public void IWebCalculatorTests_Is_Keyword_string_Empty()
        {
            IWebCalculator wcalc = new WebHandler();
            IWebCollector wecoll = new WebHandler();
            string url = "https://www.aftonbladet.se";
            wecoll.GetHTMLFromUrl(url);
            var results = wcalc.CalculateNumberOfHits(wecoll,keyword: String.Empty);
            Assert.AreEqual(-1, results);
        }
        
        // Test works
        [Test]
        public void IWebCalculatorTests_Is_Keyword_string_null()
        {
            IWebCalculator wcalc = new WebHandler();
            IWebCollector wecoll = new WebHandler();
            string url = "https://www.aftonbladet.se";
            wecoll.GetHTMLFromUrl(url);
            var results = wcalc.CalculateNumberOfHits(wecoll, keyword: null);
            Assert.AreEqual(-1, results);
        }

        // Test works
        [Test]
        public void MoqTest()
        {
            Mock<IWebCollector> moq = new Mock<IWebCollector>();
            IWebCalculator wcalc = new WebHandler();
            moq.Setup(x => x.HtmlCode).Returns("koreakoreakorea");
            string k = "korea";
            var result = wcalc.CalculateNumberOfHits(moq.Object, k);
            Assert.That(result == 3);
        }
    }
}