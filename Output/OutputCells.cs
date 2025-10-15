using KB.General.Maps;
using KB.WorldMaps;

namespace KB.Output;

public record OutputCells
{
    private readonly OutputCell[,] _cells;
    
    public OutputCells(OutputCell[,] cells)
    {
        _cells = cells;
    }
    
    public void Draw()
    {
        var rows = _cells.GetLength(0);
        var columns = _cells.GetLength(1);
        
        for (int x = 0; x < columns; x++)
        {
            for (int y = 0; y < rows; y++)
            {
                if (Enum.TryParse(_cells[x, y].ToString(), out CellType cellType))
                {
                    Console.BackgroundColor = new CellColor(cellType).Value();
                }

                Console.Write(" " + _cells[x, y] + " ");
                Console.ResetColor();
            }

            Console.WriteLine();
        }
    }
}