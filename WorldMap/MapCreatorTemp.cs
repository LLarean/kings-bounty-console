using KB.WorldMap.Maps;

namespace KB.WorldMap;

public class MapCreatorTemp
{
    private readonly char[,] _worldMap;

    public MapCreatorTemp(char[,] worldMap)
    {
        _worldMap = worldMap;
    }

    public void Create()
    {
        var rows = _worldMap.GetLength(0);
        var columns = _worldMap.GetLength(1);

        MapCell[,] consoleCells = new MapCell[columns, rows];

        for (int x = 0; x < columns; x++)
        {
            for (int y = 0; y < rows; y++)
            {
                if (Enum.TryParse(_worldMap[x, y].ToString(), out CellType cellType))
                {
                    consoleCells[x, y] = new MapCell(cellType);
                }
            }
        }


        new MapCells(consoleCells).Output();
    }
}