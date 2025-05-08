namespace Dungeon;

class Held : IMoveable
{
    public string Name { get; private set; }
    public int Leben { get; set; } = 100;
    public ARaum Standort { get; set; } 
    public Welt Welt { get; set; }
    public List<Schatzraum.Schaetze> Rucksack { get; private set; } = new List<Schatzraum.Schaetze>(); //nur held darf ihn verändern

    public Held(string name)
    {
        Name = name;
    }
    public bool IsAlive()
    {
        return Leben > 0;
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
    public void Move(IMoveable.ERichtung richtung)
        {
        switch (richtung)
        {
        case IMoveable.ERichtung.EForward: Bewegen("norden");
            break;
        case IMoveable.ERichtung.EBackward: Bewegen("sueden"); 
            break;
        case IMoveable.ERichtung.ERight: Bewegen("osten"); 
            break;
        case IMoveable.ERichtung.ELeft: Bewegen("westen"); 
            break;
        default: Console.WriteLine("Ungültige Bewegung!"); 
            break;
        }
    }
}