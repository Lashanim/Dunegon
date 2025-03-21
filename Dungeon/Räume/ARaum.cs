namespace Dungeon;

abstract class ARaum
{
    public ARaum Norden { get; set; }
    public ARaum Osten { get; set; }
    public ARaum Sueden { get; set; }
    public ARaum Westen { get; set; }
    public abstract void Betreten(Held held, Welt welt);
}