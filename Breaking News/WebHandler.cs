using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace Breaking_News
{
    public class WebHandler : IWebCollector, IWebCalculator
    {
        public string HtmlCode { get; set; }
        public int Count = 0;
        //public List<string> NewsSourceslist = new List<string>();

        public void GetHTMLFromUrl(string url)
        {
            //// Check for URL = Null Or Empty
            if (string.IsNullOrEmpty(url) || url == null)
                throw new ArgumentException("String is null or empty");

            //// Check for URL missing "http://"
            if (!url.Contains("https://") || url.Contains("http://"))
                throw new ArgumentException("Missing https or http");
            if (url.Contains("Https"))
                using (var clinet = new WebClient())
                {
                    HtmlCode = clinet.DownloadString(url).ToLower();
                }

            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            HtmlCode = client.DownloadString(url);
        }

        public int CalculateNumberOfHits(IWebCollector webColl, string keyword)
        {
            if (string.IsNullOrEmpty(webColl.HtmlCode)|| webColl == null || string.IsNullOrEmpty(keyword))
                return -1;

            MatchCollection collection = Regex.Matches(webColl.HtmlCode, keyword, RegexOptions.IgnoreCase);
            return collection.Count;
        }
    }
}