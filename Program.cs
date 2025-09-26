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
var hero = new Hero(new Position(map.HeroPosition().X, map.HeroPosition().Y));

bool isRunning = true;

while (isRunning)
{
    map.Draw();
    ConsoleKeyInfo command = Console.ReadKey();

    if (command.Key == ConsoleKey.Escape)
    {
        isRunning = false;
    }

    var newPosition = hero.Position;
    
    if (command.Key == ConsoleKey.UpArrow)
    {
        newPosition = new Position(hero.Position.X, hero.Position.Y + 1);
    }
    
    if (command.Key == ConsoleKey.DownArrow)
    {
        newPosition = new Position(hero.Position.X, hero.Position.Y - 1);
    }
    
    if (command.Key == ConsoleKey.RightArrow)
    {
        newPosition = new Position(hero.Position.X + 1, hero.Position.Y);
    }
    
    if (command.Key == ConsoleKey.LeftArrow)
    {
        newPosition = new Position(hero.Position.X - 1, hero.Position.Y);
    }

    if (map.CanMove(newPosition))
    {
        map = map.MoveHero(newPosition);
    }
}

Console.ReadKey();