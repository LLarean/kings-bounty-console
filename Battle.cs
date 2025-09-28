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

            ConsoleKeyInfo command = Console.ReadKey();

            if (command.Key == ConsoleKey.Escape)
            {
                canFight = false;
            }
            
        }
    }

    private void SetUnitsTemp()
    {
        _battleField[0, 0] = 'U';
        _battleField[1, 0] = 'U';
        _battleField[2, 0] = 'U';
        _battleField[3, 0] = 'U';
        
        _battleField[0, 5] = 'U';
        _battleField[1, 5] = 'U';
        _battleField[2, 5] = 'U';
        _battleField[3, 5] = 'U';
    }
}