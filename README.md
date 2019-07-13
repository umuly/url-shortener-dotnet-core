# url-shortener-dotnet-core

<b>Umuly Shortener Api Documantation</b>
<br>
http://um.lk/umuly-postman
<br><br>

<b>Pratice Codes</b><br>

<b>Single Create Short Url</b>

    ShortUrl shortUrl = new ShortUrl
    {
        Code = null,
        Description = null,
        RedirectUrl = "http://mydomain.com",
        Tags = null,
        Title = null,
        DomainId = null
    };
    
    var client = new RestClient("https://umuly.com/api/url");<br>
    var request = new RestRequest(Method.POST);<br>
    request.AddHeader("Authorization", "Bearer " + token);<br>
    request.AddHeader("cache-control", "no-cache");<br>
    request.AddHeader("Content-Type", "application/json");<br>
    request.AddParameter("undefined", "{\"Title\":\"" + shortUrl.Title + "\",\"Description\":\"" + shortUrl.Description + "\",\"Tags\":\"" + shortUrl.Tags + "\",\"DomainId\":\"" + shortUrl.DomainId + "\",\"RedirectUrl\":\"" + shortUrl.RedirectUrl + "\",\"Code\":\"" + shortUrl.Code + "\"\n}", ParameterType.RequestBody);<br>
    IRestResponse response = client.Execute(request);<br>
    var content = response.Content; 

<b>Multiple Create Short Url</b>

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
    var content = response.Content; 
    
