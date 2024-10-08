using System.Text.Json.Serialization;

public class Weapon
{
    [JsonIncludeAttribute]
    public int Hp;
    [JsonIncludeAttribute]
    public string Name;
}