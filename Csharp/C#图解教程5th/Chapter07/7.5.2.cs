class D
{
    /// <summary>
    /// Declare instance fields Mem1 and Mem2
    /// </summary>
    int Mem1;
    static public int Mem2;

    static void Main()
    {
        D.Mem2 = 5;
        Console.WriteLine("Mem2 = {0}", D.Mem2);
    }
} 