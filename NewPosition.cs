using KB.General;

public class NewPosition
{
    private readonly ConsoleKey _command;

    public NewPosition(ConsoleKey command)
    {
        _command = command;
    }

    public Position Value(Position newPosition)
    {
        return _command switch
        {
            ConsoleKey.UpArrow => new Position(newPosition.X - 1, newPosition.Y),
            ConsoleKey.DownArrow => new Position(newPosition.X + 1, newPosition.Y),
            ConsoleKey.RightArrow => new Position(newPosition.X, newPosition.Y + 1),
            ConsoleKey.LeftArrow => new Position(newPosition.X, newPosition.Y - 1),
            _ => newPosition
        };
    }
}