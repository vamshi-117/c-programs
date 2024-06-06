using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        int c=logLine.IndexOf(':')+2;
        string s= logLine.Substring(c);
        return s.Trim();
        
        throw new NotImplementedException("Please implement the (static) LogLine.Message() method");
    }

    public static string LogLevel(string logLine)
    {
         int c = logLine.IndexOf('[') + 1;
    int d = logLine.IndexOf(']');
    string s = logLine.Substring(c, d - c).ToLower(); 
    return s;
        throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
    }

    public static string Reformat(string logLine)
    {
        int c = logLine.IndexOf('[') + 1;
    int d = logLine.IndexOf(']');
    string z = logLine.Substring(c, d - c).ToLower(); 
    
    int a = logLine.IndexOf(':') + 2;
    string b = logLine.Substring(a);
    string e = b.Trim();
    
    return e + " (" + z + ")"; 
        throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }
}
