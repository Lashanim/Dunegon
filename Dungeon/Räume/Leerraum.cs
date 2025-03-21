namespace Dungeon;

class LeererRaum : ARaum
{
    public string Beschreibung { get; set; } = "Dieser Raum ist leer.";
    public override void Betreten(Held held, Welt welt)
    {
        Console.WriteLine(Beschreibung);
    }
}
