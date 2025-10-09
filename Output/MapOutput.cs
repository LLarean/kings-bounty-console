using kings_bounty_console.Maps;

namespace KB.Output;

public static class MapOutput
{
    public static void Write(char[,] value)
    {
        var rows = value.GetLength(0);
        var columns = value.GetLength(1);

        for (int x = 0; x < columns; x++)
        {
            for (int y = 0; y < rows; y++)
            {
                if (Enum.TryParse(value[x, y].ToString(), out CellType cellType))
                {
                    Console.BackgroundColor = new CellColor(cellType).Value();
                }

                Console.Write($" {value[x, y]} ");
                Console.ResetColor();
            }

            Console.WriteLine();
        }
    }
}