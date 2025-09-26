// See https://aka.ms/new-console-template for more information

using kings_bounty_console;
using kings_bounty_console.Maps;

var startHeroPosition = new Position(5, 5); 
var hero = new Hero(new Position(startHeroPosition.X, startHeroPosition.Y));

bool isRunning = true;

while (isRunning)
{
    new Map().Show(hero.Position);
    
    ConsoleKeyInfo command = Console.ReadKey();

    if (command.Key == ConsoleKey.Escape)
    {
        isRunning = false;
    }
    
    // if (command.Key == ConsoleKey.UpArrow)
    // {
    //     if (hero.Position.Y < 10)
    //     {
    //         heroPosition[0]++;
    //     }
    // }
    //
    // if (command.Key == ConsoleKey.DownArrow)
    // {
    //     if (heroPosition[0] > 0)
    //     {
    //         heroPosition[0]--;
    //     }
    // }
    //
    // if (command.Key == ConsoleKey.RightArrow)
    // {
    //     if (heroPosition[1] < 10)
    //     {
    //         heroPosition[1]++;
    //     }
    // }
    //
    // if (command.Key == ConsoleKey.LeftArrow)
    // {
    //     if (heroPosition[1] > 0)
    //     {
    //         heroPosition[1]--;
    //     }
    // }
    
    
}

Console.ReadKey();
