namespace KB.WorldMaps;

public record MapCell
{
    private readonly CellType _cellType;
    private readonly object? _content;

    public MapCell(CellType cellType, object? content = null)
    {
        _cellType = cellType;
        _content = content;
    }

    public CellType Type() => _cellType;
    
    public object? Content()
    {
        return _content;
    } 
    
    public ConsoleColor Color()
    {
        return _cellType switch {
            CellType.w => ConsoleColor.Blue,
            CellType.g => ConsoleColor.DarkGreen,
            CellType.m => ConsoleColor.DarkGray,
            CellType.s => ConsoleColor.Yellow,
            
            CellType.C => ConsoleColor.White,
            CellType.H => ConsoleColor.Magenta,
            CellType.T => ConsoleColor.DarkYellow,
            CellType.E => ConsoleColor.DarkRed,
            
            CellType.U => ConsoleColor.White,
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}