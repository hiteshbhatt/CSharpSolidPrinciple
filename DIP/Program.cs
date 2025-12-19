// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public interface ILogger
{
    void Log(string message);
}

public class FileLogger : ILogger // low level module
{
    public void Log(string message)
    {
        File.WriteAllText(@"c:\error.text",message);
    }
}

public class ConsoleLogger: ILogger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}
public class MemberShip // high level module
{
    ILogger logger; // abstraction
    public MemberShip(ILogger logger)
    {
        this.logger = logger;
    }
    public void Add() 
    {
        //ToDO:: any operation

        try
        {

        }
        catch (Exception ex)
        {
           

            logger.Log(ex.ToString());
        }
    }
}


