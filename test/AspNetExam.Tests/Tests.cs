using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using CenterCLR.Sgml;
using NUnit.Framework;

namespace AspNetExam.Tests
{
    [TestFixture]
    public class Tests
    {
        #region Infrastructures

        private static readonly string baseUrl = "http://localhost:12345";

        private static async Task<XDocument> FetchAsync(string urlPath)
        {
            using (var httpClient = new HttpClient())
            {
                using (var stream = await httpClient.GetStreamAsync(baseUrl + urlPath))
                {
                    return SgmlReader.Parse(stream);
                }
            }
        }
        #endregion

        [Test]
        public async Task Fetch7911101TestAsync()
        {
            var document = await FetchAsync("/Home/Index/7911101");
            Assert.AreEqual(
                "ASP.NET MVC Results",
                document.
                    Element("html").
                    Element("head").
                    Element("title").Value);
            Assert.AreEqual(
                "7911101 - 愛媛県松山市久米窪田町",
                document.
                    Descendants().
                    First(element => (string)element.Attribute("id") == "results").
                    Element("li").Value);
        }
    }
}
