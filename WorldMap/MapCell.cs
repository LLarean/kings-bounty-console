using KB.WorldMap.Maps;

namespace KB.WorldMap;

public record MapCell
{
    private readonly CellType _cellType;

    public MapCell(CellType cellType)
    {
        _cellType = cellType;
    }

    public string Value()
    {
        return $" {_cellType} ";
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