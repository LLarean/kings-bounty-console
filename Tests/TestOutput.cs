using System.Text;
using kings_bounty_console.Output;

namespace Tests;

public sealed class TestOutput : IOutput
{
    private readonly StringBuilder _buffer = new();
    
    public void Write(string text) => _buffer.Append(text);
    public void WriteLine(string text = "") => _buffer.AppendLine(text);
    public string Content() => _buffer.ToString();
}