class Program
{
    [Obsolete("Use method SuperPrintOut")] //[Obsolete ("Using method SuperPrintOut",trun)]
    static void PrintOut(string str)
    {
        Console.WriteLine(str);
    }

    static void Main(string[] args)
    {
        PrintOut("Start Of Main");
    }
}
