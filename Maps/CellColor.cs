namespace kings_bounty_console.Maps;

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
            CellType.w => ConsoleColor.DarkBlue,
            CellType.g => ConsoleColor.DarkGreen,
            CellType.m => ConsoleColor.DarkGray,
            CellType.s => ConsoleColor.DarkYellow,
            
            CellType.C => ConsoleColor.Cyan,
            CellType.H => ConsoleColor.Magenta,
            CellType.T => ConsoleColor.Yellow,
            CellType.E => ConsoleColor.Red,
            
            CellType.U => ConsoleColor.White,
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}