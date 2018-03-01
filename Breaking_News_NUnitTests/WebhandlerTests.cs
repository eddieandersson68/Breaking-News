using Breaking_News;
using NUnit.Framework;
using System;


namespace Breaking_News_NUnitTests
{
    [TestFixture]
    public class WebHandler_Tests
    {
        // Test works Check_If_Url_Is_Null_Or_Empty
        [Test ]
        public void WebHandler_Tests_GetHtmlFromUrl_Check_If_Url_Is_Null_Or_Empty()
        {
            Assert.Catch<ArgumentException>(GetHtmlFromUrl_Url_Is_Null_Or_Empry);
        }

        // Test works Check for Url_missing_"http://"
        [Test]
        public void WebHandler_Tests_GetHtmlFromUrl_Url_missing_http()
        {
            Assert.Catch<ArgumentException>(UrlDoesNotContainHttp);
        }

        // Test works Check if a valid Url is passed
        [Test]
        public void  WebHandler_Tests_GetHtmlFromUrl_ValidUrl()
        {
            var wh = new WebHandler();
            string url = "https://www.aftonbladet.se";
            wh.GetHTMLFromUrl(url);
            Assert.IsTrue(url.Contains("https://"));
        }
      
        // Test Method Works
        public void GetHtmlFromUrl_Url_Is_Null_Or_Empry()
        {
            var wh = new WebHandler();
            string nullObject = null;
            wh.GetHTMLFromUrl(nullObject);
            string empty = String.Empty;
            wh.GetHTMLFromUrl(empty);
        }
        // Test Method Works
        public void UrlDoesNotContainHttp()
        {
            var wh = new WebHandler();
            string url = "www.aftonbladet.se";
            wh.GetHTMLFromUrl(url);
        }
    }
}