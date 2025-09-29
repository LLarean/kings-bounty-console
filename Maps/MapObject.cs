using kings_bounty_console.Output;

namespace kings_bounty_console.Maps;

public class MapObject
{
    private readonly IOutput _output;
    private readonly char[,] _mapCells;

    public MapObject(IOutput output, char[,] mapCells)
    {
        _output = output;
        _mapCells = mapCells;
    }
    
    public int Rows => _mapCells.GetLength(0);
    public int Columns => _mapCells.GetLength(1);

    public void Draw()
    {
        for (int row = 0; row < Rows; row++)
        {
            for (int col = 0; col < Columns; col++)
            {
                DrawCell(_mapCells[row, col]);
            }
            _output.WriteLine();
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
    
    private void DrawCell(char cellChar)
    {
        Console.Write("[");
        
        if (Enum.TryParse(cellChar.ToString(), out CellType cellType))
        {
            Console.ForegroundColor = new CellColor(cellType).Value();
        }
        
        Console.Write(cellChar);
        Console.ResetColor();
        Console.Write("]");
    }
}