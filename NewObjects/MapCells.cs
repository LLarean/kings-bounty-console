namespace KB.Output;

public record MapCells
{
    private readonly ConsoleCell[,] _consoleCells;

    public MapCells(ConsoleCell[,] consoleCells)
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
                Console.Write(_consoleCells[x, y].Value());
                Console.ResetColor();
            }

            Console.WriteLine();
        }
    }
}