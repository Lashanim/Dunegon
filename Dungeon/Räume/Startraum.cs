namespace Dungeon;

class StartRaum : ARaum
{
    public override void Betreten(Held held, Welt welt)
    {
        held.Standort = this;
        Console.WriteLine($"Hallo {held.Name} - Willkommen in der Welt {welt.Name}");
    }
}