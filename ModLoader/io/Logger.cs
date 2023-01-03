using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum LogLevel
{
    INFO,
    WARNING,
    ERROR
}

public class Logger
{
    //FileStream file = new FileStream("logs/" + System.DateTime.Now.ToString() + ".log", FileMode.OpenOrCreate);

    public static Logger GetLogger()
    {
        Logger logger = new Logger();
        return logger;
    }

    public void Log(string msg, LogLevel level)
    {
        switch (level)
        {
            case LogLevel.INFO:
                Console.WriteLine("[" + System.DateTime.Now.ToString() + "] " + "[Thread/INFO]: " + msg);
                break;
            case LogLevel.WARNING:
                Console.WriteLine("[" + System.DateTime.Now.ToString() + "] " + "[Thread/WARNING]: " + msg);
                break;
            case LogLevel.ERROR:
                Console.WriteLine("[" + System.DateTime.Now.ToString() + "] " + "[Thread/ERROR]: " + msg);
                break;
        }
    }
}