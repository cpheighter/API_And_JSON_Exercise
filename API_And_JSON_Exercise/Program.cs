using Newtonsoft.Json.Linq;

var client1 = new HttpClient();
var kanyeURL = "https://api.kanye.rest";
var kanyeResponse = client1.GetStringAsync(kanyeURL).Result;

var client2 = new HttpClient();
var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
var ronResponse = client2.GetStringAsync(ronURL).Result;

for (int i = 0; i < 5; i++)
{
    var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
    Console.WriteLine(ronQuote);
    var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
    Console.WriteLine(kanyeQuote);
}