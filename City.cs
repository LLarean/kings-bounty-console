namespace kings_bounty_console;

public class City
{
    private readonly Hero _hero;

    public City(Hero hero)
    {
        _hero = hero;
    }
    
    public void Enter()
    {
        var isInside = true;
        
        while (isInside)
        {
            Console.Clear();
            Console.WriteLine("City");
            Console.WriteLine("Press 'ESC' to exit");
            
            Console.WriteLine("A) Get New Contract");
            Console.WriteLine("B) Cancel boat rentel");
            Console.WriteLine("C) Gather Information");
            Console.WriteLine("D) Fireball spell (1500)");
            Console.WriteLine("E) Biy seige weapons (3000)");
            
            ConsoleKeyInfo command = Console.ReadKey();

            if (command.Key == ConsoleKey.Escape)
            {
                isInside = false;
            }
            else if (command.Key == ConsoleKey.A)
            {
                RecruitSoldiers();
            }
            else if (command.Key == ConsoleKey.B)
            {
                Console.Clear();
                Console.WriteLine("You don't have any money!");
                Console.ReadKey();
            }
            else if (command.Key == ConsoleKey.C)
            {
                Console.Clear();
                Console.WriteLine("You don't have any money!");
                Console.ReadKey();
            }
            else if (command.Key == ConsoleKey.D)
            {
                Console.Clear();
                Console.WriteLine("You don't have any money!");
                Console.ReadKey();
            }
            else if (command.Key == ConsoleKey.E)
            {
                Console.Clear();
                Console.WriteLine("You don't have any money!");
                Console.ReadKey();
            }
        }
    }

    private void RecruitSoldiers()
    {
        Console.Clear();
                
        if (_hero.Gold != 0)
        {
            Console.WriteLine("You hired soldiers!");
        }
        else
        {
            Console.WriteLine("You don't have any money!");
        }
        
        Console.ReadKey();
    }
}