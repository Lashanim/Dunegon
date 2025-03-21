using Dungeon;
namespace Dungeon;
class Program
{
    static void Main()
    {
        Held hoelenforscher = new Held("Heimo");
        Welt dungeon = new Welt("Dungeon");
        dungeon.Erschaffen();
        dungeon.Enter(hoelenforscher);
        
        
        string eingabe;
        do
        {
            Console.WriteLine("Wohin möchtest du gehen? (Norden, Osten, Süden, Westen, Ende)");
            eingabe = Console.ReadLine();
            if (eingabe.ToLower() != "ende")
            {
                hoelenforscher.Bewegen(eingabe);
            }
        } while (eingabe.ToLower() != "ende");
    }
}

