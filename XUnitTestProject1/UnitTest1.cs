using System;
using Xunit;
using url_shortener_dotnet_core.Interface;
using url_shortener_dotnet_core.Model.Request;
using url_shortener_dotnet_core.Repostroy;

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
        public void Test1()
        {
            ShortUrl shortUrl = new ShortUrl
            {
                Code = null,
                Description = null,
                RedirectUrl = "http://mydomain.com",
                Tags = null,
                Title = null,
                DomainId = null
                //DomainId = "5c86c23c94a40b0ed0e644c9"
            };

            var result = Record.Exception(() => rShortUrl.SingleCreateShortUrl(shortUrl));
            //Assert.NotNull(result);
            //var exception = Assert.IsType<ArgumentNullException>(result);
            //var actual = exception.ParamName;
            //const string expected = "culture";
            //Assert.Equal(expected, actual);
        }
    }
}
