namespace kings_bounty_console.Maps;

public class Map
{
    private enum CellType
    {
        Water,
        Ground,
        Mountain,
        Sand,
        City,
    }
    
    
    char[,] numbers =
    {
        { 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w' },
        { 'w', 'g', 'g', 'g', 'g', 'w', 'g', 'g', 'g', 'w' },
        { 'w', 'g', 'g', 'g', 'g', 'w', 'g', 'g', 'g', 'w' },
        { 'w', 'g', 'g', 'g', 'g', 'w', 'g', 'g', 'g', 'w' },
        { 'w', 'g', 'g', 'g', 'g', 'w', 'g', 'g', 'g', 'w' },
        { 'w', 'g', 'g', 'g', 'g', 'w', 'g', 'g', 'g', 'w' },
        { 'w', 'g', 'g', 'g', 'g', 'w', 'g', 'g', 'g', 'w' },
        { 'w', 'g', 'g', 'g', 'g', 'w', 'g', 'g', 'g', 'w' },
        { 'w', 'g', 'g', 'g', 'g', 'w', 'g', 'g', 'g', 'w' },
        { 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w' },
    };

    public void Show()
    {
        int rows = numbers.GetUpperBound(0) + 1;
        int columns = numbers.Length / rows;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write("[");

                switch (numbers[i, j])
                {
                    case 'w':
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        break;
                    case 'g':
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        break;
                    case 'm':
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        break;
                    case 's':
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        break;
                    default:
                        break;
                }

                Console.Write(numbers[i, j]);
                Console.ResetColor();
                Console.Write("]");
            }

            Console.WriteLine();
        }
    }
}