namespace kings_bounty_console;

public class Hero
{
    private Position _position;
    private int _gold;

    public Hero(Position position)
    {
        _position = position;
    }
    
    public Position Position => _position;
    public int Gold => _gold;
}