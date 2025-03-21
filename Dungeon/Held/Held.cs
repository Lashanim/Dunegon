namespace Dungeon;

class Held
{
    public string Name { get; private set; }
    public int Leben { get; set; } = 100;
    public ARaum Standort { get; set; }
    public Welt Welt { get; set; }

    public Held(string name)
    {
        Name = name;
    }

    public void Bewegen(string richtung)
    {
        ARaum neuerRaum = null;
        switch (richtung.ToLower())
        {
            case "norden": neuerRaum = Standort.Norden; break;
            case "osten": neuerRaum = Standort.Osten; break;
            case "sueden": neuerRaum = Standort.Sueden; break;
            case "westen": neuerRaum = Standort.Westen; break;
            default: Console.WriteLine("Ungültige Richtung!"); return;
        }
        
        if (neuerRaum != null)
        {
            neuerRaum.Betreten(this, Welt);
            Standort = neuerRaum;
        }
        else
        {
            Console.WriteLine("Dort ist eine Wand!");
        }
    }
}