namespace kings_bounty_console.Maps;

public class MapObject
{
    private readonly char[,] _mapCells;

    public MapObject(char[,] mapCells)
    {
        _mapCells = mapCells;
    }
    
    public int Rows => _mapCells.GetLength(0);
    public int Columns => _mapCells.GetLength(1);

    public void DrawWithActiveCell(Position activeCell)
    {
        for (int row = 0; row < Rows; row++)
        {
            for (int col = 0; col < Columns; col++)
            {
                var isActive = row == activeCell.X && col == activeCell.Y;
                DrawCell(_mapCells[row, col], isActive);
            }
            Console.WriteLine();
        }
    }

    public void Draw()
    {
        for (int row = 0; row < Rows; row++)
        {
            for (int col = 0; col < Columns; col++)
            {
                DrawCell(_mapCells[row, col]);
            }
            Console.WriteLine();
        }
    }
    
    public Position? FindPositionByType(char cellType)
    {
        for (int row = Rows - 1; row >= 0; row--)
        {
            for (int col = Columns - 1; col >= 0; col--)
            {
                if (_mapCells[row, col] == cellType)
                {
                    return new Position(row, col);
                }
            }
        }
        
        return null;
    }
    
    public char? GetCellTypeByPosition(Position position)
    {
        if (!IsValidPosition(position)) return null;
            
        return _mapCells[position.X, position.Y];
    }
    
    public bool IsValidPosition(Position position)
    {
        return position.X >= 0 && position.X < Rows && 
               position.Y >= 0 && position.Y < Columns;
    }
    
    private void DrawCell(char cellChar, bool isActive = false)
    {
        if (isActive == true)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("[");
            
            Console.ResetColor();
        }
        else
        {
            Console.Write("[");
        }
        
        if (Enum.TryParse(cellChar.ToString(), out CellType cellType))
        {
            Console.ForegroundColor = CellColor.Value(cellType);
        }
        
        Console.Write(cellChar);
        Console.ResetColor();
        
        if (isActive == true)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("]");
            Console.ResetColor();
        }
        else
        {
            Console.Write("]");
        }
    }
}