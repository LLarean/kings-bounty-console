namespace kings_bounty_console.Output;

public interface IOutput
{
    void Write(string text);
    void WriteLine(string text = "");
}