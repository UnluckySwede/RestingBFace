using RestSharp;
using System.Text.Json;
using System.Net;

bool running = true;

while (running = true)
{

    Console.WriteLine("What sort of digimon do you wanna know about?");

    string name = Console.ReadLine();

    RestClient digiClient = new("https://digimon-api.vercel.app/api/digimon");
    RestRequest request = new($"name/{name}");
    // RestRequest request1 = new("api/digimon/level/:level");
    RestResponse response = digiClient.GetAsync(request).Result;
    // RestResponse response1 = digiClient.GetAsync(request1).Result;

    if (response.StatusCode == HttpStatusCode.OK)
    {
        digimon d = JsonSerializer.Deserialize<digimon>(response.Content);
        Console.WriteLine(name);
        Console.WriteLine(d.level);
    }
    else
    {
        Console.WriteLine((int)response.StatusCode);
        Console.WriteLine("Couldn't understand ya!");
    }
    Console.ReadLine();
}

Console.ReadLine();
