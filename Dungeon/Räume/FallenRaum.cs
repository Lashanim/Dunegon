namespace Dungeon;

class FallenRaum : ARaum
{
    public int Schaden { get; set; } = 20;
    public override void Betreten(Held held, Welt welt)
    {
        held.Leben -= Schaden;
        Console.WriteLine($"FALLE! {held.Name} nimmt Schaden {Schaden}.");
    }
}