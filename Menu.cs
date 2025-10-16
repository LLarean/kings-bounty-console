using kings_bounty_console;

namespace KB.General;

public record Menu
{
    public void Enter()
    {
        bool isRunning = true;

        while (isRunning)
        {
            Console.Clear();
            
            Console.WriteLine("Welcome to the Kings Bounty Prototype!\n");
            Console.WriteLine("A - New Game");
            Console.WriteLine("B - Load Game (Not Ready)");
            Console.WriteLine("ESC - Exit");
            
            ConsoleKeyInfo command = Console.ReadKey();
            
            switch (command.Key)
            {
                case ConsoleKey.A:
                    new Game(0).Enter();
                    break;
                case ConsoleKey.Escape:
                    isRunning = false;
                    break;
            }
        }
    }
}