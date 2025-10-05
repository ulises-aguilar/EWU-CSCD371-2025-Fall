namespace Logger;

public class LogFactory
{
    private string? _filePath;

    public BaseLogger CreateLogger(string className)
    {
        
        return null;
    }

    public void CanfigureFileLogger(string filePath)
    {
        _filePath = filePath;
    }

}
