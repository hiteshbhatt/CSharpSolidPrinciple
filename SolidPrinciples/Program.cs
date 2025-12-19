// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class MemberShip
{
    public void Add() // it is related to membership
    {
        //ToDO:: any operation

        try
        {

        }
        catch (Exception ex)
        {
            // File.WriteAllText(@"c:\error.txt",ex.Message); // this is another reponsibility to log error it should be perform by another class Logger

            FilerLogger.LogError("erro");
        }
    }
}

public class FilerLogger // this is correction
{
    public static void LogError(string error)
    {
        File.WriteAllText(@"c:\error.txt", error);
    }
}
