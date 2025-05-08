namespace Dungeon;

class GameController
{
    private Welt welt;
    private Held held;

    public GameController()
    {
        held = new Held("Heimo");
        welt = new Welt("Dungeon");
        welt.Erschaffen();
        welt.Enter(held);
    }
    public void Run()
    {
        while (held.IsAlive())
        {
            Console.WriteLine("Wohin möchtest du gehen? (W, A, S, D, Q zum Beenden)");
            ConsoleKeyInfo eingabe = Console.ReadKey();
            Console.WriteLine();

            if (eingabe.Key == ConsoleKey.Q)
            {
                Console.WriteLine("Spiel beendet!");
                break;
            }

          
        }
    }
}
