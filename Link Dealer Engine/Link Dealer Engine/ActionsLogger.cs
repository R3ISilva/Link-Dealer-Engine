namespace Link_Dealer_Engine;

public static class ActionsLogger
{
    private static readonly ILoggerProvider _LoggerProvider = new ConsoleLogger();
    public static async void Log(string message) => _LoggerProvider.Log(message);
}

internal interface ILoggerProvider
{
    public void Log(string message);
}

internal class ConsoleLogger : ILoggerProvider
{
    public void Log(string message)
    {
        Console.WriteLine(DateTime.Now.ToString("HH:mm:ss") + "-" + message);
    }
}