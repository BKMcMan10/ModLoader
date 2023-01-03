using System;
using System.IO;

class Program
{
    static Logger logger = Logger.GetLogger();

    public static void Main(string[] args)
    {
        logger.Log("Hello World!", LogLevel.INFO);
    }
}