using System;
using System.Net;
using System.Diagnostics;

class MyDownloadString()
{
    Stopwatch sw = new Stopwatch();

    public void DoRun()
    {
        const int LargeNumber = 6_000_000;
        sw.Start();
        int t1 = CountCharacters( 1, "http://www.microsoft.com");
        int t2 = CountCharacters( 2, "http://www.illustratedcsharp.com");
        CountTo
    }

    private int CountCharacters(int id, string uriString)
    {
        webClient wc1 = new WebClient();
        Console.WriteLine($"Task {id} starting");

        string result = wc1.DownloadString(uriString);
        Console.WriteLine($"Task {id} finished");
        return result.Length;
    }

    private void CountToLargeNumber(int id, int value)
    {
        for (long i = 0; i < value; i++);
        Console.WriteLine($"Task {id} finished");
    }
}

class Program
{
    static void Main()
    {
        MyDownloadString mds = new MyDownloadString();
        mds.DoRun();
    }
}