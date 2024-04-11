public class Display : IDisplay
{
    private static readonly object _lock = new();

    public void Debug(string message) => Write(message, ConsoleColor.Gray);

    public void DebugLine(string message) => WriteLine(message, ConsoleColor.Gray);

    public void Info(string message) => Write(message, ConsoleColor.White);

    public void InfoLine(string message) => WriteLine(message, ConsoleColor.White);

    public void Warn(string message) => Write(message, ConsoleColor.Yellow);

    public void WarnLine(string message) => WriteLine(message, ConsoleColor.Yellow);

    public void Error(string message) => Write(message, ConsoleColor.Red);

    public void ErrorLine(string message) => WriteLine(message, ConsoleColor.Red);

    public void Write(string message, ConsoleColor color)
    {
        lock (_lock)
        {
            Console.ForegroundColor = color;
            Console.Write(message);
            Console.ResetColor();
        }
    }

    public void WriteLine(string message, ConsoleColor color)
    {
        lock (_lock)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}

