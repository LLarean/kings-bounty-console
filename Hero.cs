using kings_bounty_console.Maps;

namespace kings_bounty_console;

public class Hero : ICell
{
    private Position _position;
    private int _gold;
    private Unit[] _units = [new Peasant(), new Archer()];

    public Hero(Position position)
    {
        _position = position;
    }
    
    public Position Position => _position;
    public int Gold => _gold;
    public Unit[] Units => _units;
    
    public void Output()
    {
        Console.BackgroundColor = new CellColor(CellType.H).Value();
        Console.Write($" {CellType.H} ");
        Console.ResetColor();
    }
}