using System.Text.Json.Serialization;

public class digimon
{
    [JsonPropertyName("name")]
    public string name { get; set; }
    public string level { get; set; }
    public bool is_default { get; set; }
}