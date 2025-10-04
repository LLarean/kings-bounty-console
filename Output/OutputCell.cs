namespace kings_bounty_console.Maps;

public record OutputCell
{
    private readonly char _symbol;
    private readonly ConsoleColor _color;

    public OutputCell(char symbol, ConsoleColor color)
    {
        _symbol = symbol;
        _color = color;
    }
    
    public Char Symbol => _symbol;
    public ConsoleColor Color => _color;
}