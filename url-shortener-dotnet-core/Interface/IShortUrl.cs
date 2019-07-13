using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using url_shortener_dotnet_core.Model.Request;
using url_shortener_dotnet_core.Model.Response;

namespace url_shortener_dotnet_core.Interface
{
    public interface IShortUrl
    {
        ResponseMain SingleCreateShortUrl(ShortUrl shortUrl);
    }
}
