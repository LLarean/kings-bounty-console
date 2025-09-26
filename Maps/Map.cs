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
    
    private char[,] _map =
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

    public void Show(Position heroPosition)
    {
        Console.Clear();
        int rows = _map.GetUpperBound(0) + 1;
        int columns = _map.Length / rows;

        for (int x = rows - 1; x >= 0; x--)
        {
            for (int y = columns - 1; y >= 0; y--)
            {
                Console.Write("[");

                // if (heroPosition.X == x && heroPosition.Y == y)
                // {
                //     Console.ForegroundColor = ConsoleColor.Magenta;
                // }
                // else
                // {
                    switch (_map[x, y])
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
                // }


                // if (heroPosition.X == x && heroPosition.Y == y)
                // {
                //     Console.Write('K');
                // }
                // else
                // {
                    Console.Write(_map[x, y]);
                // }


                Console.ResetColor();
                Console.Write("]");
            }

            Console.WriteLine();
        }
    }
}