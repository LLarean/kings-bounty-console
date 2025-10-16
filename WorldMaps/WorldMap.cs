using KB.General;

namespace KB.WorldMaps;

public record WorldMap
{
    private readonly MapCell[,] _consoleCells;

    public WorldMap(MapCell[,] consoleCells)
    {
        _consoleCells = consoleCells;
    }

    public void Output()
    {
        var rows = _consoleCells.GetLength(0);
        var columns = _consoleCells.GetLength(1);

        for (int x = 0; x < columns; x++)
        {
            for (int y = 0; y < rows; y++)
            {
                Console.BackgroundColor = _consoleCells[x, y].Color();
                Console.Write($" {_consoleCells[x, y].Type()} ");
                Console.ResetColor();
            }

            Console.WriteLine();
        }
    }

    public MapCell GetMapCell(Position position)
    {
        return _consoleCells[position.X, position.Y];;
    }
}