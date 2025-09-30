using kings_bounty_console.Maps;
using kings_bounty_console.Output;

namespace kings_bounty_console;

public class Battle
{
    private readonly Hero _hero;
    private readonly Hero _enemy;

    private char[,] _battleField =
    {
        { 'g', 'g', 'g', 'g', 'g', 'g' },
        { 'g', 'g', 'g', 'g', 'g', 'g' },
        { 'g', 'g', 'g', 'g', 'g', 'g' },
        { 'g', 'g', 'g', 'g', 'g', 'g' },
        { 'g', 'g', 'g', 'g', 'g', 'g' },
        { 'g', 'g', 'g', 'g', 'g', 'g' },
    };
    
    public Battle(Hero hero, Hero enemy)
    {
        _hero = hero;
        _enemy = enemy;
    }

    public void Enter()
    {
        SetUnitsToMap();
        var map = new MapObject(new ConsoleOutput(), _battleField);
        
        var canFight = true;

        while (canFight)
        {
            Console.Clear();
            
            var position = new Position(0, 0);
            map.DrawWithActiveCell(position);
            
            var queue = GetQueue();

            foreach (var unit in queue)
            {
                Console.Write($"{unit.Symbol}, ");
            }

            ConsoleKeyInfo command = Console.ReadKey();

            if (command.Key == ConsoleKey.Escape)
            {
                canFight = false;
            }
            
            if (command.Key == ConsoleKey.RightArrow)
            {
                var newPosition = new Position(position.X + 1, position.Y);
                
            }
        }
    }

    private void SetUnitsToMap()
    {
        for (int i = 0; i < _hero.Units.Length; i++)
        {
            _battleField[i, 0] = _hero.Units[i].Symbol;
        }
        
        for (int i = 0; i < _enemy.Units.Length; i++)
        {
            _battleField[i, 5] = _hero.Units[i].Symbol;
        }
    }

    private Queue<Unit> GetQueue()
    {
        Queue<Unit> queue = new();

        foreach (var unit in _hero.Units)
        {
            queue.Enqueue(unit);
        }
        
        foreach (var unit in _enemy.Units)
        {
            queue.Enqueue(unit);
        }
        
        return queue;
    }
}