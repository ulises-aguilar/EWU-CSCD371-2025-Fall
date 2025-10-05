using System;

namespace Logger;

public static class BaseLoggerMixins
{
    public static void Error(string message, BaseLogger baselogger, params object[] args)
    {
        if (baselogger is null) throw new ArgumentNullException(nameof(baselogger));
        baselogger.Log(LogLevel.Error, string.Format(message, args));
    }

    public static void Warning(string message, BaseLogger baselogger, params object[] args)
    {
        if (baselogger is null) throw new ArgumentNullException(nameof(baselogger));
        baselogger.Log(LogLevel.Error, string.Format(message, args));
    }

    public static void Information(string message, BaseLogger baselogger, params object[] args)
    {
        if (baselogger is null) throw new ArgumentNullException(nameof(baselogger));
        baselogger.Log(LogLevel.Error, string.Format(message, args));
    }

    public static void Debug(string message, BaseLogger baselogger, params object[] args)
    {
        if (baselogger is null) throw new ArgumentNullException(nameof(baselogger));
        baselogger.Log(LogLevel.Error, string.Format(message, args));
    } 
    
    
}
