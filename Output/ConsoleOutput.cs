namespace kings_bounty_console.Output;

public sealed class ConsoleOutput : IOutput
{
    public void Write(string text) => Console.Write(text);
    public void WriteLine(string text = "") => Console.WriteLine(text);
}
