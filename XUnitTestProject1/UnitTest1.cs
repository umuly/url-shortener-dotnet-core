using System;
using Xunit;
using url_shortener_dotnet_core.Interface;
using url_shortener_dotnet_core.Model.Request;
using url_shortener_dotnet_core.Repostroy;
using System.Collections.Generic;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        readonly RShortUrl rShortUrl;

        public UnitTest1()
        {
            this.rShortUrl = new RShortUrl();
        }

        [Fact]
        public void SingleCreateShortUrlTest()
        {
            ShortUrl shortUrl = new ShortUrl
            {
                Code = null,
                Description = null,
                RedirectUrl = "http://mydomain.com",
                Tags = null,
                Title = null,
                DomainId = null
            };

            var result = Record.Exception(() => rShortUrl.SingleCreateShortUrl(shortUrl));
        }
        [Fact]
        public void MultipleCreateShortUrlTest()
        {
            List<ShortUrl> shortUrls = new List<ShortUrl>();
            ShortUrl shortUrl = new ShortUrl
            {
                Code = null,
                Description = null,
                RedirectUrl = "http://mydomain.com",
                Tags = null,
                Title = null,
                DomainId = null
            };
            shortUrls.Add(shortUrl);
            ShortUrl shortUrl1 = new ShortUrl
            {
                Code = null,
                Description = null,
                RedirectUrl = "http://mydomain2.com",
                Tags = null,
                Title = null,
                DomainId = null
            };
            shortUrls.Add(shortUrl1);
            ShortUrl shortUrl2 = new ShortUrl
            {
                Code = null,
                Description = null,
                RedirectUrl = "http://mydomain3.com",
                Tags = null,
                Title = null,
                DomainId = null
            };
            shortUrls.Add(shortUrl2);

            var result = Record.Exception(() => rShortUrl.MultipleCreateShortUrl(shortUrls));
        }
    }
}
