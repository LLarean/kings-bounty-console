using kings_bounty_console;
using kings_bounty_console.Maps;

char[,] content =
{
    { 'C', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w' },
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

var map = new Map(content);
bool isRunning = true;

while (isRunning)
{
    map.Draw();
    ConsoleKeyInfo command = Console.ReadKey();

    if (command.Key == ConsoleKey.Escape)
    {
        isRunning = false;
    }

    var heroPosition = map.HeroPosition();
    
    if (command.Key == ConsoleKey.UpArrow)
    {
        heroPosition = new Position(heroPosition.X, heroPosition.Y - 1);
    }
    
    if (command.Key == ConsoleKey.DownArrow)
    {
        heroPosition = new Position(heroPosition.X, heroPosition.Y + 1);
    }
    
    if (command.Key == ConsoleKey.RightArrow)
    {
        heroPosition = new Position(heroPosition.X + 1, heroPosition.Y);
    }
    
    if (command.Key == ConsoleKey.LeftArrow)
    {
        heroPosition = new Position(heroPosition.X - 1, heroPosition.Y);
    }

    if (map.CanMove(heroPosition))
    {
        map = map.MoveHero(heroPosition);
    }
    
}

Console.ReadKey();