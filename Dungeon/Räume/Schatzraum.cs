namespace Dungeon;

class Schatzraum : ARaum
{
    public enum Schaetze
    {
        Krone,
        Trank
    }

    private Schaetze? schatz;
    private bool gefunden = false;

    public Schatzraum(Schaetze schatz)
    {
        this.schatz = schatz;
    }

    public override void Betreten(Held held, Welt welt)
    {
        Console.WriteLine("Du hast einen Schatzraum betreten!");
        if (!gefunden && schatz.HasValue)
        {
            held.Rucksack.Add(schatz.Value);
            Console.WriteLine($"{held.Name} hat einen {schatz.Value} gefunden!");
            gefunden = true;
        }
    }
}