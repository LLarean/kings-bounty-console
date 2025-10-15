using KB.WorldMaps;

namespace KB.General.Maps;

public record Map
{
    private readonly char[,] _baseState;
    private readonly char[,] _currentState;

    public Map(char[,] baseState)
    {
        _baseState = baseState;
        _currentState = baseState;
    }

    public Map(char[,] baseState, char[,] currentState)
    {
        _baseState = baseState;
        _currentState = currentState;
    }

    public object CanInteract(Position newPosition)
    {
        throw new NotImplementedException();
    }
    
    public object CanMove(Position newPosition)
    {
        throw new NotImplementedException();
    }

    private int _rows => _baseState.GetUpperBound(0) + 1;

    private int _columns => _baseState.Length / _rows;

    public void Draw()
    {
        Console.Clear();

        for (int x = 0; x < _columns; x++)
        {
            for (int y = 0; y < _rows; y++)
            {
                if (Enum.TryParse(_currentState[x, y].ToString(), out CellType cellType))
                {
                    Console.BackgroundColor = new CellColor(cellType).Value();
                }

                Console.Write(" " + _currentState[x, y] + " ");
                Console.ResetColor();
            }

            Console.WriteLine();
        }
    }

    public Position HeroPosition() => GetPositionByType('H');

    public char GetCellTypeByPosition(Position position) => _baseState[position.X, position.Y];

    public Map MoveHero(Position newPosition)
    {
        var currentState = _currentState;
        var oldPosition = HeroPosition();
        
        if (_baseState[oldPosition.X, oldPosition.Y] == 'H')
        {
            currentState[oldPosition.X, oldPosition.Y] = 'g';
        }
        else if (_baseState[oldPosition.X, oldPosition.Y] == 'T')
        {
            currentState[oldPosition.X, oldPosition.Y] = 'g';
        }
        else
        {
            currentState[oldPosition.X, oldPosition.Y] = _baseState[oldPosition.X, oldPosition.Y];
        }
        
        currentState[newPosition.X, newPosition.Y] = 'H';
        return new Map(_baseState, _currentState);
    }

    private Position GetPositionByType(char cellType)
    {
        for (int x = _rows - 1; x >= 0; x--)
        {
            for (int y = _columns - 1; y >= 0; y--)
            {
                if (_baseState[x, y] == cellType)
                {
                    return new Position(x, y);
                }
            }
        }

        return new Position(0, 0);
    }
}