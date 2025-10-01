namespace kings_bounty_console.Maps;

public static class CellColor
{
    public static ConsoleColor Value(CellType cellType)
    {
        return cellType switch {
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