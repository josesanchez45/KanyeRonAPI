using Newtonsoft.Json.Linq;

internal class QuoteGenerator
{
    public void KanyeQuote()
    {
        var kanyeClient = new HttpClient();
        var kanyeApi = "https://api.kanye.rest";

        var kanyeResponse = kanyeClient.GetStringAsync(kanyeApi).Result;
        var kanyeObject = JObject.Parse(kanyeResponse);
        Console.WriteLine($"Kayne: {kanyeObject["quote"]}");
    }
    public void RonQuote()
    {
        var ronClient = new HttpClient();
        var ronApi = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
        var ronResponse = ronClient.GetStringAsync(ronApi).Result;
        var ronObject = JArray.Parse(ronResponse);
        Console.WriteLine($"Ron: {ronObject[0]} ");

    }
}