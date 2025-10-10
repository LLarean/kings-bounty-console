namespace KB.WorldMap.Maps;

public record CellColor
{
    private readonly CellType _cellType;

    public CellColor(CellType cellType)
    {
        _cellType = cellType;
    }
    
    public ConsoleColor Value()
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