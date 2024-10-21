using System.Text.Json.Serialization;

public class Weapon
{
    [JsonIncludeAttribute]
    public int DamageMin;
    [JsonIncludeAttribute]
    public int DamageMax;
    [JsonIncludeAttribute]
    public int Damage;
    [JsonIncludeAttribute]
    public string Name;

    public int Attack(){
        return Random.Shared.Next(DamageMin, DamageMax);
    }
}