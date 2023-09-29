namespace DotNet7_Web_Course.Models;

public class Character
{
    public int Id { get; set; }
    
    static int nextId;
    public Character() {
        Id = Interlocked.Increment(ref nextId);
    }

    public string Name { get; set; } = "Frodo";

    public int HitPoints { get; set; } = 100;

    public int Strength { get; set; } = 10;

    public int Defense { get; set; } = 10;

    public int Intelligence { get; set; } = 10;

    public Rpg Class { get; set; } = Rpg.Knight;
}