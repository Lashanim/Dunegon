namespace Dungeon;
class ZielRaum : ARaum
{
    public override void Betreten(Held held, Welt welt)
    {
        Console.WriteLine("Ausgang erreicht!");
        Console.WriteLine($"Glückwunsch {held.Name}");
        Console.WriteLine($"Gratulation: {welt.Name} - Ziel erreicht!");
    }
}