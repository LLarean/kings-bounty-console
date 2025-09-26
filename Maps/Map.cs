namespace kings_bounty_console.Maps;

public record Map
{
    private readonly char[,] _content;

    public Map(char[,] content)
    {
        _content = content;
    }
    
    private int _rows => _content.GetUpperBound(0) + 1;
    private int _columns => _content.Length / _rows;

    public Position HeroPosition() => GetPositionByType('H');

    public bool CanMove(Position position)
    {
        if (position.X < 0 || position.Y < 0) return false;
        if (position.X > _rows || position.Y > _columns) return false;
        if (Enum.TryParse(_content[position.X, position.Y].ToString(), out CellType cellType) == false) return false;
        
        return cellType switch {
            CellType.w => false,
            CellType.g => true,
            CellType.m => false,
            CellType.s => true,
            CellType.C => true,
            CellType.H => true,
            CellType.T => true,
            CellType.E => true,
            _ => throw new ArgumentOutOfRangeException()
        };
    }
    
    public Map MoveHero(Position heroPosition)
    {
        var newContent = _content;
        newContent[HeroPosition().X, HeroPosition().Y] = 'g';
        newContent[heroPosition.X, heroPosition.Y] = 'H';
        return new Map(newContent);
    }

    public void Draw()
    {
        Console.Clear();
        int rows = _content.GetUpperBound(0) + 1;
        int columns = _content.Length / rows;

        for (int x = 0; x < rows; x++)
        {
            for (int y = 0; y < columns; y++)
            {
                Console.Write("[");

                if (Enum.TryParse(_content[x, y].ToString(), out CellType cellType))
                {
                    Console.ForegroundColor = new CellColor(cellType).Value();
                }

                Console.Write(_content[x, y]);

                Console.ResetColor();
                Console.Write("]");
            }

            Console.WriteLine();
        }
    }
    
    private Position GetPositionByType(char cellType)
    {
        for (int x = _rows - 1; x >= 0; x--)
        {
            for (int y = _columns - 1; y >= 0; y--)
            {
                if (_content[x, y] == cellType)
                {
                    return new Position(x, y);
                }
            }
        }

        return new Position(0, 0);
    }
}