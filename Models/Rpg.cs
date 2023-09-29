using System.Text.Json.Serialization;

namespace DotNet7_Web_Course.Models;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Rpg
{
    Knight = 1,
    Mage = 2,
    Cleric = 3
}