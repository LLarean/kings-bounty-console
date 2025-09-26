namespace kings_bounty_console;

public class Position
{
    private readonly int _x;
    private readonly int _y;

    public Position(int x, int y)
    {
        _x = x;
        _y = y;
    }
    
    public int X => _x;
    
    public int Y => _y;
}