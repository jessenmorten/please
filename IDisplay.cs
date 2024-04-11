public interface IDisplay
{
    void Debug(string message);

    void DebugLine(string message);

    void Info(string message);

    void InfoLine(string message);

    void Warn(string message);

    void WarnLine(string message);

    void Error(string message);

    void ErrorLine(string message);
}

