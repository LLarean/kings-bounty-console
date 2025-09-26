namespace kings_bounty_console;

public class Hero
{
    private Position _position;

    public Hero(Position position)
    {
        _position = position;
    }
    
    public Position Position => _position;
}