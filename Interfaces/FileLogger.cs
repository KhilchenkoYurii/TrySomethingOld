﻿namespace Interfaces;

public class FileLogger : ILogger
{
    private readonly string _path;

    public FileLogger(string path)
    {
        _path = path;
    }

    public void LogError(string message)
    {
        Log(message, "ERROR");
    }

    public void LogInfo(string message)
    {
        Log(message,"INFO");
    }

    private void Log(string message, string messageType)
    {
        using (var streamWritter = new StreamWriter(_path, true))
        {
            streamWritter.WriteLine($"{messageType}: {message}");
        };
    }
}