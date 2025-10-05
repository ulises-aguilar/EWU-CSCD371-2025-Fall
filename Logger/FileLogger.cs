using System;
using  System.IO;

namespace Logger;

public class FileLogger : BaseLogger
{ 
    private readonly string _filePath; //asking to be readonly

    public FileLogger(string filePath)
    {
        _filePath = filePath;
    }

    // reasearch why we need override
    public override void Log(LogLevel logLevel, string message)
    {
        // to be decided && missing className
        string logMessage = $"{DateTime.Now}: [{logLevel}] {message}";
        File.AppendAllText(_filePath, message + "\n");
    }
}

