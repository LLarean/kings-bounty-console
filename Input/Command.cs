namespace KB.Input;

public class Command
{
    private readonly ConsoleKey _command;

    public Command(ConsoleKey command)
    {
        _command = command;
    }

    public CommandType Type()
    {
        return _command switch
        {
            ConsoleKey.Escape => CommandType.Esc,
            ConsoleKey.UpArrow => CommandType.Move,
            ConsoleKey.DownArrow => CommandType.Move,
            ConsoleKey.RightArrow => CommandType.Move,
            ConsoleKey.LeftArrow => CommandType.Move,
            ConsoleKey.A => CommandType.Select,
            ConsoleKey.B => CommandType.Select,
            ConsoleKey.C => CommandType.Select,
            _ => Enum.Parse<CommandType>(_command.ToString())
        };
    }
}