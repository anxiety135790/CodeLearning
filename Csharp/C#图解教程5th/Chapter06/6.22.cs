class Program
{
    public void Count(int inVal)
    {
        if (inVal == 0)
        return;
        Count(inVal - 1);
        Console.WriteLine(inVal);
    }

    static void Main()
    {
        Program p = new Program();
        p.Count(4);
    }
}