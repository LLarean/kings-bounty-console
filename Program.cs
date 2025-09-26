using kings_bounty_console;
using kings_bounty_console.Maps;

char[,] map =
{
    { 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w' },
    { 'w', 'g', 'g', 'g', 'g', 'm', 'g', 'g', 'g', 'w' },
    { 'w', 'C', 'g', 'g', 'g', 'm', 'g', 'T', 'g', 'w' },
    { 'w', 'g', 'g', 'w', 'g', 'm', 'g', 'g', 'g', 'w' },
    { 'w', 'g', 'g', 'g', 'C', 'w', 'g', 'g', 'g', 'w' },
    { 'w', 'g', 'g', 'g', 'H', 'g', 'g', 'g', 'g', 'w' },
    { 'w', 'g', 'w', 'g', 'g', 'g', 'g', 'w', 'E', 'w' },
    { 'w', 'g', 'g', 'g', 's', 's', 'g', 'g', 'g', 'w' },
    { 'w', 'E', 'g', 'g', 's', 's', 'g', 'g', 'g', 'w' },
    { 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w' },
};

var startHeroPosition = new Position(5, 5); 
var hero = new Hero(new Position(startHeroPosition.X, startHeroPosition.Y));

map[hero.Position.X, hero.Position.Y] = 'H';

bool isRunning = true;

while (isRunning)
{
    new Map(map, startHeroPosition).Draw();
    
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
