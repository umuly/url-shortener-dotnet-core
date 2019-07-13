using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using url_shortener_dotnet_core.Interface;
using url_shortener_dotnet_core.Model.Request;
using url_shortener_dotnet_core.Model.Response;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace url_shortener_dotnet_core.Repostroy
{
    public class RShortUrl : IShortUrl
    {
        string token = "";
        public ResponseMain SingleCreateShortUrl(ShortUrl shortUrl)
        {
            ResponseMain rm = new ResponseMain();
            try
            {
                //var client = new RestClient("https://localhost:44390/api/url");
                var client = new RestClient("https://umuly.com/api/url");
                var request = new RestRequest(Method.POST);
                request.AddHeader("Authorization", "Bearer " + token);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("Content-Type", "application/json");
                request.AddParameter("undefined", "{\n\t\"Title\":\"" + shortUrl.Title + "\",\n\t\"Description\":\"" + shortUrl.Description + "\",\n\t\"Tags\":\"" + shortUrl.Tags + "\",\n\t\"DomainId\":\"" + shortUrl.DomainId + "\",\n\t\"RedirectUrl\":\"" + shortUrl.RedirectUrl + "\",\n\t\"Code\":\"" + shortUrl.Code + "\"\n}", ParameterType.RequestBody);
                
                //request.AddParameter("undefined", "{\n\t\"Title\":null,\n\t\"Description\":null,\n\t\"Tags\":null,\n\t\"DomainId\":null,\n\t\"RedirectUrl\":\"http://mysite.com\",\n\t\"Code\":null\n}", ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                var content = response.Content; // raw content as string

                rm = JsonConvert.DeserializeObject<ResponseMain>(content);
                return rm;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
