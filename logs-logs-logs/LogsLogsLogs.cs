using System;

// Define the LogLevel enum
public enum LogLevel
{
    Trace=1,
    Debug=2,
    Info=4,
    Warning=5,
    Error=6,
    Fatal=42,
    Unknown=0
}

static class LogLine
{
    // Parse the log level from a string
    public static LogLevel ParseLogLevel(string logLine)
    {
        
        string lowerLogLine = logLine;

        
        if (lowerLogLine.Substring(0,5)=="[TRC]")
        {
            return LogLevel.Trace;
        }
        else if (lowerLogLine.Substring(0,5)=="[DBG]")
        {
            return LogLevel.Debug;
        }
        else if (lowerLogLine.Substring(0,5)=="[INF]")
        {
            return LogLevel.Info;
        }
        else if (lowerLogLine.Substring(0,5)=="[WRN]")
        {
            return LogLevel.Warning;
        }
        else if (lowerLogLine.Substring(0,5)=="[ERR]")
        {
            return LogLevel.Error;
        }
        else if (lowerLogLine.Substring(0,5)=="[FTL]")
        {
            return LogLevel.Fatal;
        }
        else
        {
            
            return LogLevel.Unknown;
        }
    }

    
    public static string OutputForShortLog(LogLevel logLevel, string message)
    {
        
        return $"{(int)logLevel}:{message}";
    }
}
