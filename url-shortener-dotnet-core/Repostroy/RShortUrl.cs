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
                var client = new RestClient("https://umuly.com/api/url");
                var request = new RestRequest(Method.POST);
                request.AddHeader("Authorization", "Bearer " + token);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("Content-Type", "application/json");
                request.AddParameter("undefined", "{\"Title\":\"" + shortUrl.Title + "\",\"Description\":\"" + shortUrl.Description + "\",\"Tags\":\"" + shortUrl.Tags + "\",\"DomainId\":\"" + shortUrl.DomainId + "\",\"RedirectUrl\":\"" + shortUrl.RedirectUrl + "\",\"Code\":\"" + shortUrl.Code + "\"\n}", ParameterType.RequestBody);
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

        public ResponseMain MultipleCreateShortUrl(List<ShortUrl> shortUrls)
        {
            ResponseMain rm = null;
            try
            {
                string data = "[";
                foreach (var shortUrl in shortUrls)
                {
                    data += "{\"Title\":\"" + shortUrl.Title + "\",\"Description\":\"" + shortUrl.Description + "\",\"Tags\":\"" + shortUrl.Tags + "\",\"DomainId\":\"" + shortUrl.DomainId + "\",\"RedirectUrl\":\"" + shortUrl.RedirectUrl + "\",\"Code\":\"" + shortUrl.Code + "\"},";
                    
                }
                data += "]";

                var client = new RestClient("https://umuly.com/api/url/MultipleAdd");
                var request = new RestRequest(Method.POST);
                request.AddHeader("Authorization", "Bearer " + token);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("Content-Type", "application/json");
                request.AddParameter("undefined", data, ParameterType.RequestBody);

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
