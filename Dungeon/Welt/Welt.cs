namespace Dungeon;

class Welt
{
    public string Name { get; private set; }
    public ARaum StartRaum { get; private set; }
        
    public Welt(string name)
    {
        Name = name;
    }
        
    public void Erschaffen()
    {
        StartRaum  = new StartRaum();
        LeererRaum leererRaum = new LeererRaum();
        ZielRaum zielRaum = new ZielRaum();
        FallenRaum fallenRaum = new FallenRaum();
        Schatzraum schatzraum = new Schatzraum(Schatzraum.Schaetze.Krone);
            
        StartRaum.Norden = leererRaum;
        leererRaum.Sueden = StartRaum;
        leererRaum.Norden = fallenRaum;
        fallenRaum.Norden = zielRaum;
        zielRaum.Sueden = fallenRaum;
        fallenRaum.Sueden = leererRaum;
        leererRaum.Westen = schatzraum;
        schatzraum.Osten = leererRaum;
    }
        
    public void Enter(Held held)
    {
        held.Welt = this;
        StartRaum.Betreten(held, this);
    }
}