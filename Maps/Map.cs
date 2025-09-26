namespace kings_bounty_console.Maps;

public record Map
{
    private readonly char[,] _content;

    public Map(char[,] content, Position heroPosition)
    {
        _content = content;
    }
    
    private int _rows => _content.GetUpperBound(0) + 1;
    private int _columns => _content.Length / _rows;

    public Position HeroPosition() => GetPositionByType(CellType.H);

    // public Map MoveHero(Position heroPosition)
    // {
    //     
    //     return 
    // }

    public void Draw()
    {
        Console.Clear();
        int rows = _content.GetUpperBound(0) + 1;
        int columns = _content.Length / rows;

        for (int x = rows - 1; x >= 0; x--)
        {
            for (int y = columns - 1; y >= 0; y--)
            {
                Console.Write("[");

                if (Enum.TryParse(_content[x, y].ToString(), out CellType cellType))
                {
                    Console.ForegroundColor = new CellColor(cellType).Value();
                }

                // if (heroPosition.X == x && heroPosition.Y == y)
                // {
                //     Console.Write('K');
                // }
                // else
                // {
                    Console.Write(_content[x, y]);
                // }


                Console.ResetColor();
                Console.Write("]");
            }

            Console.WriteLine();
        }
    }
    
    private Position GetPositionByType(CellType cellType)
    {
        for (int x = _rows - 1; x >= 0; x--)
        {
            for (int y = _columns - 1; y >= 0; y--)
            {
                if (_content[x, y] == (char)cellType)
                {
                    return new Position(x, y);
                }
            }
        }

        return new Position(0, 0);
    }
}