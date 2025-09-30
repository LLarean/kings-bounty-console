using kings_bounty_console.Maps;

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
        SetUnitsTemp();
        var map = new Map(_battleField);
        
        var canFight = true;

        while (canFight)
        {
            map.Draw();
            
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
            
        }
    }

    private void SetUnitsTemp()
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