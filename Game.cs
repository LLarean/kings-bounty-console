using KB.General;
using KB.General.Maps;
using KB.Input;
using KB.Output;
using KB.WorldMaps;

namespace kings_bounty_console;

public class Game
{
    private char[,] _worldMap =
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

    private readonly int _levelCount;

    public Game(int levelCount)
    {
        _levelCount = levelCount;
    }

    public void Enter()
    {
        bool isRunning = true;

        MapObjects mapObjects = new MapObjects(0);

        var map = new Map(_worldMap);
        var hero = new Hero(map.HeroPosition());

        var turn = 1;
        var gold = 100;


        while (isRunning)
        {
            Console.Clear();
            MapOutput.Write(_worldMap);
            Console.WriteLine($"\nGold: {gold}, Turn: {turn}");

            ConsoleKeyInfo command = Console.ReadKey();

            if (command.Key == ConsoleKey.Escape)
            {
                isRunning = false;
            }

            // var commandType = new Command(command.Key).Type();

            var newPosition = map.HeroPosition();

            // if (commandType == CommandType.Esc)
            // {
            //     isRunning = false;
            // }

            // if (commandType == CommandType.Move)
            // {
            //     // TODO
            // }

            newPosition = new NewPosition(command.Key).Value(newPosition);

            if (command.Key == ConsoleKey.UpArrow)
            {
                newPosition = new Position(newPosition.X - 1, newPosition.Y);
            }

            if (command.Key == ConsoleKey.DownArrow)
            {
                newPosition = new Position(newPosition.X + 1, newPosition.Y);
            }

            if (command.Key == ConsoleKey.RightArrow)
            {
                newPosition = new Position(newPosition.X, newPosition.Y + 1);
            }

            if (command.Key == ConsoleKey.LeftArrow)
            {
                newPosition = new Position(newPosition.X, newPosition.Y - 1);
            }

            // var canInteract = map.CanInteract(newPosition);
            // var canMove = map.CanMove(newPosition);
            var cellType = map.GetCellTypeByPosition(newPosition);

            if (cellType.ToString() == nameof(CellType.g) ||
                cellType.ToString() == nameof(CellType.s))
            {
                map = map.MoveHero(newPosition);
            }
            else if (cellType.ToString() == nameof(CellType.T))
            {
                Console.Clear();
                gold += 100;
                Console.WriteLine("+100 Gold");
                Console.ReadKey();

                map = map.MoveHero(newPosition);
            }
            else if (cellType.ToString() == nameof(CellType.C))
            {
                new City(hero).Enter();
            }
            else if (cellType.ToString() == nameof(CellType.E))
            {
                new Battle(hero, new Hero(newPosition)).Enter();
            }

            turn++;
        }
    }
}